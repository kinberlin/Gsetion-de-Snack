using CLASSES.Objets;
using CLASSES.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASSES.BLL
{
 public class Stock_Manager
    {

        public List<Boissons> Liste_Boisson = new List<Boissons>();

        public Stock_Manager(List<Boissons> liste_Boisson)
        {
            Liste_Boisson = liste_Boisson;
        }
        
        public void Add_TO_Stock()
        {
        Stock stock = new Stock(Liste_Boisson);
            stock.Add_TO_STOCK();
            stock.Save();
        }

        public bool Remove_FROM_Stock(List<int> Quantite)
        {
            Stock stock = new Stock(Liste_Boisson);
            return stock.SUBSTRACT_FROM_STOCK(Quantite);
        }
    }
}
