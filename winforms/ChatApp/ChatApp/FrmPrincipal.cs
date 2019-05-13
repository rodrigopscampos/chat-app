using ChatApp.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using ChatApp.DTO;

namespace ChatApp
{
    public partial class FrmPrincipal : FrmBase
    {
        List<Usuarios> _usuarios = new List<Usuarios>();
        StringBuilder _htmlMensagens = new StringBuilder();
        string _template = @"
<!DOCTYPE html>
<html>

<head>
    <style>
        body {
            background-color: snow;
            margin:0;
            font-family: Arial, Helvetica, sans-serif;
        }

        .msg_box {
            overflow: hidden;
            padding-top: 5px;
            padding-bottom: 5px;
            padding-left: 10px;
            padding-right: 10px;
            margin:0;
        }

        .impar {
            background-color: rgb(166, 201, 233);
        }
        
        .par {
            overflow: hidden;
            background-color: rgb(138, 181, 221);
        }
        
        .reservada {
            background-color: rgb(179, 182, 180);
        }
    </style>
</head>

<body>
    {{MENSAGENS}}
</body>

</html>
";

        public FrmPrincipal()
        {
            InitializeComponent();

            _api.AoAlterarNovaListaUsuarios += _api_AoAlterarNovaListaUsuarios;
            _api.AoReceberMensagens += _api_AoReceberMensagens;
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            lbUsuarios.DisplayMember = "Nome";
            this.Text = this.Text + " (" + _api.Apelido + ")";
            _api.IniciarRecebimento();
        }

        private void _api_AoReceberMensagens(Mensagem[] mensagens)
        {
            foreach (var m in mensagens)
                AddMensagem(m);
        }

        private void AddMensagem(Mensagem mensagem)
        {
            Invoke(new Action(() =>
            {
                var destinatario = mensagem.Destinatario;
                var remetente = mensagem.Remetente;

                if (destinatario == _api.Apelido)
                    destinatario = "Você";

                if (remetente == _api.Apelido)
                    remetente = "Você";

                var par = (_htmlMensagens.Length + 1) % 2 == 0;
                var classe = par ? " par " : " impar ";

                var reservadamente = "";
                if (mensagem.Reservada)
                {
                    reservadamente = " (reservadamente)";

                    if (mensagem.Destinatario == _api.Apelido || mensagem.Remetente == _api.Apelido)
                    {
                        classe += " reservada ";
                    }
                }


                _htmlMensagens.AppendLine(
 $@"
 <div class='msg_box {classe}'>
        <span>{remetente} diz{reservadamente} para {destinatario}: {mensagem.Texto}</span>
    </div>
");
                wbMensagens.DocumentText = _template.Replace("{{MENSAGENS}}", _htmlMensagens.ToString());
            }));
        }

        private void _api_AoAlterarNovaListaUsuarios(Usuarios[] usuarios)
        {
            Invoke(new Action(() =>
            {
                foreach (var usuario in usuarios)
                {
                    if (!_usuarios.Any(u => u.Id == usuario.Id))
                    {
                        _usuarios.Add(usuario);
                        lbUsuarios.DataSource = _usuarios.ToArray();
                    }
                }
            }));
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                var texto = txtNovaMsg.Text;

                var destinatario = ((Usuarios)lbUsuarios.SelectedItem).Nome;

                var mensagem = new OutputMensagem
                {
                    Destinatario = destinatario,
                    Texto = texto,
                    Reservada = ckbMsgReservada.Checked
                };

                _api.EnviarMensagem(mensagem);

                txtNovaMsg.Text = "";
            }
            catch (Exception ex)
            {
                MostrarErro(ex);
            }
        }
    }
}