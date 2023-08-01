using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace UMS2021_API.Models.DB_UMS
{
    public partial class TblFaculty
    {
        public int FacultyId { get; set; }
        public string FacultyName { get; set; }
        public string FacultyKh { get; set; }
        public bool? IsActive { get; set; }
    }
}
