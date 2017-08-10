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
        private object comboBoxCoCo;

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
                comboBoxNumCLiCoCo.Items.Add(ObjDt.Rows[i]["IDCMDC"]);
            }
        }

        private void comboBoxCoCo_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable objdt1 = new DataTable();
            string unereq = "SELECT * FROM CLIENT,COMMANDEC WHERE COMMANDEC.IDCLI = CLIENT.IDCLI AND COMMANDEC.IDCMDC =" + comboBoxNumCLiCoCo.Text;
            CLasse.ConnexionBD objConn1 = new CLasse.ConnexionBD(unereq);
            objdt1 = objConn1.ExecuteSelect();

            CLasse.CommandeC objCMDC = new CLasse.CommandeC(Convert.ToInt32(comboBoxNumCLiCoCo.Text));
            textBoxNumCMDCCoCo.Text = objCMDC.GetIdCMDC().ToString();

            textBoxRechNomCliCoCo.Text = objdt1.Rows[0]["NOMCLI"].ToString();
            textBoxTeCoCo.Text = objdt1.Rows[0]["TELCLI"].ToString();
            textBoxCpCoCo.Text = objdt1.Rows[0]["CPCLI"].ToString();
            textBoxMailCoCo.Text = objdt1.Rows[0]["MAILCLI"].ToString();
            textBoxAdrCoCo.Text = objdt1.Rows[0]["ADRCLI"].ToString();
            textBoxVilleCoCo.Text = objdt1.Rows[0]["VILLECLI"].ToString();

        }
    }
}
