using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace UMS2021_API.Models.DB_LTS
{
    public partial class View3
    {
        public int TimeSheetId { get; set; }
        public int? SubjectAssignedId { get; set; }
        public int? TimeId { get; set; }
        public int? TeachingNoteId { get; set; }
        public DateTime? DateTeach { get; set; }
        public string Period { get; set; }
        public string TeachingNote { get; set; }
        public bool? CheckedStatus { get; set; }
    }
}
