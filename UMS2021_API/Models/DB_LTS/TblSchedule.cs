using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace UMS2021_API.Models.DB_LTS
{
    public partial class TblSchedule
    {
        public int ScheduleId { get; set; }
        public int? AcademicId { get; set; }
        public DateTime? SchStart { get; set; }
        public DateTime? SchEnd { get; set; }
        public string SchNote { get; set; }
    }
}
