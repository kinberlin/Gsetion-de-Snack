using essaie_de_notifications.Objets;
using essaie_de_notifications.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace essaie_de_notifications.BLL
{
    class Commande_Manager
    {
        public Commande_Respositories Command = new Commande_Respositories();

        public void Create_Command( string id_employe, List<Boissons> liste_boisson, string nom_commanditaires, DateTime date_commande, List<int> quantites)
        {
            Commande_Boisson C = new Commande_Boisson(id_employe,liste_boisson,nom_commanditaires,date_commande,quantites);
            Command.Add(C); 
        } 
        public void Comfirm_Command(string ID_Command,string Nom_client,double Reductions,DateTime Date_delivrance)
        {
            Facture_Respositories Fa = new Facture_Respositories();
            Commande_Boisson C = Command.FindByRef(ID_Command);
            C.Confirm = true;
            Facture F = new Facture(Nom_client,Reductions,Date_delivrance,C);
            Stock_Manager S = new Stock_Manager(C.Liste_boisson);
            S.Remove_FROM_Stock();
            Fa.Add(F);
        }
        public void Modifier_Command(Commande_Boisson CB)
        {
            Commande_Boisson C = Command.FindByRef(CB.Id_Commande);
            Command.Modifier(C, CB);
        }
        public void Add_Command (string id_employe, List<Boissons> liste_boisson, string nom_commanditaires, DateTime date_commande, List<int> quantites)
        {
            Commande_Boisson C = new Commande_Boisson(id_employe, liste_boisson, nom_commanditaires, date_commande, quantites);
            Command.Add(C);
        }
        public void Delete_Command(string Reference)
        {
            Commande_Boisson C = Command.FindByRef(Reference);
            Command.Delete(C);
        }
        public List<Commande_Boisson> Search(string Rech)
        {
            List<Commande_Boisson> LC = Command.fill_back();
            var L_C = from lc in LC where lc.Id_Commande.ToLower().Contains(Rech.ToLower()) || lc.Nom_commanditaires.ToLower().Contains(Rech.ToLower()) select lc;
            return LC;
        }
        public List<Commande_Boisson> Search_Date(DateTime datedeb, DateTime datefin)
        {
            List<Commande_Boisson> LC = Command.fill_back();
            Command.FindByDate(datedeb, datefin);
            return LC;
        }

    }
}
