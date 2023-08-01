using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UMS2023_API.Models.Proc_Models
{
    public class SelectAttendances
    {
        public int SubjectID { get; set; }
        public string Subject { get; set; }
        public int T { get; set; }
        public int A { get; set; }
        public int P { get; set; }
        public int Year1 { get; set; }
        public int Semester1 { get; set; }
    }
}
