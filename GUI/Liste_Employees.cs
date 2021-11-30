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
    public partial class Liste_Employees : Form
    { Employe Emp = new Employe();
        Employee_Manager E_M = new Employee_Manager();
        List<Employe> list = new List<Employe>();
        public Liste_Employees()
        {
            InitializeComponent();
            list = E_M.Restore();
        }

        private void user_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (user_list.SelectedItems.Count == 0)
                { return; }
                var user = user_list.SelectedItems[0].Tag as Employe;
                Emp = (Employe)user;
                var F = new GUI.SubForms.Presentation(user);
                F.Show();
            }
            catch (Exception exc) { MessageBox.Show(exc.Message, exc.Source); }
        }

        private void Liste_Employees_Load(object sender, EventArgs e)
        {
            try
            {
                list = E_M.Restore();
                foreach (var emp in list)
                {
                    ListViewItem lvi = new ListViewItem(new string[] { emp.Id_Employe.ToString(), emp.Nom, emp.Prenom, emp.Id_Fonction.ToString(), emp.Email });
                    user_list.Items.Add(lvi);
                    lvi.Tag = emp;
                }
            }
            catch (Exception exc)  { MessageBox.Show(exc.Message, exc.Source); } 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var L_C = (List<Employe>)from lc in list where lc.Nom.ToLower().Contains(textBox1.Text.ToLower()) || lc.Prenom.ToLower().Contains(textBox1.Text.ToLower()) select lc;
                foreach (var emp in L_C)
                {
                    ListViewItem lvi = new ListViewItem(new string[] { emp.Id_Employe.ToString(), emp.Nom, emp.Prenom, emp.Id_Fonction.ToString(), emp.Email });
                    user_list.Items.Add(lvi);
                }
                if (textBox1.Text.Length == 0)
                {
                    list = E_M.Restore();
                    foreach (var emp in list)
                    {
                        ListViewItem lvi = new ListViewItem(new string[] { emp.Id_Employe.ToString(), emp.Nom, emp.Prenom, emp.Id_Fonction.ToString(), emp.Email });
                        user_list.Items.Add(lvi);
                    }
                }
            }catch(Exception exc) { MessageBox.Show(exc.Message, exc.Source); }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Add_User_Click(object sender, EventArgs e)
        {
            try
            {
                var F_m = new Add_User();
                F_m.Show();
            }catch(Exception exc){ MessageBox.Show(exc.Message, exc.Source); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Emp != null)
                {
                    var F = new Set_User(Emp);
                    F.Show();
                }
                else { Modifier.BackColor = Color.Red; }
            }catch(Exception exc) { MessageBox.Show(exc.Message, exc.Source); }
        }

        private void Del_User_Click(object sender, EventArgs e)
        {
            try
            {
                if (Emp != null)
                {
                    E_M.Delete_Employe(Emp.Id_Employe);
                }
            }catch(Exception exc) { MessageBox.Show(exc.Message, exc.Source); }
        }
    }
}
