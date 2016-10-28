using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFPT.Mssql
{
    public class Istemci :EFPT.Data.IDatabaseEngine
    {
        public void Ara(int Id)
        {

        }

        public void Dispose()
        {

        }
        public void Ekle(List<EFPT.Model.User> UserListesi)
        {
            if (UserListesi!=null)
            {
                using (EFPT.Data.MSSQLEntities VeriTabani = new Data.MSSQLEntities())
                {
                    for (int Don = 0; Don < UserListesi.Count; Don++)
                    {
                        VeriTabani.UserListesi.Add(UserListesi[Don]);
                        VeriTabani.SaveChanges();
                        Application.DoEvents();
                    }
                }
            }
            
        }
        public void Sil()
        {
              
        }
    }
}
