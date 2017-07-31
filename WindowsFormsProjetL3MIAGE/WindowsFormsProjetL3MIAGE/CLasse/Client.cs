using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsProjetL3MIAGE.CLasse
{
    class Client
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

        public Client(int unNum, string unNom, string unPrenom, string uneAdr, string uneVille, int unCP, int unTel, string unMail)
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

        //Fonction get
        public int getNumCli()
        {
            return numCli;
        }
        public string getNomCli()
        {
            return nomCli;
        }
        public string getPrenomCli()
        {
            return prenomCli;
        }
        public string getAdrCli()
        {
            return adrCli;
        }
        public string getVille()
        {
            return villeCli;
        }
        public int getCpCli()
        {
            return cpCli;
        }
        public int getTelCli()
        {
            return telCli;
        }

        public string getMailCli()
        {
            return mailCli;
        }

    }
}
