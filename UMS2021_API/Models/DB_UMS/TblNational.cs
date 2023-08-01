using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UMS2021_API.Models.DB_UMS
{
    public partial class TblNational
    {
        [Key]
        public int NationalId { get; set; }
        public string NationalName { get; set; }
        public string NationalKh { get; set; }
        public string Country { get; set; }

        // ================================================== //
        public List<TblstudentDetail> TblstudentDetails { get; set; }
    }
}
