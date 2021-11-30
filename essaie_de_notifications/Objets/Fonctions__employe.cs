using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace essaie_de_notifications.Objets
{
    class Fonctions__employe
    {
        public int Id_Fonction { get; set; }
        public string Nom_Fonction { get; set; } //ou nom de poste occupe
        public string Role_Fonction { get; set; }
        public string Position { get; set; } // pour permettre de connaitre ceux travaillant a la caisse, stocks et etc
        public bool CanConnect { get; set; }
        public DateTime Horaire_travaille { get; set; }

        public Fonctions__employe()
        {

        }
        public Fonctions__employe(int id_foction,string nom_Fonction, string role_Fonction,string position, DateTime horaire_travaille)
        {
            this.Id_Fonction = id_foction;
            this.Nom_Fonction = nom_Fonction;
            this.Role_Fonction = role_Fonction;
            this.Position = position;
            this.Horaire_travaille = horaire_travaille;
            
        }
        public void Canconnect()
        {
            if (Role_Fonction.ToLower().Equals("Secretaire".ToLower()))
            {
                CanConnect = true;
            }
        }
    }
}
