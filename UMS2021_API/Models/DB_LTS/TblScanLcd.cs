using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace UMS2021_API.Models.DB_LTS
{
    public partial class TblScanLcd
    {
        public int ScanLcdid { get; set; }
        public string EquitmentId { get; set; }
        public int? StudentId { get; set; }
        public int? ReturnId { get; set; }
        public DateTime? Date { get; set; }
        public DateTime? TimeTakeIn { get; set; }
        public DateTime? TimeTakeOut { get; set; }
    }
}
