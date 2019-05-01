using ChatApp.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;

namespace ChatApp
{
    public partial class FrmPrincipal : Form
    {
        ApiClient _api;
        List<Usuarios> _usuarios = new List<Usuarios>();

        public FrmPrincipal()
        {
            InitializeComponent();

            _api = new ApiClient();
            _api.AoAlterarNovaListaUsuarios += _api_AoAlterarNovaListaUsuarios;
            _api.AoReceberMensagens += _api_AoReceberMensagens;
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            btnEnviar.Enabled = false;

            var random = new Random();
            txtApelido.Text = "Usuário " + random.Next() % 100;
            lbUsuarios.DisplayMember = "Nome";
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
                var remetenteNome = _usuarios
                    .FirstOrDefault(u => u.Id == mensagem.Remetente)?.Nome
                    ?? "Você";

                var destinatarioNome = _usuarios
                .FirstOrDefault(u => u.Id == mensagem.Destinatario)?.Nome
                ?? "Todos";

                var html = wbMensagens.DocumentText;
                html += $"<p>{remetenteNome} diz para {destinatarioNome}: {mensagem.Texto}";
                wbMensagens.DocumentText = html;
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

        private void btnConectar_Click(object sender, EventArgs e)
        {
            try
            {
                _api.FazerLogin(txtApelido.Text);

                lblStatus.Text = "conectado";
                lblStatus.ForeColor = Color.BlueViolet;
                btnConectar.Enabled = false;
                btnEnviar.Enabled = true;
                txtApelido.Enabled = false;

                _api.IniciarRecebimento();
            }
            catch (Exception ex)
            {
                MostrarErro(ex);
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                var texto = txtNovaMsg.Text;

                if (ckbMsgPrivada.Checked)
                {
                    int destinatario = ((Usuarios)lbUsuarios.SelectedItem).Id;
                    _api.EnviarMensagem(destinatario, texto);
                }
                else
                {
                    _api.EnviarMensagemParaTodos(texto);
                }

                txtNovaMsg.Text = "";
            }
            catch (Exception ex)
            {
                MostrarErro(ex);
            }
        }

        private void MostrarErro(Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }
}