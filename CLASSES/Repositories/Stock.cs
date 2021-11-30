using CLASSES.Objets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASSES.Repositories
{
    class Stock : BaseRepository<Boissons>
    {



        public List<Boissons> Liste_Boisson = new List<Boissons>();
        public Boisson_Repositories Drink_list = new Boisson_Repositories();
        
        public Stock(List<Boissons> liste_Boisson)
        {
            Liste_Boisson = liste_Boisson;
        }
        

        public void Add_TO_STOCK()
        {
            int i = 0;
            foreach(var drink in datas)
            {
                if (drink.Equals(Liste_Boisson[i]))
                {
                    double q = drink.Quantite + Liste_Boisson[i].Quantite;
                    Liste_Boisson[i].Quantite = q;
                    Set(drink, Liste_Boisson[i]);
                    i++;
                }
            }
        }
        public bool SUBSTRACT_FROM_STOCK(List<int> Quantite)
        {
            bool cont = true;
            int z = 0;
            foreach (var drink in Liste_Boisson)
            {
                if (drink.Quantite < Quantite[z])
                {
                    cont = false; break;
                }
                z++;
            }

            if (cont)
            {
                int ij = 0;
                foreach (var drink in datas)
                {
                    foreach (var drinks in Liste_Boisson)
                    {
                        if (drink.Equals(drinks))
                        {
                            double q = Liste_Boisson[ij].Quantite - (double)Quantite[ij];
                            Liste_Boisson[ij].Quantite = q;
                            Set(drink, Liste_Boisson[ij]);
                            ij++;
                        }
                    }
                }
            }
            else { throw new OutOfMemoryException($"La quantite de boisson {Liste_Boisson[z].Nom} de marque {Liste_Boisson[z].Marque} ne peut satisfaire la commande  !"); }
            return cont;
        }
    }
}
