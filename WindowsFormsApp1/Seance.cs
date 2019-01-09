using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace WindowsFormsApp1
{
    [Serializable]
	class Seance
	{
		private DateTime rdvSeance;
        private float avance;
		private String commentaire;
        private string etat;
        
		public string Commentaire { get => commentaire; set => commentaire = value; }
		internal DateTime RdvSeance { get => rdvSeance; set => rdvSeance = value; }
        public float Avance { get => avance; set => avance = value; }
        public string Etat { get => etat; set => etat = value; }

        public Seance()
        {

        }

        public Seance(DateTime rdv, string commentaire)
        {
            this.rdvSeance = new DateTime();
            this.rdvSeance = rdv;
            this.commentaire= commentaire;
            this.avance = 0;
            this.etat = "Non confirmer";
        }
	}
}
