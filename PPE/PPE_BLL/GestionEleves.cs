using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using PPE_C_Sharp_BO;
using PPE_C_Sharp_DAL;

namespace PPE_C_Sharp_BLL
{
    public class GestionEleves
    {
        public static void SetchaineConnexion(ConnectionStringSettings chset)
        {
            string chaine = chset.ConnectionString;
            ConnexionBD.GetConnexionBD().SetchaineConnexion(chaine);
        }
        public static bool Authentificate(string login, string mdp)
        {
            return UtilisateurDAO.Authentificate(login, mdp);
        }

        public static List<Eleve> GetEleves()
        { 
            return EleveDAO.GetEleves();
        }

        public static Eleve GetEleve(int id_eleve)
        {
            return EleveDAO.GetEleve(id_eleve);
        }
        public static void MdfEleve(Eleve eleve)
        {
            EleveDAO.MdfEleve(eleve);
        }

        public static void InsEleve(Eleve eleve)
        {
            EleveDAO.InsEleve(eleve);
        }

        public static void DelEleve(int id)
        {
            EleveDAO.DelEleve(id);
        }

        public static List<Classe> GetClasses()
        {
            return ClasseDAO.GetClasses();
        }

        public static Classe GetClasse(int id_classe)
        {
            return ClasseDAO.GetClasse(id_classe);
        }

        public static Classe GetClasse(string libelle_classe)
        {
            return ClasseDAO.GetClasse(libelle_classe);
        }


    }
}
