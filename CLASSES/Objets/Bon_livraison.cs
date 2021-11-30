using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASSES.Objets
{
    class Bon_livraison
    {
public string Entreprise_Livrant { get; set; }
        public List<Boissons> Listes_Boissons = new List<Boissons>();
        public DateTime Date_livraison { get; set; }
        public double Montant { get; set; }
        public string Mode_paiement { get; set; }
        
        public Bon_livraison()
        {

        }
        public Bon_livraison(string entreprise_Livrant, List<Boissons> listes_Boissons, DateTime date_livraison, double montant, string mode_paiement)
        {
            this.Entreprise_Livrant = entreprise_Livrant;
            this.Listes_Boissons = listes_Boissons;
            this.Date_livraison = date_livraison;
            this.Montant = montant;
            this.Mode_paiement = mode_paiement;
        }

    }
}
