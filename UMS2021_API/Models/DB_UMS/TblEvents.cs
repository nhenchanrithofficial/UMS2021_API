using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace UMS2021_API.Models.DB_UMS
{
    public partial class TblEvents
    {
        public int EventId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int? EventTypeId { get; set; }
        public string PhotoUrl { get; set; }
        public string PhotoCaption { get; set; }
        public DateTime? DateEvent { get; set; }
        public DateTime? DatePost { get; set; }
    }
}
