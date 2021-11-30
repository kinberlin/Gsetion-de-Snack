
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace essaie_de_notifications.Objets
{
    class Commande_Boisson
    {
        public string Id_employe { get; set; }
        public List<Boissons> Liste_boisson = new List<Boissons>(); 
        public double Prix_commandes { get; set; }
        public string Nom_commanditaires { get; set; }
        public DateTime Date_commande { get; set; }
        public List<int> Quantites { get; set; }
        public string Id_Commande;
        public bool Confirm { get; set; }

        public Commande_Boisson() 
        {
        }
        public Commande_Boisson(string id_employe,List<Boissons> liste_boisson,  string nom_commanditaires, DateTime date_commande, List<int> quantites)
        {
            Ref();
            this.Id_employe = id_employe;
            this.Liste_boisson = liste_boisson;
            this.Nom_commanditaires = nom_commanditaires;
            this.Date_commande = date_commande;
            this.Quantites = quantites;
            Prix();
        }
        public void Prix()
        {
            int i = 0;
            double prix = 0;
            foreach(var boisson in Liste_boisson)
            {
                prix = (boisson.Prix_vente * Quantites[i]) + prix;
                i++;
            }
            Prix_commandes = prix;
        }
        public void Ref()
        {
            DateTime j = DateTime.Now;
            string J = j.Day.ToString() + j.Month.ToString() + j.Year.ToString() + j.Hour.ToString() + j.Minute.ToString() + j.Second.ToString() +j.Millisecond.ToString();
            this.Id_Commande = J;
        }

    }
}
