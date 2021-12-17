using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPE_C_Sharp_BO;

namespace PPE_C_Sharp_DAL
{
    public class VisiteDAO
    {
        // Recuperation de toute les visites
        public static List<Visite> GetVisites()
        {
            // Attribut de la visite
            int id;
            DateTime date ;
            TimeSpan h_start, h_end;
            string motif, comm;
            bool suite, parent;
            List<Medicament> medicaments = new List<Medicament>();
            Medicament medicament;
            Eleve eleve;

            // Attribut de l'eleve
            int id_eleve;
            string nom_eleve, prenom_eleve, tel_elv_eleve, tel_prt_eleve, comentaire_eleve;
            bool tier_tps_eleve;
            DateTime date_naissance;
            Classe classe;

            // Objet visite
            Visite visite;

            // Liste d'objet
            List<Visite> visites = new List<Visite>();

            SqlConnection sqlConnection = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();

            // Definition de la chaine de connexion
            // Ouverture de la connexion
            cmd.Connection = sqlConnection;
            // Definition de la requête sql
            cmd.CommandText = "SELECT visite.*,eleve.*,classe.* FROM visite, eleve INNER JOIN classe ON classe.id_classe = eleve.id_classe_eleve WHERE visite.id_eleve_visite = eleve.id_eleve ORDER BY visite.id_visite; ";

            // Atribution du resultat de la requete dans sqlDataReader
            SqlDataReader sqlDataReader = cmd.ExecuteReader();

            // Tant que des ligne ce trouve dans sqlDataReader :
            while (sqlDataReader.Read())
            {
                // Visite
                id = (int)sqlDataReader["id_visite"];
                motif = sqlDataReader["motif_visite"].ToString();
                comm = sqlDataReader["commentaire_visite"].ToString();
                suite = (bool)sqlDataReader["suite_visite"];
                parent = (bool)sqlDataReader["parent_prevenus_visite"];
                date = DateTime.Parse(sqlDataReader["date_visite"].ToString()).Date;
                h_start = DateTime.Parse(sqlDataReader["heure_debut_visite"].ToString()).TimeOfDay;
                h_end = DateTime.Parse(sqlDataReader["heure_fin_visite"].ToString()).TimeOfDay;
                
                // Eleve
                id_eleve = (int)sqlDataReader["id_eleve"];
                nom_eleve = sqlDataReader["nom_eleve"].ToString();
                prenom_eleve = sqlDataReader["prenom_eleve"].ToString();
                tel_elv_eleve = sqlDataReader["telephone_eleve"].ToString();
                tel_prt_eleve = sqlDataReader["telephone_parent_eleve"].ToString();
                comentaire_eleve = sqlDataReader["commentaire_sante_eleve"].ToString();
                tier_tps_eleve = (bool)sqlDataReader["tier_temps_eleve"];
                date_naissance = DateTime.Parse(sqlDataReader["date_naissance_eleve"].ToString());
                
                // Classe
                classe = new Classe((int)sqlDataReader["id_classe"], sqlDataReader["libelle_classe"].ToString());

                // Creation Eleve
                eleve = new Eleve(id_eleve, nom_eleve, prenom_eleve, tel_elv_eleve, tel_prt_eleve, comentaire_eleve, tier_tps_eleve, date_naissance, classe);

                // Creation Visite
                visite = new Visite(id, date, h_start, h_end, motif, comm, suite, parent, eleve);

                // Ajout de visite
                visites.Add(visite);
  
            }

            // Fermeture de la connection
            sqlConnection.Close();

            // Traitement pour chaque visite dans la liste
            for(int i = 0; i < visites.Count(); i++)
            {

                int temp_id = visites[i].Id;

                // Ouverture de la connexion
                sqlConnection.Open();

                /* 
                 * Les paramètre d'une requête préparée ne peuvent
                 * pas être déclarée plusieur fois, or sachant que
                 * nous somme dans une boucle, nous ne pouvons pas
                 * utiliser le meme parametre a chaque fois
                 */
                // Definition du parametre 
                string str = "@temp_id" + i;

                // Definition de la requête sql
                cmd.CommandText = "SELECT medicament.*,prescrire.quantite_prescrire FROM medicament,prescrire WHERE prescrire.id_medicament_prescrire = medicament.id_medicament AND prescrire.id_visite_prescrire = " + str;
                
                // Affectation du parametre
                cmd.Parameters.AddWithValue(str, temp_id);

                // Atribution du resultat de la requete dans sqlDataReader
                sqlDataReader = cmd.ExecuteReader();

                // Remisde a zero de la liste
                medicaments = new List<Medicament>();

                // Tant que des ligne ce trouve dans sqlDataReader :
                while (sqlDataReader.Read())
                {
                    // Création d'un nouveau médicaments avec les valeur recu
                    medicament = new Medicament((int)sqlDataReader["id_medicament"], sqlDataReader["libelle_medicament"].ToString(), (int)sqlDataReader["quantite_prescrire"]);
                    // Ajout du medicament a la liste
                    medicaments.Add(medicament);
                }

                // Definition de la liste de medicament de la visite
                visites[i].Medicaments = medicaments;
                // Fermeture de la connexion
                sqlConnection.Close();
            }

            // Renvoie de la liste de visite
            return visites;
        }

