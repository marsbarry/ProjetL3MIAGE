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
        int idcli;
        int IdCmdc; // Le numéro de la commande.
        int idRegl;
        int IdLit;
        string Statut; //Le statut de la commande ("en cours","terminer"...)
        int DateCom; // Date a laquelle la commande à etait effectué.
        int DateLiv; // Date a laquelle la commande fut livré.

        public CommandeC(int UnID)

        {

            DataTable dtTable;
            string Req = "Select * From CommandeC Where IDCMDC = " + UnID;
            ConnexionBD uneReq = new ConnexionBD(Req);

            dtTable = uneReq.ExecuteSelect();

            IdCmdc = Convert.ToInt32(dtTable.Rows[0][0]);
            Statut = Convert.ToString(dtTable.Rows[0][1]);
            DateCom = Convert.ToInt32(dtTable.Rows[0][2]);
            DateLiv = Convert.ToInt32(dtTable.Rows[0][3]);

        }

        public int GetIdCMDC()
        {
            return this.IdCmdc;
        }

        public string GetStatut()
        {
            return this.Statut;
        }

        public int GetDate()
        {
            return this.DateCom;
        }

        public int GetDateLiv()
        {
            return this.DateLiv;
        }
    }
}
