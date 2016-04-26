using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Sistema_CervejariaV01
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {

            string linha;
            using (StreamReader reader = new StreamReader("\\teste.txt"))
            {
                linha = reader.ReadLine();

            }

            if (linha == txt_senha.Text)
            {
                administracao adm = new administracao();
                adm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Senha incorreta");
            }
            
        }



    }
}

