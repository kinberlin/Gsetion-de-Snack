using CLASSES.Objets;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASSES.Repositories
{
    class Type_Boisson_Repository : BaseRepository<Type_Boisson>
    {

        public Type_Boisson_Repository()
        {
            FileInfo fileInfo = new FileInfo(PATH);
            if (!fileInfo.Exists || fileInfo.Length == 0)
            {
                Type_Boisson FE = new Type_Boisson(0, "_", "_", "_");
                Add(FE);
            }
        }
        public List<Type_Boisson> FindByType(string name)
        {
            List<Type_Boisson> list = new List<Type_Boisson>();
            foreach (var data in datas)
                if (data.Type.ToLower().Contains(name.ToLower()))
                    list.Add(data);
            return new List<Type_Boisson>(list);
        }
        public Type_Boisson FindById(string name)
        {
           Type_Boisson list = new Type_Boisson();
            foreach (var data in datas)
                if (data.Type.ToLower().Contains(name.ToLower()))
                { list = data; }
            return list;
        }
        public List<Type_Boisson> FindByCategorie(string Categorie)
        {
            List<Type_Boisson> list = new List<Type_Boisson>();
            foreach (var data in datas)
                if (data.Categorie.ToLower().Contains(Categorie.ToLower()))
                    list.Add(data);
            return new List<Type_Boisson>(list);
        }
        public void Add_Type(Type_Boisson T) 
        {
            int id = datas.Count() + 1;
            T.Id_type = id;
            Add(T);
        }
        public bool ID_Exist(int ID)
        {
            bool exist = false;

            foreach (var data in datas)
            {
                if (data.Id_type == ID)
                { exist = true; }
            }

            return exist;
        }
        public Type_Boisson Search_Function_ID(int ID)
        {
            Type_Boisson list = new Type_Boisson();

            foreach (var data in datas)
            {
                if (data.Id_type == ID)
                { list = data; }
            }

            return list;
        }

    }
}
