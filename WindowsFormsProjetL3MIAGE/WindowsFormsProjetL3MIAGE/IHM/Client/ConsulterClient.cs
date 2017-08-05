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
                comboBoxNumCliCC.Text = dtTable.Rows[j]["IDCLI"].ToString();
            }

        }
    }
}
