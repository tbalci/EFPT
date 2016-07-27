using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFPT.Performans
{
    [Serializable]
    public  class PerformansInfo
    {
        public int No { get; set; }
        public DateTime Tarih { get; set; }
        public double AppCpu { get; set; }
        public double AppRam { get; set; }

        public double EngineCpu { get; set; }
        public double EngineRam { get; set; }


    }
}
