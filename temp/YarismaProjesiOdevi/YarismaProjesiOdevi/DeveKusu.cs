using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YarismaProjesiOdevi
{
    class DeveKusu : Hayvan
    {
        public DeveKusu()
        {
            Konum = new List<int>();
        }
        public bool Paralize { get; set; }
        public override void HareketEt(int deger)
        {
            if (Paralize!=true)
            {
                //Random rastgele = new Random();
                //int deger = rastgele.Next(1, 11);
                if (deger <= 5)
                    Konum.Add(3);
                else if (deger <= 7)
                    Konum.Add(6);
                else
                {
                    int sayisalKonum = 0;
                    foreach (int konum in Konum)
                    {
                        sayisalKonum += konum;
                    }
                    if (sayisalKonum < 4)
                    {
                        Konum.Clear();
                        Konum.Add(0);
                    }
                    else
                    {
                        Konum.Add(-4);
                    }
                } 
            }
        }
    }
}
