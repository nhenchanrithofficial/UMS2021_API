using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace UMS2021_API.Models.DB_LTS
{
    public partial class TblTaskDetail
    {
        public int TaskDetailId { get; set; }
        public int? AssignedTaskId { get; set; }
        public DateTime? DateDo { get; set; }
        public string SubjectId { get; set; }
        public int? TimeId { get; set; }
        public int? CreditId { get; set; }
        public bool? CheckedStatus { get; set; }
    }
}
