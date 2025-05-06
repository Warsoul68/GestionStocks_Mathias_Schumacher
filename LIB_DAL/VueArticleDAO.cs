using LIB_BLL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIB_DAL
{
    public class VueArticleDAO
    {
        public static List<VueArticle> getVueArticleFiltre(string libelleVueVA = "")
        {
            List<VueArticle> res = new List<VueArticle>();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            cmd.Connection = Bdd.getConnexion();
            cmd.CommandText = "SELECT * FROM Vue_Selection_Article WHERE 1=1 ";

            if (libelleVueVA != "") cmd.CommandText += " AND Libellé='" + libelleVueVA + "'";

            try
            {
                dr = cmd.ExecuteReader();
                while (dr.Read())

                {
                    VueArticle va = new VueArticle(dr.GetString(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4), dr.GetString(5));
                    res.Add(va);
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
