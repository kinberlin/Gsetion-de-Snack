
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CLASSES.BLL;
using CLASSES.Objets;

namespace GUI
{
    public partial class MainForm : Form
    {
        System.Drawing.Size FSO;
        Form df;
        private Button currentButton;
        private Random random;
        private int tempIndex;
        public MainForm()
        {
            FSO = this.Size;
            InitializeComponent();
            random = new Random();
        }
        private Color SelectThemeColor()
        {
            int index = random.Next(Themecolor.ColorList.Count);
            while (tempIndex == index)
            {
                random.Next(Themecolor.ColorList.Count);
            }
            tempIndex = index;
            string color = Themecolor.ColorList[index];
            return ColorTranslator.FromHtml(color);

        }
        private void ActivateButton( Object btnSender)
        {
            if(btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Segoe UI", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                    paneltitlebar.BackColor = color;
                  
                    Themecolor.PrimaryColor = color;
                    Themecolor.SecondaryColor = Themecolor.ChangeColorBrightness(color, -0.3);
                    button9.Visible = true;
                    DisableButton();
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panel1.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(24, 30, 54);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                }
            }
        }


        private void OpenChildForm(Form childForm, object btnSender)
        {
            df = childForm;

            object activeForm = null;
            if (activeForm != null)
                activeForm.GetHashCode();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            childForm.AutoScaleMode = AutoScaleMode.Font;
            label2.Text = childForm.Text;

        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new New_Commandes(), sender);
        }

        

        private void button6_Click(object sender, EventArgs e)
        {
            //OpenChildForm(Add_(), sender);
        }

     

        private void button9_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Command_List(), sender);
        }

        
        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Transactions(), sender);
        }

       

        private void button5_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new Forms.FormModification(), sender);
        }

        

        private void button7_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Stock(), sender);
        }

       

        private void button8_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Liste_Employees(), sender);
        }

        

        private void panelDesktopPane_Paint(object sender, PaintEventArgs e)
        {

        }

        private void paneltitlebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
           // OpenChildForm(new Forms.FormAjout(), sender);
        }

        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void paneltitlebar_Paint_1(object sender, PaintEventArgs e)
        {


        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }



        private void ajouterToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            var F = new Add_User();
            F.Show();
        }

        private void supprimerToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var F = new Delete_User();
            F.Show();
        }

        private void ajouterToolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            var F = new MenuStrip.Type_Boisson();
            F.Show();
        }

        private void supprimerToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            var F = new MenuStrip.Type_Boisson();
            F.Show();
        }

        private void modifierToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            var F = new MenuStrip.Type_Boisson();
            F.Show();
        }

        private void ajouterToolStripMenuItem3_Click_1(object sender, EventArgs e)
        {
            var F = new MenuStrip.Ajouter_Connexion();
            F.Show();
        }

        private void supprimerToolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            var F = new SubForms.Supprimer_Connexion();
            F.Show();
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized; 
            }
            else
            { this.WindowState = FormWindowState.Normal; }
        }

        private void button9_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ajouterToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            var F = new GUI.MenuStrip.Fonctions();
            F.Show();
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var F = new GUI.MenuStrip.Fonctions();
            F.Show();
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var F = new GUI.MenuStrip.Fonctions();
            F.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Employee_Manager EM = new Employee_Manager();
            Nom_Prenom.Text = EM.ReadConnected();
            txtEmail.Text = File.ReadAllText("connexion.txt");
            
        }
    }
}