        // Recuperation d'une visite
        public static Visite GetVisite(int id)
        {
            // Attribut de la visite
            /*int id;*/
            DateTime date;
            TimeSpan h_start, h_end;
            string motif, comm;
            bool suite, parent;
            List<Medicament> medicaments = new List<Medicament>();
            Medicament medicament;
            Eleve eleve;
               
            // Attribut de l'eleve
            int id_eleve;
            string nom_eleve, prenom_eleve, tel_elv_eleve, tel_prt_eleve, comentaire_eleve;
            bool tier_tps_eleve;
            DateTime date_naissance;
            Classe classe;
            
            // Objet visite
            Visite visite;


            // Recuperation de la connection et/ou ouverture
            SqlConnection sqlConnection = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();

            // Definition de la chaine de connexion
            cmd.Connection = sqlConnection;
            // Requete sql
            cmd.CommandText = "SELECT visite.*,eleve.*,classe.* FROM visite, eleve INNER JOIN classe ON classe.id_classe = eleve.id_classe_eleve WHERE visite.id_eleve_visite = eleve.id_eleve AND visite.id_visite = @id ORDER BY visite.id_visite;";
            cmd.Parameters.AddWithValue("@id", id);
            // Attribution du resultat de la requête
            SqlDataReader sqlDataReader = cmd.ExecuteReader();

            sqlDataReader.Read();
            
            id = (int)sqlDataReader["id_visite"];

            motif = sqlDataReader["motif_visite"].ToString();
            comm = sqlDataReader["commentaire_visite"].ToString();
            suite = (bool)sqlDataReader["suite_visite"];
            parent = (bool)sqlDataReader["parent_prevenus_visite"];
            date = DateTime.Parse(sqlDataReader["date_visite"].ToString()).Date;
            h_start = DateTime.Parse(sqlDataReader["heure_debut_visite"].ToString()).TimeOfDay;
            h_end = DateTime.Parse(sqlDataReader["heure_fin_visite"].ToString()).TimeOfDay;


            id_eleve = (int)sqlDataReader["id_eleve"];
            nom_eleve = sqlDataReader["nom_eleve"].ToString();
            prenom_eleve = sqlDataReader["prenom_eleve"].ToString();
            tel_elv_eleve = sqlDataReader["telephone_eleve"].ToString();
            tel_prt_eleve = sqlDataReader["telephone_parent_eleve"].ToString();
            comentaire_eleve = sqlDataReader["commentaire_sante_eleve"].ToString();
            tier_tps_eleve = (bool)sqlDataReader["tier_temps_eleve"];

            date_naissance = DateTime.Parse(sqlDataReader["date_naissance_eleve"].ToString());
            classe = new Classe((int)sqlDataReader["id_classe"], sqlDataReader["libelle_classe"].ToString());

            eleve = new Eleve(id_eleve, nom_eleve, prenom_eleve, tel_elv_eleve, tel_prt_eleve, comentaire_eleve, tier_tps_eleve, date_naissance, classe);

            visite = new Visite(id, date, h_start, h_end, motif, comm, suite, parent, eleve);

            sqlConnection.Close();

            sqlConnection.Open();

            cmd.CommandText = "SELECT medicament.*,prescrire.quantite_prescrire FROM medicament,prescrire WHERE prescrire.id_medicament_prescrire = medicament.id_medicament AND prescrire.id_visite_prescrire = @temp_id ";
            cmd.Parameters.AddWithValue("@temp_id", visite.Id);

            sqlDataReader = cmd.ExecuteReader();

            medicaments = new List<Medicament>();

            while (sqlDataReader.Read())
            {
                medicament = new Medicament((int)sqlDataReader["id_medicament"], sqlDataReader["libelle_medicament"].ToString(), (int)sqlDataReader["quantite_prescrire"]);
                medicaments.Add(medicament);
            }

            visite.Medicaments = medicaments;
            sqlConnection.Close();


            return visite;
        }

