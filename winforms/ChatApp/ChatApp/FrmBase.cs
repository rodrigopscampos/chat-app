using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatApp
{
    public class FrmBase : Form
    {
        protected static ApiClient _api = new ApiClient();

        protected void MostrarErro(Exception ex)
        {
            MessageBox.Show(ex.ToString());
        }
    }
}
