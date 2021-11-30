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

namespace GUI.SubForms
{
    public partial class Bill : Form
    {
        Facture Fa = new Facture();
        public Bill(Facture Fa)
        {
            this.Fa = Fa;
            InitializeComponent();
        }

        private void user_list_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Bill_Load(object sender, EventArgs e)
        {
            double total = 0;
            Date.Text = Fa.Date_delivrance.ToString();
            Commande_No.Text = Fa.Reference.ToString();
            Nom_Client.Text = Fa.Nom_Client;int i = 0;
            lblReductions.Text = Fa.Reductions.ToString();
            foreach (var boi in Fa.Commandes.Liste_boisson)
            {
                total = ((double)Fa.Commandes.Quantites[i] * boi.Prix_vente);
                ListViewItem lvi = new ListViewItem(new string[] {boi.Nom, Fa.Commandes.Quantites[i].ToString(), boi.Prix_vente.ToString(), total.ToString() });
                user_list.Items.Add(lvi);
                i++;
            }
            Montant.Text = Fa.Total_Horstaxes.ToString();i = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var fac = new Facture_Report(Fa);
            fac.Show();
        }
    }
}
