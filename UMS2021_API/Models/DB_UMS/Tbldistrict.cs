using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UMS2021_API.Models.DB_UMS
{
    public partial class Tbldistrict
    {
        [Key]
        public string DistCode { get; set; }
        public string DistName { get; set; }
        public string DistNameUnicode { get; set; }
        public string DistNameLimon { get; set; }
        public bool? IsTown { get; set; }

        // ======================================== //
        public List<TblAddress> TblAddresses { get; set; }
    }
}
