using System;
using System.Collections.Generic;
using essaie_de_notifications.BLL;
using essaie_de_notifications.Objets;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulaires
{
    public partial class AjoutEtSoustraction_Produits : Form
    {public Boissons_Manager BS = new Boissons_Manager();
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
            int i ;double PA;
            bool su =  int.TryParse(IdCombo.Text, out i);
            PA = double.Parse(PrixAchat.Text);
            double PV = double.Parse(PrixVente.Text);
            /*Boissons B = new Boissons(i,NomBoisson.Text,MarqueB.Text,PA,PV);
            Bois.Add(B);*/
            BS.Add_Drink(i, NomBoisson.Text, MarqueB.Text, PA, PV);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBoisson.SelectedItems.Count == 0)
                return;
            double Qua;
            bool su = double.TryParse(Quantites.Text, out Qua);
            if (su)
            {
                var boi = listBoisson.SelectedItems[0].Tag as Boissons;
                Boissons temp = new Boissons();
                temp = boi;
                boi.Quantite = Qua + boi.Quantite;
                BS.Modiif(temp, boi);
            }
        }

        private void Quantites_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Nom_Boisson_TextChanged(object sender, EventArgs e)
        {
            List<Boissons> lis =  BS.FindByName(Nom_Boisson.Text);
            foreach (var boi in lis)
            {
               /* //listBoisson.Items.Add(new ListViewItem(new[] { boi.Id_type, boi.Nom, boi.Marque,boi.Prix_vente}));
                foreach (var pro in usr.Productsp)
                {
                    pro_list.Items.Add(new ListViewItem(new[] { pro.Reference, pro.Name, pro.Price }));
                }*/
            }

        }
    }
}
