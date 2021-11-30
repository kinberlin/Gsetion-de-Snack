using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace essaie_de_notifications.Objets
{
    class Type_Boisson
    {    /// <summary>
         /// By Type we mean alcoholic, Gaseous etc ..
         /// </summary>
        public int Id_type { get; set; }
        public string Type { get; set; } 
        public string Emballage { get; set; } // en bouteil, sachet,

    /// <summary>
    /// By category we mean wine, juice,beer and etc
    /// </summary>
        public string Categorie { get; set; } 
        
        public Type_Boisson()
        {

        }
        public Type_Boisson(string type, string emballage, string categorie)
        {   
            this.Type = type;
            this.Emballage = emballage;
            this.Categorie = categorie;

        }
    }
}
