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
	class Rdv
	{
        public static List<Rdv> rendez_vous=new List<Rdv>();
		DateTime dateRdv;
		String etat;
		String nomP;

		public DateTime DateRdv { get => dateRdv; set => dateRdv = value; }
		public string Etat { get => etat; set => etat = value; }
		public string NomP { get => nomP; set => nomP = value; }
	}
}
