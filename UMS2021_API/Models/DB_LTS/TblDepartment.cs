using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace UMS2021_API.Models.DB_LTS
{
    public partial class TblDepartment
    {
        public int DepartmentId { get; set; }
        public string Department { get; set; }
        public string DeptEng { get; set; }
        public int? OrderBy { get; set; }
        public int? SubOrderBy { get; set; }
    }
}
