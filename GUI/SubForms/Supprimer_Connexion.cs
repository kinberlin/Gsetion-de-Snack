using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CLASSES.BLL;
using CLASSES.Objets;

namespace GUI.SubForms
{
    public partial class Supprimer_Connexion : Form
    {
        public Supprimer_Connexion()
        {
            InitializeComponent();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void EmpCheck_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (GroupCheck.Checked)
            {
                string s = "Entrez la Fonction : ";
                labelF.Text = s;
                Employee_Manager EM = new Employee_Manager();
                EM.Remove_Connect_TO_App(textBox1.Text);
                MessageBox.Show("Action Success", "Status", MessageBoxButtons.OK);
                textBox1.Clear();
            }
            else if (EmpCheck.Checked)
            {

                string s = "Entrez l'email : ";
                labelF.Text = s;
                Employee_Manager EM = new Employee_Manager();
                EM.Remove_Connect_TO_App(textBox1.Text);
                MessageBox.Show("Action Success", "Status", MessageBoxButtons.OK);
                textBox1.Clear();
            }
        }
    }
}
