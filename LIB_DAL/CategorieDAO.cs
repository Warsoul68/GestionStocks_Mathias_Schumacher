using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LIB_BLL;
using System.Data.SqlClient;

namespace LIB_DAL
{
    public class CategorieDAO
    {
        public static List<Categorie> getTouteLesCategorie()
        {
            List<Categorie> res = new List<Categorie>();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            cmd.Connection = Bdd.getConnexion();
            cmd.CommandText = "select * from Categorie";
            try
            {
                dr = cmd.ExecuteReader();
                while (dr.Read())

                {
                    Categorie c = new Categorie(dr.GetString(0), dr.GetString(1));
                    res.Add(c);
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
