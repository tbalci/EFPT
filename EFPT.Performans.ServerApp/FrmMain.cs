using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EFPT.Performans;
using System.Threading;
using EFPT.Remote;
using EFPT.Lib;


namespace EFPT.Performans.ServerApp
{
    
    enum KayitDurum
    {
        Baslatildi=1,
        Durduruldu=2
    }
    public partial class FrmMain : Form
    {
        KayitDurum KayitDurum { get; set; }
        public List<PerformansInfo> PerformansBilgileri {get;set;}
        public delegate void NewMessageDelegate(string NewMessage);
        private PipeServer _pipeServer;
        private PipeClient _pipeClient;
        public FrmMain()
        {
            InitializeComponent();
            _pipeServer = new PipeServer();
            _pipeServer.PipeMessage += new DelegateMessage(PipesMessageHandler);
            _pipeServer.Listen("EFPTINPUT");
            this.KayitDurum = KayitDurum.Durduruldu;
            PerformansBilgileri = new List<PerformansInfo>();
        }

        public void KomutGonder(string Komut)
        {
            _pipeClient = new PipeClient();
            _pipeClient.Send(Komut, "EFPTOUTPUT", 100000);
        }

        private void PerformansVerileriniKontrolEtKaydet()
        {
            PerformansBilgileri.Clear();
            PerformanceCounter PCounterAppCpu = new PerformanceCounter("Process", "% Processor Time", "EFPT.App.vshost");
            PerformanceCounter PCounterAppRam = new PerformanceCounter("Process", "Working Set - Private", "EFPT.App.vshost");
            PerformanceCounter PCounterEgineCpu = new PerformanceCounter("Process", "% Processor Time", "sqlservr");
            PerformanceCounter PCounterEgineRam = new PerformanceCounter("Process", "Working Set - Private", "sqlservr");
            while (KayitDurum == KayitDurum.Baslatildi)
            {
                PerformansInfo Bilgi = new PerformansInfo();
                Bilgi.No = PerformansBilgileri.Count + 1;
                Bilgi.Tarih = DateTime.Now;
                Bilgi.AppCpu = PCounterAppCpu.NextValue() / Environment.ProcessorCount;
                Bilgi.AppRam = PCounterAppRam.RawValue/(1024);
                Bilgi.EngineCpu = PCounterEgineCpu.NextValue();
                Bilgi.EngineRam = PCounterEgineRam.RawValue / (1024);
                PerformansBilgileri.Add(Bilgi);
                LogEkle(string.Format("App : (Cpu Değeri :{0} | Ram Değeri :{1}) Server : (Cpu Değeri :{2} | Ram Değeri :{3}) ", Bilgi.AppCpu,Bilgi.AppRam,Bilgi.EngineCpu,Bilgi.EngineRam));
                Thread.Sleep(1000);
                Application.DoEvents();
            }
            string SonucTxt = PerformansBilgileri.ToJson();
            KomutGonder(SonucTxt);

        }
        
        private void PipesMessageHandler(string message)
        {
            try
            {
                if (this.InvokeRequired)
                {
                    this.Invoke(new NewMessageDelegate(PipesMessageHandler), message);
                }
                else
                {
                    if (message.StartsWith("Baslat"))
                    {
                        LogEkle("Başlatıldı");
                        PerformansBilgileri = new List<PerformansInfo>();
                        KayitDurum = KayitDurum.Baslatildi;
                        Task TskIslem = Task.Factory.StartNew(() =>
                        {
                            PerformansVerileriniKontrolEtKaydet();
                        });
                        Task.WhenAny(TskIslem);
                    }

                    if (message.StartsWith("Durdur"))
                    {
                        KayitDurum = KayitDurum.Durduruldu;
                        LogEkle("Durduruldu");
                    }
                    if (message.StartsWith("Gonder"))
                    {
                    }
                    TlStrpDurum.Text = message.Substring(0, 10);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }
        delegate void SetLogCallback(string text);
        private void SetLog(string text)
        {
            if (this.TxtPerformansLog.InvokeRequired)
            {
                SetLogCallback d = new SetLogCallback(SetLog);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.TxtPerformansLog.AppendText(text);
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        public void LogEkle(string Mesaj)
        {
            SetLog(string.Format("{0} : {1}{2}", DateTime.Now.ToString(), Mesaj, Environment.NewLine));
        }


        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        

        private void CikisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            _pipeServer.PipeMessage -= new DelegateMessage(PipesMessageHandler);
            _pipeServer = null;
        }
    }
}
