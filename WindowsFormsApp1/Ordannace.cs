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
	class Ordannace
	{
		private List<String> ligneOrd;


		public Ordannace() {
			LigneOrd = new List<string>();
		}

        public Ordannace(List<string> ligneOrd)
        {
            LigneOrd = new List<string>();
            this.ligneOrd = ligneOrd;
        }

        public List<string> LigneOrd { get => ligneOrd; set => ligneOrd = value; }
	}
}
