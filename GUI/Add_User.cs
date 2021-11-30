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

namespace GUI
{
    public partial class Add_User : Form
    {
        Fonctions_Manager FM = new Fonctions_Manager();
        Employee_Manager EM = new Employee_Manager();
        public Add_User()
        {
            InitializeComponent();
            dataGridView1.RowCount = 2;
        }

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
            }
            catch (Exception exc) { MessageBox.Show(exc.Message, exc.Source); }

        }

        private void Enregistrer_Click(object sender, EventArgs e)
        {
            try
            {
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
                    EM.Add_Employee(id, Nom.Text, Prenoms.Text, Email.Text, salaire, Tab, Password.Text);
                    MessageBox.Show("Enregistrer", "Add");
                    //Id_Fonctions.Items.Clear(); Salaire.Clear(); Email.Clear(); Prenoms.Clear(); Nom.Clear();Password.Text.Clear();
                    this.Close();
                }else { MessageBox.Show("Remplissez tout les champs", "Info"); }
            }catch(Exception exc) { MessageBox.Show(exc.Message, exc.Source); }
        }

        private void Id_Fonctions_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
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
    }
}
