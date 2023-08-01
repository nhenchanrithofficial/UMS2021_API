using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace UMS2021_API.Models.DB_UMS
{
    public partial class CopiedSbjTakenUpdate
    {
        public Guid LogId { get; set; }
        public int StatusId { get; set; }
        public int SubjectId { get; set; }
        public double? Attentance { get; set; }
        public double? MidTerm { get; set; }
        public double? Assignment { get; set; }
        public double? Final { get; set; }
        public string LogType { get; set; }
        public DateTime? LogDate { get; set; }
        public string LogUser { get; set; }
    }
}
