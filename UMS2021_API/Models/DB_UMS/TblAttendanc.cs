using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace UMS2021_API.Models.DB_UMS
{
    public partial class TblAttendanc
    {
        public int AttendId { get; set; }
        public int StatusId { get; set; }
        public DateTime? AteIssue { get; set; }
        public int? SubjectId { get; set; }
        public string Attended { get; set; }
        public string AttendNote { get; set; }
        public string Section { get; set; }
        public int? PersonId { get; set; }
        public string User { get; set; }
        public DateTime? DateIssue { get; set; }
    }
}
