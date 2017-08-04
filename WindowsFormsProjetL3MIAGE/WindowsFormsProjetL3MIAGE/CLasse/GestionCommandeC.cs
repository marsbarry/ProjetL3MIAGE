using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace WindowsFormsProjetL3MIAGE.CLasse
{
    class GestionCommandeC
    {
        public static int MaxCmd()
        {
            int nbmax;
            string req = "Select MAX(numCmd) from Commande";
            ConnexionBD uneReq = new ConnexionBD(req);
            DataTable DtCmdMax = new DataTable();
            DtCmdMax = uneReq.ExecuteSelect();
            nbmax = Convert.ToInt32(DtCmdMax.Rows[0][0]);
            nbmax = nbmax + 1;
            return nbmax;
        }
    }
}
