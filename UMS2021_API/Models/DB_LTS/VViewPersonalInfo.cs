﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace UMS2021_API.Models.DB_LTS
{
    public partial class VViewPersonalInfo
    {
        public int PersonId { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string KhName { get; set; }
        public int? GenderId { get; set; }
        public DateTime? Dob { get; set; }
        public string Idcard { get; set; }
        public int? MaritalStatusId { get; set; }
        public int? NationalityId { get; set; }
        public string FatherName { get; set; }
        public int? FunctionFid { get; set; }
        public string MotherName { get; set; }
        public int? FunctionMid { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Photo { get; set; }
        public string Hobbies { get; set; }
        public int? NationalDetail { get; set; }
        public int? PositionId { get; set; }
        public int? PersonTypeId { get; set; }
        public DateTime? WorkStartDate { get; set; }
        public int? Status { get; set; }
        public string KhmerIdentityCard { get; set; }
        public int? HighestDegree { get; set; }
        public string ReasonResign { get; set; }
        public string SpecialNote { get; set; }
        public int? DepartmentId { get; set; }
        public int? SubDptId { get; set; }
        public int? HighestDegreeFrom { get; set; }
    }
}
