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
using WindowsFormsProjetL3MIAGE.IHM.Ajouter_Commande;

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
            
            textBoxNumCMD.Text = GestionCommandeC.MaxCmd().ToString(); //A l'ouverture, le numerod e commande est automatiquement rempli
            DataTable objdt = new DataTable();
            string req = "SELECT IDCLI FROM CLIENT";
            ConnexionBD objConn = new ConnexionBD(req);
            objdt = objConn.ExecuteSelect();
            for(int i = 0;i < objdt.Rows.Count; i++)
            {
                comboBoxChoiCli.Items.Add(objdt.Rows[i]["IDCLI"]);
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
            AjouterCommandeProduit objF = new AjouterCommandeProduit();
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
    }
}
