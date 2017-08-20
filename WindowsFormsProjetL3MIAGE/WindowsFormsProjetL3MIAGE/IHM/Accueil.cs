using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsProjetL3MIAGE.CLasse;
using WindowsFormsProjetL3MIAGE.IHM.Client;
using WindowsFormsProjetL3MIAGE.IHM;
using Oracle.DataAccess;
using WindowsFormsProjetL3MIAGE.IHM.Litige;

namespace WindowsFormsProjetL3MIAGE
{
    public partial class Accueil : Form
    {
        //Coonexion à la BDD
        public Accueil()
        {
            ConnexionBD.Connecter("userprojl3", "manager");
            InitializeComponent();
        }

        //Permet de quitter le projet
        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        //Permet d'aller à l'IHM d'ajout d'un client
        private void ajouterUnClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AjouterUnCLient ObjF = new AjouterUnCLient();
            ObjF.Show();
        }


        //Permet d'aller à l'IHM de consultation d'un client
        private void consulterLesClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConsulterUnClient ObjF = new ConsulterUnClient();
            ObjF.Show();
        }

        private void Accueil_Load(object sender, EventArgs e)
        {
            
        }


        //Permet d'aller à l'IHM d'ajout d'une commande
        private void ajouterUneCommandeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AjouterCommande objF = new AjouterCommande();
            objF.Show();
        }


        //Permet d'aller à l'IHM de création d'un ticket de litige
        private void ouvrirUneRéclamationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            IHM.SAV objF = new IHM.SAV();
            objF.Show();
        }


        //Permet d'aller à l'IHM de consultation d'une commande
        private void consulterLesCommandesDunClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConsulterCommande objF = new ConsulterCommande();
            objF.Show();
        }

        private void modifierUneCommandeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        //Permet d'aller à l'IHM de consultation d'un ticket de litige
        private void consulterUneRéclamationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConsulterSAV objF = new ConsulterSAV();
            objF.Show();
        }


        //Permet d'aller à l'IHM de modification d'un ticket de litige
        private void modifierUneRéclamationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModifierSAV objF = new ModifierSAV();
            objF.Show();
        }
    }
}
