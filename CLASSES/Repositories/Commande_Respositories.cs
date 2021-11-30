using CLASSES.Objets;
using MyLibs.Serialisation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASSES.Repositories
{
    class Commande_Respositories : BaseRepository<Commande_Boisson>
    {

        public Commande_Respositories() : base()
        {
            FileInfo fileInfo = new FileInfo(PATH);
            if (!fileInfo.Exists || fileInfo.Length == 0)
            { List<Boissons> L = new List<Boissons>(); List<int> Q = new List<int>();Q.Add(0);
                Boissons B = new Boissons(0, "_", "_", 0,0);L.Add(B);
                Commande_Boisson comm = new Commande_Boisson(0,L, "_", Q);
                comm.Date_commande = DateTime.Now;
                Add(comm);
            }
        }
        public List<Commande_Boisson> FindByDate(DateTime datedeb, DateTime datefin)
        {
            List<Commande_Boisson> list = new List<Commande_Boisson>();
            if (datedeb < datefin)
            {
                foreach (var data in datas)
                {
                    if (data.Date_commande >= datedeb && data.Date_commande <= datefin)
                    { list.Add(data); }
                }
            }
            return new List<Commande_Boisson>(list);
        }


        public Commande_Boisson FindByRef(string reference)
        {
            Commande_Boisson list =new Commande_Boisson();
            foreach (var data in datas)
                if (data.Id_Commande.ToLower().Equals(reference.ToLower()))
                { list = data; }
            return list;
        }
        public List<Commande_Boisson> FindByPrice(double prix)
        {
            List<Commande_Boisson> list = new List<Commande_Boisson>();
            foreach (var data in datas)
                if (data.Prix_commandes == prix)
                    list.Add(data);
            return new List<Commande_Boisson>(list);
        }
        public void Modifier (Commande_Boisson OldObj, Commande_Boisson newObj)
        {
            if(OldObj.Confirm == false)
            { Set(OldObj, newObj); }
        }



    }
}
