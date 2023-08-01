using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace UMS2021_API.Models.DB_LTS
{
    public partial class TblSubCategorie
    {
        public int SubCategoryId { get; set; }
        public string CategoryName { get; set; }
        public int? MainCategoryId { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
    }
}
