using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace UMS2021_API.Models.DB_UMS
{
    public partial class VDailyCollectionFee
    {
        public DateTime? ReceiptDate { get; set; }
        public string StudentName { get; set; }
        public string FeeHead { get; set; }
        public decimal? Amount { get; set; }
        public string EmployeeName { get; set; }
        public int StudentId { get; set; }
    }
}
