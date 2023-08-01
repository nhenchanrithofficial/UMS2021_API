using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace UMS2021_API.Models.DB_UMS
{
    public partial class VapiStudentAddress
    {
        public int AddressId { get; set; }
        public int? StudentId { get; set; }
        public int? AddTypeId { get; set; }
        public string AddType { get; set; }
        public string ProvinceId { get; set; }
        public string ProName { get; set; }
        public string ProNameUniCode { get; set; }
        public string DistrictId { get; set; }
        public string DistName { get; set; }
        public string DistNameUnicode { get; set; }
        public string CommuneId { get; set; }
        public string ComName { get; set; }
        public string ComNameUnicode { get; set; }
        public string VillageId { get; set; }
        public string VillName { get; set; }
        public string VillNameUnicode { get; set; }
        public string HomeNum { get; set; }
        public string StreetNum { get; set; }
    }
}
