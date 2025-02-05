using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIB_BLL
{
    public class Utilisateur
    {
        private int idU;
        private string nomU;
        private string pass;

        public Utilisateur(int idU, string nomU, string pass)
        {
            this.idU = idU;
            this.nomU = nomU;
            this.pass = pass;
        }

        public int getIdU()
        {
            return idU;
        }

        public void setIdU(int idU)
        {
            this.idU = idU;
        }

        public string getNomU()
        {
            return nomU;
        }

        public void setNomU(string nomU)
        {
            this.nomU = nomU;
        }

        public string getPass()
        {
            return pass;
        }

        public void setPass(string pass)
        {
            this.pass = pass;
        }
    }
}
