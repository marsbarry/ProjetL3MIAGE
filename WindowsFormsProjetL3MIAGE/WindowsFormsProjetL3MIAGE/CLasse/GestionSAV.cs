using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace WindowsFormsProjetL3MIAGE.CLasse
{
    class GestionSAV
    {
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

    }
}
