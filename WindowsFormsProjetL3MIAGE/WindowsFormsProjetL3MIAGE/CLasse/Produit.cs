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
        private int StockMini;
        private int StrockOpti;
        private int StockActuel;
        private int StockAttenteFourn;
        private int StockReserv;
        private int PlaceProd;
        private int EtagereProd;
        private int RayonProd;

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
            StockMini = Convert.ToInt32(dtProd.Rows[0]["STOCKMINI"]);
            StrockOpti = Convert.ToInt32(dtProd.Rows[0]["STOCKOPTI"]);
            StockActuel = Convert.ToInt32(dtProd.Rows[0]["STOCKACTUEL"]);
            StockAttenteFourn = Convert.ToInt32(dtProd.Rows[0]["STOCKATTENTEFOURN"]);
            StockReserv = Convert.ToInt32(dtProd.Rows[0]["STOCKRESERV"]);
            PlaceProd = Convert.ToInt32(dtProd.Rows[0]["PLACEPROD"]);
            EtagereProd = Convert.ToInt32(dtProd.Rows[0]["ETAGEREPROD"]);
            RayonProd = Convert.ToInt32(dtProd.Rows[0]["RAYONPROD"]);


        }
        public string GetNomProd()
        {
            return this.NomProd;
        }
    }
}
