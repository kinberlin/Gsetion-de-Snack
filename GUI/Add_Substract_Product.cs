using System;
using System.Collections.Generic;
using CLASSES.BLL;
using CLASSES.Objets;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class AjoutEtSoustraction_Produits : Form
    {
        public Boissons_Manager BS = new Boissons_Manager();
        public List<Boissons> Bois = new List<Boissons>();


        public AjoutEtSoustraction_Produits()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Liste_Type_Boisson.Items.Clear();
                int i; double PA;
                bool su = int.TryParse(IdCombo.Text, out i);
                PA = double.Parse(PrixAchat.Text);
                double PV = double.Parse(PrixVente.Text);
                /*Boissons B = new Boissons(i,NomBoisson.Text,MarqueB.Text,PA,PV);
                Bois.Add(B);*/
                if (su)
                {
                    BS.Add_Drink(i, NomBoisson.Text, MarqueB.Text, PA, PV);
                    Type_Boisson_Manager TBM = new Type_Boisson_Manager();
                    List<Type_Boisson> Tb = TBM.Restore();
                    foreach (var boi in Tb)
                    {
                        ListViewItem lvi = new ListViewItem(new string[] { boi.Id_type.ToString(), boi.Type, boi.Emballage, boi.Categorie });
                        Liste_Type_Boisson.Items.Add(lvi);
                        lvi.Tag = boi;
                    }
                    MessageBox.Show("Done", "Status", MessageBoxButtons.OK);
                    NomBoisson.Clear(); MarqueB.Clear(); PrixAchat.Clear(); PrixVente.Clear();
                }
            }
            catch (Exception exc) { MessageBox.Show(exc.Message, exc.Source); }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double Qua;
                bool su = double.TryParse(Quantites.Text, out Qua);
                if (su)
                {
                    var boi = listBoisson.SelectedItems[0].Tag as Boissons;
                    Boissons temp = new Boissons();
                    temp = boi;
                    boi.Quantite = Qua + boi.Quantite;
                    MessageBox.Show(temp.Nom + boi.Quantite.ToString() +boi.Prix_achat.ToString());
                    BS.Modiif(temp, boi);
                    Quantites.Clear();
                }
            }catch(Exception E) { MessageBox.Show(E.Message, E.Source); }
        }

        private void Quantites_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Nom_Boisson_TextChanged(object sender, EventArgs e)
        {
            try
            {
                listBoisson.Items.Clear();
                List<Boissons> lis = BS.FindByName(Nom_Boisson.Text);
                foreach (var boi in lis)
                {
                    ListViewItem lvi = new ListViewItem(new string[] { boi.Id_type.ToString(), boi.Nom, boi.Marque, boi.Prix_vente.ToString() });
                    listBoisson.Items.Add(lvi);
                    lvi.Tag = boi;
                }
            }
            catch (Exception exc) { MessageBox.Show(exc.Message, exc.Source); }
        }

        private void AjoutEtSoustraction_Produits_Load(object sender, EventArgs e)
        {
            try
            {
                Type_Boisson_Manager TB = new Type_Boisson_Manager();
                List<Type_Boisson> lis = TB.Restore();
                foreach (var boi in lis)
                {
                    IdCombo.Items.Add(boi.Id_type.ToString());
                }
                Type_Boisson_Manager TBM = new Type_Boisson_Manager();
                List<Type_Boisson> Tb = TBM.Restore();
                foreach (var boi in Tb)
                {
                    ListViewItem lvi = new ListViewItem(new string[] { boi.Id_type.ToString(), boi.Type, boi.Emballage, boi.Categorie });
                    Liste_Type_Boisson.Items.Add(lvi);
                }
            }
            catch (Exception exc) { MessageBox.Show(exc.Message, exc.Source); }
        }

        private void IdCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Quantites_TextChanged(object sender, EventArgs e)
        {

        }
    }
}