using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace UMS2021_API.Models.DB_UMS
{
    public partial class V4ReExam
    {
        public int MajorId { get; set; }
        public string MajorName { get; set; }
        public int DegreeId { get; set; }
        public string DegreeName { get; set; }
        public string BatchName { get; set; }
        public string YearName { get; set; }
        public int SemesterId { get; set; }
        public string SemesterName { get; set; }
        public int StatusId { get; set; }
        public int StudentId { get; set; }
        public int SubjectId { get; set; }
        public string Subject { get; set; }
        public double? TotalScores { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public int FacultyId { get; set; }
        public string FacultyName { get; set; }
        public int AcademicId { get; set; }
        public string AcademicName { get; set; }
        public int YearId { get; set; }
        public int ShiftId { get; set; }
        public string Shift { get; set; }
    }
}
