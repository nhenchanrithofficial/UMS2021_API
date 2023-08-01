using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UMS2021_API.Models.DB_UMS
{
    public partial class TblstudentDetail
    {
        [Key]
        public int StudentId { get; set; }
        public int? AcadProgrameId { get; set; }
        public int? Pob { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Mname { get; set; }
        public string NameKh { get; set; }
        public DateTime? Dob { get; set; }
        public string Passport { get; set; }
        public int? GenderId { get; set; } // relationship with TblGender
        public int? Msid { get; set; } // relationship with TblMgstatus
        public int? RaceId { get; set; } 
        public int? NationalId { get; set; }
        public string Photo { get; set; }
        public string Occupation { get; set; }
        public string Phone { get; set; }
        public string Phone2 { get; set; }
        public string Email { get; set; }
        public bool? IsActivated { get; set; }
        public DateTime? RegisterDate { get; set; }
        public string Pwd { get; set; }
        public string Verifycode { get; set; }
        public int? Ssid { get; set; }

        // ================================================== //
        public TblGender TblGender { get; set; }
        public TblMgstatus TblMgstatus { get; set; }
        //public TblRace TblRace { get; set; }
        public TblNational TblNational { get; set; }
    }
}
