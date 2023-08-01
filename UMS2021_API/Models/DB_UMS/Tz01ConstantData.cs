using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace UMS2021_API.Models.DB_UMS
{
    public partial class Tz01ConstantData
    {
        public int ConId { get; set; }
        public string KeyNote { get; set; }
        public string TextValue { get; set; }
        public DateTime? DateValue { get; set; }
        public string Description { get; set; }
        public DateTime? DateIssue { get; set; }
    }
}
