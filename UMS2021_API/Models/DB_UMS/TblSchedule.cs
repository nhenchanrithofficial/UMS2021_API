using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace UMS2021_API.Models.DB_UMS
{
    public partial class TblSchedule
    {
        public int ScheduleId { get; set; }
        public int? SubjectId { get; set; }
        public int? PersonId { get; set; }
        public int? DayWeekId { get; set; }
        public int? TimeId { get; set; }
        public int? RoomId { get; set; }
        public int? AcadProgrameId { get; set; }
        public DateTime? DateStart { get; set; }
        public DateTime? DateEnd { get; set; }
    }
}
