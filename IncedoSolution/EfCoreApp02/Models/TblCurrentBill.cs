using System;
using System.Collections.Generic;

#nullable disable

namespace EfCoreApp02.Models
{
    public partial class TblCurrentBill
    {
        public int Id { get; set; }
        public int? Pmr { get; set; }
        public int? Lmr { get; set; }
        public int? Bu { get; set; }
        public int? Ur { get; set; }
        public int? Amount { get; set; }
    }
}
