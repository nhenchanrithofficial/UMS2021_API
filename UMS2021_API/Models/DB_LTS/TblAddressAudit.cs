using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace UMS2021_API.Models.DB_LTS
{
    public partial class TblAddressAudit
    {
        public int AddressAuditId { get; set; }
        public int AddressId { get; set; }
        public int? PersonId { get; set; }
        public string ProCode { get; set; }
        public string DistCode { get; set; }
        public string ComId { get; set; }
        public string VillId { get; set; }
        public string HomeNum { get; set; }
        public string StreetNum { get; set; }
        public int? AddressStatusId { get; set; }
        public string UserLog { get; set; }
        public string Action { get; set; }
        public DateTime? ActionDate { get; set; }
    }
}
