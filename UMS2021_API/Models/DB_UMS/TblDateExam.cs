using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace UMS2021_API.Models.DB_UMS
{
    public partial class TblDateExam
    {
        public int Id { get; set; }
        public string ListNumber { get; set; }
        public string Room { get; set; }
        public string Table { get; set; }
        public string DateExam { get; set; }
        public string Exam { get; set; }
        public int? StudentId { get; set; }
    }
}
