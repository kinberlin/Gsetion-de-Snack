using CLASSES.Objets;
using CLASSES.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASSES.BLL
{
     public class Facture_Manager
    {
        Facture_Respositories FactR = new Facture_Respositories();

        public void Ajouter_Facture(Facture F)
        {
            FactR.Add(F);
        }

        public List<Facture> Search(string Rech)
        {
            List<Facture> LC = FactR.fill_back();
            List<Facture> L_C = new List<Facture>();
            foreach (var C in LC)
            {
                if (C.Reference.ToLower().Contains(Rech.ToLower()) || C.Nom_Client.ToLower().Contains(Rech.ToLower()))
                {
                    L_C.Add(C);
                }
            }
            return L_C;
        }
        public List<Facture> Search_Date(DateTime datedeb, DateTime datefin)
        {
            List<Facture> LC = FactR.fill_back();
            List<Facture> L_C = new List<Facture>();
            foreach (var C in LC)
            {
                if (C.Date_delivrance >= datedeb || C.Date_delivrance <= datefin)
                {
                    L_C.Add(C);
                }
            }
            return L_C;
        }
        public List<Facture> Restore()
        {
            Facture_Respositories FactRe = new Facture_Respositories();
            return FactR.fill_back();
        }
    }
}
