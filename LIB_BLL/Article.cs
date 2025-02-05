using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIB_BLL
{
    public class Article
    {
        private int idA;
        private string referenceA;
        private string libelleA;

        public Article(int idA, string referenceA, string libelleA)
        {
            this.idA = idA;
            this.referenceA = referenceA;
            this.libelleA = libelleA;
        }

        public int getIdA()
        {
            return idA;
        }

        public void setIdA(int idA)
        {
            this.idA = idA;
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
