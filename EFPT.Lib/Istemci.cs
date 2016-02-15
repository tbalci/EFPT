using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFPT.Lib
{
   public enum VeriTabaniTipi
    {
        Mssql = 1,
        Mysql = 2,
        Oracle = 3
    }

    public class Istemci : IDisposable
    {
        public void Dispose()
        {
            //abc
        }
    }
}