using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace essaie_de_notifications.Objets
{
    class Employe
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
        public Employe(int id_fonction , DateTime prise_de_service,string nom,string prenom,string email, double sal,string[,] horaire)
        {
            
            this.Id_Fonction = id_fonction;
            this.Date_dembauche = prise_de_service;
            this.Nom = nom;
            this.Prenom = prenom;
            this.Email = email;
            this.Salaire = sal;
            this.Horraire = horaire;
        }
        
    }
}
