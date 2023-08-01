using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace UMS2021_API.Models.DB_UMS
{
    public partial class VStudentFeesTransac
    {
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Phone { get; set; }
        public DateTime? TransacDate { get; set; }
        public string YearName { get; set; }
        public string SemesterName { get; set; }
        public decimal? Amount { get; set; }
        public int? Discount { get; set; }
        public decimal? Paid { get; set; }
        public string Description { get; set; }
        public string Remark { get; set; }
        public int ReceiptId { get; set; }
        public string TransacId { get; set; }
        public int StudentId { get; set; }
        public string Employee { get; set; }
        public int? FeeId { get; set; }
    }
}
