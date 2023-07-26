using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace HayvanCiftligiDeneme2
{
    abstract class Hayvan
    {
        public abstract int urunUret();//Kalıtım alan sınıflar için abstarct metotu olarak yazdım.
        public abstract int urunSat();//Kalıtım alan sınıflar için abstarct  metotu olarak yazdım.



        private int kasa;
        public int lblkasa
        {
            get
            {
                return kasa;
            }
            set
            {
                kasa = value;
            }
        }

        private int saniye;
        protected int Saniye
        {
            get
            {
                return saniye;
            }
            set
            {
                saniye = value;
            }
        }

        private string durumu;//
        public string Durumu
        {
            get
            {
                return durumu;
            }
            set
            {
                durumu = value;
            }
        }
    }
}