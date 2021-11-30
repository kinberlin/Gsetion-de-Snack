using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace essaie_de_notifications.Objets
{
    public class Boissons
    {
        public int Id_type { get; set; }
        public string Nom { get; set; }
        public string Marque { get; set; }
        public double Prix_achat { get; set; }
        public double Prix_vente { get; set; }
        public double Quantite { get; set; }
       /* public DateTime Date_production { get; set; }
        public DateTime Date_expiration { get; set; }*/

        public Boissons()
        {

        }
        public Boissons(int id_type, string nom, string marque, double prix_achat, double prix_vente/*, DateTime date_production, DateTime date_expiration*/)
        {
            this.Id_type = id_type;
            this.Nom = nom;
            this.Marque = marque;
            this.Prix_achat = prix_achat;
            this.Prix_vente = prix_vente;
           /* this.Date_production = date_production;
            this.Date_expiration = date_expiration;*/

        }
    }
}
