using CLASSES.Objets;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASSES.Repositories
{
    class Fonctions_Repository : BaseRepository<Fonctions__employe>
    {
        public Fonctions_Repository() { 
        FileInfo fileInfo = new FileInfo(PATH);
            if (!fileInfo.Exists || fileInfo.Length == 0)
            {
                Fonctions__employe FE = new Fonctions__employe(0,"Admin","Admin","Admin");
                Add(FE);
            }
    }
    public List<Fonctions__employe> Function_Name(string nom)
        {
            List<Fonctions__employe> list = new List<Fonctions__employe>();

            foreach (var data in datas)
            {
                if (data.Nom_Fonction.ToLower().Contains(nom.ToLower()))
                { list.Add(data); }
            }

            return new List<Fonctions__employe>(list);
        }

        public Fonctions__employe Search_Function_ID(int ID)
        {
            Fonctions__employe list = new Fonctions__employe();

            foreach (var data in datas)
            {
                if (data.Id_Fonction == ID)
                { list = data; }
            }

            return list;
        }

        public bool ID_Exist(int ID)
        {
            bool exist = false;

            foreach (var data in datas)
            {
                if (data.Id_Fonction == ID)
                { exist = true; }
            }

            return exist;
        }

        public void Fonctions_Connect(int idFonc)
        {
            bool list ;
            Employe_Repository Empl = new Employe_Repository();
            List<Employe> EmpList = Empl.GetAll();
            list = ID_Exist(idFonc);
            if (list)
            {
                 foreach (var emp in EmpList)
                {
                    if (emp.Id_Fonction == idFonc)
                    {
                        emp.CanConnect =  true;
                    }
                }
                Empl.Set_List(EmpList);
            }
        }
    }
}
