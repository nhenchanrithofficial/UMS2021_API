using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace UMS2021_API.Models.DB_UMS
{
    public partial class TblStudentStatus
    {
        public int StatusId { get; set; }
        public int StudentId { get; set; }
        public int? AcadProgrameId { get; set; }
        public int? RoomId { get; set; }
        public int? TimeId { get; set; }
        public bool? IsActive { get; set; }
        public string Assigned { get; set; }
        public string Note { get; set; }
        public DateTime? AssignDate { get; set; }
    }
}
