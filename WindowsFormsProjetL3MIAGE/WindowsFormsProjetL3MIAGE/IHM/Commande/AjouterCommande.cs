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
    public partial class AjouterCommande : Form
    {
        public AjouterCommande()
        {
            InitializeComponent();
        }

        private void AjouterCommandeInfoClient_Load(object sender, EventArgs e)
        {
            //A l'ouverture, le numerod de commande est automatiquement rempli avec un numéro unique
            textBoxNumCMD.Text = GestionCommandeC.MaxCmd().ToString(); 

            //Création d'une datatable qui vas contenir les Identifiants de tous les clients de la BDD
            DataTable objdt = new DataTable();
            string req = "SELECT IDCLI FROM CLIENT";
            ConnexionBD objConn = new ConnexionBD(req);
            objdt = objConn.ExecuteSelect();
            for(int i = 0;i < objdt.Rows.Count; i++)
            {
                comboBoxChoiCli.Items.Add(objdt.Rows[i]["IDCLI"]);
            }

            //Création d'une datatable qui va contenir tous les nom de produits de la BDD
            DataTable objdt1 = new DataTable();
            string req1 = "SELECT NOMPROD FROM PRODUIT";
            ConnexionBD objconn1 = new ConnexionBD(req1);
            objdt1 = objconn1.ExecuteSelect();

            for (int j = 0; j< objdt1.Rows.Count; j++)
            {
                comboBoxNomProdAC.Items.Add(objdt1.Rows[j]["NOMPROD"]);
            }

        }

        private void comboBoxChoiCli_SelectedIndexChanged(object sender, EventArgs e)
        {
            string chaine = comboBoxChoiCli.SelectedItem.ToString();
            string[] tableau_de_mots = chaine.Split(' ');
            
            //Création d'un client via l'identifiants selectionner dans la combobox de l'IHM
            CLasse.Client unCli = new CLasse.Client(Convert.ToInt32(tableau_de_mots[0]));

            //Affichage dans les textbox des informations client via l'objet client
            textBoxTelAco.Text = unCli.getTelCli().ToString();
            textBoxCpAco.Text = unCli.getCpCli().ToString();
            textBoxMailAco.Text = unCli.getMailCli();
            textBoxAdrAco.Text = unCli.getAdrCli();
            textBoxVilleAco.Text = unCli.getVille();
            
        }

        //Retoiur vers l'accueil
        private void co_Click(object sender, EventArgs e)
        {
            this.Hide();
            Accueil objF = new Accueil();
            objF.Show();
        }


        private void buttonSuiAco_Click(object sender, EventArgs e)
        {
         
        }

        private void comboBoxChoiCli_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //Création d'une datatable qui va contenir toutes les informations du client portant le numéro selectionné dans la combobobox
            DataTable objdt = new DataTable();
            string req = "SELECT * FROM CLIENT WHERE IDCLI = "+comboBoxChoiCli.SelectedItem;
            ConnexionBD objconn = new ConnexionBD(req);
            objdt = objconn.ExecuteSelect();

            //Affichage dans les textbox des informations client via la datatable
            textBoxNomCliAC.Text = objdt.Rows[0]["NOMCLI"].ToString();
            textBoxPreCliAC.Text =  objdt.Rows[0]["PRENOMCLI"].ToString();
            textBoxTelAco.Text = objdt.Rows[0]["TELCLI"].ToString();
            textBoxCpAco.Text = objdt.Rows[0]["CPCLI"].ToString();
            textBoxMailAco.Text = objdt.Rows[0]["MAILCLI"].ToString();
            textBoxVilleAco.Text = objdt.Rows[0]["VILLECLI"].ToString();
            textBoxAdrAco.Text = objdt.Rows[0]["ADRCLI"].ToString();

        }

        private void comboBoxNomProdAC_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Création d'une datatable qui va contenir l'id et le prix du produit selectionné dans la combobox
            DataTable objdt = new DataTable();
            string req = "SELECT IDPRODUIT,PRIXPROD from PRODUIT where NOMPROD = '" + comboBoxNomProdAC.SelectedItem+"'";
            ConnexionBD objConn = new ConnexionBD(req);
            objdt = objConn.ExecuteSelect();

            //Affichage dans les textbox des informations client via la datatable
            textBoxRefProdAC.Text = objdt.Rows[0]["IDPRODUIT"].ToString();
            textBoxPrixProdAC.Text = objdt.Rows[0]["PRIXPROD"].ToString();
        }

        private void buttonAddProdACP_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonDelAC_Click(object sender, EventArgs e)
        {
            
        }

        //Retoiur vers l'accueil
        private void buttonCanAC_Click(object sender, EventArgs e)
        {
            this.Close();
            Accueil objF = new Accueil();
            objF.Show();
        }

        private void buttonEnrAC_Click(object sender, EventArgs e)
        {
            //Messagebox confirmer
            DialogResult result = MessageBox.Show("Voulez vous ajoutez la commande n° " + textBoxNumCMD.Text , "Confirmer", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                //Execution de la requête permettant l'ajout dans la BDD d'une commande dans la table commandeC
                string req = "insert into commandeC(idcli,idcmdc) values (" + comboBoxChoiCli.SelectedItem + "," + textBoxNumCMD.Text + ")";
                ConnexionBD objconn = new ConnexionBD(req);
                objconn.ExecuteIUD();

                //Execution de la requête permettant l'ajout dans la BDD d'une commande dans la table commandeC_2
                string req1 = "Insert into commandec_2 (IDCLI,IDCMDC,IDPRODUIT,QTECMDC) values (" + comboBoxChoiCli.SelectedItem + "," + textBoxNumCMD.Text + "," + textBoxRefProdAC.Text + "," + textBoxQteProdAC.Text + ")";
                ConnexionBD objconn1 = new ConnexionBD(req1);
                objconn1.ExecuteIUD();

                //Retoiur vers l'accueil
                this.Close();
                Accueil objF = new Accueil();
                objF.Show();
            }

            //Messagebox indiquant que lajout ne s'est pas fait
            else
            {
                MessageBox.Show("La commande n° " + textBoxNumCMD.Text + " n'a pas était ajouté");
            }

        }
    }
}
