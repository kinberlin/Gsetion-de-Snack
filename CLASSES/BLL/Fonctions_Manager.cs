using CLASSES.Objets;
using CLASSES.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASSES.BLL
{
    public class Fonctions_Manager
    {
        Fonctions_Repository FR = new Fonctions_Repository();

        public bool ID_Exist(int ID)
        {
           return FR.ID_Exist(ID);
        }
        public List<Fonctions__employe> Restore()
        {
            return FR.fill_back();
        }
        public Fonctions__employe Find_ID(int ID)
        {
            return FR.Search_Function_ID(ID);
        }
        public void Add(int id_foction, string nom_Fonction, string role_Fonction, string position)
        {
            Fonctions__employe F_E = new Fonctions__employe(id_foction, nom_Fonction, role_Fonction, position);
            FR.Add(F_E);
        }
        public void Modify(Fonctions__employe OldObj, Fonctions__employe NewObj)
        {
            FR.Set(OldObj, NewObj);
        }
        public void Delete(int ID)
        {
            FR.Delete(FR.Search_Function_ID(ID));
        }
    }

}
