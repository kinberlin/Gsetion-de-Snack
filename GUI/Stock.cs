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
    public partial class Stock : Form
    {
        List<Boissons> lis;
        public Boissons_Manager BS = new Boissons_Manager();
        public List<Boissons> Bois = new List<Boissons>();
        public Stock()
        {
            lis = new List<Boissons>();
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                user_list.Items.Clear();
                List<Boissons> lis = BS.FindByName(textBox1.Text);
                foreach (var boi in lis)
                {

                    ListViewItem lvi = new ListViewItem(new string[] { boi.Marque, boi.Nom, boi.Quantite.ToString(), boi.Prix_achat.ToString(), boi.Prix_vente.ToString(), boi.Id_type.ToString() });
                    user_list.Items.Add(lvi);
                }
                if (textBox1.Text.Length == 0)
                {
                    user_list.Items.Clear();
                    Bois = BS.Restore();
                    foreach (var boi in Bois)
                    {
                        ListViewItem lvi = new ListViewItem(new string[] { boi.Marque, boi.Nom, boi.Quantite.ToString(), boi.Prix_achat.ToString(), boi.Prix_vente.ToString(), boi.Id_type.ToString() });
                        user_list.Items.Add(lvi);
                    }
                }
            }
            catch (Exception exc) { MessageBox.Show(exc.Message, exc.Source); }
        }

        private void user_list_SelectedIndexChanged(object sender, EventArgs e)
        {try
            {
                if (user_list.SelectedItems.Count == 0)
                { return; }
                var com = user_list.SelectedItems[0].Tag as CLASSES.Objets.Boissons;
            }
            catch (Exception exc) { MessageBox.Show(exc.Message, exc.Source); }
        }

        private void Stock_Load(object sender, EventArgs e)
        {try
            {
                lis = BS.Restore();
                foreach (var boi in lis)
                {
                    ListViewItem lvi = new ListViewItem(new string[] { boi.Marque, boi.Nom, boi.Quantite.ToString(), boi.Prix_achat.ToString(), boi.Prix_vente.ToString(), boi.Id_type.ToString() });
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
        {try
            {
                var F = new AjoutEtSoustraction_Produits();
                F.Show();
            }
            catch (Exception exc) { MessageBox.Show(exc.Message, exc.Source); }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                CLASSES.Objets.Boissons com = user_list.SelectedItems[0].Tag as Boissons;
                BS.Delete_Drink(com);
            }
            catch (Exception exc) { MessageBox.Show(exc.Message, exc.Source); }
        }
    }
}
