using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace UMS2021_API.Models.DB_LTS
{
    public partial class TblTimeSheet
    {
        public int TimeSheetId { get; set; }
        public int? SubjectAssignedId { get; set; }
        public DateTime? DateTeach { get; set; }
        public int? TimeId { get; set; }
        public int? TeachingNote { get; set; }
        public bool? CheckedStatus { get; set; }
        public string Other { get; set; }
    }
}
