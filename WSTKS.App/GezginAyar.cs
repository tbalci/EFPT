using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSKTS.App
{
    public class GezginAyar
    {
        public string Ad { get; set; }
        public int SaniyeIlk { get; set;}
        public int SaniyeSon { get; set; }

        public int ProxySaniyeIlk { get; set; }
        public int ProxySaniyeSon { get; set; }

        public int Adet { get; set; }
        public string Url { get; set; }
        public bool SiteGezinmeDurumu { get; set; }
        public bool CerezDurumu { get; set; }
        public GezginAyar()
        {
            Ad = "Site Tanımı";
            Adet = 25;
            Url = "http://";
            SaniyeIlk = 45;
            SaniyeSon = 90;
            ProxySaniyeIlk = 45;
            ProxySaniyeSon = 90;
            this.SiteGezinmeDurumu = false;
            this.CerezDurumu = false;
        }
    }
}
