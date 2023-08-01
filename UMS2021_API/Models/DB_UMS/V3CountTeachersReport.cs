﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace UMS2021_API.Models.DB_UMS
{
    public partial class V3CountTeachersReport
    {
        public string FacultyName { get; set; }
        public string MajorName { get; set; }
        public string DegreeName { get; set; }
        public string YearName { get; set; }
        public string SemesterName { get; set; }
        public string Name { get; set; }
        public string Subject { get; set; }
        public int FacultyId { get; set; }
        public int MajorId { get; set; }
        public int YearId { get; set; }
        public int SemesterId { get; set; }
        public int AcadProgrameId { get; set; }
        public bool? Active { get; set; }
        public int AcademicId { get; set; }
        public string AcademicName { get; set; }
        public int DegreeId { get; set; }
    }
}
