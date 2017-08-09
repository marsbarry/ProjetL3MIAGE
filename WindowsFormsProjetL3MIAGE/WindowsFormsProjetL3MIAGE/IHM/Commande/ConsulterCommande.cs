using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsProjetL3MIAGE.IHM
{
    public partial class ConsulterCommande : Form
    {
        public ConsulterCommande()
        {
            InitializeComponent();
        }

        private void labelNumCoCo_Click(object sender, EventArgs e)
        {

        }

        private void ConsulterCommande_Load(object sender, EventArgs e)
        {
            DataTable ObjDt = new DataTable();
            string req = "SELECT IDCMDC FROM COMMANDEC";
            CLasse.ConnexionBD objConn = new CLasse.ConnexionBD(req);
            ObjDt = objConn.ExecuteSelect();

            for (int i = 0; i< ObjDt.Rows.Count; i++)
            {
                comboBoxNumCLiCoCo.Text = ObjDt.Rows[i]["IDCMDC"].ToString();
            }
        }

        private void comboBoxCoCo_SelectedIndexChanged(object sender, EventArgs e)
        {
            CLasse.CommandeC objCMDC = new CLasse.CommandeC(Convert.ToInt32(comboBoxNumCLiCoCo.Text));
            CLasse.Client objCli = new CLasse.Client(Convert.ToInt32(comboBoxNumCLiCoCo.Text));
            textBoxRechNomCliCoCo.Text = objCli.getNomCli();
            textBoxNumCMDCCoCo.Text = objCMDC.GetIdCMDC().ToString();
            textBoxTeCoCo.Text = objCli.getTelCli().ToString();
            textBoxCpCoCo.Text = objCli.getCpCli().ToString();
            textBoxMailCoCo.Text = objCli.getMailCli();
            textBoxAdrCoCo.Text = objCli.getAdrCli();
            textBoxVilleCoCo.Text = objCli.getVille();

        }
    }
}
