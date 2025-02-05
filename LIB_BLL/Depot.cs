using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIB_BLL
{
    public class Depot
    {
        private int num;
        private string nomD;
        private string ville;
        private string pays;
        private string longitude;
        private string latitude;

        public Depot(int num, string nomD, string ville, string pays, string longitude, string latitude)
        {
            this.num = num;
            this.nomD = nomD;
            this.ville = ville;
            this.pays = pays;
            this.longitude = longitude;
            this.latitude = latitude;
        }

        public int getNum()
        {
            return num;
        }

        public void setNum(int num)
        {
            this.num = num;
        }

        public string getNomD()
        {
            return nomD;
        }

        public void setNom(string nomD)
        {
            this.nomD = nomD;
        }

        public string getVille()
        {
            return ville;
        }

        public void setVille(string ville)
        {
            this.ville = ville;
        }

        public string getPays()
        {
            return pays;
        }

        public void setPays(string pays)
        {
            this.pays = pays;
        }

        public string getLongitude()
        {
            return longitude;
        }

        public void setLongitude(string longitude)
        {
            this.longitude = longitude;
        }

        public string getLatitude()
        {
            return latitude;
        }

        public void setLatitude(string latitude)
        {
            this.latitude = latitude;
        }
    }
}

