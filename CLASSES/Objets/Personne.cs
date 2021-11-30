using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASSES.Objets
{
    class Personne
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime Date_de_Naissance { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }

        public Personne()
        {

        }
        public Personne(string nom , string prenom , DateTime date_de_naissance, string email, string telephone)
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.Date_de_Naissance = date_de_naissance;
            this.Email = email;
            this.Telephone = telephone;
        }


    }
}
