using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace UMS2021_API.Models.DB_UMS
{
    public partial class TblStunRecord
    {
        public int EducationId { get; set; }
        public int? StudentId { get; set; }
        public int? StunInfoId { get; set; }
        public string RecordDetail { get; set; }
        public bool? IsPassed { get; set; }
        public bool? IsLack { get; set; }
    }
}
