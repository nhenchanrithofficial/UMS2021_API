using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace UMS2021_API.Models.DB_LTS
{
    public partial class VViewStudyRecord
    {
        public int StudyDetailId { get; set; }
        public int? PersonId { get; set; }
        public int? DegreeId { get; set; }
        public int? SkillDetailId { get; set; }
        public int? MajorId { get; set; }
        public string YearStudy { get; set; }
        public string School { get; set; }
    }
}
