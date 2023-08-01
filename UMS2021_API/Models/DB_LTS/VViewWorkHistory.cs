using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace UMS2021_API.Models.DB_LTS
{
    public partial class VViewWorkHistory
    {
        public int WorkId { get; set; }
        public int? PersonId { get; set; }
        public string Year2Year { get; set; }
        public int? FunctionId { get; set; }
        public int? LocationTypeId { get; set; }
        public string Location { get; set; }
        public int? TimeTypeId { get; set; }
        public DateTime? StartDateWork { get; set; }
        public string Status { get; set; }
    }
}
