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
	class Patient
	{
		private String nomP;
        private String prenomP;
        private String listeAlergie;
        private String schemaDentaire;
        private string assurance_medicale;
        private string numTel;
        private string sexe;
        private string Radio_dent;
        private string radio_Panoramique;
        private DateTime date_n;
        private List<Intervention> interventions=new List<Intervention>();
        public static List<Patient> patients = new List<Patient>();

        public string NomP { get => nomP; set => nomP = value; }
        public string PrenomP { get => prenomP; set => prenomP = value; }
        public string ListeAlergie { get => listeAlergie; set => listeAlergie = value; }
        public string Assurance_medicale { get => assurance_medicale; set => assurance_medicale = value; }
        public string SchemaDentaire { get => schemaDentaire; set => schemaDentaire = value; }
        public string NumTel { get => numTel; set => numTel = value; }
        public DateTime Date_n { get => date_n; set => date_n = value; }
        public string Sexe { get => sexe; set => sexe = value; }
        internal List<Intervention> Interventions { get => interventions; set => interventions = value; }
        public string Radio_dent1 { get => Radio_dent; set => Radio_dent = value; }
        public string Radio_Panoramique { get => radio_Panoramique; set => radio_Panoramique = value; }

        public Patient()
        {
                
        }

        public static void ajouterPatient(Patient p)
		{
            patients.Add(p);
		}

		public void ajouterIntervention(Intervention i)
		{
            this.interventions.Add(i);
		}

		public void ajouterSeance(Seance s)
        {
            this.interventions[interventions.Count-1].Seances= s;
		}

        public void atjouerRDV(String nomP, DateTime dateRDV,string comment) {
			Seance s = new Seance(dateRDV,comment);
			for (int i = 0; i < patients.Count; i++)
				if (patients[i].nomP.Equals(nomP))
						patients[i].ajouterSeance(s);
		}
/*
		public void donneeOrdannace(Ordannace o)
		{
			int der_int = Interventions.Count - 1;
			int der_sea = this.Interventions[der_int].Seances.Count - 1;
			this.Interventions[der_int].Seances[der_sea].Ordannace = o;
		}

*/

        public Patient(string nomP, string prenomP, string listeAlergie, string schemaDentaire, string assurance_medicale, string numTel, string sexe, DateTime date_n,string d1, string d2)
        {
            this.nomP = nomP;
            this.prenomP = prenomP;
            this.listeAlergie = listeAlergie;
            this.schemaDentaire = schemaDentaire;
            this.assurance_medicale = assurance_medicale;
            this.Radio_Panoramique = d1;
            this.Radio_dent1 = d2;
            this.numTel = numTel;
            this.sexe = sexe;
            this.Date_n = date_n;
        }

        public void payement(int pos,string nomp, float avance)
        {
            foreach (var item in Patient.patients)
            {
                if (item.NomP.Contains(nomp))
                {
                    if (avance >= item.interventions[pos].RestePayement)
                    {
                        item.interventions[pos].RestePayement = 0;
                        item.interventions[pos].Etat = "Regler";
                    }
                    else
                    {
                        item.Interventions[pos].RestePayement = item.Interventions[pos].RestePayement - avance;
                        if (item.interventions[pos].RestePayement <= 0)
                        {
                            item.interventions[pos].Etat = "Regler";
                            item.interventions[pos].RestePayement = 0;
                        }
                    }
                }
            }
        }


        public void Save()
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream("mesDonnees", FileMode.OpenOrCreate);
            bf.Serialize(fs, patients);
            fs.Close();
        }

		public void load()
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream("mesDonnees", FileMode.OpenOrCreate);
            if (fs.Length > 0) patients = (List<Patient>)bf.Deserialize(fs);
            fs.Close();
        }

	}
}
