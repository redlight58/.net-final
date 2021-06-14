using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Task;

namespace Odev

interface IOgrenci

{
    public string No { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Yas { get; set; }
        public DateTime Dtarihi { get; set; }
        public Enumlar.Bolumler Bolum { get; set; }
        public string Sınıf { get; set; }
        public string Ortalama { get; set; }
}