using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YarismaProjesiOdevi
{
    class MekanikFil : Robot
    {
        public MekanikFil()
        {
            Konum = new List<int>();
        }
        public override void HareketEt(int deger)
        {
            //Random rastgele = new Random();
            //int deger = rastgele.Next(1, 11);
            if (deger <= 4)
                Konum.Add(2);
            else if (deger <= 5)
                Konum.Add(3);
            else
                Konum.Add(0);
        }
    }
}
