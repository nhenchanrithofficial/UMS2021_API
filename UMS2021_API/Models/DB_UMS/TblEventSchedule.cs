using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace UMS2021_API.Models.DB_UMS
{
    public partial class TblEventSchedule
    {
        public int EscheduleId { get; set; }
        public string Estitle { get; set; }
        public string EstartTime { get; set; }
        public string EendTime { get; set; }
        public int? EventId { get; set; }
        public int? PresenterId { get; set; }
        public DateTime? EdatePresent { get; set; }
        public string Edescription { get; set; }
        public DateTime? Edate { get; set; }
        public string EimageUrl { get; set; }
    }
}
