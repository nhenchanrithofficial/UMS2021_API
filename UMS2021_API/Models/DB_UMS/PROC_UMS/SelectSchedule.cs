using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UMS2023_API.Models.PROC_UMS
{
    public class SelectSchedule
    {
        public int ID { get; set; }
        public string Time { get; set; }
        public int MonID { get; set; }
        public string Monday { get; set; }
        public int TueID { get; set; }
        public string Tuesday { get; set; }
        public int WedID { get; set; }
        public string Wednesday { get; set; }
        public int ThuID { get; set; }
        public string Thursday { get; set; }
        public int FriID { get; set; }
        public string Friday { get; set; }
        public int ShiftID { get; set; }
        public string DegreeName { get; set; }
        public string FacultyName { get; set; }
        public string MajorName { get; set; }
        public string AcademicName { get; set; }
        public string BG { get; set; }
        public string YS { get; set; }
        public string Shift { get; set; }
        public DateTime AcadDateStart { get; set; }
        public DateTime AcadDateEnd { get; set; }
    }
}
