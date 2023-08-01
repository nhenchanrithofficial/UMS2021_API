using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace UMS2021_API.Models.DB_UMS
{
    public partial class TblEvenRegister
    {
        public int RegisterId { get; set; }
        public string StudentId { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Major { get; set; }
        public string FromUniversity { get; set; }
        public int? EvenId { get; set; }
        public string Photo { get; set; }
        public bool? IsOther { get; set; }
        public DateTime? Date { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}
