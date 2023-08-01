using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace UMS2021_API.Models.DB_UMS
{
    public partial class TblDegree
    {
        public int DegreeId { get; set; }
        public string DegreeName { get; set; }
        public string DegreeKh { get; set; }
    }
}