        // Modification d'une visite
        public static bool MdfVisite(Visite visite)
        {
            bool b = true;

            try
            {

                SqlConnection sqlConnection = ConnexionBD.GetConnexionBD().GetSqlConnexion();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlConnection;

                cmd.CommandText = "UPDATE visite SET date_visite = @date, heure_debut_visite = @start, heure_fin_visite = @end, motif_visite = @motif, commentaire_visite = @comm, suite_visite = @suite, parent_prevenus_visite = @prt, id_eleve_visite = @id_eleve WHERE id_visite = @id; ";
                cmd.Parameters.AddWithValue("@date", visite.Date);
                cmd.Parameters.AddWithValue("@start", visite.H_start);
                cmd.Parameters.AddWithValue("@end", visite.H_end);
                cmd.Parameters.AddWithValue("@motif", visite.Motif);
                cmd.Parameters.AddWithValue("@comm", visite.Comm);
                cmd.Parameters.AddWithValue("@suite", visite.Suite);
                cmd.Parameters.AddWithValue("@prt", visite.Parent);
                cmd.Parameters.AddWithValue("@id_eleve", visite.Eleve.Id);
                cmd.Parameters.AddWithValue("@id", visite.Id);

                cmd.ExecuteNonQuery();
                sqlConnection.Close();
                
                sqlConnection.Open();
                cmd.CommandText = "DELETE FROM prescrire WHERE id_visite_prescrire = @id";
                cmd.Parameters.AddWithValue("@id_visite", visite.Id);

                cmd.ExecuteNonQuery();
                sqlConnection.Close();

                for(int i = 0; i< visite.Medicaments.Count; i++)
                {
                    sqlConnection.Open();
                    string id = "@id" + i;
                    string str = "@med" + i;
                    string q = "@q" + i;
                    cmd.CommandText = "INSERT INTO prescrire (id_visite_prescrire,id_medicament_prescrire,quantite_prescrire) VALUES ("+id+","+str+","+q+")";
                    cmd.Parameters.AddWithValue(id,visite.Id);
                    cmd.Parameters.AddWithValue(str, visite.Medicaments[i].Id);
                    cmd.Parameters.AddWithValue(q, visite.Medicaments[i].Quantity);

                    cmd.ExecuteNonQuery();
                    sqlConnection.Close();
                }

            }
            catch
            {
                b = false;
            }
            return b;
        }

