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
    public partial class Type_Boisson : Form
    {
        public Type_Boisson()
        {
            InitializeComponent();
        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            Type_Boisson_Manager TB = new Type_Boisson_Manager();
            CLASSES.Objets.Type_Boisson tb = new CLASSES.Objets.Type_Boisson();
            int Id;
            bool s = int.TryParse(txtTypeBoisson.Text, out Id);
            bool Existe = TB.ID_Exist(Id);
            tb = TB.Find_ID(Id);
            CLASSES.Objets.Type_Boisson t_b = tb;
            t_b.Categorie = txtCategorie.Text;
            t_b.Emballage = txtEmballage.Text;
            t_b.Type = Type.Text;
            if (Existe) { MessageBox.Show("L'ID Entree existe deja", "ID", MessageBoxButtons.OK); }
            if (s)
            {
                TB.Modify(tb, t_b);
            }
            else { MessageBox.Show("L'ID Entree n'est pas numeriques", "ID", MessageBoxButtons.OK); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Type_Boisson_Manager TB = new Type_Boisson_Manager();
            if (deleteCheck.Checked)
            {
                Save.Text = "Delete";
                int Id;
                bool s = int.TryParse(txtTypeBoisson.Text, out Id);
                bool Existe = TB.ID_Exist(Id);
                if (Existe) { MessageBox.Show("L'ID Entree existe deja", "ID", MessageBoxButtons.OK); }
                if (s)
                {
                    TB.Delete(Id);
                }
                else { MessageBox.Show("L'ID Entree n'est pas numeriques", "ID", MessageBoxButtons.OK); }
            }
            else
            {
                Save.Text = "Save";
                int ID;
                bool su = int.TryParse(txtTypeBoisson.Text, out ID);
                bool Exist = TB.ID_Exist(ID);
                if (Exist) { MessageBox.Show("L'ID Entree existe deja", "ID", MessageBoxButtons.OK); }
                if (su)
                {
                    TB.Add(Type.Text, txtEmballage.Text, txtCategorie.Text);
                }
                else { MessageBox.Show("L'ID Entree n'est pas numeriques", "ID", MessageBoxButtons.OK); }
                Type.Clear(); txtCategorie.Clear(); txtEmballage.Clear(); txtTypeBoisson.Clear();
            }
        }
    }
}
