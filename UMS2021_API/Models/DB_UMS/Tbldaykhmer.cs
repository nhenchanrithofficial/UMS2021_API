using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace UMS2021_API.Models.DB_UMS
{
    public partial class Tbldaykhmer
    {
        public int Id { get; set; }
        public int? Year { get; set; }
        public string Month { get; set; }
        public string Day { get; set; }
        public string Daykhmer { get; set; }
        public string Publicholiday { get; set; }
        public string Dayimg { get; set; }
    }
}
