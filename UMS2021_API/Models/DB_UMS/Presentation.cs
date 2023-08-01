using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace UMS2021_API.Models.DB_UMS
{
    public partial class Presentation
    {
        public int PresentId { get; set; }
        public int? Rdid { get; set; }
        public string Title { get; set; }
        public DateTime? DateIssue { get; set; }
        public string Assessors { get; set; }
        public string Location { get; set; }
        public int? ShowId { get; set; }
        public string Evaluation { get; set; }
        public bool? IsApproval { get; set; }
    }
}
