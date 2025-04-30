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
            cmd.CommandText = "SELECT reference_, libelle, codeUnite, codeCategorie, idFabricant FROM dbo.Article";
            try
            {
                dr = cmd.ExecuteReader();
                while (dr.Read())

                {
                    Article a = new Article(dr.GetString(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetInt32(4));
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

        public static int creer(Article a)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Bdd.getConnexion();
            cmd.CommandText = "INSERT INTO Article VALUES ('" + a.getReferenceA() + "', '" + a.getLibelleA() + "', '" + a.getCodeUnite() + "', '" + a.getCodeCategorie() + "', '" + a.getIdFabricant() + "')";
            try
            {
                return cmd.ExecuteNonQuery();
            }
            catch
            {
                return 0;


            }
        }

        public static int modifier(Article a)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Bdd.getConnexion();
            cmd.CommandText = "UPDATE Article SET libelle = '" + a.getLibelleA() + "', codeUnite= " + a.getCodeUnite() + ", codeCategorie= " + a.getCodeCategorie() + ", idFabricant= " + a.getIdFabricant() +  " WHERE  reference_ = '" + a.getReferenceA() + "';";
            try
            {

                return cmd.ExecuteNonQuery();
            }
            catch
            {
                return 0;


            }
        }

        public static int supprimer(Article a)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Bdd.getConnexion();
            cmd.CommandText = "DELETE FROM Article WHERE libelle = '" + a.getLibelleA() + "';";
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
