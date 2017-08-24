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

namespace WindowsFormsProjetL3MIAGE.IHM.Litige
{
    public partial class ModifierSAV : Form
    {
        public ModifierSAV()
        {
            InitializeComponent();
        }

        private void ModifierSAV_Load(object sender, EventArgs e)
        {
            //Création d'une datatable contenant les Id des clients ayant ouvert un ticket
            string requete = "SELECT CLIENT.IDCLI from client,COMMANDEC,LITIGE where client.idcli = commandec.idcli and commandec.idcmdc = litige.idcmdc";
            DataTable DtCOns = new DataTable();
            ConnexionBD ObjCons = new ConnexionBD(requete);
            DtCOns = ObjCons.ExecuteSelect();

            //Affichage de ces ID
            foreach (DataRow row in DtCOns.Rows)
            {
                comboBoxNumSAVML.Items.Add(row[0]);
            }
        }

        private void comboBoxNumSAVML_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Création d'un objet Client
            CLasse.Client NewCli = new CLasse.Client(Convert.ToInt32(comboBoxNumSAVML.SelectedItem));

            //Affichage des données de ce client
            textBoxNomSAVML.Text = NewCli.getNomCli();
            textBoxPreSAVML.Text = NewCli.getPrenomCli();
            textBoxAdrSAVML.Text = NewCli.getAdrCli();
            textBoxVilleSAVML.Text = NewCli.getVille().ToString();
            textBoxCPSAVML.Text = NewCli.getCpCli().ToString();
            textBoxTelSAVML.Text = NewCli.getTelCli().ToString();
            textBoxMailSAVML.Text = NewCli.getMailCli().ToString();
            textBoxTelSAVML.Text = NewCli.getTelCli().ToString();

            //création d'une datatable contenant le(s) Id de/des commandes effectué par le client selectionné
            int Idcli = Convert.ToInt32(comboBoxNumSAVML.SelectedItem);
            string requete = "Select COMMANDEC_2.IDCMDC from CommandeC, COMMANDEC_2 where COMMANDEC_2.IDCMDC = COMMANDEC.IDCMDC AND COMMANDEC_2.IDCLI =" + Idcli;
            DataTable DtCOns = new DataTable();
            ConnexionBD ObjCons = new ConnexionBD(requete);
            DtCOns = ObjCons.ExecuteSelect();

            //Affichage  de(s) Id
            foreach (DataRow row in DtCOns.Rows)
            {
                comboBoxNumCmdSAVML.Items.Clear();
                comboBoxNumCmdSAVML.Items.Add(row[0]);
            }
        }

        private void comboBoxNumCmdSAVML_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Création d'une datatable contenant l'Id produit de la commande
            int Idcmdc = Convert.ToInt32(comboBoxNumCmdSAVML.SelectedItem);
            string Unerequete = "select produit.idproduit from produit , COMMANDEC , COMMANDEC_2 where PRODUIT.IDPRODUIT = COMMANDEC_2.IDPRODUIT and COMMANDEC_2.IDCMDC = COMMANDEC.IDCMDC and COMMANDEC_2.IDCMDC =" + Idcmdc;
            DataTable DtCOMM = new DataTable();
            ConnexionBD ObjCons = new ConnexionBD(Unerequete);
            DtCOMM = ObjCons.ExecuteSelect();

            //Affichage de cet ID
            textBoxNumProdML.Text = DtCOMM.Rows[0][0].ToString();

            //Création d'une datatable contenant le nom, prix et couleur du produit de la commande
            int IdProd = Convert.ToInt32(textBoxNumProdML.Text);
            string ReqNomProd = "select NOMPROD,PRIXPROD, COULEURPROD from produit where produit.idproduit = " + IdProd;
            DataTable DtArt = new DataTable();
            ConnexionBD ObjArt = new ConnexionBD(ReqNomProd);
            DtArt = ObjArt.ExecuteSelect();

            //Affichage de ces données
            textBoxNomProdSAVML.Text = DtArt.Rows[0]["NOMPROD"].ToString();
            textBoxCouProSAVML.Text = DtArt.Rows[0]["COULEURPROD"].ToString();
            textBoxPrixProdSAVML.Text = DtArt.Rows[0]["PRIXPROD"].ToString();


            textBoxNomCliSAVML.Text = textBoxNomSAVML.Text;
            NomCliSAV2ML.Text = textBoxNomSAVML.Text;

            //Création d'une datatable contenant l'id, le commentaire, la note et le statut du ticket lié à la commande
            int idcmdc = Convert.ToInt32(comboBoxNumCmdSAVML.SelectedItem);
            string uneReq = "SELECT IDLIT,COMMENTAIRE,NOTE,STATUT FROM LITIGE WHERE IDCMDC = " + idcmdc;
            ConnexionBD objConnLit = new ConnexionBD(uneReq);
            DataTable objDtLit = new DataTable();
            objDtLit = objConnLit.ExecuteSelect();

            //Affichage de ces données
            textBoxNumLitSAVML.Text = objDtLit.Rows[0]["IDLIT"].ToString();
            textBoxCommSAVML.Text = objDtLit.Rows[0]["COMMENTAIRE"].ToString();
            textBoxNoteSaVML.Text = objDtLit.Rows[0]["NOTE"].ToString();

        }

        private void buttonEnrSAVML_Click(object sender, EventArgs e)
        {
            //MessageBox Confirmer
            DialogResult result = MessageBox.Show("Voulez vous modifier le litige n° " + textBoxNumLitSAVML.Text + "dans la base de données ?", "Confirmer", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                //Création d'une requête SQL qui vav permettre la mise à jour des données d'un ticket via la classe ConnexionBD
                string req = "UPDATE LITIGE SET COMMENTAIRE = '" + textBoxCommSAVML.Text + "',NOTE = '" + textBoxNoteSaVML.Text + "',STATUT ='" + comboBoxStatSAVML.SelectedItem.ToString() + "' WHERE idlit = " + textBoxNumLitSAVML.Text;
                ConnexionBD objConn = new ConnexionBD(req);
                objConn.ExecuteIUD();

                //Retour vers l'accueil
                this.Close();
                Accueil objF = new Accueil();
                objF.Show();
            }
            //MessageBox indiquant que la mise à jour n'a pas été effectué
            else
            {
                MessageBox.Show("Le litige n° " + textBoxNumLitSAVML.Text + " n'a pas était modifié");

                //Retour vers l'accueil
                this.Close();
                Accueil objF = new Accueil();
                objF.Show();
            }
        }

        private void buttonCanSAVML_Click(object sender, EventArgs e)
        {
            this.Close();
            Accueil ObjF = new Accueil();
            ObjF.Show();
        }
    }
}
