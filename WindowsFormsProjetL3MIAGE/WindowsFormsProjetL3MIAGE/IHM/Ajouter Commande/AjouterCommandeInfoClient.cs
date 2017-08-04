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

namespace WindowsFormsProjetL3MIAGE.IHM
{
    public partial class AjouterCommandeInfoClient : Form
    {
        public AjouterCommandeInfoClient()
        {
            InitializeComponent();
        }

        private void AjouterCommandeInfoClient_Load(object sender, EventArgs e)
        {
            textBoxRechNomCli.Focus(); //A l'ouverture, le curseur placé sur la box de recherche
            textBoxNumCMD.Text = GestionCommandeC.MaxCmd().ToString(); //A l'ouverture, le numerod e commande est automatiquement rempli
        }

        private void comboBoxChoiCli_SelectedIndexChanged(object sender, EventArgs e)
        {
            string chaine = comboBoxChoiCli.SelectedItem.ToString();
            string[] tableau_de_mots = chaine.Split(' ');
            
            CLasse.Client unCli = new CLasse.Client(Convert.ToInt32(tableau_de_mots[0]));
            textBoxTelAco.Text = unCli.getTelCli().ToString();
            textBoxCpAco.Text = unCli.getCpCli().ToString();
            textBoxMailAco.Text = unCli.getMailCli();
            textBoxAdrAco.Text = unCli.getAdrCli();
            textBoxVilleAco.Text = unCli.getVille();
            
        }
    }
}
