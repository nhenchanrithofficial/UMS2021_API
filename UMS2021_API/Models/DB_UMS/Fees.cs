using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace UMS2021_API.Models.DB_UMS
{
    public partial class Fees
    {
        public int FeeId { get; set; }
        public string FeeHeading { get; set; }
        public decimal? Amount { get; set; }
        public int? BatchId { get; set; }
        public int? DegreeId { get; set; }
        public int? MajorId { get; set; }
        public int? YearId { get; set; }
        public int? SemesterId { get; set; }
        public int? FeeTypeId { get; set; }
        public int? AcadProgrameId { get; set; }
    }
}
