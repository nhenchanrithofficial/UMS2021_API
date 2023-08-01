using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace UMS2021_API.Models.DB_LTS
{
    public partial class TblDay
    {
        public int DayId { get; set; }
        public int? SessionId { get; set; }
        public string Day { get; set; }
    }
}
