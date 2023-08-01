using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace UMS2021_API.Models.DB_UMS
{
    public partial class TblConnection
    {
        [Key]
        public int ConnectionId { get; set; }
        public string Connection { get; set; }

        // ======================================== //
        public List<TblFamily> TblFamily { get; set; }
    }
}
