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
    public partial class SAV : Form
    {
        private int v1;
        private string text1;
        private string text2;
        private string v2;

        public SAV()
        {
            InitializeComponent();
        }

        public SAV(int v1, string text1, string text2, string v2)
        {
            this.v1 = v1;
            this.text1 = text1;
            this.text2 = text2;
            this.v2 = v2;
        }

        private void SAV_Load(object sender, EventArgs e)
        {
            string requete = "SELECT IDCLI from client";
            DataTable DtCOns = new DataTable();
            ConnexionBD ObjCons = new ConnexionBD(requete);
            DtCOns = ObjCons.ExecuteSelect();
            foreach (DataRow row in DtCOns.Rows)
            {
                comboBoxNumSAV.Items.Add(row[0]);
            }
        }

        private void comboBoxNumSAV_SelectedIndexChanged(object sender, EventArgs e)
        {
            CLasse.Client NewCli = new CLasse.Client(Convert.ToInt32(comboBoxNumSAV.SelectedItem));
            textBoxNomSAV.Text = NewCli.getNomCli();
            textBoxPreSAV.Text = NewCli.getPrenomCli();
            textBoxAdrSAV.Text = NewCli.getAdrCli();
            textBoxVilleSAV.Text = NewCli.getVille().ToString();
            textBoxCPSAV.Text = NewCli.getCpCli().ToString();
            textBoxPreSAV.Text = NewCli.getTelCli().ToString();
            textBoxMailSAV.Text = NewCli.getMailCli().ToString();
            textBoxTelSAV.Text = NewCli.getTelCli().ToString();

            int Idcli = Convert.ToInt32(comboBoxNumSAV.SelectedItem);
            string requete = "Select COMMANDEC_2.IDCMDC from CommandeC, COMMANDEC_2 where COMMANDEC_2.IDCMDC = COMMANDEC.IDCMDC AND COMMANDEC_2.IDCLI =" + Idcli;
            DataTable DtCOns = new DataTable();
            ConnexionBD ObjCons = new ConnexionBD(requete);
            DtCOns = ObjCons.ExecuteSelect();

            foreach (DataRow row in DtCOns.Rows)
            {
                comboBoxNumCmdSAV.Items.Add(row[0]);
            }
        }

        private void comboBoxArtSAV_SelectedIndexChanged(object sender, EventArgs e)
        {
            int IdProd = Convert.ToInt32(comboBoxArtSAV.SelectedItem);
            string ReqNomProd = "select NOMPROD,PRIXPROD, COULEURPROD from produit where produit.idproduit = " + IdProd;
            DataTable DtArt = new DataTable();
            ConnexionBD ObjArt = new ConnexionBD(ReqNomProd);
            DtArt = ObjArt.ExecuteSelect();

            textBoxNomProdSAV.Text = DtArt.Rows[0]["NOMPROD"].ToString();
            textBoxCouProSAV.Text = DtArt.Rows[0]["COULEURPROD"].ToString();
            textBoxPrixProdSAV.Text = DtArt.Rows[0]["PRIXPROD"].ToString();


            textBoxNomCliSAV.Text = textBoxNomSAV.Text;
            NomCliSAV2.Text = textBoxNomSAV.Text;
            GestionSAV OUi = new GestionSAV();
            textBoxNumLitSAV.Text = OUi.GetMAxId().ToString();
        }

        private void buttonOkSAV_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Voulez vous ajoutez le litige n° " + textBoxNumLitSAV.Text + " dans la base de données ?", "Confirmer", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                CLasse.SAV NewLit = new CLasse.SAV(Convert.ToInt32(textBoxNumLitSAV.Text),Convert.ToInt32(comboBoxNumCmdSAV.SelectedItem), textBoxCommSAV.Text, textBoxNoteSaV.Text, comboBoxStatSAV.SelectedItem.ToString());
                GestionSAV.AjoutLit(NewLit);

                this.Close();
                Accueil Oui = new Accueil();
                Oui.Show();
            }
            else
            {
                MessageBox.Show("Le litige n° " + textBoxNumLitSAV.Text + " n'a pas était ajouté");
            }
        }

        private void buttonCanSAV_Click(object sender, EventArgs e)
        {
            this.Close();
            Accueil Oui = new Accueil();
            Oui.Show();
        }

        private void comboBoxNumCmdSAV_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Idcmdc = Convert.ToInt32(comboBoxNumCmdSAV.SelectedItem);
            string Unerequete = "select produit.idproduit from produit , COMMANDEC , COMMANDEC_2 where PRODUIT.IDPRODUIT = COMMANDEC_2.IDPRODUIT and COMMANDEC_2.IDCMDC = COMMANDEC.IDCMDC and COMMANDEC_2.IDCMDC =" + Idcmdc;
            DataTable DtCOMM = new DataTable();
            ConnexionBD ObjCons = new ConnexionBD(Unerequete);
            DtCOMM = ObjCons.ExecuteSelect();
            foreach (DataRow row in DtCOMM.Rows)
            {
                comboBoxArtSAV.Items.Add(row[0]);
            }
        }

        private void comboBoxStatSAV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
