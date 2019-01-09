namespace WindowsFormsApp1
{
	partial class MDIParent1
	{
		/// <summary>
		/// Variable nécessaire au concepteur.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Nettoyage des ressources utilisées.
		/// </summary>
		/// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Code généré par le Concepteur Windows Form

		/// <summary>
		/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
		/// le contenu de cette méthode avec l'éditeur de code.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.viewMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionPatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterPatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterRdvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.confiermerSeanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesInterventionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medecinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conultationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterIntervebntonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calendrierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rendezvousDuJourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paiementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suiviDuPayementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewMenu,
            this.medecinToolStripMenuItem,
            this.calendrierToolStripMenuItem,
            this.paiementToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(954, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // viewMenu
            // 
            this.viewMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionPatientToolStripMenuItem});
            this.viewMenu.Name = "viewMenu";
            this.viewMenu.Size = new System.Drawing.Size(70, 20);
            this.viewMenu.Text = "Secretaire";
            // 
            // gestionPatientToolStripMenuItem
            // 
            this.gestionPatientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterPatientToolStripMenuItem,
            this.consultertToolStripMenuItem,
            this.ajouterRdvToolStripMenuItem,
            this.confiermerSeanceToolStripMenuItem,
            this.listeDesInterventionToolStripMenuItem});
            this.gestionPatientToolStripMenuItem.Name = "gestionPatientToolStripMenuItem";
            this.gestionPatientToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.gestionPatientToolStripMenuItem.Text = "Gestion Patient";
            // 
            // ajouterPatientToolStripMenuItem
            // 
            this.ajouterPatientToolStripMenuItem.Name = "ajouterPatientToolStripMenuItem";
            this.ajouterPatientToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.ajouterPatientToolStripMenuItem.Text = "Ajouter Patient";
            this.ajouterPatientToolStripMenuItem.Click += new System.EventHandler(this.ajouterPatientToolStripMenuItem_Click);
            // 
            // consultertToolStripMenuItem
            // 
            this.consultertToolStripMenuItem.Name = "consultertToolStripMenuItem";
            this.consultertToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.consultertToolStripMenuItem.Text = "Consultert";
            this.consultertToolStripMenuItem.Click += new System.EventHandler(this.consultertToolStripMenuItem_Click);
            // 
            // ajouterRdvToolStripMenuItem
            // 
            this.ajouterRdvToolStripMenuItem.Name = "ajouterRdvToolStripMenuItem";
            this.ajouterRdvToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.ajouterRdvToolStripMenuItem.Text = "Ajouter Rdv";
            this.ajouterRdvToolStripMenuItem.Click += new System.EventHandler(this.ajouterRdvToolStripMenuItem_Click);
            // 
            // confiermerSeanceToolStripMenuItem
            // 
            this.confiermerSeanceToolStripMenuItem.Name = "confiermerSeanceToolStripMenuItem";
            this.confiermerSeanceToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.confiermerSeanceToolStripMenuItem.Text = "confiermer Seance";
            // 
            // listeDesInterventionToolStripMenuItem
            // 
            this.listeDesInterventionToolStripMenuItem.Name = "listeDesInterventionToolStripMenuItem";
            this.listeDesInterventionToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.listeDesInterventionToolStripMenuItem.Text = "Lisu";
            this.listeDesInterventionToolStripMenuItem.Click += new System.EventHandler(this.listeDesInterventionToolStripMenuItem_Click);
            // 
            // medecinToolStripMenuItem
            // 
            this.medecinToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conultationToolStripMenuItem,
            this.ajouterIntervebntonToolStripMenuItem});
            this.medecinToolStripMenuItem.Name = "medecinToolStripMenuItem";
            this.medecinToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.medecinToolStripMenuItem.Text = "Medecin";
            this.medecinToolStripMenuItem.Visible = false;
            // 
            // conultationToolStripMenuItem
            // 
            this.conultationToolStripMenuItem.Name = "conultationToolStripMenuItem";
            this.conultationToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.conultationToolStripMenuItem.Text = "Conultation";
            this.conultationToolStripMenuItem.Click += new System.EventHandler(this.conultationToolStripMenuItem_Click);
            // 
            // ajouterIntervebntonToolStripMenuItem
            // 
            this.ajouterIntervebntonToolStripMenuItem.Name = "ajouterIntervebntonToolStripMenuItem";
            this.ajouterIntervebntonToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.ajouterIntervebntonToolStripMenuItem.Text = "Ajouter Intervebnton";
            this.ajouterIntervebntonToolStripMenuItem.Click += new System.EventHandler(this.ajouterIntervebntonToolStripMenuItem_Click);
            // 
            // calendrierToolStripMenuItem
            // 
            this.calendrierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rendezvousDuJourToolStripMenuItem});
            this.calendrierToolStripMenuItem.Name = "calendrierToolStripMenuItem";
            this.calendrierToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.calendrierToolStripMenuItem.Text = "Calendrier";
            this.calendrierToolStripMenuItem.Click += new System.EventHandler(this.calendrierToolStripMenuItem_Click);
            // 
            // rendezvousDuJourToolStripMenuItem
            // 
            this.rendezvousDuJourToolStripMenuItem.Name = "rendezvousDuJourToolStripMenuItem";
            this.rendezvousDuJourToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.rendezvousDuJourToolStripMenuItem.Text = "Rendez-vous du jour";
            this.rendezvousDuJourToolStripMenuItem.Click += new System.EventHandler(this.rendezvousDuJourToolStripMenuItem_Click);
            // 
            // paiementToolStripMenuItem
            // 
            this.paiementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.suiviDuPayementToolStripMenuItem});
            this.paiementToolStripMenuItem.Name = "paiementToolStripMenuItem";
            this.paiementToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.paiementToolStripMenuItem.Text = "Paiement";
            // 
            // suiviDuPayementToolStripMenuItem
            // 
            this.suiviDuPayementToolStripMenuItem.Name = "suiviDuPayementToolStripMenuItem";
            this.suiviDuPayementToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.suiviDuPayementToolStripMenuItem.Text = "Suivi du payement";
            this.suiviDuPayementToolStripMenuItem.Click += new System.EventHandler(this.suiviDuPayementToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 564);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(954, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(27, 17);
            this.toolStripStatusLabel.Text = "État";
            // 
            // MDIParent1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 586);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MDIParent1";
            this.Text = "MDIParent1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MDIParent1_FormClosed);
            this.Load += new System.EventHandler(this.MDIParent1_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion


		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
		private System.Windows.Forms.ToolStripMenuItem viewMenu;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.ToolStripMenuItem gestionPatientToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ajouterPatientToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem consultertToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem medecinToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem conultationToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ajouterIntervebntonToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ajouterRdvToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem confiermerSeanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesInterventionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calendrierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rendezvousDuJourToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paiementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suiviDuPayementToolStripMenuItem;
    }
}



