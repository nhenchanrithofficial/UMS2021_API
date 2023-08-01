using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace UMS2021_API.Models.DB_UMS
{
    public partial class TblSbjTaken
    {
        public int SbjTakenId { get; set; }
        public int StatusId { get; set; }
        public int SubjectId { get; set; }
        public double? Attentance { get; set; }
        public double? MidTerm { get; set; }
        public double? Assignment { get; set; }
        public double? Final { get; set; }
        public double? ReExam1 { get; set; }
        public double? ReExam2 { get; set; }
        public double? ReExam3 { get; set; }
        public string UserEntried { get; set; }
    }
}
