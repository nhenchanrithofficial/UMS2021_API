using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace UMS2021_API.Models.DB_UMS
{
    public partial class TblReferences
    {
        public string ReferenceId { get; set; }
        public int? StatusId { get; set; }
        public string Employee1 { get; set; }
        public string Employee2 { get; set; }
        public DateTime? DateIssue { get; set; }
        public int? RequestTypeId { get; set; }
        public DateTime? DatePrinted { get; set; }
        public string Reason { get; set; }
        public string ReferenceFile { get; set; }
        public string RefApproved { get; set; }
        public string CertificateId { get; set; }
        public string Employee3 { get; set; }
        public DateTime? DateChecked { get; set; }
        public DateTime? DateApproved { get; set; }
    }
}
