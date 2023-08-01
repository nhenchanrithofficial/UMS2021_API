using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace UMS2021_API.Models.DB_LTS
{
    public partial class TblGender
    {
        public int GenderId { get; set; }
        public string GenderName { get; set; }
        public string SexEng { get; set; }
    }
}
