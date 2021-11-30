using essaie_de_notifications.Objets;
using essaie_de_notifications.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace essaie_de_notifications.BLL
{
    class Employee_Manager
    {
        public Employe_Repository employe = new Employe_Repository();

        public Employe Authenticate(string nom, string password)
        {
            Employe Emp = new Employe();
            Fonctions__employe Fonction = new Fonctions__employe();
            
            List<Fonctions__employe> fonction = new List<Fonctions__employe>();
            List<Employe> employ = employe.GetAll();
            foreach (var user in employ)
            {
                if (user.Nom.ToLower().Equals( nom.ToLower()) && user.Password.ToLower().Equals(password.ToLower())) 
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
        /// <summary>
        /// You can modify connection permissions for a given employee by giving it email to this function to enable him commect to the app
        /// </summary>
        /// <param name="email"></param>
       public void Set_Connect_TO_App(string email)
        {
            bool Can_connect;
            Employe Emp = new Employe();
            Employe_Repository Empl = new Employe_Repository();

            List<Fonctions__employe> fonction = new List<Fonctions__employe>();
            List<Employe> employ = employe.GetAll();
            foreach(var emp in employ)
            {
                if (emp.Email.ToLower().Equals(email.ToLower()))
                {
                    Emp = emp;
                    Can_connect = true;
                    Emp.CanConnect = Can_connect;
                    Empl.Set(emp, Emp);
                    break;
                }
            }
        }
        public void Remove_Connect_TO_App(string email)
        {
            bool Can_connect;
            Employe Emp = new Employe();
            Employe_Repository Empl = new Employe_Repository();

            List<Fonctions__employe> fonction = new List<Fonctions__employe>();
            List<Employe> employ = employe.GetAll();
            foreach (var emp in employ)
            {
                if (emp.Email.ToLower().Equals(email.ToLower()))
                {
                    Emp = emp;
                    Can_connect = false;
                    Emp.CanConnect = Can_connect;
                    Empl.Set(emp, Emp);
                    break;
                }
            }
        }
        public void Set_Employe(int Id_Employe, DateTime Date_dembauche, string Nom, string Prenom, double Salaire, string[,] Horraire, string Password, string Email, int Id_Fonction)
        {
            Employe_Repository Empl = new Employe_Repository();
            Empl.FindById(Id_Employe);
            Employe Emp = Empl.FindById(Id_Employe);
            Employe Emp1 = Empl.FindById(Id_Employe);
            Emp.Id_Employe = Id_Employe;
            Emp.Date_dembauche = Date_dembauche;
            Emp.Nom = Nom;
            Emp.Prenom = Prenom;
            Emp.Salaire = Salaire;
            Emp.Horraire = Horraire;
            Emp.Password = Password;
            Emp.Email = Email;
            Emp.Id_Fonction = Id_Fonction;
            Empl.Set(Emp1, Emp);

        }
        public void Add_Employee(int id_fonction, DateTime prise_de_service, string nom, string prenom, string email, double sal, string[,] horaire)
        {
            Employe Emp = new Employe(id_fonction,prise_de_service,nom,prenom,email,sal,horaire);
            Employe_Repository Empl = new Employe_Repository();
            Empl.Add(Emp);
            
        }

        public void Delete_Employe(int Id)
        {
            Employe Emp = employe.FindById(Id);
            employe.Delete(Emp);
        }

    }
}
