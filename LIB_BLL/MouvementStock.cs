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
        private int num;
        private int codeTypeMS;
        private DateTime dateHeureMS;
        private string type;
        private float qte;
        private int idArticle;
        private int numDepot;

        public MouvementStock(int idMS, int num, int codeTypeMS, DateTime dateHeureMS, string type, float qte, int idArticle, int numDepot)
        {
            this.idMS = idMS;
            this.num = num;
            this.codeTypeMS = codeTypeMS;
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

        public int getNum()
        {
            return num;
        }

        public void setNum(int num)
        {
            this.num = num;
        }

        public int getCodeTypeMS()
        {
            return codeTypeMS;
        }

        public void setCodeTypeMS(int codeTypeMS)
        {
            this.codeTypeMS = codeTypeMS;
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
