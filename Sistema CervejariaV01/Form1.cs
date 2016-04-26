using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_CervejariaV01
{
    public partial class inicial : Form
    {
        public inicial()
        {
            InitializeComponent();
        }

        private void btn_adm_Click(object sender, EventArgs e)
        {
            login login1 = new login();
            login1.ShowDialog();


        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Close();
                       
        }
    }
}
