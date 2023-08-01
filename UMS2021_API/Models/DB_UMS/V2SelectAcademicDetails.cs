using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace UMS2021_API.Models.DB_UMS
{
    public partial class V2SelectAcademicDetails
    {
        public string FacultyName { get; set; }
        public string MajorName { get; set; }
        public string YearName { get; set; }
        public string SemesterName { get; set; }
        public string Shift { get; set; }
        public string AcademicName { get; set; }
        public int AcadProgrameId { get; set; }
        public int AcademicId { get; set; }
        public int FacultyId { get; set; }
        public int MajorId { get; set; }
        public int YearId { get; set; }
        public int ShiftId { get; set; }
        public int? ClassId { get; set; }
        public string Classes { get; set; }
        public int BatchId { get; set; }
        public int DegreeId { get; set; }
        public int SemesterId { get; set; }
        public int GroupId { get; set; }
        public string BatchName { get; set; }
        public string DegreeName { get; set; }
        public string MajorKh { get; set; }
        public string FacultyKh { get; set; }
        public string Expr1 { get; set; }
        public string Expr2 { get; set; }
        public DateTime? AcadDateStart { get; set; }
        public DateTime? AcadDateEnd { get; set; }
        public string KeyCode { get; set; }
        public bool? Active { get; set; }
        public bool? IsTemp { get; set; }
        public string ShiftKh { get; set; }
    }
}
