using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE_C_Sharp_DAL
{
    public class ConnexionBD
    {
        private SqlConnection maConnexion;
        private static ConnexionBD uneConnexionBD; // Instance d'une connexion
        private string chaineConnexion; // Chaîne de connexion à la BD

        public string GetchaineConnexion() // Récupéré la chaine de connection
        {
            return chaineConnexion;
        }

        public void SetchaineConnexion(string ch) // Attribuer une valeur a la chaine de connexion
        {
            chaineConnexion = ch;
        }

        public static ConnexionBD GetConnexionBD()
        {
            if (uneConnexionBD == null)
            {
                uneConnexionBD = new ConnexionBD();
            }
            return uneConnexionBD;
        }

        public SqlConnection GetSqlConnexion()
        {
            if (maConnexion == null)
            {
                maConnexion = new SqlConnection();
            }
            if (maConnexion.State != System.Data.ConnectionState.Open)
            {
                maConnexion.ConnectionString = chaineConnexion;
            }
            // Si la connexion est fermée, on l’ouvre
            if (maConnexion.State == System.Data.ConnectionState.Closed)
            {
                maConnexion.Open();
            }
            return maConnexion;
        }

        public void CloseConnexion()
        {
            // Si la connexion est ouverte, on la ferme
            if (this.maConnexion != null && this.maConnexion.State !=
           System.Data.ConnectionState.Closed)
            {
                this.maConnexion.Close();
            }
        }
    }
}
