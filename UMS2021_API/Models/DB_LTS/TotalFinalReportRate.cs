using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace UMS2021_API.Models.DB_LTS
{
    public partial class TotalFinalReportRate
    {
        public int? YearId { get; set; }
        public int? SemesterId { get; set; }
        public int? PersonId { get; set; }
        public string FullName { get; set; }
        public int? Total { get; set; }
        public string Subject { get; set; }
        public decimal? Rate { get; set; }
    }
}
