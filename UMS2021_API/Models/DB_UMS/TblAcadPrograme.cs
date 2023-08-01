﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace UMS2021_API.Models.DB_UMS
{
    public partial class TblAcadPrograme
    {
        public int AcadProgrameId { get; set; }
        public string AcadTitle { get; set; }
        public int? YearId { get; set; }
        public int? SemesterId { get; set; }
        public int? BatchId { get; set; }
        public int? GroupId { get; set; }
        public int? DegreeId { get; set; }
        public int? MajorId { get; set; }
        public int? ShiftId { get; set; }
        public int? ClassId { get; set; }
        public DateTime? AcadDateStart { get; set; }
        public DateTime? AcadDateEnd { get; set; }
        public DateTime? AcadDateIsue { get; set; }
        public int? AcademicId { get; set; }
        public string KeyCode { get; set; }
        public DateTime? DateCompletion { get; set; }
        public bool? Active { get; set; }
        public bool? IsTemp { get; set; }
    }
}
