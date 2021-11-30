using CLASSES.Objets;
using System;
using System.Collections.Generic;
using System.IO;

namespace CLASSES.Repositories
{
    class Facture_Respositories : BaseRepository<Facture>
    {
        public Facture_Respositories() : base()
        {
            FileInfo fileInfo = new FileInfo(PATH);
            if (!fileInfo.Exists || fileInfo.Length == 0)
            {
                List<Boissons> L = new List<Boissons>(); List<int> Q = new List<int>(); Q.Add(0);
                Boissons B = new Boissons(0, "_", "_", 0, 0); L.Add(B);
                Commande_Boisson comm = new Commande_Boisson(0, L, "_", Q);
                comm.Date_commande = DateTime.Now;
                Facture Fa_ct = new  Facture(comm);
                Add(Fa_ct);
            }
        }
        public List<Facture> FindByDate(DateTime datedeb, DateTime datefin)
        {
            List<Facture> list = new List<Facture>();
            if (datedeb < datefin)
            {
                foreach (var data in datas)
                {
                    if (data.Date_delivrance >= datedeb && data.Date_delivrance <= datefin)
                    { list.Add(data); }
                }
            }
            return new List<Facture>(list);
        }


        public Facture FindByRef(string reference)
        {
            Facture list = new Facture();
            foreach (var data in datas)
                if (data.Reference.ToLower().Contains(reference.ToLower()))
                    list = data ;
            return list ;
        }
        public List< Facture> FindByPriceInterval(double prix1, double prix2)
        {
            List<Facture> list = new List<Facture>();
            if (prix1 < prix2)
            {
                foreach (var data in datas)
                {
                    if (data.Total_Horstaxes >= prix1 && data.Total_Horstaxes <= prix2)
                    { list.Add(data); }
                }
            }
            return new List<Facture>(list);
        }
        
        public double PrixTTC(double Total_TTC , double reduction)
        { double t = 0;
            if (reduction > 0) {
                t = Total_TTC - (Total_TTC * reduction);
                    }

            return t;
        }

    }
}
