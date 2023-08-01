using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UMS2021_API.Models.DB_UMS
{
    public partial class TblDocType
    {
        [Key]
        public int DocTypeId { get; set; }
        public string DocName { get; set; }
        public string DocNameKh { get; set; }

        // ================================================== //
        public List<TblDocAttached> TblDocAttached { get; set; }
    }
}
