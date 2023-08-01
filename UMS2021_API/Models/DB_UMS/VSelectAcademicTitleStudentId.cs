﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace UMS2021_API.Models.DB_UMS
{
    public partial class VSelectAcademicTitleStudentId
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string AcademicTitle { get; set; }
    }
}
