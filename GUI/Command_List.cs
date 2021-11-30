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
using GUI.SubForms;

namespace GUI
{
    public partial class Command_List : Form
    {
        Commande_Manager CM = new Commande_Manager();
        public Command_List()
        {
            InitializeComponent();

        }

        private void user_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (user_list.SelectedItems.Count == 0)
                    return;
                var com = user_list.SelectedItems[0].Tag as CLASSES.Objets.Commande_Boisson;
                var F = new GUI.SubForms.Commande_Boisson(com);
             
                F.Show();
            }
            catch (Exception exc) { MessageBox.Show(exc.Message, exc.Source); }
        }

        private void Command_List_Load(object sender, EventArgs e)
        {
            try
            {
                List<CLASSES.Objets.Commande_Boisson> lis = CM.Restore();
                foreach (var boi in lis)
                {
                    ListViewItem lvi = new ListViewItem(new string[] { boi.Id_Commande, boi.Id_employe.ToString(), boi.Confirm.ToString(), boi.Date_commande.ToString(), boi.Prix_commandes.ToString() });
                    user_list.Items.Add(lvi);
                    lvi.Tag = boi;
                }
            }
            catch (Exception exc) { MessageBox.Show(exc.Message, exc.Source); }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

      private void button1_Click(object sender, EventArgs e)
        {
            try { 
            CLASSES.Objets.Commande_Boisson com = user_list.SelectedItems[0].Tag as CLASSES.Objets.Commande_Boisson;
            if (!com.Confirm)
            {
                CM.Delete_Command(com.Id_Commande);
            }
            }catch(Exception excc) { MessageBox.Show(excc.Message, excc.Source); }

        }
    }
}
