using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE_C_Sharp_BO
{
    public class Eleve
    {
        private int id;
        private string nom, prenom, tel_elv, tel_prt, comentaire;
        private bool tier_tps;
        private DateTime date_naissance;
        private Classe classe;

        public Eleve()
        {

        }
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

        //public Eleve(string nom, string prenom, string tel_elv, string tel_prt, string comentaire, bool tier_tps, DateTime date_naissance)
        //{
        //    this.id = id;
        //    this.nom = nom;
        //    this.prenom = prenom;
        //    this.tel_elv = tel_elv;
        //    this.tel_prt = tel_prt;
        //    this.comentaire = comentaire;
        //    this.date_naissance = date_naissance;
        //    this.classe = classe;
        //    this.tier_tps = tier_tps;
        //}

        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Tel_elv { get => tel_elv; set => tel_elv = value; }
        public string Tel_prt { get => tel_prt; set => tel_prt = value; }
        public string Comentaire { get => comentaire; set => comentaire = value; }
        public DateTime Date_naissance { get => date_naissance; set => date_naissance = value; }
        public bool Tier_tps { get => tier_tps; set => tier_tps = value; }
        public Classe Classe { get => classe; set => classe = value; }
    }
}