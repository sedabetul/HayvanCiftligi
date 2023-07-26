using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace HayvanCiftligiDeneme2
{
    internal class Inek:Hayvan
    {
       
        private int inekSutu;  //Süt litresi için.
       
        public override int urunSat()
        {
            lblkasa += inekSutu * 5;
            return inekSutu = 0;

        }

        public override int urunUret()
        {
            Saniye++;
            if (Saniye % 8 == 0)
            {
                inekSutu++;
            }

            return inekSutu;
        }

       


    }
}

