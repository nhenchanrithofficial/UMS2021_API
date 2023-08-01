using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace UMS2021_API.Models.DB_LTS
{
    public partial class TblPositionMulti
    {
        public int PositionMultiId { get; set; }
        public int? PersonId { get; set; }
        public string KhName { get; set; }
        public string EnName { get; set; }
    }
}
