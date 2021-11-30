using essaie_de_notifications.Objets;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace essaie_de_notifications.Repositories
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
                Employe emplo = new Employe(0,DT,"admin","admin","admin@admin.net",0,horaire);
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
                if (data.Id_Employe == id)
                    list = data;
            return list;
        }
        public List<Employe> FindBySurname(string surname)
        {
            List<Employe> list = new List<Employe>();
            foreach (var data in datas)
                if (data.Prenom.ToLower().Contains(surname.ToLower()))
                    list.Add(data);
            return new List<Employe>(list);
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
    }
}
