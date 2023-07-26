using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanCiftligiDeneme2
{
    internal class Keci:Hayvan
    {
        private int keciSutu;  //Süt litresi için.

        public override int urunSat()
        {
            lblkasa += keciSutu * 5;
            return keciSutu = 0;

        }

        public override int urunUret()
        {
            Saniye++;
            if (Saniye % 8 == 0)
            {
                keciSutu++;
            }

            return keciSutu;
        }

    }
}

