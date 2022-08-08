using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YarismaProjesiOdevi
{
    abstract class Hayvan : IYarismaci
    {
        public string Isim { get; set; }
        public List<int> Konum { get; set; }
        public string YarismaciNo { get; set; }
        private string isim;
        protected string rng;
        private string yarismaciNo;
        protected string yarismaPisti;

        public Hayvan()
        {
            
        }
        public abstract void HareketEt(int deger);
        
    }
}
