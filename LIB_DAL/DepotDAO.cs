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
            cmd.CommandText = "select * from Depot";
            try
            {
                dr = cmd.ExecuteReader();
                while (dr.Read())

                {
                    Depot d = new Depot(dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4), dr.GetString(5));
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
    }
}
