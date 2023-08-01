using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace UMS2021_API.Models.DB_UMS
{
    public partial class V5SchoolPromotion
    {
        public int StatusId { get; set; }
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int? ShiftId { get; set; }
        public int? AcademicId { get; set; }
        public int? DegreeId { get; set; }
        public int? MajorId { get; set; }
        public int? BatchId { get; set; }
        public int? YearId { get; set; }
        public int? SemesterId { get; set; }
    }
}
