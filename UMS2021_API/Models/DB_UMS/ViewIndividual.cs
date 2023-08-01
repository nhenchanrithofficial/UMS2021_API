using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace UMS2021_API.Models.DB_UMS
{
    public partial class ViewIndividual
    {
        public int StudentId { get; set; }
        public string NameKh { get; set; }
        public string LatinName { get; set; }
        public int GenderId { get; set; }
        public string NationalKh { get; set; }
        public DateTime? Dob { get; set; }
        public string VillNameUnicode { get; set; }
        public string ComNameUnicode { get; set; }
        public string DistNameUnicode { get; set; }
        public string ProNameUniCode { get; set; }
        public int? AddTypeId { get; set; }
        public int? ConnectionId { get; set; }
        public string KhName { get; set; }
        public string MajorKh { get; set; }
        public string ShiftKh { get; set; }
        public string DegreeKh { get; set; }
        public string Photo { get; set; }
        public string Occupation { get; set; }
        public int YearId { get; set; }
        public string YearName { get; set; }
        public int SemesterId { get; set; }
        public string SemesterName { get; set; }
        public int Bid { get; set; }
        public string BatchId { get; set; }
        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public int? RelateId { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Nationality { get; set; }
        public string WorkPlace { get; set; }
        public string Phone { get; set; }
        public int? Id { get; set; }
        public string ListNumber { get; set; }
        public string Room { get; set; }
        public string Table { get; set; }
        public string DateExam { get; set; }
        public string Exam { get; set; }
    }
}
