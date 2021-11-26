using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPE_C_Sharp_BO;

namespace PPE_C_Sharp_DAL
{
    public class EleveDAO
    {

        public static List<Eleve> GetEleves()
        {
            // Attribut de l'eleve
            int id;
            string nom, prenom, tel_elv, tel_prt, comentaire;
            bool tier_tps;
            DateTime date_naissance;
            Classe classe;
            //objet eleve vide
            Eleve unEleve;

            //connexion a la base de données
            SqlConnection sqlConnection = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            //Liste d'élève vide
            List<Eleve> eleves = new List<Eleve>();
            //nouvelle commande SQL
            SqlCommand cmd = new SqlCommand();
            //on connecte la requete a la base
            cmd.Connection = sqlConnection;
            //ecriture de la requete
            cmd.CommandText = "SELECT * FROM eleve INNER JOIN classe ON eleve.id_classe_eleve = classe.id_classe";
            //recuperation des données
            SqlDataReader sqlDataReader = cmd.ExecuteReader();

            while (sqlDataReader.Read())
            {
                id = (int)sqlDataReader["id_eleve"];
                nom = sqlDataReader["nom_eleve"].ToString();
                prenom = sqlDataReader["prenom_eleve"].ToString();
                tel_elv = sqlDataReader["telephone_eleve"].ToString();
                tel_prt = sqlDataReader["telephone_parent_eleve"].ToString();
                comentaire = sqlDataReader["commentaire_sante_eleve"].ToString();
                tier_tps = (bool)sqlDataReader["tier_temps_eleve"];
                //tier_tps = true;
                date_naissance = DateTime.Parse(sqlDataReader["date_naissance_eleve"].ToString());
                classe = new Classe((int)sqlDataReader["id_classe"], sqlDataReader["libelle_classe"].ToString());
                //classe = new Classe(1, "salut");

                unEleve = new Eleve(id,nom, prenom, tel_elv, tel_prt, comentaire, tier_tps, date_naissance, classe);
                eleves.Add(unEleve);
            }
            sqlConnection.Close();
            return eleves;

        }

        public static Eleve GetEleve(int id_eleve)
        {
            // Attribut de l'eleve
            int id;
            string nom, prenom, tel_elv, tel_prt, comentaire;
            bool tier_tps;
            DateTime date_naissance;
            Classe classe;
            //objet eleve vide
            Eleve eleve;

            //connexion a la base de données
            SqlConnection sqlConnection = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            //Liste d'élève vide
            List<Eleve> eleves = new List<Eleve>();
            //nouvelle commande SQL
            SqlCommand cmd = new SqlCommand();
            //on connecte la requete a la base
            cmd.Connection = sqlConnection;
            //ecriture de la requete
            cmd.CommandText = "SELECT * FROM eleve INNER JOIN classe ON eleve.id_classe_eleve = classe.id_classe WHERE eleve.id_eleve = @id";
            //recuperation des données
            cmd.Parameters.AddWithValue("@id",id_eleve);
            SqlDataReader sqlDataReader = cmd.ExecuteReader();

            sqlDataReader.Read();
           
            id = (int)sqlDataReader["id_eleve"];
            nom = sqlDataReader["nom_eleve"].ToString();
            prenom = sqlDataReader["prenom_eleve"].ToString();
            tel_elv = sqlDataReader["telephone_eleve"].ToString();
            tel_prt = sqlDataReader["telephone_parent_eleve"].ToString();
            comentaire = sqlDataReader["commentaire_sante_eleve"].ToString();
            tier_tps = (bool)sqlDataReader["tier_temps_eleve"];
            //tier_tps = true;
            date_naissance = DateTime.Parse(sqlDataReader["date_naissance_eleve"].ToString());
            classe = new Classe((int)sqlDataReader["id_classe"], sqlDataReader["libelle_classe"].ToString());
            //classe = new Classe(1, "salut");

            eleve = new Eleve(id, nom, prenom, tel_elv, tel_prt, comentaire, tier_tps, date_naissance, classe);
            
            sqlConnection.Close();
            return eleve;

        }

        public static void MdfEleve(Eleve eleve)
        {
            SqlConnection sqlConnection = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlConnection;
            cmd.CommandText = "UPDATE eleve SET nom_eleve = @nom , prenom_eleve = @prn , telephone_eleve = @tel_elv, telephone_parent_eleve = @tel_elv_prt, commentaire_sante_eleve = @com, tier_temps_eleve = @tier_tps, date_naissance_eleve = @date , id_classe_eleve = @classe WHERE id_eleve = @id";
            //cmd.CommandText = "UPDATE eleve SET nom_eleve = @nom WHERE id_eleve = @id";
            cmd.Parameters.AddWithValue("@nom", eleve.Nom);
            cmd.Parameters.AddWithValue("@prn", eleve.Prenom);
            cmd.Parameters.AddWithValue("@tel_elv", eleve.Tel_elv);
            cmd.Parameters.AddWithValue("@tel_elv_prt", eleve.Tel_prt);
            cmd.Parameters.AddWithValue("@com", eleve.Comentaire);
            cmd.Parameters.AddWithValue("@tier_tps", eleve.Tier_tps);
            cmd.Parameters.AddWithValue("@date", eleve.Date_naissance);
            cmd.Parameters.AddWithValue("@classe", eleve.Classe.Id);
            cmd.Parameters.AddWithValue("@id", eleve.Id);
            //Console.WriteLine(eleve.Nom);
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public static void InsEleve(Eleve eleve)
        {
            SqlConnection sqlConnection = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlConnection;
            cmd.CommandText = "INSERT INTO eleve(nom_eleve,prenom_eleve,telephone_eleve,telephone_parent_eleve,commentaire_sante_eleve,tier_temps_eleve,date_naissance_eleve,id_classe_eleve) VALUES (@nom,@prn,@tel_elv,@tel_elv_prt,@com,@tier_tps,@date,@classe)";
            //cmd.CommandText = "UPDATE eleve SET nom_eleve = @nom WHERE id_eleve = @id";
            cmd.Parameters.AddWithValue("@nom", eleve.Nom);
            cmd.Parameters.AddWithValue("@prn", eleve.Prenom);
            cmd.Parameters.AddWithValue("@tel_elv", eleve.Tel_elv);
            cmd.Parameters.AddWithValue("@tel_elv_prt", eleve.Tel_prt);
            cmd.Parameters.AddWithValue("@com", eleve.Comentaire);
            cmd.Parameters.AddWithValue("@tier_tps", eleve.Tier_tps);
            cmd.Parameters.AddWithValue("@date", eleve.Date_naissance);
            cmd.Parameters.AddWithValue("@classe", eleve.Classe.Id);
            //cmd.Parameters.AddWithValue("@id", eleve.Id);
            //Console.WriteLine(eleve.Nom);
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public static void DelEleve(int id)
        {
            SqlConnection sqlConnection = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlConnection;
            cmd.CommandText = "DELETE FROM eleve WHERE id_eleve = @id";
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
        }

    }
}
