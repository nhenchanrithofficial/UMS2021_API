using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UMS2021_API.Models.DB_UMS
{
    public partial class TblMgstatus
    {
        [Key]
        public int Msid { get; set; }
        public string Msname { get; set; }

        // ================================================== //
        public List<TblstudentDetail> TblstudentDetails { get; set; }
    }
}
