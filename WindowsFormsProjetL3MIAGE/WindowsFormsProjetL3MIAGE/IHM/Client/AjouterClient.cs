using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsProjetL3MIAGE
{
    public partial class AjouterUnCLient : Form
    {
        public AjouterUnCLient()
        {
            InitializeComponent();
        }

        private void buttonCanAc_Click(object sender, EventArgs e)
        {
            this.Close();
            Accueil ObjF = new Accueil();
            ObjF.Show();
        }
    }
}
