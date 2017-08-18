using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace WindowsFormsProjetL3MIAGE.CLasse
{
    public class Client
    {
        //Propriété
        private int numCli;
        private string nomCli;
        private string prenomCli;
        private string adrCli;
        private string villeCli;
        private int cpCli;
        private int telCli;
        private string mailCli;

        public Client(int unNum, string unNom, string unPrenom, int unTel, string uneAdr, int unCP, string uneVille , string unMail)
        {
            //Constructeur nouveaux client
            numCli = unNum;
            nomCli = unNom;
            prenomCli = unPrenom;
            adrCli = uneAdr;
            villeCli = uneVille;
            cpCli = unCP;
            telCli = unTel;
            mailCli = unMail;
        }
        public Client(int unNum)
        {
            //Constructeur client deja present dans la base de données

            DataTable DataClient = new DataTable();
            DataClient = GestionClient.unCli(unNum);
            numCli = Convert.ToInt32(DataClient.Rows[0][0]);
            nomCli = Convert.ToString(DataClient.Rows[0][1]);
            prenomCli = Convert.ToString(DataClient.Rows[0][2]);
            telCli = Convert.ToInt32(DataClient.Rows[0][3]);
            adrCli = Convert.ToString(DataClient.Rows[0][4]);
            cpCli = Convert.ToInt32(DataClient.Rows[0][5]);
            villeCli = Convert.ToString(DataClient.Rows[0][6]);
            mailCli = Convert.ToString(DataClient.Rows[0][7]);

        }

        //Permet de récupérer le numéro du Client
        public int getNumCli()
        {
            return numCli;
        }

        //Permet de récupérer le nom du Client
        public string getNomCli()
        {
            return nomCli;
        }

        //Permet de récupérer le prénom du Client
        public string getPrenomCli()
        {
            return prenomCli;
        }

        //Permet de récupérer l'adresse du Client
        public string getAdrCli()
        {
            return adrCli;
        }

        //Permet de récupérer  la ville du Client
        public string getVille()
        {
            return villeCli;
        }

        //Permet de récupérer  le code postal du CLient
        public int getCpCli()
        {
            return cpCli;
        }

        //Permet de récupérer le numéro de téléphone du CLient
        public int getTelCli()
        {
            return telCli;
        }

        //Permet de récupérer  l'adresse mail du Client
        public string getMailCli()
        {
            return mailCli;
        }

    }
}
