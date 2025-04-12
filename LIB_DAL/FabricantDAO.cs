using LIB_BLL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIB_DAL
{
    public class FabricantDAO
    {
        public static List<Fabricant> getTousLesFabricant()
        {
            List<Fabricant> res = new List<Fabricant>();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            cmd.Connection = Bdd.getConnexion();
            cmd.CommandText = "select * from Fabricant";
            try
            {
                dr = cmd.ExecuteReader();
                while (dr.Read())

                {
                    Fabricant f = new Fabricant(dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetString(3));
                    res.Add(f);
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
