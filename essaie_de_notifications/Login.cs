using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestionnairebar
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void Admin_Load(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
        }
        private void effacer()
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Ok_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "admin" || textBox2.Text == "admin")
            {
                MessageBox.Show("Bienvenue boby !");
                var bb = new Login();
                var form = new MainForm();
                form.Show();
                this.Close();


            }
            else
            {
                MessageBox.Show("User Name ou Password invalid!!");
                effacer();
            }
        }
    }
}
