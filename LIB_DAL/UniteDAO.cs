using LIB_BLL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIB_DAL
{
    public class UniteDAO
    {
        public static List<Unite> getTouteLesUnites()
        {
            List<Unite> res = new List<Unite>();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            cmd.Connection = Bdd.getConnexion();
            cmd.CommandText = "select * from Unite";
            try
            {
                dr = cmd.ExecuteReader();
                while (dr.Read())

                {
                    Unite u = new Unite(dr.GetString(0), dr.GetString(1));
                    res.Add(u);
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
