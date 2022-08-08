using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YarismaProjesiOdevi
{
    class SalyanBot : Robot
    {
        public SalyanBot()
        {
            Konum = new List<int>();
        }
        public override void HareketEt(int deger)
        {
            Konum.Add(1);
        }
    }
}
