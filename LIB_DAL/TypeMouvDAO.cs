using LIB_BLL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIB_DAL
{
    public class TypeMouvDAO
    {
        public static List<TypeMouv> getTousLesType()
        {
            List<TypeMouv> res = new List<TypeMouv>();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            cmd.Connection = Bdd.getConnexion();
            cmd.CommandText = "select * from Type";
            try
            {
                dr = cmd.ExecuteReader();
                while (dr.Read())

                {
                    TypeMouv tm = new TypeMouv(dr.GetInt32(0), dr.GetString(1));
                    res.Add(tm);
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
