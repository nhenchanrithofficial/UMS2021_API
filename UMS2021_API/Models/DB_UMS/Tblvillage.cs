using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UMS2021_API.Models.DB_UMS
{
    public partial class Tblvillage
    {
        [Key]
        public string VillCode { get; set; }
        public string VillName { get; set; }
        public string VillNameUnicode { get; set; }
        public string VillNameLimon { get; set; }

        // ======================================== //
        public List<TblAddress> TblAddresses { get; set; }
    }
}
