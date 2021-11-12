using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilisateursBO
{
    public class Utilisateur
    {
        private int Id_utilisateur;
        private string Nom_utilisateur;

        public Utilisateur(string Nom_utilisateur)
        {
            Nom_utilisateur = this.Nom_utilisateur;
        }
        
        public Utilisateur(int Id_utilisateur, string Nom_utilisateur)
        {
            Id_utilisateur = this.Id_utilisateur;
            Nom_utilisateur = this.Nom_utilisateur;
        }

        public int Id   
        {
            get => this.Id_utilisateur ;
            set => this.Id_utilisateur = Id_utilisateur;
        }

        public string Nom    
        {
            get => this.Nom_utilisateur;
            set => this.Nom_utilisateur = Nom_utilisateur;
        }

    }
}
