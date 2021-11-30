using essaie_de_notifications.Objets;
using essaie_de_notifications.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace essaie_de_notifications.BLL
{
    public class Boissons_Manager
    {
        Boisson_Repositories B = new Boisson_Repositories();

        public Boissons_Manager()
        {

        }
        public void Add_Drink(int id_type, string nom, string marque, double prix_achat, double prix_vente)
        {
            Boissons Bo = new Boissons(id_type, nom, marque, prix_achat, prix_vente);
            B.Add(Bo);  
        }
        public void Delete_Drink(int id_type, string nom, string marque, double prix_achat, double prix_vente)
        {
            Boissons Bo = new Boissons(id_type, nom, marque, prix_achat, prix_vente);
            B.Delete (Bo);
        }
       /* public void Modify_Drink(int id_type, string nom, string marque, double prix_achat, double prix_vente)
        {
            Boissons Bn = new Boissons(id_type, nom, marque, prix_achat, prix_vente);
           Boissons Bo = B.FindById(Bo.Id_type);
            B.Set(Bo);
        }*/
        public List<Boissons> FindByName(string nom)
        {
           List<Boissons> list = B.FindByName(nom);
            return list;
        }
        public List<Boissons> FindByType(int type)
        {
            List<Boissons> list = new List<Boissons>();
            list = B.FindByType(type);
            return new List<Boissons>(list);
        }
        public void Modiif(Boissons OldObj, Boissons newObj)
        {
            B.Set(OldObj,newObj);
        }



    }
}
