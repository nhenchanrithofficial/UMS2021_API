using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UMS2021_API.Models.DB_UMS
{
    public partial class TblAddType
    {
        [Key]
        public int AddTypeId { get; set; }
        public string AddType { get; set; }

        // ======================================== //
        public List<TblAddress> TblAddresses { get; set; }
    }
}
