using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace UMS2021_API.Models.DB_LTS
{
    public partial class TblSubjectAssigned
    {
        public int SubjectAssignedId { get; set; }
        public int? PersonId { get; set; }
        public int? SubjectId { get; set; }
        public int? StaffStatusId { get; set; }
        public int? RateId { get; set; }
        public int? SchoolLevelId { get; set; }
        public int? BonusId { get; set; }
        public int? RoomId { get; set; }
    }
}
