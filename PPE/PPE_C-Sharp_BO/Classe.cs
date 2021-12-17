using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE_C_Sharp_BO
{
    // Objet Classe
    public class Classe
    {
        // Attribut de l'objet
        private int id;
        private string libelle;

        // Propriete de l'objet
        public int Id { get => id; set => id = value; }
        public string Libelle { get => libelle; set => libelle = value; }

        // Constructeur de l'objet
        public Classe(int id, string libelle)
        {
            this.id = id;
            this.libelle = libelle;
        }

        public Classe(string libelle)
        {
            this.libelle = libelle;
        }

        /*
         * La fonction ToString() permet l'affichage
         * de l'objet sous la forme d'une chaine de caractere
         */
        // Reecriture de la fonction ToString()
        public override string ToString()
        {
            // Renvoie du labelle de la classe
            return libelle;
        }
    }
}
