using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Task;

namespace Odev
{
    public class Personel : IPersonel
    {
    public string Kno { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Yas { get; set; }
        public DateTime D.Tarihi { get; set; }
        public Enumlar.Departmanlar Departman { get; set; }
        public string Baslama Tarihi { get; set; }
    }
}