using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE_C_Sharp_BO
{
    public class Classe
    {
        private int id;
        private string libelle;

        public int Id { get => id; set => id = value; }
        public string Libelle { get => libelle; set => libelle = value; }

        public Classe(int id, string libelle)
        {
            this.id = id;
            this.libelle = libelle;
        }

        public Classe(string libelle)
        {
            this.libelle = libelle;
        }

        public override string ToString()
        {
            return libelle;
        }
    }
}
