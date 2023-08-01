using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace UMS2021_API.Models.DB_UMS
{
    public partial class TblScholarGranted
    {
        public int SchGrantedId { get; set; }
        public int? StudentId { get; set; }
        public int? ScholarshipId { get; set; }
        public int? YearId { get; set; }
        public short? Amount { get; set; }
        public DateTime? GrantedDate { get; set; }
        public bool? IsCountinue { get; set; }
        public string RequestedBy { get; set; }
    }
}
