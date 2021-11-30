using essaie_de_notifications.Objets;
using essaie_de_notifications.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace essaie_de_notifications.BLL
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

        public void Remove_FROM_Stock()
        {
            Stock stock = new Stock(Liste_Boisson);
            stock.SUBSTRACT_FROM_STOCK();
            stock.Save();
        }
    }
}
