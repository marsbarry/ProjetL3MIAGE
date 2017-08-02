using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace WindowsFormsProjetL3MIAGE.CLasse
{
    class GestionClient
    {
            public static DataTable unCli(int numCli) //renvoi la DataTable contenant les informations d'un client
            {
                DataTable dtTable;
                string Req = "Select * From Client Where IDCLI = " + numCli;
                ConnexionBD uneReq = new ConnexionBD(Req);
                dtTable = uneReq.ExecuteSelect();
                return dtTable;
            }
            public static int MaxCli() //Retourne le numero max des client (+1) 
            {
                int nbmax;
                string req = "Select MAX(numCli) from Client";
                ConnexionBD uneReq = new ConnexionBD(req);
                DataTable DtCliMax = new DataTable();
                DtCliMax = uneReq.ExecuteSelect();
                nbmax = Convert.ToInt16(DtCliMax.Rows[0][0]);
                nbmax = nbmax + 1;
                return nbmax;
            }

            public static void TousLesCLients(System.Windows.Forms.ComboBox box, string NomCli) //Retourne tous les numero, noms, prenom des client que l'on souhaite rechercher et les insére dans une combobox
            {
                string req = "Select NumCli, NomCli, PrenomCli From Client Where NomCli = '" + NomCli + "'";
            ConnexionBD uneReq = new ConnexionBD(req);
                DataTable DtCli = new DataTable();
                DtCli = uneReq.ExecuteSelect();
                foreach (DataRow x in DtCli.Rows)
                {
                    string chaine = x[0] + " " + x[1] + " " + x[2];
                    box.Items.Add(chaine);
                }

            }

            public static void AjoutCli(Client unclient) //Ajoute un client a la BDD
            {

                string req = "Insert into CLIENT values (" + unclient.getNumCli() + ",'" + unclient.getNomCli() + "','" + unclient.getPrenomCli() + "','" + unclient.getAdrCli() + "', '" + unclient.getVille() + "', '" + unclient.getCpCli() + "','" + unclient.getTelCli() + "', '" + unclient.getMailCli() + "')";
                ConnexionBD uneReq = new ConnexionBD(req);
                // uneReq.ExecuteID();
            }


        }
}
