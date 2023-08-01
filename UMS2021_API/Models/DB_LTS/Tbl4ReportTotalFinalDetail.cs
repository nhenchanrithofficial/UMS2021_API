using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace UMS2021_API.Models.DB_LTS
{
    public partial class Tbl4ReportTotalFinalDetail
    {
        public string CloseDate { get; set; }
        public string FacultyName { get; set; }
        public string BatchName { get; set; }
        public string GroupName { get; set; }
        public string YearName { get; set; }
        public string SemesterName { get; set; }
        public string DegreeName { get; set; }
        public string SessionName { get; set; }
        public string AcademicName { get; set; }
        public string MajorName { get; set; }
        public DateTime? DateTeach { get; set; }
        public string Period { get; set; }
        public string TeachingNote { get; set; }
        public string Other { get; set; }
        public string PersonId { get; set; }
        public string FullName { get; set; }
        public int? FacultyId { get; set; }
        public int? SubjectAssignedId { get; set; }
        public string Subject { get; set; }
    }
}
