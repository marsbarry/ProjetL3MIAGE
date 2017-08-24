using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using WindowsFormsProjetL3MIAGE.IHM;

namespace WindowsFormsProjetL3MIAGE.CLasse
{
    class GestionSAV
    {
        //Permet de récupérer le numéro maximum de litige pour lui ajouter 1 afin d'être sur qu'il n'existe pas un numéro de litige identique dans la BDD
        public int GetMAxId()
        {
            string req = " SELECT MAX(idlit) from litige";
            DataTable dtMaxId;
            ConnexionBD ObjMaxId = new ConnexionBD(req);
            dtMaxId = ObjMaxId.ExecuteSelect();

            int MaxId = Convert.ToInt32(dtMaxId.Rows[0]["MAX(idlit)"]);
            MaxId = MaxId + 1;
            return MaxId;
        }

        public static void AjoutLit(SAV unLit) //Ajoute un litige à la BDD
        {
            string ReqAddLit = "INSERT INTO LITIGE values (" + unLit.getIdlit() + ",'"  + unLit.getComm()+"')" + ",'" + unLit.getNote() + "','" + unLit.getStatut() + "',"+ unLit.getIdCMDC()+")";
            ConnexionBD ObjLit = new ConnexionBD(ReqAddLit);
            ObjLit.ExecuteIUD();
        }

    }
}
