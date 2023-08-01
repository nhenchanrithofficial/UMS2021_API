using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace UMS2021_API.Models.DB_UMS
{
    public partial class Tblmajor
    {
        public int MajorId { get; set; }
        public int? FacultyId { get; set; }
        public int? DeptId { get; set; }
        public int? DegreeLabelId { get; set; }
        public string MajorName { get; set; }
        public string MajorKh { get; set; }
        public bool? IsActive { get; set; }
    }
}
