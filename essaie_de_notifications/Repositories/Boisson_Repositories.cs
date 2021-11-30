using essaie_de_notifications.Objets;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace essaie_de_notifications.Repositories
{
   
    class Boisson_Repositories : BaseRepository<Boissons>
    {
        public Boisson_Repositories() : base()
        {
            FileInfo fileInfo = new FileInfo(PATH);
            if (!fileInfo.Exists || fileInfo.Length == 0)
            {
                 Boissons bois = new Boissons();
                Add(bois);
            }
        }
       
        public List<Boissons> FindByName(string nom)
        {
            List<Boissons> list = new List<Boissons>();

                foreach (var data in datas)
                {
                if (data.Nom.ToLower().Equals(nom.ToLower()))
                    { list.Add(data); }
                }
            
            return new List<Boissons>(list);
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
