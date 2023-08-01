using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace UMS2021_API.Models.DB_UMS
{
    public partial class TblDocAttached
    {
        [Key]
        public int AttachedId { get; set; }
        public string DocAttached { get; set; }
        public string FileAttached { get; set; }
        public int? StudentId { get; set; }
        public int? DocTypeId { get; set; }

        // ================================================== //
        public TblDocType TblDocType { get; set; }
    }
}
