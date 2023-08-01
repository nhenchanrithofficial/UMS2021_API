using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace UMS2021_API.Models.DB_LTS
{
    public partial class TblAssignedTask
    {
        public int AssignedTaskId { get; set; }
        public int? PersonId { get; set; }
        public DateTime? DateDo { get; set; }
        public int? TimeId { get; set; }
        public int? CreditId { get; set; }
        public int? OtherRateId { get; set; }
        public int? AssignedNoteId { get; set; }
        public bool? CheckedStatus { get; set; }
    }
}
