using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace UMS2021_API.Models.DB_UMS
{
    public partial class V6StudentChangedFromOtherSchool
    {
        public string FacultyName { get; set; }
        public string MajorName { get; set; }
        public string YearName { get; set; }
        public string SemesterName { get; set; }
        public string BatchName { get; set; }
        public string GroupName { get; set; }
        public string DegreeName { get; set; }
        public int StudentId { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public int? GenderId { get; set; }
        public DateTime? RegisterDate { get; set; }
        public int? NotedId { get; set; }
        public string Note { get; set; }
        public int? AcademicId { get; set; }
        public int FacultyId { get; set; }
        public int MajorId { get; set; }
        public int YearId { get; set; }
        public int? ShiftId { get; set; }
        public int BatchId { get; set; }
        public int DegreeId { get; set; }
        public DateTime? DateIsue { get; set; }
    }
}
