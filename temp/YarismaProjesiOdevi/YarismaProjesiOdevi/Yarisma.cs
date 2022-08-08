using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace YarismaProjesiOdevi
{
    class Yarisma
    {

        ArrayList yarismacilar;
        Pist yarismaPisti;
        public Yarisma(string yarismaciDosyaYolu, uint pistUzunlugu)
        {
            yarismaPisti = new Pist(pistUzunlugu);
            yarismacilar = yarismaPisti.YarismaciEkle(yarismaciDosyaYolu);
        }
        public void Baslat()
        {
            Random rastgele = new Random();
            bool sonuc;
            do
            {
                sonuc = yarismaPisti.KonumGuncelle(yarismacilar, rastgele);
            } while (sonuc != true);
        }
        public void KonumlariYazdir()
        {
            yarismaPisti.DurumuYazdir(yarismacilar);
        }
    }
}
