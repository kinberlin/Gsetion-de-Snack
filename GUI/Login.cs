using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CLASSES.BLL;
using CLASSES.Objets;

namespace GUI
{
    public partial class Login : Form
    {
        /*Commande_Manager CM = new Commande_Manager();
        Facture_Manager FM = new Facture_Manager();*/
        Type_Boisson_Manager TM = new Type_Boisson_Manager();
        Boissons_Manager BM = new Boissons_Manager();

        Fonctions_Manager FOM = new Fonctions_Manager();
        Employee_Manager EM = new Employee_Manager();


        public Login()
        {
            InitializeComponent();

        }
        private void Admin_Load(object sender, EventArgs e)
        {
            Password.UseSystemPasswordChar = true;
        }
        private void effacer()
        {
            email.Text = "";
            Password.Text = "";
        }
        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Ok_Click(object sender, EventArgs e)
        {
            try
            {

                if (EM.Authenticate(email.Text, Password.Text) != null)
                {
                    Employe Emp = EM.Authenticate(email.Text, Password.Text);
                    if (Emp.CanConnect)
                    {
                        File.WriteAllText("connexion.txt", Emp.Email);
                    }
                    else { File.WriteAllText("connexion.txt", EM.GetFonction(Emp.Id_Fonction)); }
                    MessageBox.Show("Connected", "Connexion", MessageBoxButtons.OK);
                    var F = new MainForm();
                    F.Show();
                    this.Close();
                }
                else { MessageBox.Show("Parametres de connexion incorrecte", "Issues", MessageBoxButtons.OK); }
            }
            catch (Exception exc) { MessageBox.Show(exc.Message, exc.Source); }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
