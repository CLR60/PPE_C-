using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPE_C_Sharp_BO;
using PPE_C_Sharp_DAL;

namespace PPE_C_Sharp_BLL
{
    // Bibliothèque de gestion des medicaments
    public class GestionMedicaments
    {
        // Fonction permettant la recuperation des medicaments
        public static List<Medicament> GetMedicaments()
        {
            return MedicamentDAO.GetMedicaments();
        }
        // Fonction permettant la recuperation d'un medicament grace a son id
        public static Medicament GetMedicament(int id_medicament)
        {
            return MedicamentDAO.GetMedicament(id_medicament);
        }
        // Fonction permettant l'insertion d'un medicament grace a un objet Medicament
        public static void InsMedicament(Medicament medicament)
        {
            MedicamentDAO.InsMedicament(medicament);
        }
        // Fonction permettant la modification d'un medicament grace a un objet Medicament
        public static void MdfMedicament(Medicament medicament)
        {
            MedicamentDAO.MdfMedicament(medicament);
        }
        // Fonction permettant la supression d'un medicament grace a son id
        public static bool DelMedicament(int id_medicament)
        {
            return MedicamentDAO.DelMedicament(id_medicament);
        }
    }
}
