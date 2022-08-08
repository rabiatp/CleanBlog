using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YarismaProjesiOdevi
{
    class Cakal : Hayvan
    {
        public Cakal()
        {
            Konum = new List<int>();
        }
        public override void HareketEt(int deger)
        {
            //Random rastgele = new Random();
            //int deger= rastgele.Next(1, 11);
            if (deger <= 3)
                Konum.Add(3) ;
            else if (deger <= 8)
                Konum.Add(2);
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
