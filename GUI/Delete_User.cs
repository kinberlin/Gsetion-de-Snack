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
    public partial class Delete_User : Form
    {
        Employee_Manager EM = new Employee_Manager();
        public Delete_User()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        { try{int i;
            MessageBox.Show("Voulez vous vraiment supprimer l'utilisateur dont l'id est : " + emp_id.Text, "Delete INFO", MessageBoxButtons.OKCancel);
            bool s = int.TryParse(emp_id.Text, out i);
                if (s) {
                    EM.Delete_Employe(i);
                }
      }
            catch (Exception exc) { MessageBox.Show(exc.Message, exc.Source); }
        }
    }
}
