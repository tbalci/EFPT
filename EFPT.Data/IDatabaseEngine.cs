using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFPT.Data
{
   public interface IDatabaseEngine:IDisposable
    {
        void Ekle();
        void Sil();
        void Ara(int Id);
    }
}
