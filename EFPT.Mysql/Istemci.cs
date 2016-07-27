using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;


namespace EFPT.Mysql
{
    public class Istemci : EFPT.Data.IDatabaseEngine
    {
        public void Ara(int Id)
        {
            
        }

        public void Dispose()
        {
            
        }

        public void Ekle(List<EFPT.Model.User> UserListesi)
        {
            using (EFPT.Data.MYSQLEntities VeriTabani = new Data.MYSQLEntities())
            {
                for (int Don = 0; Don < UserListesi.Count; Don++)
                {
                    VeriTabani.UserListesi.Add(UserListesi[Don]);
                    VeriTabani.Commit();
                }
            }
        }

        public void Sil()
        {
            //throw new NotImplementedException();
        }
    }
}
