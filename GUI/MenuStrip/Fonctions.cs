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
    public partial class Fonctions : Form
    {
        Fonctions_Manager FM = new Fonctions_Manager();
        Fonctions__employe FE = new Fonctions__employe();
        public Fonctions()
        {
            InitializeComponent();
        }

        private void Fonctions_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (deleteCheck.Checked)
            {
                btnSave.Text = "Delete";
                int Id;
                bool s = int.TryParse(txtIdFonctions.Text, out Id);
                bool Existe = FM.ID_Exist(Id);
                if (Existe) { MessageBox.Show("L'ID Entree existe deja", "ID", MessageBoxButtons.OK); }
                if (s)
                {
                    FM.Delete(Id);
                    MessageBox.Show("Item deleted Successfully", "Info", MessageBoxButtons.OK);
                }
                else { MessageBox.Show("L'ID Entree n'est pas numeriques", "ID", MessageBoxButtons.OK); }
                txtIdFonctions.Clear();txtNameFonction.Clear();Role.Clear();Position.Clear();
                
            }
            else
            {
                btnSave.Text = "Save";
                int ID;
                bool su = int.TryParse(txtIdFonctions.Text, out ID);
                bool Exist = FM.ID_Exist(ID);
                if (Exist) { MessageBox.Show("L'ID Entree existe deja", "ID", MessageBoxButtons.OK); }
                if (su)
                {
                    FM.Add(ID, txtNameFonction.Text, Role.Text, Position.Text);
                    txtIdFonctions.Clear(); txtNameFonction.Clear(); Role.Clear(); Position.Clear();
                    MessageBox.Show("Item Added Successfully", "Info", MessageBoxButtons.OK);
                }
                else { MessageBox.Show("L'ID Entree n'est pas numeriques", "ID", MessageBoxButtons.OK); }

            }
        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            int Id;
            bool s = int.TryParse(txtIdFonctions.Text, out Id);
            bool Existe = FM.ID_Exist(Id);
            FE = FM.Find_ID(Id);
            Fonctions__employe F_E = FE;
            F_E.Nom_Fonction = txtNameFonction.Text;
            F_E.Role_Fonction = Role.Text;
            F_E.Position = Position.Text;
            if (Existe) { MessageBox.Show("L'ID Entree existe deja", "ID", MessageBoxButtons.OK); }
            if (s)
            {
                FM.Modify(FE,F_E);
                MessageBox.Show("Modification Done!", "Info", MessageBoxButtons.OK);
            }
            else { MessageBox.Show("L'ID Entree n'est pas numeriques", "ID", MessageBoxButtons.OK); }
        }
    }
}
