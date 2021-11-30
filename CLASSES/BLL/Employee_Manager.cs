using CLASSES.Objets;
using CLASSES.Repositories;
using CLASSES.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CLASSES.BLL
{
    public class Employee_Manager
    {
         Employe_Repository employe = new Employe_Repository();
        Fonctions_Manager FM = new Fonctions_Manager();

        public Employe Authenticate(string nom, string password)
        {
            Employe Emp = new Employe();
            Fonctions__employe Fonction = new Fonctions__employe();

            List<Fonctions__employe> fonction = FM.Restore();

            List<Employe> employ = employe.GetAll();
            foreach (var user in employ)
            {
                if (user.Email.ToLower().Equals(nom.ToLower()) && user.Password.ToLower().Equals(password.ToLower()))
                {
                    Emp = user;
                    break;
                }
            }
            foreach (var fonc in fonction)
            {
                if (fonc.Id_Fonction == Emp.Id_Fonction)
                {
                    Fonction = fonc; break;
                }
            }
            if (Fonction.CanConnect == true)
            {
                return Emp;

            }
            else
            {
                if (Emp.CanConnect)
                {
                    return Emp;
                }
                else
                {
                    return null;
                }
            }
        }
        public string GetFonction(int ID)
        {
            string Nom = " ";
            List<Fonctions__employe> fonction = FM.Restore();
            foreach (var fonc in fonction)
            {
                if (fonc.Id_Fonction == ID)
                {
                    Nom = fonc.Nom_Fonction; break;
                }
            }
            return Nom;
        }
        public string ReadConnected()
        { 
            Employe _em = new Employe();
            _em = null; string s = " ";
            string connected = File.ReadAllText("connexion.txt");
            foreach (var Emp in employe.fill_back()) { if (Emp.Email.ToLower().Equals(connected.ToLower())) { _em = Emp; s = _em.Nom + " " + _em.Prenom; } }
            s = "Fonctions";
            return s;
        }
        public string ReadConnected_File()
        {
            Employe _em = new Employe();
            _em = null;
            string connected = File.ReadAllText("connexion.txt");
            return connected;
        }
        /// <summary>
        /// You can modify connection permissions for a given employee by giving it email to this function to enable him commect to the app
        /// </summary>
        /// <param name="email"></param>
        public void Set_Connect_TO_App(string txt)
        {
            employe.Set_Connect_TO_App(txt);
        }
        public void Remove_Connect_TO_App(string email)
        {
            employe.Remove_Connect_TO_App(email);
        }
        public void Set_Employe(int Id_Employe, string Nom, string Prenom, double Salaire, string[,] Horraire, string Password, string Email, int Id_Fonction,Employe E)
        {
            Employe_Repository Empl = new Employe_Repository();
            Employe Emp = Empl.FindById(Id_Employe);
            Emp.Id_Employe = Id_Employe;
            Emp.Nom = Nom;
            Emp.Prenom = Prenom;
            Emp.Salaire = Salaire;
            Emp.Horraire = Horraire;
            Emp.Password = Password;
            Emp.Email = Email;
            Emp.Id_Fonction = Id_Fonction;
            Empl.Set(E, Emp);

        }
        public void Add_Employee(int id_fonction,  string nom, string prenom, string email, double sal, string[,] horaire,string password)
        {
                int len = 0;
                List<Employe> L = employe.fill_back();
                foreach (var em in L) { len++; }
                DateTime j = DateTime.Now;
                Employe Emp = new Employe(len,id_fonction, j, nom, prenom, email, sal, horaire, password);
                employe.Add(Emp);

        }

        public void Delete_Employe(int Id)
        {
            Employe Emp = employe.FindById(Id);
            employe.Delete(Emp);
        }
        public List<Employe> Restore()
        {
            return employe.fill_back();
        }
        public Employe Search(int Id)
        {
            return employe.FindById(Id);
        }

    }
}
