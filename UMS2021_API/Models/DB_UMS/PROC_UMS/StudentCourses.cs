using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UMS2023_API.Models.PROC_UMS
{
    public class StudentCourses
    {
        public int SubjectID { get; set; }
        public string Subject { get; set; }
        public double Attentance { get; set; }
        public double MidTerm { get; set; }
        public double Assignment { get; set; }
        public string Final { get; set; }
        public double Total { get; set; }
        public double? ReExam { get; set; }
        public int SbjTakenID { get; set; }
        public int FacultyID { get; set; }
        public double FinalScore { get; set; }
        public string Result { get; set; }
        public int Hide { get; set; }
    }
}
