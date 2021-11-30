using CLASSES.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASSES.Objets
{
    public class Facture : IEquatable<Facture>
    {
        public string Reference { get; set; }
        public double Total_Commandes { get; set; }
        public double Total_Horstaxes { get; set; }
        public string Nom_Client { get; set; }
        public float TVA { get; set; }
        public double Reductions { get; set; }
        public DateTime Date_delivrance { get; set; }
        public List<int> Quantites { get; set; }
        public Commande_Boisson Commandes = new Commande_Boisson();

        public void SetDate_delivrance()
        {
            DateTime j = DateTime.Now;

                Date_delivrance = j;
        }
        public Facture()
        {

        }
        public Facture(  Commande_Boisson commandes)
        {
            this.Quantites = Commandes.Quantites;
            this.Reference = commandes.Id_Commande;
            this.Total_Commandes = commandes.Prix_commandes;
            this.Nom_Client = commandes.Nom_commanditaires;
            this.Reductions = commandes.Reduction;
            SetDate_delivrance();
            PTTC();
            this.Commandes = commandes;
        }
        public void PTTC()
        {
            double b = Total_Commandes -( (Reductions/100) * Total_Commandes);
            this.Total_Horstaxes = b;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Facture);
        }

        public bool Equals(Facture other)
        {
            return other != null &&
                   Reference == other.Reference &&
                   Total_Commandes == other.Total_Commandes &&
                   Total_Horstaxes == other.Total_Horstaxes &&
                   Nom_Client == other.Nom_Client &&
                   TVA == other.TVA &&
                   Reductions == other.Reductions &&
                   Date_delivrance == other.Date_delivrance; /* &&
                   EqualityComparer<Commande_Boisson>.Default.Equals(Commandes, other.Commandes);*/
        }

        public override int GetHashCode()
        {
            int hashCode = 2025041379;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Reference);
            hashCode = hashCode * -1521134295 + Total_Commandes.GetHashCode();
            hashCode = hashCode * -1521134295 + Total_Horstaxes.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Nom_Client);
            hashCode = hashCode * -1521134295 + TVA.GetHashCode();
            hashCode = hashCode * -1521134295 + Reductions.GetHashCode();
            hashCode = hashCode * -1521134295 + Date_delivrance.GetHashCode();
           // hashCode = hashCode * -1521134295 + EqualityComparer<Commande_Boisson>.Default.GetHashCode(Commandes);
            return hashCode;
        }

        public static bool operator ==(Facture left, Facture right)
        {
            return EqualityComparer<Facture>.Default.Equals(left, right);
        }

        public static bool operator !=(Facture left, Facture right)
        {
            return !(left == right);
        }
    }
}
