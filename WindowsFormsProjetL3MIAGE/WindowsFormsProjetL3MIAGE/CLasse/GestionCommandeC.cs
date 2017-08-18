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
        //Permet de récupérer le numéro maximu des commandes et lui ajoute 1 pour être sur de ne pas ajouter un numéro de commande existant
        public static int MaxCmd()
        {
            int nbmax;
            string req = "Select MAX(idCmdc) from CommandeC";
            ConnexionBD uneReq = new ConnexionBD(req);
            DataTable DtCmdMax = new DataTable();
            DtCmdMax = uneReq.ExecuteSelect();
            nbmax = Convert.ToInt32(DtCmdMax.Rows[0][0]);
            nbmax = nbmax + 1;
            return nbmax;
        }
    }
}
