using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE_C_Sharp_BO
{
    // Objet Visite
    public class Visite
    {
        // Attribut de l'objet
        private int id;
        private DateTime date;
        private TimeSpan h_start, h_end;
        private string motif,comm;
        private bool suite, parent;
        private List<Medicament> medicaments;
        private Eleve eleve;

        /* 
         * Constructeur vide permettant la recuperation
         * des propriete de l'objet, utiliser pour
         * l'affichage des datagrid
         */
        public Visite()
        {

        }
        // Constructeur de l'objet
        // Prend en compte totue les attribut a part l'id
        public Visite(DateTime date, TimeSpan h_start, TimeSpan h_end, string motif, string comm, bool suite, bool parent, List<Medicament> medicaments, Eleve eleve)
        {
            this.date = date;
            this.h_start = h_start;
            this.h_end = h_end;
            this.motif = motif;
            this.comm = comm;
            this.suite = suite;
            this.parent = parent;
            this.medicaments = medicaments;
            this.eleve = eleve;
        }
        // prend en compte tout les attribut
        public Visite(int id, DateTime date, TimeSpan h_start, TimeSpan h_end, string motif, string comm, bool suite, bool parent, Eleve eleve)
        {
            this.id = id;
            this.date = date;
            this.h_start = h_start;
            this.h_end = h_end;
            this.motif = motif;
            this.comm = comm;
            this.suite = suite;
            this.parent = parent;
            this.eleve = eleve;
        }

        // Prend en compte totue les attribut a part la liste de medicament
        public Visite(int id, DateTime date, TimeSpan h_start, TimeSpan h_end, string motif, string comm, bool suite, bool parent, List<Medicament> medicaments, Eleve eleve)
        {
            this.id = id;
            this.date = date;
            this.h_start = h_start;
            this.h_end = h_end;
            this.motif = motif;
            this.comm = comm;
            this.suite = suite;
            this.parent = parent;
            this.medicaments = medicaments;
            this.eleve = eleve;
        }

        // Propriete de l'objet
        public int Id { get => id; set => id = value; }
        public DateTime Date { get => date; set => date = value; }
        public TimeSpan H_start { get => h_start; set => h_start = value; }
        public TimeSpan H_end { get => h_end; set => h_end = value; }
        public string Motif { get => motif; set => motif = value; }
        public string Comm { get => comm; set => comm = value; }
        public bool Suite { get => suite; set => suite = value; }
        public bool Parent { get => parent; set => parent = value; }
        public List<Medicament> Medicaments { get => medicaments; set => medicaments = value; }
        public Eleve Eleve { get => eleve; set => eleve = value; }
    }
}
