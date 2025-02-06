using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIB_BLL
{
    public class MouvementStock
    {
        private int idMS;
        private int numMS;
        private int codeType;
        private DateTime dateHeureMS;
        private string type;
        private float qte;
        private int idArticle;
        private int numDepot;

        public MouvementStock(int idMS, int numMS, int codeType, DateTime dateHeureMS, string type, float qte, int idArticle, int numDepot)
        {
            this.idMS = idMS;
            this.numMS = numMS;
            this.codeType = codeType;
            this.dateHeureMS = dateHeureMS;
            this.type = type;
            this.qte = qte;
            this.idArticle = idArticle;
            this.numDepot = numDepot;
        }

        public int getIdMS()
        {
            return idMS;
        }

        public void setIdMS(int idMS)
        {
            this.idMS = idMS;
        }

        public int getNumMS()
        {
            return numMS;
        }

        public void setNumMS(int numMS)
        {
            this.numMS = numMS;
        }

        public int getCodeType()
        {
            return codeType;
        }

        public void setCodeType(int codeType)
        {
            this.codeType = codeType;
        }

        public DateTime getDateHeureMS()
        {
            return dateHeureMS;
        }

        public void setDateHeureMS(DateTime dateHeureMS)
        {
            this.dateHeureMS = dateHeureMS;
        }

        public string getType()
        {
            return type;
        }

        public void setType(string type)
        {
            this.type = type;
        }

        public float getQte()
        {
            return qte;
        }

        public void setQte(float qte)
        {
            this.qte = qte;
        }

        public int getIdArticle()
        {
            return idArticle;
        }

        public void setIdArticle(int idArticle)
        {
            this.idArticle = idArticle;
        }

        public int getNumDepot()
        {
            return numDepot;
        }

        public void setNumDepot(int numDepot)
        {
            this.numDepot = numDepot;
        }

    }
}
