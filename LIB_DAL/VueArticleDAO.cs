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
        public static List<VueArticle> getCategorieFiltres(string categorieVa)
        {
            List<VueArticle> articles = new List<VueArticle>();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Bdd.getConnexion();
            cmd.CommandText = "SELECT * FROM Vue_Selection_Article WHERE Catégorie = " + "'" + categorieVa + "'";

            try
            {
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        VueArticle va = new VueArticle(
                            dr.GetString(0),
                            dr.GetString(1),
                            dr.GetString(2),
                            dr.GetString(3),
                            dr.GetString(4)
                        );

                        articles.Add(va);

                    }

                }
            }
            catch
            {
                // Tu peux logguer l'erreur ici
            }

            return articles;
        }
    }
}
