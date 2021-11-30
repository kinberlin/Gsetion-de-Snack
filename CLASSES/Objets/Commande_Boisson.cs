
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASSES.Objets
{
   public class Commande_Boisson : IEquatable<Commande_Boisson>
    {
        public int Id_employe { get; set; }
        public List<Boissons> Liste_boisson = new List<Boissons>(); 
        public double Prix_commandes { get; set; }
        public string Nom_commanditaires { get; set; }
        public DateTime Date_commande { get; set; }
        public List<int> Quantites { get; set; }
        public string Id_Commande;
        public double Reduction;
        public bool Confirm { get; set; }
        
        public Commande_Boisson() 
        {
        }
        public Commande_Boisson(int id_employe,List<Boissons> liste_boisson,  string nom_commanditaires, List<int> quantites)
        {
            Ref();
            Date_commande = DateTime.Now;
            this.Id_employe = id_employe;
            this.Liste_boisson = liste_boisson;
            this.Nom_commanditaires = nom_commanditaires;
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

        public override bool Equals(object obj)
        {
            return Equals(obj as Commande_Boisson);
        }

        public bool Equals(Commande_Boisson other)
        {
            return other != null &&
                   Id_employe == other.Id_employe &&
                  // EqualityComparer<List<Boissons>>.Default.Equals(Liste_boisson, other.Liste_boisson) &&
                   Prix_commandes == other.Prix_commandes &&
                   Nom_commanditaires == other.Nom_commanditaires &&
                   Date_commande == other.Date_commande &&
                  // EqualityComparer<List<int>>.Default.Equals(Quantites, other.Quantites) &&
                   Id_Commande == other.Id_Commande &&
                   Reduction == other.Reduction &&
                   Confirm == other.Confirm;
        }

        public override int GetHashCode()
        {
            int hashCode = -1042092953;
            hashCode = hashCode * -1521134295 + Id_employe.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<List<Boissons>>.Default.GetHashCode(Liste_boisson);
            hashCode = hashCode * -1521134295 + Prix_commandes.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Nom_commanditaires);
            hashCode = hashCode * -1521134295 + Date_commande.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<List<int>>.Default.GetHashCode(Quantites);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Id_Commande);
            hashCode = hashCode * -1521134295 + Reduction.GetHashCode();
            hashCode = hashCode * -1521134295 + Confirm.GetHashCode();
            return hashCode;
        }

        public static bool operator ==(Commande_Boisson left, Commande_Boisson right)
        {
            return EqualityComparer<Commande_Boisson>.Default.Equals(left, right);
        }

        public static bool operator !=(Commande_Boisson left, Commande_Boisson right)
        {
            return !(left == right);
        }
    }
}
