using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace WindowsFormsApp1
{
    public partial class ConsutationPatients : Form
    {
        public ConsutationPatients()
        {
            InitializeComponent();
        }

        private void ConsutationPatients_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            new Patient().load();
            foreach (var item in Patient.patients)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item.NomP;
                dataGridView1.Rows[n].Cells[1].Value = item.PrenomP;
                dataGridView1.Rows[n].Cells[2].Value = item.Sexe;
                dataGridView1.Rows[n].Cells[3].Value = item.NumTel;
                dataGridView1.Rows[n].Cells[4].Value = item.SchemaDentaire;
                dataGridView1.Rows[n].Cells[5].Value = Image.FromFile(item.Radio_Panoramique);
                dataGridView1.Rows[n].Cells[6].Value = Image.FromFile(item.Radio_dent1);
              /*  foreach (DataGridViewImageColumn column in dataGridView1.Columns)    //Pour afficher la taille complete de la Photo
                {
                    column.ImageLayout = DataGridViewImageCellLayout.Stretch;
                    column.Description = "Stretched";
                }*/
            }
        }
    }
}
