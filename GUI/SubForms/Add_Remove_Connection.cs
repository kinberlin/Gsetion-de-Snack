using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CLASSES.Objets;
using CLASSES.BLL;

namespace GUI.SubForms
{
    public partial class Add_Remove_Connection : Form
    {
        public Add_Remove_Connection()
        {
            InitializeComponent();
        }

        Employe E = new Employe();

        private void Ajouter_Connexion_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            string s = "Entrez la Fonction : ";
        }

        private void EmpCheck_CheckedChanged(object sender, EventArgs e)
        {
            string s = "Entrez l'email : ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (EmpCheck.Checked)
            {

                string s = "Entrez l'email : ";
                labelF.Text = s;
                Employee_Manager EM = new Employee_Manager();
                EM.Remove_Connect_TO_App(textBox1.Text);
                MessageBox.Show("Connection Set", "Info", MessageBoxButtons.OK);
            }
            else if (GroupCheck.Checked)
            {
                string s = "Entrez la Fonction : ";
                labelF.Text = s;
                Employee_Manager EM = new Employee_Manager();
                EM.Remove_Connect_TO_App(textBox1.Text);
                MessageBox.Show("Connection Set", "Info", MessageBoxButtons.OK);

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
