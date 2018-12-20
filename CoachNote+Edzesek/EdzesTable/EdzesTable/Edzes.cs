using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdzesekGridView
{
    class Edzes
    {
        private int edzesid;
        private DateTime edzesidopont;
        private string nap;
        private string tipus;
        private string helyszin;
        private bool megtartva;
        public Edzes(int edzesid, DateTime edzesidopont, string nap, string tipus, string helyszin, bool megtartva)
        {
            this.edzesid = edzesid;
            this.edzesidopont = edzesidopont;
            this.nap = nap;
            this.tipus = tipus;
            this.helyszin = helyszin;
            this.megtartva = megtartva;
        }
        public int getEdzesId()
        {
            return edzesid;
        }
        public DateTime getEdzesIdopont()
        {
            return edzesidopont;
        }
        public void setMeccsIdopont(DateTime edzesidopont)
        {
            this.edzesidopont = edzesidopont;
        }
        public string getNap()
        {
            return nap;
        }
        public void setNap(string nap)
        {
            this.nap = nap;
        }
        private string getTipus()
        {
            return tipus;
        }
        private void setTipus(string tipus)
        {
            this.tipus = tipus;
        }
        private string getHelyszin()
        {
            return helyszin;
        }
        private void setHelyszin(string helyszin)
        {
            this.helyszin = helyszin;
        }
        private bool getMegtartva()
        {
            return megtartva;
        }
        private void setMegtartva(bool megtartva)
        {
            this.megtartva = megtartva;
        }
    }
}
