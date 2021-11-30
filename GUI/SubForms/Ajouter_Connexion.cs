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

namespace GUI.MenuStrip
{
    public partial class Ajouter_Connexion : Form
    {
        Employe E = new Employe();
        public Ajouter_Connexion()
        {
            InitializeComponent();
        }

        private void Ajouter_Connexion_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void EmpCheck_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (EmpCheck.Checked)
            {

                string s = "Entrez l'email : ";
                labelF.Text = s;
                Employee_Manager EM = new Employee_Manager();
                EM.Set_Connect_TO_App(textBox1.Text);
            }
            else if (GroupCheck.Checked)
            {
                string s = "Entrez la Fonction : ";
                labelF.Text = s;
                Employee_Manager EM = new Employee_Manager();
                EM.Set_Connect_TO_App(textBox1.Text);

            }
        }
    }
}
