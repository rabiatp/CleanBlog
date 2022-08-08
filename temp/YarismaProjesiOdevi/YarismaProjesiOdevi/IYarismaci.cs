using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YarismaProjesiOdevi
{
    interface IYarismaci
    {
        string Isim { get; set; }
        List<int> Konum { get; set; }
        string YarismaciNo { get; set; }
        void HareketEt(int deger);


    }
}
