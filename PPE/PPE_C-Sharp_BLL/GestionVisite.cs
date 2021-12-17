using PPE_C_Sharp_BO;
using PPE_C_Sharp_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE_C_Sharp_BLL
{

    // Bibliothèque de gestion des visites
    public class GestionVisite
    {
        // Fonction permettant la recuperation des visites
        public static List<Visite> GetVisites()
        {
            return VisiteDAO.GetVisites();
        }
        public static Visite GetVisite(int id)
        {
            return VisiteDAO.GetVisite(id);
        }

        public static bool MdfVisite(Visite v)
        {
            return VisiteDAO.MdfVisite(v);
        }

        public static bool InsVisite(Visite v)
        {
            return VisiteDAO.InsVisite(v);
        }

        public static bool DelVisite(int i)
        {
            return VisiteDAO.DelVisite(i);
        }

        public static List<Visite> SortVisites(string str)
        {
            return VisiteDAO.SortVisites(str);
        }
    }
}
