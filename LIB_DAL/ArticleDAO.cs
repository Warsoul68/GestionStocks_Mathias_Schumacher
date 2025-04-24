using LIB_BLL;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace LIB_DAL
{
    public class ArticleDAO
    {
        public static List<Article> getTouteLesArticle()
        {
            List<Article> res = new List<Article>();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            cmd.Connection = Bdd.getConnexion();
            cmd.CommandText = "select * from Article";
            try
            {
                dr = cmd.ExecuteReader();
                while (dr.Read())

                {
                    Article a = new Article(dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4), dr.GetInt32(5));
                    res.Add(a);
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
