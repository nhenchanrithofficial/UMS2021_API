using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UMS2021_API.Models.DB_UMS
{
    public partial class Tblcommune
    {
        [Key]
        public string ComCode { get; set; }
        public string ComName { get; set; }
        public string ComNameUnicode { get; set; }
        public string ComNameLimon { get; set; }

        // ======================================== //
        public List<TblAddress> TblAddresses { get; set; }
    }
}
