using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIB_BLL
{
    public class MouvementStock
    {
        private int idMouvStock;
        private int numDepot;
        private int codeTypeMS;
        private DateTime dateHeureMS;
        private float qte;

        public MouvementStock(int idMouvStock, int codeTypeMS, DateTime dateHeureMS, float qte, int numDepot)
        {
            this.idMouvStock = idMouvStock;
            this.numDepot = numDepot;
            this.codeTypeMS = codeTypeMS;
            this.dateHeureMS = dateHeureMS;
            this.qte = qte;
        }

        public int getIdMouvStock()
        {
            return idMouvStock;
        }

        public void setIdMouvStock(int idMouvStock)
        {
            this.idMouvStock = idMouvStock;
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

        public float getQte()
        {
            return qte;
        }

        public void setQte(float qte)
        {
            this.qte = qte;
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
