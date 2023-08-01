using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace UMS2021_API.Models.DB_UMS
{
    public partial class EmpyeeAttendance
    {
        public int EmpAttId { get; set; }
        public string DateCaption { get; set; }
        public DateTime? DateIssue { get; set; }
        public string FilePath { get; set; }
        public string Description { get; set; }
    }
}
