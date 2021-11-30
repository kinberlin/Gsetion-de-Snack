using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASSES.Objets
{
    public class Fonctions__employe : IEquatable<Fonctions__employe>
    {
        public int Id_Fonction { get; set; }
        public string Nom_Fonction { get; set; } //ou nom de poste occupe
        public string Role_Fonction { get; set; }
        public string Position { get; set; } // pour permettre de connaitre ceux travaillant a la caisse, stocks et etc
        public bool CanConnect { get; set; }

        public Fonctions__employe()
        {

        }
        public Fonctions__employe(int id_foction,string nom_Fonction, string role_Fonction,string position)
        {
            this.Id_Fonction = id_foction;
            this.Nom_Fonction = nom_Fonction;
            this.Role_Fonction = role_Fonction;
            this.Position = position;
            connect();
            
        }
        public void connect()
        {
            if (Role_Fonction.ToLower().Equals("Secretaire".ToLower()))
            {
                CanConnect = true;
            }
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Fonctions__employe);
        }

        public bool Equals(Fonctions__employe other)
        {
            return other != null &&
                   Id_Fonction == other.Id_Fonction &&
                   Nom_Fonction == other.Nom_Fonction &&
                   Role_Fonction == other.Role_Fonction &&
                   Position == other.Position &&
                   CanConnect == other.CanConnect;
        }

        public override int GetHashCode()
        {
            int hashCode = 730881974;
            hashCode = hashCode * -1521134295 + Id_Fonction.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Nom_Fonction);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Role_Fonction);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Position);
            hashCode = hashCode * -1521134295 + CanConnect.GetHashCode();
            return hashCode;
        }

        public static bool operator ==(Fonctions__employe left, Fonctions__employe right)
        {
            return EqualityComparer<Fonctions__employe>.Default.Equals(left, right);
        }

        public static bool operator !=(Fonctions__employe left, Fonctions__employe right)
        {
            return !(left == right);
        }
    }
}
