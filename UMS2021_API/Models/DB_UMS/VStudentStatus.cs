using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace UMS2021_API.Models.DB_UMS
{
    public partial class VStudentStatus
    {
        public int? StudentId { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string GroupName { get; set; }
        public string Shift { get; set; }
        public string DegreeName { get; set; }
        public string MajorName { get; set; }
        public int? YearId { get; set; }
        public int? SemesterId { get; set; }
        public int AcadProgrameId { get; set; }
        public string BatchName { get; set; }
        public int BatchId { get; set; }
        public int MajorId { get; set; }
        public int DegreeId { get; set; }
        public string Phone { get; set; }
        public int? AcademicId { get; set; }
        public string YearName { get; set; }
        public string SemesterName { get; set; }
        public int? ClassId { get; set; }
        public string Classes { get; set; }
        public DateTime? AcadDateStart { get; set; }
        public DateTime? AcadDateEnd { get; set; }
        public int ShiftId { get; set; }
        public string DegreeKh { get; set; }
        public string MajorKh { get; set; }
        public string ShiftKh { get; set; }
        public string KeyCode { get; set; }
        public bool? Active { get; set; }
        public int GroupId { get; set; }
        public string AcademicName { get; set; }
    }
}
