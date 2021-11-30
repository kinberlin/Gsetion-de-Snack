using CLASSES.Objets;
using CLASSES.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASSES.BLL
{
    public class Commande_Manager
    {
        Commande_Respositories Command = new Commande_Respositories();

        public void Create_Command(int id_employe, List<Boissons> liste_boisson, string nom_commanditaires, List<int> quantites)
        {
            Stock_Manager ST = new Stock_Manager(liste_boisson);
            ST.Remove_FROM_Stock(quantites);
            Commande_Boisson C = new Commande_Boisson(id_employe, liste_boisson, nom_commanditaires, quantites);
            Command.Add(C);
        }
        /*public void Comfirm_Command(string ID_Command,string Nom_client,double Reductions,DateTime Date_delivrance)
        {
            Facture_Respositories Fa = new Facture_Respositories();
            Commande_Boisson C = Command.FindByRef(ID_Command);
            C.Confirm = true;
            Facture F = new Facture(Reductions,C);
            Stock_Manager S = new Stock_Manager(C.Liste_boisson);
            S.Remove_FROM_Stock();
            Fa.Add(F);
        }*/
        public void Creer_Facture(Commande_Boisson C)
        {
            Facture _F = new Facture(C);
            Facture_Manager FM = new Facture_Manager();

            FM.Ajouter_Facture(_F);
        }

        public Commande_Boisson Modifier_Command(Commande_Boisson CB)
        {
            Commande_Boisson C = Command.FindByRef(CB.Id_Commande);
            Command.Modifier(C, CB);
            return CB;
        }
        public bool Add_Command(int id_employe, List<Boissons> liste_boisson, string nom_commanditaires, List<int> quantites)
        {

            Commande_Boisson C = new Commande_Boisson(id_employe, liste_boisson, nom_commanditaires, quantites);
            Stock_Manager SM = new Stock_Manager(liste_boisson);
            bool c = SM.Remove_FROM_Stock(quantites);
            if (c)
            {
                Command.Add(C);
            }
            return c;
        }
        public void Delete_Command(string Reference)
        {
            Commande_Boisson C = Command.FindByRef(Reference);
            Command.Delete(C);
        }
        public List<Commande_Boisson> Search(string Rech)
        {

            List<Commande_Boisson> LC = Command.fill_back();
            List<Commande_Boisson> L_C = new List<Commande_Boisson>();
            foreach (var C in LC)
            {
                if (C.Id_Commande.ToLower().Contains(Rech.ToLower()) || C.Nom_commanditaires.ToLower().Contains(Rech.ToLower()))
                {
                    L_C.Add(C);
                }
            }
            return L_C;
        }
        public List<Commande_Boisson> Search_Date(DateTime datedeb, DateTime datefin)
        {
            List<Commande_Boisson> LC = Command.fill_back();
            Command.FindByDate(datedeb, datefin);
            return LC;
        }
        public List<Commande_Boisson> Restore()
        {
            return Command.fill_back();
        }

    }
}
