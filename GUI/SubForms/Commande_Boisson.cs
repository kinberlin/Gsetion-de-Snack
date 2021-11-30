using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CLASSES;
using CLASSES.BLL;

namespace GUI.SubForms
{
    public partial class Commande_Boisson : Form
    {
        CLASSES.Objets.Commande_Boisson C = new CLASSES.Objets.Commande_Boisson();
        bool confirm; Employee_Manager EM = new Employee_Manager();
        public Commande_Boisson(CLASSES.Objets.Commande_Boisson Ca)
        {
            this.C = Ca;
            InitializeComponent();
        }

        private void Commande_Boisson_Load(object sender, EventArgs e)
        {
            
            double total = 0;
            Date.Text = C.Date_commande.ToString();
            Commande_No.Text = C.Id_Commande.ToString();
            Nom_Client.Text = C.Nom_commanditaires;
            Employe.Text = EM.Search(C.Id_employe).Nom;
            int i = 0;
            foreach(var boi in C.Liste_boisson)
            {
                total = C.Quantites[i] * boi.Prix_vente;
                ListViewItem lvi = new ListViewItem(new string[] { boi.Marque, boi.Nom, C.Quantites[i].ToString(), boi.Prix_vente.ToString(), boi.Id_type.ToString(), total.ToString() });
                user_list.Items.Add(lvi);
                i++;
            }
            i = 0;
            Montant.Text = C.Prix_commandes.ToString();
            confirm = C.Confirm;
            if (confirm)
            {
                CONFIRMER.BackColor = Color.Gray;
                Reduction.Hide();
            }
        }
        public void load()
        {
            double total = 0;int i = 0;
            Date.Text = C.Date_commande.ToString();
            Commande_No.Text = C.Id_Commande.ToString();
            Nom_Client.Text = C.Nom_commanditaires;
            Employe.Text = EM.Search(C.Id_employe).Nom;
            foreach (var boi in C.Liste_boisson)
            {
                total = C.Quantites[i] * boi.Prix_vente;
                ListViewItem lvi = new ListViewItem(new string[] { boi.Marque, boi.Nom, boi.Quantite.ToString(), boi.Prix_vente.ToString(), boi.Id_type.ToString(), total.ToString() });
                user_list.Items.Add(lvi);i++;
            }
            Montant.Text = C.Prix_commandes.ToString();
            confirm = C.Confirm;
            if (confirm)
            {
                
                CONFIRMER.BackColor = Color.Gray;
                Reduction.Hide();
                lblReductions.Text = C.Reduction.ToString();
            }
        }

        private void CONFIRMER_Click(object sender, EventArgs e)
        {
            if (!confirm)
            {
                double Red;
                bool s = double.TryParse(Reduction.Text, out Red);
                C.Reduction = Red;
                if (s)
                {
                    C.Confirm = true;
                Commande_Manager CM = new Commande_Manager();
                C.Reduction = double.Parse(Reduction.Text);
                C = CM.Modifier_Command(C);
                    CM.Creer_Facture(C);
                    load();
                }  
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void user_list_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
