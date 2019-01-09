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
	public partial class MDIParent1 : Form
	{
		private int childFormNumber = 0;

		public MDIParent1()
		{
			InitializeComponent();
		}

		private void ShowNewForm(object sender, EventArgs e)
		{
			Form childForm = new Form();
			childForm.MdiParent = this;
			childForm.Text = "Fenêtre " + childFormNumber++;
			childForm.Show();
		}

		private void OpenFile(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			openFileDialog.Filter = "Fichiers texte (*.txt)|*.txt|Tous les fichiers (*.*)|*.*";
			if (openFileDialog.ShowDialog(this) == DialogResult.OK)
			{
				string FileName = openFileDialog.FileName;
			}
		}

		private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			saveFileDialog.Filter = "Fichiers texte (*.txt)|*.txt|Tous les fichiers (*.*)|*.*";
			if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
			{
				string FileName = saveFileDialog.FileName;
			}
		}

		private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void CutToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			LayoutMdi(MdiLayout.Cascade);
		}

		private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
		{
			LayoutMdi(MdiLayout.TileVertical);
		}

		private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
		{
			LayoutMdi(MdiLayout.TileHorizontal);
		}

		private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			LayoutMdi(MdiLayout.ArrangeIcons);
		}

		private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
		{
			foreach (Form childForm in MdiChildren)
			{
				childForm.Close();
			}
		}

		private void ajouterPatientToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ajouterPati p = new ajouterPati();
			p.MdiParent = this;
			p.Show();
            p.WindowState = FormWindowState.Maximized;
        }

		private void consultertToolStripMenuItem_Click(object sender, EventArgs e)
		{
            ConsutationPatients p = new ConsutationPatients();
            p.MdiParent = this;
            p.Show();
            p.WindowState = FormWindowState.Maximized;
        }

		private void MDIParent1_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}
		private int testi=0;

		public int Testi { get => testi; set => testi = value; }

		private void MDIParent1_Load(object sender, EventArgs e)
		{
			if (testi != 0)
			{
				medecinToolStripMenuItem.Visible = true;
			}
		}

		private void ajouterRdvToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Ajouter_Rdv f = new Ajouter_Rdv();
			f.MdiParent = this;
			f.Show();
            f.WindowState = FormWindowState.Maximized;
        }

        private void conultationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsutationPatients p = new ConsutationPatients();
            p.MdiParent = this;
            p.Show();
            p.WindowState = FormWindowState.Maximized;
        }

        private void ajouterIntervebntonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AjouterIntervention f = new AjouterIntervention();
            f.MdiParent = this;
            f.Show();
            f.WindowState = FormWindowState.Maximized;
        }

        private void creeOrdananceToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listeDesInterventionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LinstedDesInterventions f = new LinstedDesInterventions();
            f.MdiParent = this;
            f.Show();
            f.WindowState = FormWindowState.Maximized;
        }

        private void rendezvousDuJourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calendrier c = new Calendrier();
            c.MdiParent = this;
            c.Show();
            c.WindowState = FormWindowState.Maximized;
        }

        private void suiviDuPayementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Payement p = new Payement();
            p.MdiParent = this;
            p.Show();
            p.WindowState = FormWindowState.Maximized;
        }

        private void calendrierToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
