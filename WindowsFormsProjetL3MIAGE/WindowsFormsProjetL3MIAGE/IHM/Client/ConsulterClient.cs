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
            this.Hide();
            Accueil objF = new Accueil();
            objF.Show();
        }

        private void buttonAjCC_Click(object sender, EventArgs e)
        {
            this.Hide();
            Accueil objF = new Accueil();
            objF.Show();
        }

        private void comboBoxNumCliCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            CLasse.Client objCli = new CLasse.Client(Convert.ToInt32(comboBoxNumCliCC.Text));
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
