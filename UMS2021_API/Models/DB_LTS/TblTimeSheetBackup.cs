using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace UMS2021_API.Models.DB_LTS
{
    public partial class TblTimeSheetBackup
    {
        public int TimeSheetBackupId { get; set; }
        public int? CloseProcessId { get; set; }
        public string TimeSheetType { get; set; }
        public int TimeSheetCode { get; set; }
    }
}
