using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UMS2021_API.Models.DB_UMS
{
    public partial class TblAddress
    {
        [Key]
        public int AddressId { get; set; }
        public int? StudentId { get; set; }
        public int? AddTypeId { get; set; }
        public string ProvinceId { get; set; }
        public string DistrictId { get; set; }
        public string CommuneId { get; set; }
        public string VillageId { get; set; }
        public string HomeNum { get; set; }
        public string StreetNum { get; set; }

        // ======================================== //
        public TblAddType TblAddType { get; set; }
        public Tblcommune Tblcommune { get; set; }
        public Tbldistrict Tbldistrict { get; set; }
        public Tblprovince Tblprovince { get; set; }
        public Tblvillage Tblvillage { get; set; }
    }
}
