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
using ProjTpConn;
using WindowsFormsProjetL3MIAGE.IHM;

namespace WindowsFormsProjetL3MIAGE
{
    public partial class Accueil : Form
    {
        public Accueil()
        {
            ConnexionBD.Connecter("userprojl3", "manager");
            InitializeComponent();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void ajouterUnClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AjouterUnCLient ObjF = new AjouterUnCLient();
            ObjF.Show();
        }

        private void consulterLesClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConsulterUnClient ObjF = new ConsulterUnClient();
            ObjF.Show();
        }

        private void Accueil_Load(object sender, EventArgs e)
        {
            
        }

        private void ajouterUneCommandeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AjouterCommandeInfoClient objF = new AjouterCommandeInfoClient();
            objF.Show();
        }

        private void ouvrirUneRéclamationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            IHM.SAV objF = new IHM.SAV();
            objF.Show();
        }

        private void consulterLesCommandesDunClientToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void modifierUneCommandeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void consulterUneRéclamationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
