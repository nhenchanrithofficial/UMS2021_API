using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UMS2021_API.Models.DB_UMS
{
    public partial class TblFamily
    {
        [Key]
        public int FamilyId { get; set; }
        public int? StudentId { get; set; }
        public int? ConnectionId { get; set; }
        public string Name { get; set; }
        public string KhName { get; set; }
        public string Education { get; set; }
        public string Occupation { get; set; }
        public decimal? Income { get; set; }
        public string City { get; set; }
        public string Status { get; set; }
        public string Country { get; set; }
        public string OfficePhone { get; set; }
        public string MobilePhone { get; set; }
        public string Email { get; set; }
        public int? Yob { get; set; }

        // ======================================== //
        public TblConnection TblConnection { get; set; }
    }
}
