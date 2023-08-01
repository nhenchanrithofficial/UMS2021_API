using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace UMS2021_API.Models.DB_LTS
{
    public partial class TblDocAtt
    {
        public int DocAttId { get; set; }
        public int? PersonId { get; set; }
        public string DocName { get; set; }
        public string FileType { get; set; }
        public string DocAttUrl { get; set; }
    }
}
