using essaie_de_notifications.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace essaie_de_notifications.Objets
{
    class Facture
    {
        public string Reference { get; set; }
        public double Total_Commandes { get; set; }
        public double Total_Horstaxes { get; set; }
        public string Nom_Client { get; set; }
        public float TVA { get; set; }
        public double Reductions { get; set; }
        public DateTime Date_delivrance { get; set; }
        public Commande_Boisson Commandes = new Commande_Boisson();

        public void SetDate_delivrance(DateTime date_delivrance)
        {
            DateTime j = DateTime.Now;
            if (date_delivrance == j) 
            {
                Date_delivrance = date_delivrance;
            }
        }
        public Facture()
        {

        }
        public Facture( string nom_Client,  double reductions, DateTime date_delivrance, Commande_Boisson commandes)
        {
            this.Reference = commandes.Id_Commande;
            this.Total_Commandes = commandes.Prix_commandes;
            this.Nom_Client = nom_Client;
            this.Reductions = reductions;
            SetDate_delivrance(date_delivrance);
            this.Commandes = commandes;
            Facture_Respositories fact = new Facture_Respositories();
            Total_Horstaxes = fact.PrixTTC(this.Total_Commandes, this.Reductions);
        }

    }
}
