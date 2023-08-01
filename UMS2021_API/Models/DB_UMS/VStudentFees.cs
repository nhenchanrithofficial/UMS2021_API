using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace UMS2021_API.Models.DB_UMS
{
    public partial class VStudentFees
    {
        public int FeeId { get; set; }
        public decimal? Fees { get; set; }
        public int YearId { get; set; }
        public string YearName { get; set; }
        public int SemesterId { get; set; }
        public string SemesterName { get; set; }
        public int StudentId { get; set; }
        public decimal? Amount { get; set; }
        public int? Discount { get; set; }
        public bool? Status { get; set; }
    }
}
