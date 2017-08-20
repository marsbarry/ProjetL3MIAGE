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

namespace WindowsFormsProjetL3MIAGE
{
    public partial class AjouterUnCLient : Form
    {
        public AjouterUnCLient()
        {
            InitializeComponent();
        }

        //Permet de revenir à l'accueil
        private void buttonCanAc_Click(object sender, EventArgs e)
        {
            this.Close();
            Accueil ObjF = new Accueil();
            ObjF.Show();
        }

        //Permet de récupérer le numéro unique pour unn nouveau <client
        private void AjouterUnCLient_Load(object sender, EventArgs e)
        {
            textBoxNumC.Focus();
            textBoxNumC.Text = Convert.ToString(GestionClient.MaxCli());
        }

        private void buttonAjAc_Click(object sender, EventArgs e)
        {
            //Message box confirmer

            DialogResult result = MessageBox.Show("Voulez vous ajoutez Mr/Mme " + textBoxNomAc.Text + " comme nouveau client ?", "Confirmer", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                //Création d'un nouveau Client avec les données récupérer dans l'IHM
                Client newCli = new Client(Convert.ToInt32(textBoxNumC.Text), textBoxNomAc.Text, textBoxPreAc.Text, Convert.ToInt32(textBoxTelAc.Text) , textBoxAdrAc.Text , Convert.ToInt32(textBoxCpAc.Text), textBoxVilleAc.Text, Convert.ToString(textBoxMailAc.Text));
                GestionClient.AjoutCli(newCli);

                //Retour vers l'accueil
                this.Close();
                Accueil objF = new Accueil();
                objF.Show();
            }
            else
            {
                //Messabox informant que le client n'a pas été ajouté
                MessageBox.Show("Le client " + textBoxNomAc.Text + " n'a pas était ajouté");
            }
        }

        private void labelTitreAC_Click(object sender, EventArgs e)
        {

        }
    }
}
