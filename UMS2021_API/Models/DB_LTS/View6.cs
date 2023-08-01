using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace UMS2021_API.Models.DB_LTS
{
    public partial class View6
    {
        public int? NationalityId { get; set; }
        public string Nations { get; set; }
        public int? Total { get; set; }
        public int DegreeId { get; set; }
        public string DegreeKh { get; set; }
        public int? TotalSex { get; set; }
        public int? GenderId { get; set; }
        public string SexEng { get; set; }
    }
}
