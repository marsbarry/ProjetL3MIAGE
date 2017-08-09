namespace WindowsFormsProjetL3MIAGE
{
    partial class Accueil
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStripFichier = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesCommandesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUneCommandeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consulterLesCommandesDunClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierUneCommandeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sAVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ouvrirUneRéclamationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consulterUneRéclamationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUnClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consulterLesClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripFichier.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripFichier
            // 
            this.menuStripFichier.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.gestionDesCommandesToolStripMenuItem,
            this.sAVToolStripMenuItem,
            this.clientToolStripMenuItem});
            this.menuStripFichier.Location = new System.Drawing.Point(0, 0);
            this.menuStripFichier.Name = "menuStripFichier";
            this.menuStripFichier.Size = new System.Drawing.Size(507, 24);
            this.menuStripFichier.TabIndex = 0;
            this.menuStripFichier.Text = "Fichier";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // gestionDesCommandesToolStripMenuItem
            // 
            this.gestionDesCommandesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterUneCommandeToolStripMenuItem,
            this.consulterLesCommandesDunClientToolStripMenuItem,
            this.modifierUneCommandeToolStripMenuItem});
            this.gestionDesCommandesToolStripMenuItem.Name = "gestionDesCommandesToolStripMenuItem";
            this.gestionDesCommandesToolStripMenuItem.Size = new System.Drawing.Size(149, 20);
            this.gestionDesCommandesToolStripMenuItem.Text = "Gestion des commandes";
            // 
            // ajouterUneCommandeToolStripMenuItem
            // 
            this.ajouterUneCommandeToolStripMenuItem.Name = "ajouterUneCommandeToolStripMenuItem";
            this.ajouterUneCommandeToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.ajouterUneCommandeToolStripMenuItem.Text = "Ajouter une commande";
            this.ajouterUneCommandeToolStripMenuItem.Click += new System.EventHandler(this.ajouterUneCommandeToolStripMenuItem_Click);
            // 
            // consulterLesCommandesDunClientToolStripMenuItem
            // 
            this.consulterLesCommandesDunClientToolStripMenuItem.Name = "consulterLesCommandesDunClientToolStripMenuItem";
            this.consulterLesCommandesDunClientToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.consulterLesCommandesDunClientToolStripMenuItem.Text = "Consulter les commandes d\"un client";
            this.consulterLesCommandesDunClientToolStripMenuItem.Click += new System.EventHandler(this.consulterLesCommandesDunClientToolStripMenuItem_Click);
            // 
            // modifierUneCommandeToolStripMenuItem
            // 
            this.modifierUneCommandeToolStripMenuItem.Name = "modifierUneCommandeToolStripMenuItem";
            this.modifierUneCommandeToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.modifierUneCommandeToolStripMenuItem.Text = "Modifier une commande";
            this.modifierUneCommandeToolStripMenuItem.Click += new System.EventHandler(this.modifierUneCommandeToolStripMenuItem_Click);
            // 
            // sAVToolStripMenuItem
            // 
            this.sAVToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ouvrirUneRéclamationToolStripMenuItem,
            this.consulterUneRéclamationToolStripMenuItem});
            this.sAVToolStripMenuItem.Name = "sAVToolStripMenuItem";
            this.sAVToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.sAVToolStripMenuItem.Text = "SAV";
            // 
            // ouvrirUneRéclamationToolStripMenuItem
            // 
            this.ouvrirUneRéclamationToolStripMenuItem.Name = "ouvrirUneRéclamationToolStripMenuItem";
            this.ouvrirUneRéclamationToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.ouvrirUneRéclamationToolStripMenuItem.Text = "Ouvrir une réclamation";
            this.ouvrirUneRéclamationToolStripMenuItem.Click += new System.EventHandler(this.ouvrirUneRéclamationToolStripMenuItem_Click);
            // 
            // consulterUneRéclamationToolStripMenuItem
            // 
            this.consulterUneRéclamationToolStripMenuItem.Name = "consulterUneRéclamationToolStripMenuItem";
            this.consulterUneRéclamationToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.consulterUneRéclamationToolStripMenuItem.Text = "Consulter une réclamation";
            this.consulterUneRéclamationToolStripMenuItem.Click += new System.EventHandler(this.consulterUneRéclamationToolStripMenuItem_Click);
            // 
            // clientToolStripMenuItem
            // 
            this.clientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterUnClientToolStripMenuItem,
            this.consulterLesClientsToolStripMenuItem});
            this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            this.clientToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.clientToolStripMenuItem.Text = "Client";
            // 
            // ajouterUnClientToolStripMenuItem
            // 
            this.ajouterUnClientToolStripMenuItem.Name = "ajouterUnClientToolStripMenuItem";
            this.ajouterUnClientToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.ajouterUnClientToolStripMenuItem.Text = "Ajouter un Client";
            this.ajouterUnClientToolStripMenuItem.Click += new System.EventHandler(this.ajouterUnClientToolStripMenuItem_Click);
            // 
            // consulterLesClientsToolStripMenuItem
            // 
            this.consulterLesClientsToolStripMenuItem.Name = "consulterLesClientsToolStripMenuItem";
            this.consulterLesClientsToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.consulterLesClientsToolStripMenuItem.Text = "Consulter les clients";
            this.consulterLesClientsToolStripMenuItem.Click += new System.EventHandler(this.consulterLesClientsToolStripMenuItem_Click);
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 363);
            this.Controls.Add(this.menuStripFichier);
            this.MainMenuStrip = this.menuStripFichier;
            this.Name = "Accueil";
            this.Text = "Accueil";
            this.Load += new System.EventHandler(this.Accueil_Load);
            this.menuStripFichier.ResumeLayout(false);
            this.menuStripFichier.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripFichier;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesCommandesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUneCommandeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consulterLesCommandesDunClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sAVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ouvrirUneRéclamationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierUneCommandeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consulterUneRéclamationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUnClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consulterLesClientsToolStripMenuItem;
    }
}