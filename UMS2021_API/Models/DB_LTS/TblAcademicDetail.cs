using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace UMS2021_API.Models.DB_LTS
{
    public partial class TblAcademicDetail
    {
        public int AcademicIddetail { get; set; }
        public int AcademicId { get; set; }
        public DateTime? DateStart1 { get; set; }
        public DateTime? DateEnd1 { get; set; }
        public DateTime? DateStart2 { get; set; }
        public DateTime? DateEnd2 { get; set; }
    }
}
