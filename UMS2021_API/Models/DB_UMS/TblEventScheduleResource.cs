using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace UMS2021_API.Models.DB_UMS
{
    public partial class TblEventScheduleResource
    {
        public int ResourceId { get; set; }
        public string Rtitle { get; set; }
        public string Rresource { get; set; }
        public int EscheduleId { get; set; }
        public string Rdescription { get; set; }
        public DateTime? Rdate { get; set; }
    }
}
