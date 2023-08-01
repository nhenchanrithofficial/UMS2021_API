using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace UMS2021_API.Models.DB_UMS
{
    public partial class DeleteTransaction
    {
        public Guid AuditLogId { get; set; }
        public string AuditLogType { get; set; }
        public string AuditRecieptId { get; set; }
        public decimal? AuditFeesAmount { get; set; }
        public decimal? AuditAmountPaid { get; set; }
        public string AuditMoneyIdentifier { get; set; }
        public string AuditNote { get; set; }
        public string AuditUser { get; set; }
        public DateTime? AuditChanged { get; set; }
        public int? StudentId { get; set; }
        public string StudentName { get; set; }
    }
}
