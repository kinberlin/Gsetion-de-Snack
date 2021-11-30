using CLASSES.Objets;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.SubForms
{
    public partial class Facture_Report : Form
    {
        public List<Boissons> Pro = new List<Boissons>();
        public Facture Fa = new Facture();
        public List<Facture> Fac = new List<Facture>();

        public Facture_Report(Facture F)
        {
            Pro = F.Commandes.Liste_boisson;
            Fa = F;
            InitializeComponent();
        }

        private void Facture_Report_Load(object sender, EventArgs e)
        {
            Fac.Add(Fa);
            this.reportViewer1.LocalReport.ReportPath = "FactureReport.rdlc";
            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("Facture", Fac));
            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("Boisson", Pro));
            this.reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
            this.reportViewer1.ZoomPercent = 100;
            this.reportViewer1.RefreshReport();

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
