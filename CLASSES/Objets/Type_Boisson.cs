using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASSES.Objets
{
    public class Type_Boisson : IEquatable<Type_Boisson>
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
        public Type_Boisson(int Id,string type, string emballage, string categorie)
        {
            this.Id_type = Id;
            this.Type = type;
            this.Emballage = emballage;
            this.Categorie = categorie;

        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Type_Boisson);
        }

        public bool Equals(Type_Boisson other)
        {
            return other != null &&
                   Id_type == other.Id_type &&
                   Type == other.Type &&
                   Emballage == other.Emballage &&
                   Categorie == other.Categorie;
        }

        public override int GetHashCode()
        {
            int hashCode = 1258171075;
            hashCode = hashCode * -1521134295 + Id_type.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Type);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Emballage);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Categorie);
            return hashCode;
        }

        public static bool operator ==(Type_Boisson left, Type_Boisson right)
        {
            return EqualityComparer<Type_Boisson>.Default.Equals(left, right);
        }

        public static bool operator !=(Type_Boisson left, Type_Boisson right)
        {
            return !(left == right);
        }
    }
}
