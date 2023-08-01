using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace UMS2021_API.Models.DB_LTS
{
    public partial class TblSubject
    {
        public int SubjectId { get; set; }
        public int? DateUpdateId { get; set; }
        public int? DegreeId { get; set; }
        public int? MajorId { get; set; }
        public int? YearId { get; set; }
        public int? SemesterId { get; set; }
        public string Subject { get; set; }
        public int? NumSession { get; set; }
    }
}
