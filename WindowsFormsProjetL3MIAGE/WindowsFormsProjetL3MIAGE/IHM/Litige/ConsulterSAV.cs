﻿using System;
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
    public partial class ConsulterSAV : Form
    {
        public ConsulterSAV()
        {
            InitializeComponent();
        }

        private void comboBoxNumSAVCL_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Création d'un objet client via l'id selectionné dans la combobox
            CLasse.Client NewCli = new CLasse.Client(Convert.ToInt32(comboBoxNumSAVCL.SelectedItem));

            //Affichage des données du client créé
            textBoxNomSAVCL.Text = NewCli.getNomCli();
            textBoxPreSAVCL.Text = NewCli.getPrenomCli();
            textBoxAdrSAVCL.Text = NewCli.getAdrCli();
            textBoxVilleSAVCL.Text = NewCli.getVille().ToString();
            textBoxCPSAVCL.Text = NewCli.getCpCli().ToString();
            textBoxTelSAVCL.Text = NewCli.getTelCli().ToString();
            textBoxMailSAVCL.Text = NewCli.getMailCli().ToString();
            textBoxTelSAVCL.Text = NewCli.getTelCli().ToString();

            //Création d'une datatable contenant le/les ID des commandes d'un client
            int Idcli = Convert.ToInt32(comboBoxNumSAVCL.SelectedItem);
            string requete = "Select COMMANDEC_2.IDCMDC from CommandeC, COMMANDEC_2 where COMMANDEC_2.IDCMDC = COMMANDEC.IDCMDC AND COMMANDEC_2.IDCLI =" + Idcli;
            DataTable DtCOns = new DataTable();
            ConnexionBD ObjCons = new ConnexionBD(requete);
            DtCOns = ObjCons.ExecuteSelect();

            //Affichage de ce(s) Id
            foreach (DataRow row in DtCOns.Rows)
            {
                comboBoxNumCmdSAVCL.Items.Clear();
                comboBoxNumCmdSAVCL.Items.Add(row[0]);
            }

        }

        private void ConsulterSAV_Load(object sender, EventArgs e)
        {
            //Création d'une datatable contenant le(s) ID de(s) client(s) ayant ouvert un ticket
            string requete = "SELECT CLIENT.IDCLI from client,COMMANDEC,LITIGE where client.idcli = commandec.idcli and commandec.idcmdc = litige.idcmdc";
            DataTable DtCOns = new DataTable();
            ConnexionBD ObjCons = new ConnexionBD(requete);
            DtCOns = ObjCons.ExecuteSelect();

            //Affichage de ce(s) Id
            foreach (DataRow row in DtCOns.Rows)
            {
                comboBoxNumSAVCL.Items.Add(row[0]);
            }
        }

        private void comboBoxNumCmdSAVCL_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Création d'une datatable contenant l'Id produit d'une commande
            int Idcmdc = Convert.ToInt32(comboBoxNumCmdSAVCL.SelectedItem);
            string Unerequete = "select produit.idproduit from produit , COMMANDEC , COMMANDEC_2 where PRODUIT.IDPRODUIT = COMMANDEC_2.IDPRODUIT and COMMANDEC_2.IDCMDC = COMMANDEC.IDCMDC and COMMANDEC_2.IDCMDC =" + Idcmdc;
            DataTable DtCOMM = new DataTable();
            ConnexionBD ObjCons = new ConnexionBD(Unerequete);
            DtCOMM = ObjCons.ExecuteSelect();
            
            //Affichage de l'id récupéré
            textBoxNumProdCL.Text = DtCOMM.Rows[0][0].ToString();

            //Création d'une dataatable contenant le nom,prix et couleur du produit selectionné
            int IdProd = Convert.ToInt32(textBoxNumProdCL.Text);
            string ReqNomProd = "select NOMPROD,PRIXPROD, COULEURPROD from produit where produit.idproduit = " + IdProd;
            DataTable DtArt = new DataTable();
            ConnexionBD ObjArt = new ConnexionBD(ReqNomProd);
            DtArt = ObjArt.ExecuteSelect();
            
            //Affichage de ces données
            textBoxNomProdSAVCL.Text = DtArt.Rows[0]["NOMPROD"].ToString();
            textBoxCouProSAVCL.Text = DtArt.Rows[0]["COULEURPROD"].ToString();
            textBoxPrixProdSAVCL.Text = DtArt.Rows[0]["PRIXPROD"].ToString();

            
            textBoxNomCliSAVCL.Text = textBoxNomSAVCL.Text;
            NomCliSAV2CL.Text = textBoxNomSAVCL.Text;

            //Création d'une datatable contenant l'id, le commentaire, la note et le statut d'un ticket
            int idcmdc = Convert.ToInt32(comboBoxNumCmdSAVCL.SelectedItem);
            string uneReq = "SELECT IDLIT,COMMENTAIRE,NOTE,STATUT FROM LITIGE WHERE IDCMDC = " +idcmdc;
            ConnexionBD objConnLit = new ConnexionBD(uneReq);
            DataTable objDtLit = new DataTable();
            objDtLit = objConnLit.ExecuteSelect();

            //Affichage de ces données
            textBoxNumLitSAVCL.Text = objDtLit.Rows[0]["IDLIT"].ToString();
            textBoxCommSAVCL.Text = objDtLit.Rows[0]["COMMENTAIRE"].ToString();
            textBoxNoteSaVCL.Text = objDtLit.Rows[0]["NOTE"].ToString();
            textBoxStatSAVCL.Text = objDtLit.Rows[0]["STATUT"].ToString();
        }

        private void textBoxCommSAVCL_TextChanged(object sender, EventArgs e)
        {

        }

        //Retour vers l'accueil
        private void buttonTerminerSAVCL_Click(object sender, EventArgs e)
        {
            this.Close();
            Accueil objF = new Accueil();
            objF.Show();
        }
    }
}
