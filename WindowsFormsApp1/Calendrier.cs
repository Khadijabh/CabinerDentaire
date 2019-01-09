using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Calendrier : Form
    {
        public Calendrier()
        {
            InitializeComponent();
        }

        private void Calendrier_Load(object sender, EventArgs e)
        {
            new Patient().load();

            dataGridView1.Rows.Clear();
            foreach (var item in Patient.patients)
            {
                foreach (var inte in item.Interventions)
                {
                    if (inte.Seances.RdvSeance.Date == DateTime.Now.Date)
                    {
                        int n = dataGridView1.Rows.Add();
                        dataGridView1.Rows[n].Cells[0].Value = item.NomP;
                        dataGridView1.Rows[n].Cells[1].Value = item.PrenomP;
                        dataGridView1.Rows[n].Cells[2].Value = inte.Seances.Etat;
                        dataGridView1.Rows[n].Cells[3].Value = inte.Seances.RdvSeance;
                        dataGridView1.Rows[n].Cells[4].Value = item.NumTel;
                    }
                }
            }
        }

        private void Calendrier_FormClosing(object sender, FormClosingEventArgs e)
        {
            new Patient().Save();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime d = new DateTime();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Selected)
                {
                    textBox1.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    textBox2.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    d = (DateTime) dataGridView1.Rows[i].Cells[3].Value;
                    dateTimePicker1.Value = d.Date ;
                    textBox3.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var item in Patient.patients)
            {
                if (item.NomP.Equals(textBox1.Text))
                {
                    foreach (var interv in item.Interventions)
                    {
                        interv.Seances.Etat = "Confirmer";
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
