using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace UMS2021_API.Models.DB_LTS
{
    public partial class TblEquitment
    {
        public string EquitmentId { get; set; }
        public string Equitment { get; set; }
        public int? ProjectId { get; set; }
        public int? BrandId { get; set; }
        public int? SupplyerId { get; set; }
        public int? SubCategoryId { get; set; }
        public decimal? UnitPrice { get; set; }
        public DateTime? DateIn { get; set; }
        public string Idcard { get; set; }
        public string Picture { get; set; }
        public int? StatusId { get; set; }
        public bool? IsDonated { get; set; }
    }
}
