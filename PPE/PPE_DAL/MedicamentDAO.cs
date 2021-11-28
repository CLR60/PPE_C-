using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPE_C_Sharp_BO;


namespace PPE_C_Sharp_DAL
{
    public class MedicamentDAO
    {
        public static Medicament GetMedicament(int medicamentId)
        {
            int id ;
            string libelle;
            
            SqlConnection sqlConnection = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlConnection;
            cmd.CommandText = "SELECT * from medicament where medicament.id_medicament = @id_medicament";
            cmd.Parameters.AddWithValue("@id_medicament", medicamentId);
            
            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            sqlDataReader.Read();

            id = (int) sqlDataReader["id_medicament"];
            libelle = sqlDataReader["libelle_medicament"].ToString();
            
            sqlConnection.Close();
            return new PPE_C_Sharp_BO.Medicament(id, libelle);
        }

        public static List<Medicament> GetMedicaments()
        {
            
            int id ;
            string libelle;
            
            List<PPE_C_Sharp_BO.Medicament> medicaments = new List<PPE_C_Sharp_BO.Medicament>();
            
            SqlConnection sqlConnection = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlConnection;
            cmd.CommandText = "SELECT * from medicament";
            
            SqlDataReader sqlDataReader = cmd.ExecuteReader();

            while (sqlDataReader.Read())
            {
                id = (int) sqlDataReader["id_medicament"];
                libelle = sqlDataReader["libelle_medicament"].ToString();

                medicaments.Add(new PPE_C_Sharp_BO.Medicament(id, libelle));
            }
            
            sqlConnection.Close();
            return medicaments;
        }
        
        public static void InsMedicament(PPE_C_Sharp_BO.Medicament medicament)
        {
            SqlConnection sqlConnection = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlConnection;
            cmd.CommandText = "INSERT INTO medicament(libelle_medicament) values (@lbl_medicament)";
            cmd.Parameters.AddWithValue("@lbl_medicament", medicament.Libelle);
            
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public static void MdfMedicament(PPE_C_Sharp_BO.Medicament medicament, string newLibelle)
        {
            SqlConnection sqlConnection = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlConnection;
            cmd.CommandText = "UPDATE medicament set libelle_medicament = @lbl_medicament where medicament.id_medicament = @id_medicament ";
            cmd.Parameters.AddWithValue("@lbl_medicament", newLibelle);
            cmd.Parameters.AddWithValue("@id_medicament", medicament.Id);
            
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public static void DelMedicament(PPE_C_Sharp_BO.Medicament medicament)
        {
            SqlConnection sqlConnection = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlConnection;
            cmd.CommandText = "DELETE from medicament where medicament.id_medicament = @id_medicament ";
            cmd.Parameters.AddWithValue("@id_medicament", medicament.Id);
            
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
        }
    }
}