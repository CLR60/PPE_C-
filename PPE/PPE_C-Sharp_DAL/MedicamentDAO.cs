using PPE_C_Sharp_BO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE_C_Sharp_DAL
{
    public class MedicamentDAO
    {
        // Recuperation de tout les medicaments
        public static List<Medicament> GetMedicaments()
        {
            // Attribut d'un medicament
            int id;
            string libelle;

            // Objet medicament
            Medicament medicament;

            // Liste de medicaments
            List<Medicament> medicaments = new List<Medicament>();

            // Recuperation de la connection et/ou ouverture
            SqlConnection sqlConnection = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();

            // Definition de la chaine de connexion
            cmd.Connection = sqlConnection;
            // Requete sql
            cmd.CommandText = "SELECT * FROM medicament";
            // Attribution du resultat de la requête
            SqlDataReader sqlDataReader = cmd.ExecuteReader();

            // Tant que des ligne ce trouve dans sqlDataReader :
            while (sqlDataReader.Read())
            {
                id = (int)sqlDataReader["id_medicament"];
                libelle = sqlDataReader["libelle_medicament"].ToString();
                // Création d'un nouveau médicaments avec les valeur recu
                medicament = new Medicament(id, libelle);
                // Ajout du medicament a la liste
                medicaments.Add(medicament);
            }

            // Fermeture de la connexion
            sqlConnection.Close();

            // Renvoie de la liste de medicaments
            return medicaments;
        }

        // Recuperation d'un medicament grace a son id
        public static Medicament GetMedicament(int id_medicament)
        {
            // Attribut du medicament
            int id;
            string libelle;

            // Objet medicament
            Medicament medicament;

            // Recuperation de la connection et/ou ouverture
            SqlConnection sqlConnection = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();

            // Definition de la chaine de connexion
            cmd.Connection = sqlConnection;
            // Requete sql
            cmd.CommandText = "SELECT * FROM medicament WHERE id_medicament = @id";
            // Affectation du parametre
            cmd.Parameters.AddWithValue("@id",id_medicament);
            // Attribution du resultat de la requête
            SqlDataReader sqlDataReader = cmd.ExecuteReader();

            // Lecture des données
            sqlDataReader.Read();
            
            id = (int)sqlDataReader["id_medicament"];
            libelle = sqlDataReader["libelle_medicament"].ToString();
            // Création d'un nouveau médicaments avec les valeur recu
            medicament = new Medicament(id, libelle);
            // Fermeture de la connection
            sqlConnection.Close();

            // Renvoie du medicament
            return medicament;
        }

        // Modification d'un medicament grace a un objet medicament
        public static void MdfMedicament(Medicament medicament)
        {
            // Recuperation de la connection et/ou ouverture
            SqlConnection sqlConnection = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            // Definition de la chaine de connexion
            cmd.Connection = sqlConnection;
            // Requete sql
            cmd.CommandText = "UPDATE medicament SET libelle_medicament = @libelle WHERE id_medicament = @id";
            // Affectation des parametres
            cmd.Parameters.AddWithValue("@libelle", medicament.Libelle);
            cmd.Parameters.AddWithValue("@id", medicament.Id);
            // Execution de la requete
            cmd.ExecuteNonQuery();
            // Fermeture de la connection
            sqlConnection.Close();
        }

        // Insertion d'un medicament grace a un objet medicament
        public static void InsMedicament(Medicament medicament)
        {
            // Recuperation de la connection et/ou ouverture
            SqlConnection sqlConnection = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            // Definition de la chaine de connexion
            cmd.Connection = sqlConnection;
            // Requete sql
            cmd.CommandText = "INSERT INTO medicament(libelle_medicament) VALUES (@libelle)";
            // Affectation du parametres
            cmd.Parameters.AddWithValue("@libelle", medicament.Libelle);
            // Execution de la requete
            cmd.ExecuteNonQuery();
            // Fermeture de la connection
            sqlConnection.Close();
        }
        
        // Supression d'un medicament grace a son id
        public static bool DelMedicament(int id)
        {
            // Recuperation de la connection et/ou ouverture
            SqlConnection sqlConnection = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            // Definition de la chaine de connexion
            cmd.Connection = sqlConnection;
            // Requete sql
            cmd.CommandText = "DELETE FROM medicament WHERE id_medicament = @id";
            // Affectation du parametres
            cmd.Parameters.AddWithValue("@id", id);
            // Execution de la requete
            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            // Fermeture de la connection
            sqlConnection.Close();
        }
    }
}
