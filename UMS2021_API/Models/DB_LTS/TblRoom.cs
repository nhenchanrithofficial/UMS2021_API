using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace UMS2021_API.Models.DB_LTS
{
    public partial class TblRoom
    {
        public int RoomId { get; set; }
        public int? BuildingId { get; set; }
        public string Room { get; set; }
        public string AreaSize { get; set; }
        public string FixedSeats { get; set; }
        public string ReservedSeats { get; set; }
    }
}
