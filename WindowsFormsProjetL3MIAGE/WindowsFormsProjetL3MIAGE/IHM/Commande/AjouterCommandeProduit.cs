using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsProjetL3MIAGE.IHM.Ajouter_Commande
{
    public partial class AjouterCommandeProduit : Form
    {
        public AjouterCommandeProduit()
        {
            InitializeComponent();
        }

        private void buttonCanACP_Click(object sender, EventArgs e)
        {
            this.Close();
            Accueil objF = new Accueil();
            objF.Show();
        }

        private void buttonEnrACP_Click(object sender, EventArgs e)
        {

        }
    }
}
