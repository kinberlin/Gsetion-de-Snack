using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASSES.Objets
{
    public class Employe : IEquatable<Employe>
    {
        public int Id_Employe { get; set; }
        public DateTime Date_dembauche { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public double Salaire { get; set; }
        public string[,] Horraire = new string[7, 3];
        public string Password { get; set; }
        public string Email { get; set; }
        public bool CanConnect { get; set; }
        public int Id_Fonction { get; set; }

        public Employe()
        {

        }
        public Employe(int id,int id_fonction , DateTime prise_de_service,string nom,string prenom,string email, double sal,string[,] horaire,string Password)
        {
            this.Id_Employe = id;
            this.Id_Fonction = id_fonction;
            this.Date_dembauche = prise_de_service;
            this.Nom = nom;
            this.Prenom = prenom;
            this.Email = email;
            this.Salaire = sal;
            this.Horraire = horaire;
            this.Password = Password;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Employe);
        }

        public bool Equals(Employe other)
        {
            return other != null &&
                   Id_Employe == other.Id_Employe &&
                   Date_dembauche == other.Date_dembauche &&
                   Nom == other.Nom &&
                   Prenom == other.Prenom &&
                   Salaire == other.Salaire &&
                   //EqualityComparer<string[,]>.Default.Equals(Horraire, other.Horraire) &&
                   Password == other.Password &&
                   Email == other.Email &&
                   CanConnect == other.CanConnect &&
                   Id_Fonction == other.Id_Fonction;
        }

        public override int GetHashCode()
        {
            int hashCode = 1597382783;
            hashCode = hashCode * -1521134295 + Id_Employe.GetHashCode();
            hashCode = hashCode * -1521134295 + Date_dembauche.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Nom);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Prenom);
            hashCode = hashCode * -1521134295 + Salaire.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string[,]>.Default.GetHashCode(Horraire);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Password);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Email);
            hashCode = hashCode * -1521134295 + CanConnect.GetHashCode();
            hashCode = hashCode * -1521134295 + Id_Fonction.GetHashCode();
            return hashCode;
        }

        public static bool operator ==(Employe left, Employe right)
        {
            return EqualityComparer<Employe>.Default.Equals(left, right);
        }

        public static bool operator !=(Employe left, Employe right)
        {
            return !(left == right);
        }
    }
}
