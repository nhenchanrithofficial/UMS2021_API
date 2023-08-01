using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace UMS2021_API.Models.DB_LTS
{
    public partial class TblFamily
    {
        public int FamilyId { get; set; }
        public int? PersonId { get; set; }
        public string FamilyName { get; set; }
        public string Contact { get; set; }
        public int? FunctionId { get; set; }
        public short? ChildNumber { get; set; }
        public short? Son { get; set; }
        public short? Daughter { get; set; }
    }
}