        public static bool InsVisite(Visite visite)
        {
            bool b = true;

            try
            {

                SqlConnection sqlConnection = ConnexionBD.GetConnexionBD().GetSqlConnexion();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlConnection;

                cmd.CommandText = "INSERT INTO dbo.visite (date_visite,heure_debut_visite,heure_fin_visite,motif_visite ,commentaire_visite,suite_visite,parent_prevenus_visite,id_eleve_visite) VALUES (@Date, @start, @end, @motif, @comm, @suite, @prt, @id_eleve); ";
                cmd.Parameters.AddWithValue("@date", visite.Date);
                cmd.Parameters.AddWithValue("@start", visite.H_start);
                cmd.Parameters.AddWithValue("@end", visite.H_end);
                cmd.Parameters.AddWithValue("@motif", visite.Motif);
                cmd.Parameters.AddWithValue("@comm", visite.Comm);
                cmd.Parameters.AddWithValue("@suite", visite.Suite);
                cmd.Parameters.AddWithValue("@prt", visite.Parent);
                cmd.Parameters.AddWithValue("@id_eleve", visite.Eleve.Id);

                cmd.ExecuteNonQuery();
                sqlConnection.Close();

                sqlConnection.Open();
                cmd.CommandText = "SELECT MAX(id_visite) AS 'last_id' FROM visite ";
                SqlDataReader sqlDataReader = cmd.ExecuteReader();

                sqlDataReader.Read();
                int id_visite = (int)sqlDataReader["last_id"];
                sqlConnection.Close();

                for (int i = 0; i < visite.Medicaments.Count; i++)
                {
                    sqlConnection.Open();
                    string id = "@id" + i;
                    string str = "@med" + i;
                    string q = "@q" + i;
                    cmd.CommandText = "INSERT INTO prescrire (id_visite_prescrire,id_medicament_prescrire,quantite_prescrire) VALUES (" + id + "," + str + "," + q + ")";
                    cmd.Parameters.AddWithValue(id, id_visite);
                    cmd.Parameters.AddWithValue(str, visite.Medicaments[i].Id);
                    cmd.Parameters.AddWithValue(q, visite.Medicaments[i].Quantity);

                    cmd.ExecuteNonQuery();
                    sqlConnection.Close();
                }

            }
            catch
            {
                b = false;
            }
            return b;
        }

        public static bool DelVisite(int id)
        {
            bool b = true;

            try
            {

                SqlConnection sqlConnection = ConnexionBD.GetConnexionBD().GetSqlConnexion();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlConnection;

                cmd.CommandText = "DELETE FROM prescrire WHERE id_visite_prescrire = @id_visite";
                cmd.Parameters.AddWithValue("@id_visite", id);

                cmd.ExecuteNonQuery();
                sqlConnection.Close();
                
                sqlConnection.Open();
                cmd.CommandText = "DELETE FROM visite WHERE id_visite = @id";
                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();
                sqlConnection.Close();

            }
            catch
            {
                b = false;
            }
            return b;
        }

