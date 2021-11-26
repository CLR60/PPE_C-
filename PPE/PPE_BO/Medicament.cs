using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE_C_Sharp_BO
{
    public class Medicament
    {
        private int id;
        private string libelle;

        public string Libelle { get => libelle; set => libelle = value; }
        public int Id { get => id; set => id = value; }

        public Medicament(int id, string libelle)
        {
            this.id = id;
            this.libelle = libelle;
        }

        public Medicament(string libelle)
        {
            this.libelle = libelle;
        }
    }
}
