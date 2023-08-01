using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace UMS2021_API.Models.DB_UMS
{
    public partial class TblPresenter
    {
        public int Pid { get; set; }
        public string Pname { get; set; }
        public int? GenderId { get; set; }
        public string Pphone { get; set; }
        public string Pemail { get; set; }
        public string Paddress { get; set; }
        public string Pdetail { get; set; }
        public DateTime? Pdate { get; set; }
    }
}
