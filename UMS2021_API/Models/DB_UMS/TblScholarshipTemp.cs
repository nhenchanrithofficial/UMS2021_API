using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace UMS2021_API.Models.DB_UMS
{
    public partial class TblScholarshipTemp
    {
        public int StunTempId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string KhmerName { get; set; }
        public int? GenderId { get; set; }
        public DateTime? Dob { get; set; }
        public int? ProviderId { get; set; }
        public int? DegreeId { get; set; }
        public int? MajorId { get; set; }
        public string Duration { get; set; }
        public int? GrantedPercent { get; set; }
        public string Requester { get; set; }
        public DateTime? DateIssued { get; set; }
        public double? SchoolFee { get; set; }
        public double? FixAmount { get; set; }
        public int? StudentId { get; set; }
        public string Phone { get; set; }
        public DateTime? DateRecord { get; set; }
    }
}
