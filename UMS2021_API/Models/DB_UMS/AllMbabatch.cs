using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace UMS2021_API.Models.DB_UMS
{
    public partial class AllMbabatch
    {
        public int? N { get; set; }
        public int? AcadProgrameId { get; set; }
        public string NameKh { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string FullName { get; set; }
        public int? GenderId { get; set; }
        public DateTime? Dob { get; set; }
        public int? Pob { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string StudentId { get; set; }
    }
}
