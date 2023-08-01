using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace UMS2021_API.Models.DB_UMS
{
    public partial class TblAuditAddScores
    {
        public Guid AuditId { get; set; }
        public string AuditType { get; set; }
        public DateTime? AuditDatetime { get; set; }
        public string AuditUser { get; set; }
        public string AuditNote { get; set; }
        public int? StudentId { get; set; }
        public int? SubjectId { get; set; }
        public double? Attendance { get; set; }
        public double? Midterm { get; set; }
        public double? Assignment { get; set; }
        public double? Final { get; set; }
    }
}
