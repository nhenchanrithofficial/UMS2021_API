using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace UMS2021_API.Models.DB_UMS
{
    public partial class TblLuckyDraw
    {
        public int WinId { get; set; }
        public string VisitorId { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public string Major { get; set; }
        public string FromUniversity { get; set; }
        public string Image { get; set; }
        public int? EvenId { get; set; }
        public DateTime? DateIssue { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}
