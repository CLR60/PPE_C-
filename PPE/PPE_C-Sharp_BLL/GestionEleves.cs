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
    // Bibliothèque de gestion des eleves
    public class GestionEleves
    {
        // Fonction d'assignation de la chaine de connection grace a un objet ConnectionStringSettings
        public static void SetchaineConnexion(ConnectionStringSettings chset)
        {
            string chaine = chset.ConnectionString;
            ConnexionBD.GetConnexionBD().SetchaineConnexion(chaine);
        }

        // Fonction permettant l'autentification grace a 2 chaine de caractere
        public static bool Authentificate(string login, string mdp)
        {
            return UtilisateurDAO.Authentificate(login, mdp);
        }

        // Fonction permettant la la recuperation de tout les eleves
        public static List<Eleve> GetEleves()
        { 
            return EleveDAO.GetEleves();
        }

        // Fonction permettant la recuperation d'un eleve grace a son id
        public static Eleve GetEleve(int id_eleve)
        {
            return EleveDAO.GetEleve(id_eleve);
        }
        // Fonction permettant la modification d'un eleve grace a un objet Eleve
        public static void MdfEleve(Eleve eleve)
        {
            EleveDAO.MdfEleve(eleve);
        }

        // Fonction permettant l'insertion d'un eleve grace a un objet Eleve
        public static void InsEleve(Eleve eleve)
        {
            EleveDAO.InsEleve(eleve);
        }

        // Fonction permettant la supression d'un eleve grace a un objet Eleve
        public static void DelEleve(int id)
        {
            EleveDAO.DelEleve(id);
        }

        // Fonction permettant la recuperation de toute les classe
        public static List<Classe> GetClasses()
        {
            return ClasseDAO.GetClasses();
        }

        // Fonction permettant la Recuperation d'une classe grace a son id
        public static Classe GetClasse(int id_classe)
        {
            return ClasseDAO.GetClasse(id_classe);
        }

        // Fonction permettant la Recuperation d'une classe grace a son libelle
        /*public static Classe GetClasse(string libelle_classe)
        {
            return ClasseDAO.GetClasse(libelle_classe);
        }*/

        // Fonction permettant le trie des eleve grace a une chaine de caractere
        public static List<Eleve> SortEleves(string str)
        {
            return EleveDAO.SortEleves(str);
        }

        public static List<Eleve> GetElevesByClasse(Classe classe)
        {
            return EleveDAO.GetElevesByClasse(classe);
        }

        public static List<Classe> GetClassesWithEleves()
        {
            return ClasseDAO.GetClassesWithEleves();
        }

        public static int GetNumberOfVisites(int id)
        {
            return EleveDAO.GetNumberOfVisites(id);
        }
    }
}
