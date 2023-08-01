using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace UMS2021_API.Models.DB_UMS
{
    public partial class TblAcadNoted
    {
        public int ChangClassId { get; set; }
        public int? StatusId { get; set; }
        public string Status { get; set; }
        public int? NotedId { get; set; }
        public int? AcadProgramId { get; set; }
        public DateTime? DateIsue { get; set; }
        public string Note { get; set; }
        public string SchoolNameKh { get; set; }
        public string LastMajor { get; set; }
    }
}
