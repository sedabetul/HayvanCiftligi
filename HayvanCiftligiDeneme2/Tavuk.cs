using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanCiftligiDeneme2
{
 
        internal class Tavuk : Hayvan
        {
            private int tavukYumurtası = 0;

            public int lblkasa { get; private set; }

            public override int urunSat()// urunu gerekli işlem yaparak kasaya aktarır.
            {
                lblkasa += tavukYumurtası * 1;
                return tavukYumurtası = 0;
            }


            public override int urunUret()// Gerekli işlem yapılarak saniyeye göre yumurta artırılır.
            {
                Saniye++;
                if (Saniye % 3 == 0)
                {
                    tavukYumurtası++;
                }

                return tavukYumurtası;

            }
        }
}
