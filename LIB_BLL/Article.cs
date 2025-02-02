using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIB_BLL
{
    public class Article
    {
        private int id;
        private string referenceA;
        private string libelleA;

        public Article(int id, string referenceA, string libelleA)
        {
            this.id = id;
            this.referenceA = referenceA;
            this.libelleA = libelleA;
        }

        public int getId()
        {
            return id;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public string getReferenceA()
        {
            return referenceA;
        }

        public void setReferenceA(string referenceA)
        {
            this.referenceA = referenceA;
        }

        public string getLibelleA()
        {
            return libelleA;
        }

        public void setLibelleA(string libelleA)
        {
            this.libelleA = libelleA;
        }
    }
}
