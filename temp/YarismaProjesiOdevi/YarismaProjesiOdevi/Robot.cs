using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YarismaProjesiOdevi
{
    abstract class Robot : IYarismaci
    {
        public string Isim { get; set; }
        public List<int> Konum { get; set; }
        public string YarismaciNo { get; set; }
        public bool Bozuldu { get; set; }
        private string isim;
        protected string rng;
        private string yarismaciNo;
        protected string yarismaPisti;


        public Robot()
        {

        }

        public abstract void HareketEt(int deger);
        
    }
}
