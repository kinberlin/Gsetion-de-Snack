using CLASSES.BLL;
using CLASSES.Objets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Set_User : Form
    {
        Employe Emp = new Employe();
        public Set_User(Employe e)
        {
                InitializeComponent();
                dataGridView1.RowCount = 2;
                Emp = e;
        }
        Fonctions_Manager FM = new Fonctions_Manager();
        Employee_Manager EM = new Employee_Manager();

        private void Add_User_Load(object sender, EventArgs e)
        {
            try
            {
                List<Fonctions__employe> _f = FM.Restore();
                foreach (var Fon in _f)
                {
                    // ListViewItem lvi = new ListViewItem(new string[] { Fon.Id_Fonction.ToString()}) ;
                    Id_Fonctions.Items.Add(Fon.Id_Fonction.ToString());
                }
                Nom.Text = Emp.Nom;
                Email.Text = Emp.Email;
                Salaire.Text = Emp.Salaire.ToString();
                Password.Text = Emp.Password;
                Prenoms.Text = Emp.Prenom;
                /*........................................................................*/
                Fonctions_Manager F = new Fonctions_Manager();
                Fonctions__employe Fonc = new Fonctions__employe();
                foreach (var fO in F.Restore()) { if (fO.Id_Fonction == Emp.Id_Fonction) { Fonc = fO; } }
                //var Fonc = (Fonctions__employe)from Fo in F.Restore() where Fo.Id_Fonction == E.Id_Fonction  select Fo  as Fonctions__employe;
                Id_Fonctions.Text = Fonc.Id_Fonction.ToString();
                Nom_Fonction.Text = Fonc.Nom_Fonction;
                Role.Text = Fonc.Role_Fonction;
                Position.Text = Fonc.Position;
                /*........................................................................*/
                DataGridViewRow row;
                for (int i = 0; i < 2; i++)
                {
                    /*ListViewItem lvi = new ListViewItem(new string[] { E.Horraire[i, 0], E.Horraire[i, 1], E.Horraire[i, 2], E.Horraire[i, 3], E.Horraire[i, 4], E.Horraire[i, 5], E.Horraire[i, 6] });
                     listView1.Items.Add(lvi);*/
                    row = dataGridView1.Rows[i];
                    for (int j = 0; j < 7; j++)
                    {
                        row.Cells[j].Value = Emp.Horraire[i, j];
                    }
                }
            }
            catch (Exception exc) { MessageBox.Show(exc.Message, exc.Source); }

        }

        private void Enregistrer_Click(object sender, EventArgs e)
        {
            try { 
            int id; double salaire;
            bool su = int.TryParse(Id_Fonctions.Text, out id);
            su = double.TryParse(Salaire.Text, out salaire);
                if (su)
                {
                    string[,] Tab = new string[2, 7];

                    DataGridViewRow row;
                    for (int i = 0; i < 2; i++)
                    {
                        row = dataGridView1.Rows[i];
                        for (int j = 0; j < 7; j++)
                        {
                            Tab[i, j] = row.Cells[j].Value.ToString();
                        }
                    }
                    EM.Set_Employe(Emp.Id_Employe, Nom.Text, Prenoms.Text, salaire, Tab, Password.Text, Email.Text, id,Emp);
                    MessageBox.Show("Modifications Effectue", "Set", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception E) { MessageBox.Show(E.Message, E.Source); }
        }

        private void Id_Fonctions_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {
                Fonctions_Manager FM = new Fonctions_Manager();
                Fonctions__employe FE = new Fonctions__employe();
                int id;
                bool su = int.TryParse(Id_Fonctions.Text, out id);
                if (su)
                {
                    FE = FM.Find_ID(id);
                    Role.Text = FE.Role_Fonction;
                    Position.Text = FE.Position;
                    Nom_Fonction.Text = FE.Nom_Fonction;
                }
            }
            catch (Exception exc) { MessageBox.Show(exc.Message, exc.Source); }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
