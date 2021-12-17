using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE_C_Sharp_BO
{
    // Objet Medicament
    public class Medicament
    {
        // Attribut de l'objet
        private int id;
        private string libelle;
        // Quantite de médicament dans la table prescrire
        private int quantity = 0;

        // Propriete de l'objet
        public string Libelle { get => libelle; set => libelle = value; }
        public int Id { get => id; set => id = value; }
        public int Quantity { get => quantity; set => quantity = value; }

        // Constructeur
        public Medicament(int id, string libelle)
        {
            this.id = id;
            this.libelle = libelle;
        }

        public Medicament(string libelle)
        {
            this.libelle = libelle;
        }

        public Medicament(int id, string libelle, int quantity) : this(id, libelle)
        {
            this.quantity = quantity;
        }

        /*
         * La fonction ToString() permet l'affichage
         * de l'objet sous la forme d'une chaine de caractere
         */
        // Reecriture de la fonction ToString()
        public override string ToString()
        {
            // Definition d'une chaine de caractere domposer du libelle en majuscule
            string str = this.libelle.ToUpper();
            // si la quantite est superrieur a 0 
            if (this.quantity != 0)
            {
                // Ajout de la quantite a la chaine de caractere
                str = str + " ( " + this.quantity + " ) ";
            }
            // Renvoie de la chaine de caractere
            return str ;
        }
    }
}
