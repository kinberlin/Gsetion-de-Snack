using essaie_de_notifications.Objets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace essaie_de_notifications.Repositories
{
    class Stock : BaseRepository<Boissons>
    {


        public List<Boissons> Liste_Boisson_S = new List<Boissons>();
        public List<Boissons> Liste_Boisson = new List<Boissons>();
        public Boisson_Repositories Drink_list = new Boisson_Repositories();
        
        public Stock(List<Boissons> liste_Boisson)
        {
            Liste_Boisson = liste_Boisson;
            Liste_Boisson_S = Drink_list.fill_back();
        }
        

        public void Add_TO_STOCK()
        {
            int i = 0;
            foreach(var drink in Liste_Boisson_S)
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
        public bool SUBSTRACT_FROM_STOCK()
        {
            bool subs = true;
            int i = 0;
            foreach (var drink in Liste_Boisson_S)
            {
                if (drink.Equals(Liste_Boisson[i]))
                {
                    double q = drink.Quantite - Liste_Boisson[i].Quantite;
                    if (q > 0)
                    {
                        Liste_Boisson[i].Quantite = q;
                        Set(drink, Liste_Boisson[i]);
                        i++;
                    }
                    else if (q < 0)
                    {
                        subs = false;
                        throw new DuplicateWaitObjectException($"La quantite de boisson {Liste_Boisson[i].Nom} de marque {Liste_Boisson[i].Marque} ne peut satisfaire la commande  !");
                        i++;
                        break;
                    }
                }
            }
            return subs;
        }

    }
}
