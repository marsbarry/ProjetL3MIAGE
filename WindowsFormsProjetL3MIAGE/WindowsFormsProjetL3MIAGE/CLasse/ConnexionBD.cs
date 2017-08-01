using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using System.Windows.Forms;

namespace WindowsFormsProjetL3MIAGE.CLasse
{
    class ConnexionBD
    {
        private string Req;
        private int Nb1;
        private static OracleConnection Conn = new OracleConnection();
        private static bool ConnOk;
        OracleCommand Cmd = new OracleCommand();

        public ConnexionBD(string uneReq) //Contructeur
        {
            Req = uneReq;
        }

        public DataTable ExecuteSelect() //Fonction pour executer une requete de type Select
        {

            DataSet Ds = new DataSet();
            DataTable Dt = new DataTable();
            OracleDataAdapter ObjDa = new OracleDataAdapter();
            Conn.Open();
            Cmd.CommandText = Req;
            Cmd.Connection = Conn;
            ObjDa.SelectCommand = Cmd;

            try
            {
                Nb1 = ObjDa.Fill(Ds, "Liste");
                Dt = Ds.Tables["Liste"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur dans la requête SQL : " + ex.Message);
            }


            Conn.Close();
            Nb1 = Dt.Rows.Count;
            return Dt;

        }

        public int ExecuteIUD()  //Fonction pour executer une requete de type Insert/Update/Delete
        {
            Cmd.CommandText = Req;
            try
            {
                Cmd.Connection = Conn;
                Conn.Open();
                Nb1 = Cmd.ExecuteNonQuery();
                Conn.Close();
                MessageBox.Show("Mise à jour effectuée");
            }
            catch (Exception e)
            {
                MessageBox.Show("Erreur mise à jour : " + e.Message);

            }
            return Nb1;
        }

        public static void Connecter(string IdUtilusateur, string MdpUtilisateur)  //Fonction pour se connecter a la BDD
        {
            string ChaineConn = "Data Source=(DESCRIPTION=";
            ChaineConn = ChaineConn + "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))";
            ChaineConn = ChaineConn + "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe)));";
            ChaineConn = ChaineConn + "User Id=" + IdUtilusateur + ";Password=" + MdpUtilisateur + ";";

            Conn.ConnectionString = ChaineConn;
            try
            {
                Conn.Open();
                Conn.Close();
                ConnOk = true;
                MessageBox.Show("Connection marche");
            }
            catch (Exception)
            {
                ConnOk = false;
                MessageBox.Show("Connection marche pas");

            }

        }

        public static bool GetConnOK() //Renvoie la private de connection
        {
            return ConnOk;
        }
    }
}
