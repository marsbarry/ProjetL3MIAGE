using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace WindowsFormsProjetL3MIAGE.CLasse
{
    class CommandeC
    {
        int idcli; // le numéro du Client
        int IdCmdc; // Le numéro de la commande.
        int DateCom; // Date a laquelle la commande à etait effectué.
        int DateLiv; // Date a laquelle la commande fut livré.

        public CommandeC(int UnID)

        {

            DataTable dtTable;
            string Req = "Select * From CommandeC Where IDCMDC = " + UnID;
            ConnexionBD uneReq = new ConnexionBD(Req);

            dtTable = uneReq.ExecuteSelect();

            IdCmdc = Convert.ToInt32(dtTable.Rows[0]["IDCMDC"]);
            idcli = Convert.ToInt32(dtTable.Rows[0]["IDCLI"]);
        //    DateCom = Convert.ToInt32(dtTable.Rows[0]["DATECMDC"]);
        //    DateLiv = Convert.ToInt32(dtTable.Rows[0]["DATERECEPTC"]);

        }

        //Permet de récupérer le numéro de commande
        public int GetIdCMDC()
        {
            return this.IdCmdc;
        }

        //Permet de récupérer la date de la commande
        public int GetDate()
        {
            return this.DateCom;
        }

        //Permet de récupérer la date de livraison
        public int GetDateLiv()
        {
            return this.DateLiv;
        }
    }
}
