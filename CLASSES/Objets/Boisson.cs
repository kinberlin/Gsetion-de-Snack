using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASSES.Objets
{
    public class Boissons : IEquatable<Boissons>
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
            this.Date_expiration = date_expiratinsvqmhgcx cmqon;*/

        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Boissons);
        }

        public bool Equals(Boissons other)
        {
            return other != null &&
                   Id_type == other.Id_type &&
                   Nom == other.Nom &&
                   Marque == other.Marque &&
                   Prix_achat == other.Prix_achat &&
                   Prix_vente == other.Prix_vente;       
        }

        public override int GetHashCode()
        {
            int hashCode = -510406923;
            hashCode = hashCode * -1521134295 + Id_type.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Nom);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Marque);
            hashCode = hashCode * -1521134295 + Prix_achat.GetHashCode();
            hashCode = hashCode * -1521134295 + Prix_vente.GetHashCode();
            hashCode = hashCode * -1521134295 + Quantite.GetHashCode();
            return hashCode;
        }
        
        public static bool operator ==(Boissons left, Boissons right)
        {
            return EqualityComparer<Boissons>.Default.Equals(left, right);
        }

        public static bool operator !=(Boissons left, Boissons right)
        {
            return !(left == right);
        }
    }
}
