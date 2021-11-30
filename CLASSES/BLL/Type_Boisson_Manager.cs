using CLASSES.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CLASSES.Objets;

namespace CLASSES.BLL
{
    public class Type_Boisson_Manager
    {

        Type_Boisson_Repository TB = new Type_Boisson_Repository();

        public bool ID_Exist(int ID)
        {
            return TB.ID_Exist(ID);
        }
        public List<Type_Boisson> Restore()
        {
            return TB.fill_back();
        }
        public Type_Boisson Find_ID(int ID)
        {
            return TB.Search_Function_ID(ID);
        }
        public void Add( string type, string emballage, string categorie)
        {
            int i = TB.fill_back().Count();
            Type_Boisson TBO = new Type_Boisson(i, type, emballage, categorie);
            TB.Add(TBO);
        }
        public void Modify(Type_Boisson OldObj, Type_Boisson NewObj)
        {
            TB.Set(OldObj, NewObj);
        }
        public void Delete(int ID)
        {
            TB.Delete(TB.Search_Function_ID(ID));
        }
        public List<Type_Boisson> Restore(int ID)
        {
            return TB.fill_back();      
        }
    }
}
