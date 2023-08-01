using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace UMS2021_API.Models.DB_UMS
{
    public partial class TblEvenInfo
    {
        public int EvenId { get; set; }
        public string EvenTitle { get; set; }
        public string Orginize { get; set; }
        public string DateIssue { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string Note { get; set; }
        public int? NumStun { get; set; }
        public DateTime? DateClosed { get; set; }
        public int? EorgId { get; set; }
        public int? BuildingId { get; set; }
        public int? RoomId { get; set; }
        public string DateKh { get; set; }
        public string CreateByUser { get; set; }
        public int? EventTypeId { get; set; }
    }
}
