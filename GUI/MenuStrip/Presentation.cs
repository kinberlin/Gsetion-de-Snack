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
    public partial class Presentation : Form
    {
        Employe E = new Employe();
        public Presentation(Employe E )
        {
            this.E = E;
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Telephone_Click(object sender, EventArgs e)
        {

        }

        private void Presentation_Load(object sender, EventArgs e)
        {
            Matricule.Text = E.Id_Employe.ToString();
            Noms.Text = E.Nom;
            Email.Text = E.Email;
            Salaire.Text = E.Salaire.ToString();
            Date_Embauche.Text = E.Date_dembauche.ToString();
            /*........................................................................*/
            Fonctions_Manager F = new Fonctions_Manager();
            Fonctions__employe Fonc = new Fonctions__employe();
            foreach (var fO in F.Restore()) { if (fO.Id_Fonction == E.Id_Fonction) { Fonc = fO; } }
            //var Fonc = (Fonctions__employe)from Fo in F.Restore() where Fo.Id_Fonction == E.Id_Fonction  select Fo  as Fonctions__employe;
            Id_Fonction.Text = Fonc.Id_Fonction.ToString();
            Nom_Fonction.Text = Fonc.Nom_Fonction;
            Role.Text = Fonc.Role_Fonction;
            Position.Text = Fonc.Position;
            /*........................................................................*/
            for(int i = 0; i < 2; i++)
            {
                    ListViewItem lvi = new ListViewItem(new string[] { E.Horraire[i, 0], E.Horraire[i, 1], E.Horraire[i, 2], E.Horraire[i, 3], E.Horraire[i, 4], E.Horraire[i, 5], E.Horraire[i, 6] });
                listView1.Items.Add(lvi);
            }

        }
    }
}
