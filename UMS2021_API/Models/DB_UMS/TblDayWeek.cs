using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace UMS2021_API.Models.DB_UMS
{
    public partial class TblDayWeek
    {
        public int DayWeekId { get; set; }
        public string DayWeek { get; set; }
        public int? ShiftId { get; set; }
    }
}
