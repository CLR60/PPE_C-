using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;
using PPE_C_Sharp_BO;
using PPE_C_Sharp_DAL;
    
namespace PPE_C_Sharp_BLL
{
    public class GestionMedicament
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
        
        public static List<PPE_C_Sharp_BO.Medicament> GetMedicaments()
        { 
            return MedicamentDAO.GetMedicaments();
        }

        public static PPE_C_Sharp_BO.Medicament GetMedicament(int id_medicament)
        {
            return MedicamentDAO.GetMedicament(id_medicament);
        }

        public static bool InsMedicament(PPE_C_Sharp_BO.Medicament medicament)
        {
            if (!PPE_C_Sharp_BO.verifyInput.isValidInput(medicament.Libelle))
            {
                return false;
            }
            MedicamentDAO.InsMedicament(medicament);
            return true;
        }

        public static bool MdfMedicament(PPE_C_Sharp_BO.Medicament medicament, string newLibelle)
        {
            if (!PPE_C_Sharp_BO.verifyInput.isValidInput(newLibelle))
            {
                return false;
            }

            MedicamentDAO.MdfMedicament(medicament, newLibelle);
            return true;
        }

        public static bool DelMedicament(PPE_C_Sharp_BO.Medicament medicament)
        {
            DialogResult DialogResult = MessageBox.Show("supprimer med",
                "voulez-vous vraiment supprimer ce medicament ? ", MessageBoxButtons.YesNo);
            
            if (DialogResult == DialogResult.Yes)
            {
                MedicamentDAO.DelMedicament(medicament);
                return true;
            }
            return false;
        }
        
    }
}