        public static List<Visite> SortVisites(string search)
        {
            // Attribut de la visite
            int id;
            DateTime date;
            TimeSpan h_start, h_end;
            string motif, comm;
            bool suite, parent;
            List<Medicament> medicaments = new List<Medicament>();
            Medicament medicament;
            Eleve eleve;

            // Attribut de l'eleve
            int id_eleve;
            string nom_eleve, prenom_eleve, tel_elv_eleve, tel_prt_eleve, comentaire_eleve;
            bool tier_tps_eleve;
            DateTime date_naissance;
            Classe classe;

            // Objet visite
            Visite visite;

            // Liste d'objet
            List<Visite> visites = new List<Visite>();

            SqlConnection sqlConnection = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();

            // Definition de la chaine de connexion
            // Ouverture de la connexion
            cmd.Connection = sqlConnection;
            // Definition de la requête sql
            search = '%' + search + '%';
            cmd.CommandText = "SELECT *  FROM visite INNER JOIN eleve INNER JOIN classe ON eleve.id_classe_eleve = classe.id_classe ON eleve.id_eleve = visite.id_eleve_visite WHERE eleve.nom_eleve LIKE @sort OR eleve.prenom_eleve LIKE @sort OR DATEPART(HOUR, visite.heure_debut_visite) LIKE @sort OR DATEPART(MINUTE, visite.heure_debut_visite) LIKE @sort OR DATEPART(SECOND, visite.heure_debut_visite) LIKE @sort OR date_visite LIKE @sort ORDER BY visite.id_visite;";
            cmd.Parameters.AddWithValue("@sort", search);
            // Atribution du resultat de la requete dans sqlDataReader
            SqlDataReader sqlDataReader = cmd.ExecuteReader();

            // Tant que des ligne ce trouve dans sqlDataReader :
            while (sqlDataReader.Read())
            {
                // Visite
                id = (int)sqlDataReader["id_visite"];
                motif = sqlDataReader["motif_visite"].ToString();
                comm = sqlDataReader["commentaire_visite"].ToString();
                suite = (bool)sqlDataReader["suite_visite"];
                parent = (bool)sqlDataReader["parent_prevenus_visite"];
                date = DateTime.Parse(sqlDataReader["date_visite"].ToString()).Date;
                h_start = DateTime.Parse(sqlDataReader["heure_debut_visite"].ToString()).TimeOfDay;
                h_end = DateTime.Parse(sqlDataReader["heure_fin_visite"].ToString()).TimeOfDay;

                // Eleve
                id_eleve = (int)sqlDataReader["id_eleve"];
                nom_eleve = sqlDataReader["nom_eleve"].ToString();
                prenom_eleve = sqlDataReader["prenom_eleve"].ToString();
                tel_elv_eleve = sqlDataReader["telephone_eleve"].ToString();
                tel_prt_eleve = sqlDataReader["telephone_parent_eleve"].ToString();
                comentaire_eleve = sqlDataReader["commentaire_sante_eleve"].ToString();
                tier_tps_eleve = (bool)sqlDataReader["tier_temps_eleve"];
                date_naissance = DateTime.Parse(sqlDataReader["date_naissance_eleve"].ToString());

                // Classe
                classe = new Classe((int)sqlDataReader["id_classe"], sqlDataReader["libelle_classe"].ToString());

                // Creation Eleve
                eleve = new Eleve(id_eleve, nom_eleve, prenom_eleve, tel_elv_eleve, tel_prt_eleve, comentaire_eleve, tier_tps_eleve, date_naissance, classe);

                // Creation Visite
                visite = new Visite(id, date, h_start, h_end, motif, comm, suite, parent, eleve);

                // Ajout de visite
                visites.Add(visite);

            }

            // Fermeture de la connection
            sqlConnection.Close();

            // Traitement pour chaque visite dans la liste
            for (int i = 0; i < visites.Count(); i++)
            {

                int temp_id = visites[i].Id;

                // Ouverture de la connexion
                sqlConnection.Open();

                /* 
                 * Les paramètre d'une requête préparée ne peuvent
                 * pas être déclarée plusieur fois, or sachant que
                 * nous somme dans une boucle, nous ne pouvons pas
                 * utiliser le meme parametre a chaque fois
                 */
                // Definition du parametre 
                string str = "@temp_id" + i;

                // Definition de la requête sql
                cmd.CommandText = "SELECT medicament.*,prescrire.quantite_prescrire FROM medicament,prescrire WHERE prescrire.id_medicament_prescrire = medicament.id_medicament AND prescrire.id_visite_prescrire = " + str;

                // Affectation du parametre
                cmd.Parameters.AddWithValue(str, temp_id);

                // Atribution du resultat de la requete dans sqlDataReader
                sqlDataReader = cmd.ExecuteReader();

                // Remisde a zero de la liste
                medicaments = new List<Medicament>();

                // Tant que des ligne ce trouve dans sqlDataReader :
                while (sqlDataReader.Read())
                {
                    // Création d'un nouveau médicaments avec les valeur recu
                    medicament = new Medicament((int)sqlDataReader["id_medicament"], sqlDataReader["libelle_medicament"].ToString(), (int)sqlDataReader["quantite_prescrire"]);
                    // Ajout du medicament a la liste
                    medicaments.Add(medicament);
                }

                // Definition de la liste de medicament de la visite
                visites[i].Medicaments = medicaments;
                // Fermeture de la connexion
                sqlConnection.Close();
            }

            // Renvoie de la liste de visite
            return visites;
        }
    }
}
