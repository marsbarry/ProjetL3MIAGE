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
        public SAV()
        {
            InitializeComponent();
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
           
        }
    }
}
