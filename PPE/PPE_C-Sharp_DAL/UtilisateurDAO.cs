using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE_C_Sharp_DAL
{
    public class UtilisateurDAO
    {
        public static bool Authentificate(string login_utilisateur, string mdp_utilisateur)
        {
            bool response = false;
            if (!(String.IsNullOrEmpty(login_utilisateur)))
            {
                SqlConnection sqlConnection = ConnexionBD.GetConnexionBD().GetSqlConnexion();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlConnection;
                cmd.CommandText = "SELECT * FROM Utilisateur WHERE login_utilisateur = @user";
                //SqlParameter loginParam = new SqlParameter("@user", SqlDbType.VarChar, 255, login_utilisateur);
                cmd.Parameters.AddWithValue("@user", login_utilisateur);
                //SqlParameter LoginParam = new SqlParameter("@user", SqlDbType.VarChar, 255);
                //LoginParam.Value = login_utilisateur;
                SqlDataReader sqlDataReader = cmd.ExecuteReader();

                if (sqlDataReader.Read())
                {
                    if (sqlDataReader["mdp_utilisateur"].ToString() == mdp_utilisateur)
                    {
                        response = true;
                    }
                }
                sqlConnection.Close();
            }
            return response;
        }
    }
}
