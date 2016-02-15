using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFPT.Model
{
    public class User:Base
    {
        [MaxLength(50)]
        public string Ad { get; set; }
        [MaxLength(50)]
        public string Soyad { get; set; }

        [MaxLength(50)]
        public string Mail { get; set; }

    }
}
