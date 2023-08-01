using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UMS2021_API.Models.DB_UMS
{
    public partial class Tblprovince
    {
        [Key]
        public string ProCode { get; set; }
        public string ProName { get; set; }
        public string ProNameUniCode { get; set; }
        public string ProNameLimon { get; set; }
        public int? IsCity { get; set; }

        // ======================================== //
        public List<TblAddress> TblAddresses { get; set; }
    }
}
