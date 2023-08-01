using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace UMS2021_API.Models.DB_LTS
{
    public partial class TblMultiPosition
    {
        public int MultiPositionId { get; set; }
        public int? PositionId { get; set; }
        public int? PersonId { get; set; }
        public int? PersonPartId { get; set; }
        public DateTime? MultiPositionDate { get; set; }
        public string UserIdentify { get; set; }
    }
}
