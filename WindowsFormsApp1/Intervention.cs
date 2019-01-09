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
	class Intervention
	{
		private Seance seances;
		private float prix;
        private float restePayement;
        private string etat;
		private String description;

		public float Prix { get => prix; set => prix = value; }
		public string Description { get => description; set => description = value; }
        public string Etat { get => etat; set => etat = value; }
        public float RestePayement { get => restePayement; set => restePayement = value; }
        internal Seance Seances { get => seances; set => seances = value; }

        public Intervention()
        {

        }

        public Intervention(float prix, string description)
        {
            //this.seances = new List<Seance>();
            this.prix = prix;
            this.restePayement = prix;
            this.description = description;
            this.etat = "Non regler";
        }
    }
}
