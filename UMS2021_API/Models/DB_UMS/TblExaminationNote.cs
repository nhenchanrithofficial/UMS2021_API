using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace UMS2021_API.Models.DB_UMS
{
    public partial class TblExaminationNote
    {
        public int ExamNoteId { get; set; }
        public int? StatusId { get; set; }
        public int? SubjectId { get; set; }
        public double? Score { get; set; }
        public DateTime? IssuDate { get; set; }
        public string Taken { get; set; }
        public int? RoomId { get; set; }
        public bool? IsPassed { get; set; }
        public string Other { get; set; }
    }
}
