using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace UMS2021_API.Models.DB_UMS
{
    public partial class Transaction
    {
        public int TransacId { get; set; }
        public DateTime? TransacDate { get; set; }
        public int? FeeId { get; set; }
        public int? StudentId { get; set; }
        public string Employee { get; set; }
        public decimal? Amount { get; set; }
        public string Description { get; set; }
        public decimal? Credit { get; set; }
        public decimal? Debit { get; set; }
        public string Remark { get; set; }
    }
}
