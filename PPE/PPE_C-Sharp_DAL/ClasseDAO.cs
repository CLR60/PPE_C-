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
        // Recuperation de toute les classes
        public static List<Classe> GetClasses()
        {
            // Attribut d'une classe
            int id;
            string libelle;
            // Objet classe
            Classe classe;

            // Liste de classe vide
            List<Classe> classes = new List<Classe>();
            // Recuperation de la connection et/ou ouverture
            SqlConnection sqlConnection = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            // Nouvelle commande SQL
            SqlCommand cmd = new SqlCommand();

            // Definition de la chaine de connexion
            cmd.Connection = sqlConnection;
            // Requete sql
            cmd.CommandText = "SELECT * FROM Classe";
            // Attribution du resultat de la requête
            SqlDataReader sqlDataReader = cmd.ExecuteReader();

            // Tant que des ligne ce trouve dans sqlDataReader :
            while (sqlDataReader.Read())
            {
                id = (int)sqlDataReader["id_classe"];
                libelle = sqlDataReader["libelle_classe"].ToString();
                // Creation d'une nouvelles classe avec les données recuperer
                classe = new Classe(id, libelle);
                // ajout de la classe a la liste
                classes.Add(classe);
            }

            // Fermeture de la connection
            sqlConnection.Close();

            // Renvoie une liste de classe
            return classes;
        }

        public static List<Classe> GetClassesWithEleves()
        {
            // Attribut d'une classe
            int id;
            string libelle;
            // Objet classe
            Classe classe;

            // Liste de classe vide
            List<Classe> classes = new List<Classe>();
            // Recuperation de la connection et/ou ouverture
            SqlConnection sqlConnection = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            // Nouvelle commande SQL
            SqlCommand cmd = new SqlCommand();

            // Definition de la chaine de connexion
            cmd.Connection = sqlConnection;
            // Requete sql
            cmd.CommandText = "SELECT classe.* FROM classe WHERE id_classe IN ( SELECT eleve.id_classe_eleve FROM eleve GROUP BY id_classe_eleve );";
            // Attribution du resultat de la requête
            SqlDataReader sqlDataReader = cmd.ExecuteReader();

            // Tant que des ligne ce trouve dans sqlDataReader :
            while (sqlDataReader.Read())
            {
                id = (int)sqlDataReader["id_classe"];
                libelle = sqlDataReader["libelle_classe"].ToString();
                // Creation d'une nouvelles classe avec les données recuperer
                classe = new Classe(id, libelle);
                // ajout de la classe a la liste
                classes.Add(classe);
            }

            // Fermeture de la connection
            sqlConnection.Close();

            // Renvoie une liste de classe
            return classes;
        }


        // Recuperation d'une classe grace a son id
        public static Classe GetClasse(int id_classe)
        {
            // Attribu de la classe
            int id;
            string libelle;
            // Objet classe vide
            Classe classe;

            // Recuperation de la connection et/ou ouverture
            SqlConnection sqlConnection = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            // Nouvelle commande SQL
            SqlCommand cmd = new SqlCommand();

            // Definition de la chaine de connexion
            cmd.Connection = sqlConnection;
            // Requete sql
            cmd.CommandText = "SELECT * FROM Classe WHERE id_classe=@id";
            // Affectation du parametre
            cmd.Parameters.AddWithValue("@id", id_classe);
            // Attribution du resultat de la requête
            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            // Lecture des données
            sqlDataReader.Read();

            id = (int)sqlDataReader["id_classe"];
            libelle = sqlDataReader["libelle_classe"].ToString();

            // Creation d'une nouvelle classe avec les valeurs recu
            classe = new Classe(id, libelle);
            
            // Fermeture de la connection
            sqlConnection.Close();
            // Renvoie de la classe
            return classe;
        }

        /*public static Classe GetClasse(string libelle_classe)
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
        }*/
    }
}
