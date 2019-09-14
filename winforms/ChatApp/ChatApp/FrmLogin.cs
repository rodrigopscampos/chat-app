using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatApp
{
    public partial class FrmLogin : FrmBase
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            var apelido = txtApelido.Text.ToUpper().Trim();

            try
            {
                btnEntrar.Text = "Entrando ...";
                btnEntrar.Enabled = false;

                Thread.Sleep(100);
                _api.FazerLogin(apelido);

                var frmPrincipal = new FrmPrincipal();
                this.Hide();
                frmPrincipal.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                MostrarErro(ex);
                btnEntrar.Text = "Entrar";
                btnEntrar.Enabled = true;
            }
        }
    }
}
