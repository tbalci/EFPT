using System;
using System.ComponentModel.DataAnnotations;

namespace EFPT.Model
{
    //[NotMapped]
    public class Base
    {
        [Key]
        public int No { get; set; }

        private DateTime? _Tarih = DateTime.Now;

        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? Tarih
        {
            get { return _Tarih; }
            set { _Tarih = value; }
        }

        public Base()
        {
            Tarih = DateTime.Now;
        }
    }
}