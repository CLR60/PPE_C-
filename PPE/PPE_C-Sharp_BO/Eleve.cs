using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE_C_Sharp_BO
{
    // Objet Eleve
    public class Eleve
    {
        // Attribut de l'objet
        private int id;
        private string nom, prenom, tel_elv, tel_prt, comentaire;
        private bool tier_tps;
        private DateTime date_naissance;
        private Classe classe;

        /* 
         * Constructeur vide permettant la recuperation
         * des propriete de l'objet, utiliser pour
         * l'affichage des datagrid
         */
        public Eleve()
        {

        }

        // Constructeur
        public Eleve(string nom, string prenom, string tel_elv, string tel_prt, string comentaire, bool tier_tps, DateTime date_naissance, Classe classe)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.tel_elv = tel_elv;
            this.tel_prt = tel_prt;
            this.comentaire = comentaire;
            this.date_naissance = date_naissance;
            this.classe = classe;
            this.tier_tps = tier_tps;
        }

        public Eleve(int id, string nom, string prenom, string tel_elv, string tel_prt, string comentaire, bool tier_tps, DateTime date_naissance, Classe classe)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.tel_elv = tel_elv;
            this.tel_prt = tel_prt;
            this.comentaire = comentaire;
            this.date_naissance = date_naissance;
            this.classe = classe;
            this.tier_tps = tier_tps;
        }

        // Propriete de l'objet
        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Tel_elv { get => tel_elv; set => tel_elv = value; }
        public string Tel_prt { get => tel_prt; set => tel_prt = value; }
        public string Comentaire { get => comentaire; set => comentaire = value; }
        public DateTime Date_naissance { get => date_naissance; set => date_naissance = value; }
        public bool Tier_tps { get => tier_tps; set => tier_tps = value; }
        public Classe Classe { get => classe; set => classe = value; }

        /*
         * La fonction ToString() permet l'affichage
         * de l'objet sous la forme d'une chaine de caractere
         */
        // Reecriture de la fonction ToString()
        public override string ToString()
        {
            // Renvoie d'une chaine contenant le prenom, le nom et la classe
            return Prenom + ' ' + Nom + ' ' + Classe ;
        }
    }
}