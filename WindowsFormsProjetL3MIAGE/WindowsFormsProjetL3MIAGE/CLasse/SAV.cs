using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace WindowsFormsProjetL3MIAGE.CLasse
{
    class SAV
    {
        private int idLit;      // Id du Litige
        private string commentaire; //COmmentaire sur le problème concernant le litige
        private string note;       // Note concernant l'acttion a réaliser pour clore le litige
        private string statut;      // Statut du litige;
        private int idcommande;     // Id de la commande
        private int idArticle;      // Id de l'article défectueux
        private int idCli;          //Id du client correspondant à la commande
        private int NbLigneAffect;  // Nombre de lignes affectées lors d'un insert dans la base de données.

        /// <summary>
        /// Constructeur pour un litige non existant.
        /// </summary>
        /// <param name="uncomm">Commentaire sur le Litige</param>
        /// <param name="uneNote">Note sur le Litige</param>
        /// <param name="unstatut">Statut du Litige</param>
        /// <param name="unidart"Id de l article porant sur le Litige></param>
        /// <param name="unidcommande">Id de la commande du litige  </param>
        /// <param name="unIdCli">Id du client porant réclamation pour le Litige</param>
       
        public SAV(int unId, int unIdCmdc,string uncomm, string Unenote, string unstatut) // Constructeur pour un litige non existant dans la base de données
        {
            idLit = unId;
            idcommande = unIdCmdc;
            commentaire = uncomm;
            note = Unenote;
            statut = unstatut;
        }


        public SAV(int unId) // Constructeur pour un litige existant dans la base de données.
        {
            string req = "SELECT * FROM LITIGE WHERE IDLIT = " + unId;
            ConnexionBD ObjLitCons1 = new ConnexionBD(req);
            DataTable ObjDTCons = new DataTable();
            ObjDTCons = ObjLitCons1.ExecuteSelect();

            idLit = Convert.ToInt32(ObjDTCons.Rows[0]["IDLIT"]);
            commentaire = ObjDTCons.Rows[0]["COMMENTAIRE"].ToString();
            note = ObjDTCons.Rows[0]["NOTE"].ToString();
            statut = ObjDTCons.Rows[0]["STATUT"].ToString();
            idcommande = Convert.ToInt32(ObjDTCons.Rows[0]["IDCMDC"]);
            idArticle = Convert.ToInt32(ObjDTCons.Rows[0]["IDARTICLE"]);
            idCli = Convert.ToInt32(ObjDTCons.Rows[0]["IDCLIENT"]);

        }

        //Permet de récupérer  l'identidiant du Client
        public int GetIdCli()
        {
            return this.idCli;
        }

        //Permet de récupérer  l'identifiant du litige
        public int getIdlit()
        {
            return this.idLit;
        }

        //Permet de récupérer  le commentaire du ticket
        public string getComm()
        {
            return this.commentaire;
        }

        //Permet de récupérer  la note du ticket
        public string getNote()
        {
            return this.note;
        }

        //Permet de récupérer  le statut du ticket
        public string getStatut()
        {
            return this.statut;
        }
   }
}
