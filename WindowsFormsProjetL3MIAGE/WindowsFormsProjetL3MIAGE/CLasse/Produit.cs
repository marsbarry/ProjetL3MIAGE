using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace WindowsFormsProjetL3MIAGE.CLasse
{
    class Produit
    {
        private int IdProduit;
        private int IdTypeProd;
        private int IdFourn;
        private string NomProd;
        private double PrixProd;
        private string CouleurProd;


        public Produit(int unidprod)
        {
            DataTable dtProd;
            string req = "Select * FROM produit WHERE idproduit = " + unidprod;
            ConnexionBD ObjProd = new ConnexionBD(req);
            dtProd = ObjProd.ExecuteSelect();

            IdTypeProd = Convert.ToInt32(dtProd.Rows[0]["IDTYPEPROD"]);
            IdFourn = Convert.ToInt32(dtProd.Rows[0]["IDFOURN"]);
            NomProd = dtProd.Rows[0]["NOMPROD"].ToString();
            PrixProd = Convert.ToDouble(dtProd.Rows[0]["PRIXPROD"]);
            CouleurProd = dtProd.Rows[0]["COULEURPROD"].ToString();

        }
        public string GetNomProd()
        {
            return this.NomProd;
        }
    }
}
