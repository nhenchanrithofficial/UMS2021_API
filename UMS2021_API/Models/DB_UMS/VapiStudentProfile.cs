using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace UMS2021_API.Models.DB_UMS
{
    public partial class VapiStudentProfile
    {
        public int StudentId { get; set; }
        public int? AcadProgrameId { get; set; }
        public int? Pob { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Mname { get; set; }
        public string NameKh { get; set; }
        public DateTime? Dob { get; set; }
        public string Passport { get; set; }
        public int? GenderId { get; set; }
        public string GenderName { get; set; }
        public int? Msid { get; set; }
        public string Msname { get; set; }
        public int? RaceId { get; set; }
        public string Race { get; set; }
        public int? NationalId { get; set; }
        public string NationalName { get; set; }
        public string Photo { get; set; }
        public string Occupation { get; set; }
        public string Phone { get; set; }
        public string Phone2 { get; set; }
        public string Email { get; set; }
        public bool? IsActivated { get; set; }
        public DateTime? RegisterDate { get; set; }
    }
}
