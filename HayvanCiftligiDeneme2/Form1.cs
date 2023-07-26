using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HayvanCiftligiDeneme2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        Keci keci = new Keci();//Nesne oluşturulur.
        Inek inek = new Inek();//Nesne oluşturulur.
        Ordek ordek = new Ordek();//Nesne oluşturulur.
        Tavuk tavuk = new Tavuk();//Nesne oluşturulur.


        Hayvan hayvan;


        int sayac = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            btnzaman.Text = Convert.ToString(sayac + " SN");   //SÜRE butonuna yazar.

            canTavuk.Increment(-2);
            canOrdek.Increment(-3);
            canInek.Increment(-8);
            canKeci.Increment(-6);

            hayvan = tavuk;//Hayvan tavuğa dönüştürülür.
            lblTavukYumurta.Text = (hayvan.urunUret() + " ADET").ToString();// Oluşan yumurta label'a eklenir.
            if (canTavuk.Value == 0)//Progress Bar 0 olduğunda durum label'ında ÖLDÜ yazar ve Progress Bar değeri 0 olarak kalır.
            {
                lblTavukCan.Text = hayvan.Durumu;


            }




            hayvan = inek;
            lblSutInek.Text = (hayvan.urunUret() + " ADET").ToString();
            if (canInek.Value == 0)
            {
                lblInekCan.Text = hayvan.Durumu;

            }



            hayvan = ordek;
            lblOrdekYumurta.Text = (hayvan.urunUret() + " ADET").ToString();
            if (canOrdek.Value == 0)
            {
                lblOrdekCan.Text = hayvan.Durumu;

            }



            hayvan = keci;
            lblSutKeci.Text = (hayvan.urunUret() + " ADET").ToString();
            if (canKeci.Value == 0)
            {
                lblKeciCan.Text = hayvan.Durumu;

            }




        }




        private void btnzaman_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        int besleTavuk = 0;
        private void btnTavukBesle_Click(object sender, EventArgs e)
        {
            besleTavuk++;
            TavukYem.Text = besleTavuk.ToString();







        }
        int besleOrdek = 0;
        private void btnOrdekBesle_Click(object sender, EventArgs e)
        {
            besleOrdek++;
            OrdekYem.Text = besleOrdek.ToString();
        }

        int besleKeci = 0;
        private void btnKeciBesle_Click(object sender, EventArgs e)
        {
            besleKeci++;
            KeciYem.Text = besleKeci.ToString();
        }


        int besleInek = 0;
        private void btnInekBesle_Click(object sender, EventArgs e)
        {
            besleInek++;
            InekYem.Text = besleInek.ToString();

        }
        
       
        private void btnTavukSat_Click(object sender, EventArgs e)
        {
            /*
              string tavukyumurta = lblTavukYumurta.Text;
                int tyumurta = System.Convert.ToInt32(tavukyumurta);
                tyumurta--;
                btnTavukSat.Text=tyumurta.ToString();                           //  hata verdi nedenını ogren */


            hayvan = tavuk;
            hayvan.urunSat();
            lblkasa.Text = ((tavuk.lblkasa + inek.lblkasa + ordek.lblkasa + keci.lblkasa) + " TL").ToString();

        }

        private void btnOrdekSat_Click(object sender, EventArgs e)
        {
            hayvan = ordek;
            hayvan.urunSat();
            lblkasa.Text = ((tavuk.lblkasa + ordek.lblkasa + inek.lblkasa + keci.lblkasa)).ToString();
        }

        private void btnKeciSat_Click(object sender, EventArgs e)
        {
            hayvan = keci;
            hayvan.urunSat();
            lblkasa.Text = ((tavuk.lblkasa + inek.lblkasa + ordek.lblkasa + keci.lblkasa) + " TL").ToString();
        }

        private void btnInekSat_Click(object sender, EventArgs e)
        {
            hayvan = inek;
            hayvan.urunSat();
            lblkasa.Text = ((tavuk.lblkasa + inek.lblkasa + ordek.lblkasa + keci.lblkasa) + " TL").ToString();
        }
    }
    }










