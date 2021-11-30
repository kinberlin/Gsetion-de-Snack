using CLASSES.Objets;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASSES.Repositories
{
   
    class Boisson_Repositories : BaseRepository<Boissons>
    {
        public Boisson_Repositories() : base()
        {
            FileInfo fileInfo = new FileInfo(PATH);
            if (!fileInfo.Exists || fileInfo.Length == 0)
            {
                 Boissons bois = new Boissons(0,"_", "_", 0,0);
                Add(bois);
            }
        }

        public List<Boissons> FindByName(string nom)
        {
            List<Boissons> list = new List<Boissons>();
            foreach (var C in datas) {
                if (C.Nom.ToLower().Contains(nom.ToLower()) || C.Marque.ToLower().Contains(nom.ToLower()))
                    {
                    list.Add(C);
                } 
            }
            return list;
        }


        public List<Boissons> FindByType(int type)
        {
            List<Boissons> list = new List<Boissons>();
            foreach (var data in datas)
                if (data.Id_type == type)
                    list.Add(data);
            return new List<Boissons>(list);
        }






    }
}
