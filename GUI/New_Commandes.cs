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
    public partial class New_Commandes : Form
    {
        List<int> tab = new List<int>();
        Employee_Manager EM = new Employee_Manager();
        Commande_Manager CM = new Commande_Manager();
        Boissons_Manager BM = new Boissons_Manager();
        List<Boissons> LB1 = new List<Boissons>();
        List<Boissons> LB2 = new List<Boissons>();
        public New_Commandes()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                pro_list.Items.Clear();
                LB1 = BM.FindByName(txtNM.Text);
                foreach (var boi in LB1)
                {
                    ListViewItem lvi = new ListViewItem(new string[] { boi.Marque, boi.Nom, boi.Quantite.ToString(), boi.Prix_vente.ToString(), boi.Id_type.ToString() });
                    pro_list.Items.Add(lvi);
                    lvi.Tag = boi;
                }
            }
            catch (Exception exc) { MessageBox.Show(exc.Message, exc.Source); }
        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            try { 
            int q,i=0;
            bool su = int.TryParse(Quantite.Text, out q);
                if (su)
                {
                    if (pro_list.SelectedItems.Count == 0)
                    { return; }
                    Boissons boi = pro_list.SelectedItems[0].Tag as CLASSES.Objets.Boissons;
                    LB2.Add(boi); tab.Add(q);
                    foreach (var bois in LB2)
                    {
                        ListViewItem lvi = new ListViewItem(new string[] { bois.Marque, bois.Nom, bois.Quantite.ToString(), bois.Prix_vente.ToString(), bois.Id_type.ToString(), tab[i].ToString() });
                        list_Pro.Items.Add(lvi);
                        lvi.Tag = bois;
                    }
                }
            }catch(Exception exc) { MessageBox.Show(exc.Message, exc.Message); }
        }

        private void Commander_Click(object sender, EventArgs e)
        { try
            {
                int  id;
                bool su = int.TryParse(idCombo.Text, out id);
                if (su)
                {
                    
                    int xz = idCombo.Items.Count; int Par = xz - 1; int last = int.Parse(idCombo.Items[Par].ToString());
                    if (id > 0 && id < last)
                        if (CM.Add_Command(id, LB2, Client.Text, tab))
                        {
                            Quantite.Clear(); Client.Clear(); txtNM.Clear(); pro_list.Clear(); list_Pro.Clear(); idCombo.Text = " ";
                        }
                }
            }catch(Exception exc) { MessageBox.Show(exc.Message, exc.Source); }

        }

        private void New_Commandes_Load(object sender, EventArgs e)
        {
            try {
                List<Employe> _e = EM.Restore();
                foreach (var emp in _e)
                {
                    idCombo.Items.Add(emp.Id_Employe.ToString());
                }
            }
            catch (Exception exc) { MessageBox.Show(exc.Message, exc.Source); }
        }

        private void idCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
