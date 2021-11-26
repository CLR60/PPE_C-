using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPE_C_Sharp_BO;

namespace PPE_C_Sharp_DAL
{
    public class ClasseDAO
    {
        public static List<Classe> GetClasses()
        {

            int id;
            string libelle;
            Classe classe;

            SqlConnection sqlConnection = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            List<Classe> classes = new List<Classe>();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlConnection;
            cmd.CommandText = "SELECT * FROM Classe";
            SqlDataReader sqlDataReader = cmd.ExecuteReader();

            while (sqlDataReader.Read())
            {
                id = Int32.Parse(sqlDataReader["id_classe"].ToString());
                libelle = sqlDataReader["libelle_classe"].ToString();
                classe = new Classe(id, libelle);
                classes.Add(classe);
            }
            sqlConnection.Close();
            return classes;
        }

        public static Classe GetClasse(int id_classe)
        {

            int id;
            string libelle;
            Classe classe;

            SqlConnection sqlConnection = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlConnection;
            SqlParameter idParam = new SqlParameter("@id", SqlDbType.Int, id_classe);
            cmd.CommandText = "SELECT * FROM Classe WHERE id_classe=@id";
            SqlDataReader sqlDataReader = cmd.ExecuteReader();

            sqlDataReader.Read();
            id = Int32.Parse(sqlDataReader["id_classe"].ToString());
            libelle = sqlDataReader["libelle_classe"].ToString();

            classe = new Classe(id, libelle);
            sqlConnection.Close();
            return classe;
        }

        public static Classe GetClasse(string libelle_classe)
        {

            int id;
            string libelle;
            Classe classe;

            SqlConnection sqlConnection = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlConnection;
            //SqlParameter idParam = new SqlParameter("@id", SqlDbType.Int, id_classe);
            cmd.CommandText = "SELECT * FROM Classe WHERE libelle_classe=@libelle";
            cmd.Parameters.AddWithValue("@libelle", libelle_classe);
            SqlDataReader sqlDataReader = cmd.ExecuteReader();

            sqlDataReader.Read();
            id = Int32.Parse(sqlDataReader["id_classe"].ToString());
            libelle = sqlDataReader["libelle_classe"].ToString();

            classe = new Classe(id, libelle);
            sqlConnection.Close();
            return classe;
        }
    }
}
