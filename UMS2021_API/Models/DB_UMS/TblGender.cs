using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UMS2021_API.Models.DB_UMS
{
    public partial class TblGender
    {
        [Key]
        public int GenderId { get; set; }
        public string GenderName { get; set; }
        public string GenderKh { get; set; }

        // ================================================== //
        public List<TblstudentDetail> TblstudentDetails { get; set; }
    }
}
