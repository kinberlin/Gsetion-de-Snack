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
    public partial class Transactions : Form
    {
        Facture_Manager FM = new Facture_Manager();
        Commande_Manager CM = new Commande_Manager();
        List<Facture> ListF = new List<Facture>();
        Facture _f = new Facture();
        List<Commande_Boisson> ListC = new List<Commande_Boisson>();
        public Transactions()
        {
            InitializeComponent();

        }
        
        private void Transactions_Load(object sender, EventArgs e)
        {
            try
            {
                ListC = CM.Restore();
                foreach (var boi in ListC)
                {
                    ListViewItem lvi = new ListViewItem(new string[] { boi.Id_Commande, boi.Id_employe.ToString(), boi.Confirm.ToString(), boi.Prix_commandes.ToString() });
                    command_list.Items.Add(lvi);
                    lvi.Tag = boi;
                }
                ListF = FM.Restore();
                foreach (var boi in ListF)
                {
                    ListViewItem lvi = new ListViewItem(new string[] { boi.Reference, boi.Nom_Client, boi.Date_delivrance.ToString(), boi.Total_Horstaxes.ToString() });
                    receipt_list.Items.Add(lvi);
                    lvi.Tag = boi;
                }
            }
            catch (Exception exc) { MessageBox.Show(exc.Message, exc.Source); }
        }

        private void command_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            try { 
            if (command_list.SelectedItems.Count == 0)
                return;
            var com = command_list.SelectedItems[0].Tag as Commande_Boisson;
            var F = new GUI.SubForms.Commande_Boisson(com);
            F.Show();
            }
            catch (Exception exc) { MessageBox.Show(exc.Message, exc.Source); }
        }

        private void receipt_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            try { 
            if (receipt_list.SelectedItems.Count == 0)
                return;
            var com = receipt_list.SelectedItems[0].Tag as Facture;
            var F = new GUI.SubForms.Bill(com);
            F.Show();
            }
            catch (Exception exc) { MessageBox.Show(exc.Message, exc.Source); }
        }
    }
}
