using LIB_BLL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIB_DAL
{
    public class DepotDAO
    {
        public static List<Depot> getTousLesDepot()
        {
            List<Depot> res = new List<Depot>();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            cmd.Connection = Bdd.getConnexion();
            cmd.CommandText = "SELECT nom, ville, pays, longitude, latitude FROM Depot";
            try
            {
                dr = cmd.ExecuteReader();
                while (dr.Read())

                {
                    Depot d = new Depot(dr.GetString(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4));
                    res.Add(d);
                }

                dr.Close();
                return res;
            }
            catch
            {
                return null;


            }

        }

        public static int creer(Depot d)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Bdd.getConnexion();
            cmd.CommandText = "INSERT INTO Depot VALUES ('" + d.getNomD() + "', '" + d.getVille() + "', '" + d.getPays() + "', '" + d.getLongitude() + "', '" + d.getLatitude() + "')";
            try
            {
                return cmd.ExecuteNonQuery();
            }
            catch
            {
                return 0;


            }
        }

        public static int modifier(Depot d)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Bdd.getConnexion();
            cmd.CommandText = "UPDATE Depot SET ville= '" + d.getVille() + "', pays= '" + d.getPays() + "', longitude= '" + d.getLongitude() + "',latitude= '" + d.getLatitude()  + "' WHERE  nom = '" + d.getNomD() + "';";
            try
            {

                return cmd.ExecuteNonQuery();
            }
            catch
            {
                return 0;


            }
        }

        public static int supprimer(Depot d)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Bdd.getConnexion();
            cmd.CommandText = "DELETE FROM Depot WHERE nom = '" + d.getNomD() + "';";
            try
            {
                return cmd.ExecuteNonQuery();
            }
            catch
            {
                return 0;


            }
        }


    }
}
