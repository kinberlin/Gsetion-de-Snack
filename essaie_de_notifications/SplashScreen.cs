using MiNET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestionnairebar.Interfaces
{
    
    public partial class SplashScreen : Form
    {
    
        public SplashScreen()
        {
            InitializeComponent();
        }
   

        int secound = 0;
        private void timer1_Tick(Object Sender, EventArgs e)
        {
            secound++;
           /* ProgressBar.Left += 2;
            if (ProgressBar.Left + ProgressBar.Width + 3 > Centerpanel.Width +3)
                ProgressBar.Left = 0;*/

            if (secound == 300)
            {
                Login login = new Login();
                timer1.Stop();
                this.Hide();
                var form = new Login();

                form.Show();

                this.Close();

            }
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
