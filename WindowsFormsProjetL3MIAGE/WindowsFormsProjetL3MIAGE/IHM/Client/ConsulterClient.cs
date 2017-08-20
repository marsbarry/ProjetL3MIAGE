using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace WindowsFormsProjetL3MIAGE.IHM.Client
{
    public partial class ConsulterUnClient : Form
    {
        public ConsulterUnClient()
        {
            InitializeComponent();
        }

        private void ConsulterClient_Load(object sender, EventArgs e)
        {
            //Création d'une datatable qui vas contenir les données récupérer par la requête SQL éxecuter via la classe ConnexionBD
            DataTable dtTable = new DataTable();
            string Req = "SELECT IDCLI FROM CLIENT";
            CLasse.ConnexionBD uneReq = new CLasse.ConnexionBD(Req);
            dtTable = uneReq.ExecuteSelect();
          
            for (int j = 0; j < dtTable.Rows.Count; j++)
            {
                comboBoxNumCliCC.Items.Add(dtTable.Rows[j]["IDCLI"]);
            }

        }

        private void buttonCanCC_Click(object sender, EventArgs e)
        {
          
        }


        //Permet de revenir à l'accueil
        private void buttonAjCC_Click(object sender, EventArgs e)
        {
            this.Hide();
            Accueil objF = new Accueil();
            objF.Show();
        }

        private void comboBoxNumCliCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Création d'un objet Client qui vas permettre l'affichage des données de celui-ci dans l'IHM
            CLasse.Client objCli = new CLasse.Client(Convert.ToInt32(comboBoxNumCliCC.Text));

            //Affichage dans les textbox des informations client via l'objet client
            textBoxNomCC.Text = objCli.getNomCli();
            textBoxPreCC.Text = objCli.getPrenomCli();
            textBoxAdrCC.Text = objCli.getAdrCli();
            textBoxVilleCC.Text = objCli.getVille();
            textBoxCpCC.Text = objCli.getCpCli().ToString();
            textBoxTelCC.Text = objCli.getTelCli().ToString();
            textBoxMailCC.Text = objCli.getMailCli();

        }
    }
}
