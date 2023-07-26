using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace HayvanCiftligiDeneme2
{
    internal class Ordek:Hayvan
    {
       

        private int ordekYumurtası;  //Yumurta adeti için.
       

        public override int urunSat()// Yemi gerekli işlem yaparak kasaya aktarır.
        {

            lblkasa += ordekYumurtası * 3;
            return ordekYumurtası = 0;
        }

        public override int urunUret()// Gerekli işlem yapılarak saniyeye göre yumurta artırılır.
        {
            Saniye++;
            if (Saniye % 5 == 0)
            {
                ordekYumurtası++;
            }
            return ordekYumurtası;
        }

       

    }
}

