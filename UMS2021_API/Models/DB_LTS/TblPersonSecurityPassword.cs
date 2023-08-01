using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace UMS2021_API.Models.DB_LTS
{
    public partial class TblPersonSecurityPassword
    {
        public int Id { get; set; }
        public string Idcard { get; set; }
        public string Password { get; set; }
        public string PaswordQuestion { get; set; }
        public string PasswordAnswer { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? PasswordChangeDate { get; set; }
        public bool? IsApproved { get; set; }
    }
}
