using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace EFPT.Performans
{
    public delegate void IslemTamamCalis();
    public class Istemci
    {
        public event IslemTamamCalis IslemTamam;

        public string Ad { get; set; }
        public string Aciklama { get; set; }
        public DateTime Tarih { get; set; }

        public TimeSpan TotalTime { get; private set; }
        public TimeSpan AverageTime { get; private set; }
        public TimeSpan MinTime { get; private set; }
        public TimeSpan MaxTime { get; private set; }
        public List<PerformansInfo> SonucListesi { get; set; }

        public Action Action { get; set; }

        //public List<PerformansInfo> PerformansListesi { get; set; }


        public Istemci(Action action)
        {
            Action = action;
            MaxTime = TimeSpan.MinValue;
            MinTime = TimeSpan.MaxValue;
            this.SonucListesi = new List<PerformansInfo>();
            this.Tarih = DateTime.Now;
        }
        public Istemci()
        {
            MaxTime = TimeSpan.MinValue;
            MinTime = TimeSpan.MaxValue;
            this.SonucListesi = new List<PerformansInfo>();
            this.Tarih = DateTime.Now;
        }

        /// <summary>
        /// Micro performance testing
        /// </summary>
        public void MeasureExecTime()
        {
            var sw = Stopwatch.StartNew();
            Action();
            sw.Stop();
            AverageTime = sw.Elapsed;
            TotalTime = sw.Elapsed;
        }

        /// <summary>
        /// Micro performance testing
        /// </summary>
        /// <param name="iterations">the number of times to perform action</param>
        /// <returns></returns>
        public void MeasureExecTime(int iterations)
        {
            Action(); // warm up
            var sw = Stopwatch.StartNew();
            for (int i = 0; i < iterations; i++)
            {
                Action();
            }
            sw.Stop();
            AverageTime = new TimeSpan(sw.Elapsed.Ticks / iterations);
            TotalTime = sw.Elapsed;
            IslemTamam();
        }

        /// <summary>
        /// Micro performance testing, also measures
        /// max and min execution times
        /// </summary>
        /// <param name="iterations">the number of times to perform action</param>
        public void MeasureExecTimeWithMetrics(int iterations)
        {
            TimeSpan total = new TimeSpan(0);
            Action(); // warm up
            for (int i = 0; i < iterations; i++)
            {
                var sw = Stopwatch.StartNew();
                Action();
                sw.Stop();
                TimeSpan thisIteration = sw.Elapsed;
                total += thisIteration;
                if (thisIteration > MaxTime) MaxTime = thisIteration;
                if (thisIteration < MinTime) MinTime = thisIteration;
                //var cpuTimes = ManagementObjectSearcher.Get()
                //                .Cast<ManagementObject>()
                //                .Select(mo => new
                //                {
                //                    Name = mo["Name"],
                //                    Usage = mo["PercentProcessorTime"]
                //                }
                //    ).ToArray();
            }
            TotalTime = total;
            AverageTime = new TimeSpan(total.Ticks / iterations);
            IslemTamam();
        }
    }
}

