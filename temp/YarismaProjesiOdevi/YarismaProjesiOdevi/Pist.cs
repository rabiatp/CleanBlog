using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace YarismaProjesiOdevi
{
    class Pist
    {
        string pist;
        public uint pistUzunlugu { get; set; }
        public Pist(uint pistUzunlugu)
        {
            this.pistUzunlugu = pistUzunlugu;
        }
        public void DurumuYazdir(ArrayList yarismacilar)
        {
            foreach (var yarismaci in yarismacilar)
            {
                if(yarismaci is Cakal)
                {
                    Cakal cakal = (Cakal)yarismaci;
                    int konum = 0;
                    foreach (int konum2 in cakal.Konum)
                    {
                        //Console.Write(konum2 + " ");
                        konum += konum2;
                    }
                    Console.WriteLine(konum + "  ::  " + cakal.YarismaciNo + ", " + cakal.Isim);
                } else if (yarismaci is MekanikFil)
                {
                    MekanikFil mekanikFil = (MekanikFil)yarismaci;
                    int konum = 0;
                    foreach (int konum2 in mekanikFil.Konum)
                    {
                        //Console.Write(konum2 + " ");
                        konum += konum2;
                    }
                    Console.WriteLine(konum + "  ::  " + mekanikFil.YarismaciNo + ", " + mekanikFil.Isim);
                }
                else if (yarismaci is DeveKusu)
                {
                    DeveKusu deveKusu = (DeveKusu)yarismaci;
                    int konum = 0;
                    foreach (int konum2 in deveKusu.Konum)
                    {
                        //Console.Write(konum2 + " ");
                        konum += konum2;
                    }
                    Console.WriteLine(konum + "  ::  " + deveKusu.YarismaciNo + ", " + deveKusu.Isim);
                }
                else if (yarismaci is SalyanBot)
                {
                    SalyanBot salyanBot = (SalyanBot)yarismaci;
                    int konum = 0;
                    foreach (int konum2 in salyanBot.Konum)
                    {
                        //Console.Write(konum2 + " ");
                        konum += konum2;
                    }
                    Console.WriteLine(konum + "  ::  " + salyanBot.YarismaciNo + ", " + salyanBot.Isim);
                }
            }
        }
        public void KonumdakiYarismacilar(ArrayList yarismacilar)
        {
            foreach (var yarismaci in yarismacilar)
            {
                if (yarismaci is Cakal)
                {
                    Cakal cakal = (Cakal)yarismaci;
                    foreach (var rakip in yarismacilar)
                    {
                        if (yarismaci != rakip)
                        {
                            if (rakip is DeveKusu)
                            {
                                DeveKusu deveKusu = (DeveKusu)rakip;
                                int yarismaciKonum = 0;
                                foreach (int konum in cakal.Konum)
                                {
                                    yarismaciKonum += konum;
                                }
                                int rakipKonum = 0;
                                foreach (int konum in deveKusu.Konum)
                                {
                                    rakipKonum += konum;
                                }
                                if (yarismaciKonum == rakipKonum && cakal.Konum.Last() >= deveKusu.Konum.Last())
                                {
                                    Random rastgele = new Random();
                                    if (rastgele.Next(0, 2) == 0)
                                        deveKusu.Paralize = true;

                                }
                            }
                        }
                    }
                }
                else if (yarismaci is MekanikFil)
                {
                    MekanikFil mekanikFil = (MekanikFil)yarismaci;
                    foreach (var rakip in yarismacilar)
                    {
                        if (yarismaci != rakip)
                        {
                            if (rakip is DeveKusu)
                            {
                                DeveKusu deveKusu = (DeveKusu)rakip;
                                int yarismaciKonum = 0;
                                foreach (int konum in mekanikFil.Konum)
                                {
                                    yarismaciKonum += konum;
                                }
                                int rakipKonum = 0;
                                foreach (int konum in deveKusu.Konum)
                                {
                                    rakipKonum += konum;
                                }
                                if (yarismaciKonum == rakipKonum && mekanikFil.Konum.Last() >= deveKusu.Konum.Last())
                                {
                                    Random rastgele = new Random();
                                    if (rastgele.Next(0, 6) == 0)
                                        deveKusu.Paralize = true;
                                }
                            }
                        }
                    }
                }
                else if (yarismaci is SalyanBot)
                {
                    SalyanBot salyanBot = (SalyanBot)yarismaci;
                    foreach (var rakip in yarismacilar)
                    {
                        if (yarismaci != rakip)
                        {
                            if (rakip is Cakal)
                            {
                                Cakal cakal = (Cakal)rakip;
                                int yarismaciKonum = 0;
                                foreach (int konum in salyanBot.Konum)
                                {
                                    yarismaciKonum += konum;
                                }
                                int rakipKonum = 0;
                                foreach (int konum in cakal.Konum)
                                {
                                    rakipKonum += konum;
                                }
                                if (yarismaciKonum == rakipKonum && salyanBot.Konum.Last() >= cakal.Konum.Last())
                                {
                                    Random rastgele = new Random();
                                    if (rastgele.Next(0, 4) == 0)
                                        cakal.Konum.Add(-1);
                                }
                                
                            }
                            /*else if (rakip is MekanikFil)
                            {
                                MekanikFil mekanikFil = (MekanikFil)rakip;
                                int yarismaciKonum = 0;
                                foreach (int konum in salyanBot.Konum)
                                {
                                    yarismaciKonum += konum;
                                }
                                int rakipKonum = 0;
                                foreach (int konum in mekanikFil.Konum)
                                {
                                    rakipKonum += konum;
                                }
                                if (yarismaciKonum == rakipKonum && salyanBot.Konum.Last() >= mekanikFil.Konum.Last())
                                {
                                    Random rastgele = new Random();
                                    if (rastgele.Next(0, 4) == 0)
                                        mekanikFil.Konum.Add(-1);
                                }
                            }*/
                            else if (rakip is DeveKusu)
                            {
                                DeveKusu deveKusu = (DeveKusu)rakip;
                                int yarismaciKonum = 0;
                                foreach (int konum in salyanBot.Konum)
                                {
                                    yarismaciKonum += konum;
                                }
                                int rakipKonum = 0;
                                foreach (int konum in deveKusu.Konum)
                                {
                                    rakipKonum += konum;
                                }
                                if (yarismaciKonum == rakipKonum && salyanBot.Konum.Last() >= deveKusu.Konum.Last())
                                {
                                    Random rastgele = new Random();
                                    if (rastgele.Next(0, 4) == 0)
                                        deveKusu.Konum.Add(-1);
                                }
                            }
                            /*else if (rakip is SalyanBot)
                            {
                                SalyanBot salyanBot1 = (SalyanBot)rakip;
                                Random rastgele = new Random();
                                if (rastgele.Next(0, 4) == 0)
                                    salyanBot1.Konum.Add(-1);
                            }*/
                        }
                    }
                }
            }
        }
        public bool KonumGuncelle(ArrayList yarismacilar,Random rastgele)
        {
            bool bittimi = false;
            foreach (var item in yarismacilar)
            {

                if (item is Cakal)
                {
                    
                    Cakal cakal = (Cakal)item;
                    cakal.HareketEt(rastgele.Next(1,11));
                    int sayisaldeger = 0;
                    foreach (int konum in cakal.Konum)
                    {
                        sayisaldeger += konum;
                    }
                    if (sayisaldeger >= pistUzunlugu)
                    {
                        bittimi = true;
                        break;
                    }

                }
                else if (item is MekanikFil)
                {
                    MekanikFil mekanikFil = (MekanikFil)item;
                    mekanikFil.HareketEt(rastgele.Next(1, 11));
                    int sayisaldeger = 0;
                    foreach (int konum in mekanikFil.Konum)
                    {
                        sayisaldeger += konum;
                    }
                    if (sayisaldeger >= pistUzunlugu)
                    {
                        bittimi = true;
                        break;
                    }

                }
                else if (item is DeveKusu)
                {
                    DeveKusu deveKusu = (DeveKusu)item;
                    deveKusu.HareketEt(rastgele.Next(1, 11));
                    int sayisaldeger = 0;
                    foreach (int konum in deveKusu.Konum)
                    {
                        sayisaldeger += konum;
                    }
                    if (sayisaldeger >= pistUzunlugu)
                    {
                        bittimi = true;
                        break;
                    }
                }
                else if (item is SalyanBot)
                {

                    SalyanBot salyanBot = (SalyanBot)item;
                    salyanBot.HareketEt(rastgele.Next(1, 11));
                    int sayisaldeger = 0;
                    foreach (int konum in salyanBot.Konum)
                    {
                        sayisaldeger += konum;
                    }
                    if (sayisaldeger >= pistUzunlugu)
                    {
                        bittimi = true;
                        break;
                    }

                }
            }
            KonumdakiYarismacilar(yarismacilar);
            return bittimi;
        }

        public ArrayList YarismaciEkle(string dosyaYolu)
        {
            ArrayList yarismacilar = new ArrayList();
            FileStream fs = new FileStream(dosyaYolu, FileMode.Open, FileAccess.Read);
            StreamReader sw = new StreamReader(fs);
            string yazi = sw.ReadLine();
            while (yazi != null)
            {
                string[] satir = yazi.Split(' ');
                string yarismaciNo = satir[0];
                string isim = satir[1];
                string tür = satir[2];
                if (tür == "CAKAL")
                {
                    Cakal cakal = new Cakal();
                    cakal.Isim = isim;
                    cakal.YarismaciNo = yarismaciNo;
                    cakal.Konum.Add(0);
                    yarismacilar.Add(cakal);
                }
                else if (tür == "MEKANIKFIL")
                {
                    MekanikFil mekanikFil = new MekanikFil();
                    mekanikFil.Isim = isim;
                    mekanikFil.YarismaciNo = yarismaciNo;
                    mekanikFil.Konum.Add(0);
                    yarismacilar.Add(mekanikFil);
                }
                else if (tür == "SALYANBOT")
                {
                    SalyanBot salyanBot = new SalyanBot();
                    salyanBot.Isim = isim;
                    salyanBot.YarismaciNo = yarismaciNo;
                    salyanBot.Konum.Add(0);
                    yarismacilar.Add(salyanBot);
                }
                else if (tür == "DEVEKUSU")
                {
                    DeveKusu deveKusu = new DeveKusu();
                    deveKusu.Isim = isim;
                    deveKusu.YarismaciNo = yarismaciNo;
                    deveKusu.Konum.Add(0);
                    yarismacilar.Add(deveKusu);
                }
                yazi = sw.ReadLine();
            }
            sw.Close();
            fs.Close();
            return yarismacilar;
        }

    }
}
