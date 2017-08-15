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
            
            textBoxNumCMD.Text = GestionCommandeC.MaxCmd().ToString(); //A l'ouverture, le numerod de commande est automatiquement rempli
            DataTable objdt = new DataTable();
            string req = "SELECT IDCLI FROM CLIENT";
            ConnexionBD objConn = new ConnexionBD(req);
            objdt = objConn.ExecuteSelect();
            for(int i = 0;i < objdt.Rows.Count; i++)
            {
                comboBoxChoiCli.Items.Add(objdt.Rows[i]["IDCLI"]);
            }

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
            
            CLasse.Client unCli = new CLasse.Client(Convert.ToInt32(tableau_de_mots[0]));
            textBoxTelAco.Text = unCli.getTelCli().ToString();
            textBoxCpAco.Text = unCli.getCpCli().ToString();
            textBoxMailAco.Text = unCli.getMailCli();
            textBoxAdrAco.Text = unCli.getAdrCli();
            textBoxVilleAco.Text = unCli.getVille();
            
        }

        private void co_Click(object sender, EventArgs e)
        {
            this.Hide();
            Accueil objF = new Accueil();
            objF.Show();
        }

        private void buttonSuiAco_Click(object sender, EventArgs e)
        {
            this.Hide();
            AjouterCommande objF = new AjouterCommande();
            objF.Show();
        }

        private void comboBoxChoiCli_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            DataTable objdt = new DataTable();
            string req = "SELECT * FROM CLIENT WHERE IDCLI = "+comboBoxChoiCli.SelectedItem;
            ConnexionBD objconn = new ConnexionBD(req);
            objdt = objconn.ExecuteSelect();

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
            DataTable objdt = new DataTable();
            string req = "SELECT IDPRODUIT,PRIXPROD from PRODUIT where NOMPROD = '" + comboBoxNomProdAC.SelectedItem+"'";
            ConnexionBD objConn = new ConnexionBD(req);
            objdt = objConn.ExecuteSelect();

            textBoxRefProdAC.Text = objdt.Rows[0]["IDPRODUIT"].ToString();
            textBoxPrixProdAC.Text = objdt.Rows[0]["PRIXPROD"].ToString();
        }

        private void buttonAddProdACP_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonDelAC_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonCanAC_Click(object sender, EventArgs e)
        {
            this.Close();
            Accueil objF = new Accueil();
            objF.Show();
        }

        private void buttonEnrAC_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Voulez vous ajoutez la commande n° " + textBoxNumCMD.Text , "Confirmer", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {

                string req = "insert into commandeC(idcli,idcmdc) values (" + comboBoxChoiCli.SelectedItem + "," + textBoxNumCMD.Text + ")";
                ConnexionBD objconn = new ConnexionBD(req);
                objconn.ExecuteIUD();

                string req1 = "Insert into commandec_2 (IDCLI,IDCMDC,IDPRODUIT,QTECMDC) values (" + comboBoxChoiCli.SelectedItem + "," + textBoxNumCMD.Text + "," + textBoxRefProdAC.Text + "," + textBoxQteProdAC.Text + ")";
                ConnexionBD objconn1 = new ConnexionBD(req1);
                objconn1.ExecuteIUD();
            }
            else
            {
                MessageBox.Show("La commande n° " + textBoxNumCMD.Text + " n'a pas était ajouté");
            }

        }
    }
}
