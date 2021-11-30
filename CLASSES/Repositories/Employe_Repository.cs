using CLASSES.Objets;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CLASSES.BLL;
namespace CLASSES.Repositories
{
    class Employe_Repository : BaseRepository<Employe>
    {
        public List<Employe> Liste_Employe = new List<Employe>();

        public Employe_Repository() : base()
        {
            FileInfo fileInfo = new FileInfo(PATH);
            if (!fileInfo.Exists || fileInfo.Length == 0)
            { string[,] horaire = new string[7, 3];
                DateTime DT = new DateTime();
                Employe emplo = new Employe(0,0,DT,"admin","admin","admin@admin.net",0,horaire,"admin");
                Add(emplo);
            }
        }

        public List<Employe> FindByName(string name)
        {
            List<Employe> list = new List<Employe>();
            foreach (var data in datas)
                if (data.Nom.ToLower().Contains(name.ToLower()))
                    list.Add(data);
            return new List<Employe>(list);
        }
        public Employe FindById(int id)
        {
            Employe list = new Employe();
            foreach (var data in datas)
            {
                if (data.Id_Employe == id)
                    list = data;
            }
            return list;
        }

        public List<Employe> FindByFonction(int fonc)
        {
           List< Employe> list = new List<Employe>();
            foreach (var data in datas)
                if (data.Id_Fonction == fonc)
                { list.Add(data); }
            return list;
        }
        /// <summary>
        /// Methode a utiliser seuleument pour la modification des Acces a la l'appli
        /// </summary>
        /// <param name="Liste_Emplo"></param>
        public void Set_List(List<Employe> Liste_Emplo)
        {
            datas = Liste_Emplo;
            Save();
        }
        public void Set_Connect_TO_App(string txt)
        {
            Fonctions_Manager FM = new Fonctions_Manager();
            bool Can_connect = false;
            Employe Emp = new Employe();int i = 0;
            List<Fonctions__employe> fonction = new List<Fonctions__employe>();
            foreach (var emp in datas)
            {
                if (emp.Email.ToLower().Equals(txt.ToLower()))
                {
                    Emp = emp;
                    Can_connect = true;
                    Emp.CanConnect = true;
                    if (emp.Equals(emp))
                    {
                        datas[i] = Emp;
                        Save();
                    }
                    break;
                }
                i++;
            }
            if (Can_connect == false)
            {
                fonction = FM.Restore(); Fonctions__employe fonction_ = new Fonctions__employe(); ;
                foreach (var fonc in fonction)
                {
                    if (fonc.Nom_Fonction.ToLower().Equals(txt.ToLower()))
                    {
                        fonction_ = fonc;
                        fonction_.CanConnect = true;
                        FM.Modify(fonc, fonction_);
                    }
                }
            }
        }
        public void Remove_Connect_TO_App(string email)
        {
            Fonctions_Manager FM = new Fonctions_Manager();
            bool Can_connect = true;
            Employe Emp = new Employe();
            Employe_Repository Empl = new Employe_Repository();
            int i = 0;
            List<Fonctions__employe> fonction = new List<Fonctions__employe>();
            foreach (var emp in datas)
            {
                
                if (emp.Email.ToLower().Equals(email.ToLower()))
                {
                    Emp = emp;
                    Can_connect = false;
                    Emp.CanConnect = false;
                    if (emp.Equals(emp))
                    {
                        datas[i] = Emp;
                        Save();
                    }
                    i++;
                    break;
                }
            }
            if (Can_connect) { }
            fonction = FM.Restore(); Fonctions__employe fonction_ = new Fonctions__employe(); ;
            foreach (var fonc in fonction)
            {
                if (fonc.Nom_Fonction.ToLower().Equals(email.ToLower()))
                {
                    fonction_ = fonc;
                    fonction_.CanConnect = false;
                    FM.Modify(fonc, fonction_);
                }
            }
        }
    }
}
