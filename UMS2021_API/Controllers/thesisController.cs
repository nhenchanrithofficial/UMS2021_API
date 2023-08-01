using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UMS2021_API.Context;

namespace UMS2021_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class thesisController : ControllerBase
    {
        private readonly UMSDbContext _UMScontext;
        private readonly LTSDbContext _LTScontext;
        public thesisController(UMSDbContext UMScontext, LTSDbContext LTScontext)
        {
            _UMScontext = UMScontext;
            _LTScontext = LTScontext;
        }

        // ========================= Thesis Requesting Form ========================= //

        [HttpGet]
        [Route("batch")]
        public IActionResult GetBatch()
        {
            try
            {
                var Batch = _UMScontext.TblBatch.ToList();

                if (Batch.Count == 0)
                {
                    return StatusCode(404, "Data not found.");
                }

                return Ok(Batch);
            }
            catch (Exception)
            {
                return StatusCode(500, "An error an occurred.");
            }
        }

        [HttpGet]
        [Route("group")]
        public IActionResult GetGroup()
        {
            try
            {
                var Group = _UMScontext.TblGroup.ToList();

                if (Group.Count == 0)
                {
                    return StatusCode(404, "Data not found.");
                }

                return Ok(Group);
            }
            catch (Exception)
            {
                return StatusCode(500, "An error an occurred.");
            }
        }

        [HttpGet]
        [Route("shift")]
        public IActionResult GetShift()
        {
            try
            {
                var Shift = _UMScontext.TblShift.ToList();

                if (Shift.Count == 0)
                {
                    return StatusCode(404, "Data not found.");
                }

                return Ok(Shift);
            }
            catch (Exception)
            {
                return StatusCode(500, "An error an occurred.");
            }
        }

        [HttpGet]
        [Route("faculty")]
        public IActionResult GetFaculty()
        {
            try
            {
                var Faculty = _UMScontext.TblFaculty.ToList();

                if (Faculty.Count == 0)
                {
                    return StatusCode(404, "Data not found.");
                }

                return Ok(Faculty);
            }
            catch (Exception)
            {
                return StatusCode(500, "An error an occurred.");
            }
        }

        [HttpGet]
        [Route("major")]
        public IActionResult GetMajor()
        {
            try
            {
                var Major = _UMScontext.Tblmajor.ToList();

                if (Major.Count == 0)
                {
                    return StatusCode(404, "Data not found.");
                }

                return Ok(Major);
            }
            catch (Exception)
            {
                return StatusCode(500, "An error an occurred.");
            }
        }

        [HttpGet]
        [Route("major_by_facultyid/{facultyId}")]
        public IActionResult GetMajorByFacultyId(int facultyId)
        {
            try
            {
                var Major = (from m in _UMScontext.Tblmajor
                             join f in _UMScontext.TblFaculty on m.FacultyId equals f.FacultyId
                             where f.FacultyId == facultyId
                             select new
                             {
                                 Major = m.MajorId,
                                 MajorName = m.MajorName,
                             }).ToList();

                if (Major == null)
                {
                    return StatusCode(404, "Data not found.");
                }

                return Ok(Major);
            }
            catch (Exception)
            {
                return StatusCode(500, "An error an occurred.");
            }
        }

        [HttpGet]
        [Route("acadprogame_by_studentid/{studentId}")]
        public IActionResult GetAcadProgrameByStudentId(int studentId)
        {
            try
            {
                var acadPro = (from a in _UMScontext.TblAcadPrograme
                               join s in _UMScontext.TblStudentStatus on a.AcadProgrameId equals s.AcadProgrameId
                               join m in _UMScontext.Tblmajor on a.MajorId equals m.MajorId
                               where s.StudentId == studentId
                               orderby a.YearId descending, a.SemesterId descending
                               select new
                               {
                                   AcadProgrameID = a.AcadProgrameId,
                                   YearID = a.YearId,
                                   SemesterID = a.SemesterId,
                                   BatchID = a.BatchId,
                                   GroupID = a.GroupId,
                                   DegreeID = a.DegreeId,
                                   MajorID = a.MajorId,
                                   ShiftID = a.ShiftId,
                                   ClassID = a.ClassId,
                                   AcademicID = a.AcademicId,
                                   FacultyID = m.FacultyId
                               }).FirstOrDefault();

                if (acadPro == null)
                {
                    return StatusCode(404, "Data not found.");
                }

                return Ok(acadPro);
            }
            catch (Exception)
            {
                return StatusCode(500, "An error an occurred.");
            }
        }

        // ========================= Thesis Student Info Form ========================= //

        [HttpGet]
        [Route("national")]
        public IActionResult GetNational()
        {
            try
            {
                var National = _UMScontext.TblNational.ToList();

                if (National.Count == 0)
                {
                    return StatusCode(404, "Data not found.");
                }

                return Ok(National);
            }
            catch (Exception)
            {
                return StatusCode(500, "An error an occurred.");
            }
        }

        [HttpGet]
        [Route("year")]
        public IActionResult GetYear()
        {
            try
            {
                var Year = _UMScontext.Tblyear.ToList();

                if (Year.Count == 0)
                {
                    return StatusCode(404, "Data not found.");
                }

                return Ok(Year);
            }
            catch (Exception)
            {
                return StatusCode(500, "An error an occurred.");
            }
        }

        [HttpGet]
        [Route("semester")]
        public IActionResult GetSemester()
        {
            try
            {
                var Semester = _UMScontext.TblSemester.ToList();

                if (Semester.Count == 0)
                {
                    return StatusCode(404, "Data not found.");
                }

                return Ok(Semester);
            }
            catch (Exception)
            {
                return StatusCode(500, "An error an occurred.");
            }
        }

        // ========================= Student Data ========================= //

        [HttpGet]
        [Route("student_detail")]
        public IActionResult GetTblstudentDetail()
        {
            try
            {
                var StudentDetail = _UMScontext.TblstudentDetail.ToList();

                if (StudentDetail.Count == 0)
                {
                    return StatusCode(404, "Data not found.");
                }

                return Ok(StudentDetail);
            }
            catch (Exception)
            {
                return StatusCode(500, "An error has occurred.");
            }
        }

        [HttpGet]
        [Route("student_detail/{student_id}")]
        public IActionResult GetTblstudentDetail(int student_id)
        {
            try
            {
                var StudentDetail = _UMScontext.TblstudentDetail.FirstOrDefault(c => c.StudentId == student_id);

                if (StudentDetail == null)
                {
                    return StatusCode(404, "No user found.");
                }

                return Ok(StudentDetail);
            }
            catch (Exception)
            {
                return StatusCode(500, "An error has occurred.");
            }
        }

        [HttpGet]
        [Route("student_status")]
        public IActionResult GetTblStudentStatus()
        {
            try
            {
                var AcadPrograme = _UMScontext.TblStudentStatus.ToList();

                if (AcadPrograme.Count == 0)
                {
                    return StatusCode(404, "Data not found.");
                }

                return Ok(AcadPrograme);
            }
            catch (Exception)
            {
                return StatusCode(500, "An error has occurred.");
            }
        }

        [HttpGet]
        [Route("student_status/{student_id}")]
        public IActionResult GetTblStudentStatus(int student_id)
        {
            try
            {
                var StudentStatus = _UMScontext.TblStudentStatus.FirstOrDefault(c => c.StudentId == student_id);

                if (StudentStatus == null)
                {
                    return StatusCode(404, "No user found.");
                }

                return Ok(StudentStatus);
            }
            catch (Exception)
            {
                return StatusCode(500, "An error has occurred.");
            }
        }

        // ========================= Teacher Data ========================= //

        [HttpGet]
        [Route("teacher_detail")]
        public IActionResult GetTeacherDetail()
        {
            try
            {
                var TeacherDetail = _LTScontext.TblPerson.ToList();

                if (TeacherDetail.Count == 0)
                {
                    return StatusCode(404, "Data not found.");
                }

                return Ok(TeacherDetail);
            }
            catch (Exception)
            {
                return StatusCode(500, "An error has occurred.");
            }
        }

        [HttpGet]
        [Route("teacher_details/{teacher_id}")]
        public IActionResult Teacher(int teacher_id)
        {
            try
            {
                var TeacherDetail = _LTScontext.TblPerson.FirstOrDefault(c => c.PersonId == teacher_id);

                if (TeacherDetail == null)
                {
                    return StatusCode(404, "No user found.");
                }

                return Ok(TeacherDetail);
            }
            catch (Exception)
            {
                return StatusCode(500, "An error has occurred.");
            }
        }

        // ========================= AcadPrograme Data  ========================= //

        [HttpGet]
        [Route("acad_programe")]
        public IActionResult GetTblAcadPrograme()
        {
            try
            {
                var AcadPrograme = _UMScontext.TblAcadPrograme.ToList();

                if (AcadPrograme.Count == 0)
                {
                    return StatusCode(404, "Data not found.");
                }

                return Ok(AcadPrograme);
            }
            catch (Exception)
            {
                return StatusCode(500, "An error has occurred.");
            }
        }

        [HttpGet]
        [Route("acad_programe/{acad_programe_id}")]
        public IActionResult GetTblAcadPrograme(int acad_programe_id)
        {
            try
            {
                var AcadPrograme = (from a in _UMScontext.TblAcadPrograme
                                    join y in _UMScontext.Tblyear on a.YearId equals y.YearId
                                    join s in _UMScontext.TblSemester on a.SemesterId equals s.SemesterId
                                    join b in _UMScontext.TblBatch on a.BatchId equals b.BatchId
                                    join g in _UMScontext.TblGroup on a.GroupId equals g.GroupId
                                    join m in _UMScontext.Tblmajor on a.MajorId equals m.MajorId
                                    join f in _UMScontext.TblFaculty on m.FacultyId equals f.FacultyId
                                    join sh in _UMScontext.TblShift on a.ShiftId equals sh.ShiftId
                                    where a.AcadProgrameId == acad_programe_id
                                    select new
                                    {
                                        AcadProgrameId = a.AcadProgrameId,
                                        YearId = a.YearId,
                                        YearName = y.YearName,
                                        SemesterId = a.SemesterId,
                                        SemesterName = s.SemesterName,
                                        BatchId = a.BatchId,
                                        BatchName = b.BatchName,
                                        GroupId = a.GroupId,
                                        GroupName = g.GroupName,
                                        MajorId = a.MajorId,
                                        MajorName = m.MajorName,
                                        MajorKh = m.MajorKh,
                                        FacultyId = m.FacultyId,
                                        FacultyName = f.FacultyName,
                                        FacultyKh = f.FacultyKh,
                                        ShiftId = a.ShiftId,
                                        Shift = sh.Shift,
                                        ShiftKh = sh.ShiftKh
                                    }).FirstOrDefault();

                if (AcadPrograme == null)
                {
                    return StatusCode(404, "Data not found.");
                }

                return Ok(AcadPrograme);
            }
            catch (Exception)
            {
                return StatusCode(500, "An error has occurred.");
            }
        }

        [HttpGet]
        [Route("acad_pro_by_stun_id")]
        public IActionResult GetAcademicPro()
        {
            try
            {
                var AcadPrograme = (from p in _UMScontext.TblAcadPrograme
                                    join s in _UMScontext.TblStudentStatus on p.AcadProgrameId equals s.AcadProgrameId
                                    select new
                                    {
                                        AcadProgrameId = p.AcadProgrameId,
                                        YearID = p.YearId,
                                        SemesterID = p.SemesterId,
                                        BatchID = p.BatchId,
                                        GroupID = p.GroupId,
                                        DegreeID = p.DegreeId,
                                        MajorID = p.MajorId,
                                        ShiftID = p.ShiftId,
                                        ClassID = p.ClassId,
                                        AcadDateStart = p.AcadDateStart,
                                        AcadDateEnd = p.AcadDateEnd
                                    }).ToList();

                if (AcadPrograme == null)
                {
                    return StatusCode(404, "Data not found.");
                }

                return Ok(AcadPrograme);
            }
            catch (Exception)
            {
                return StatusCode(500, "An error has occurred.");
            }
        }

        [HttpGet]
        [Route("acad_pro_by_stun_id/{stun_id}")]
        public IActionResult GetAcademicPro(int stun_id)
        {
            try
            {
                var AcadPrograme = (from p in _UMScontext.TblAcadPrograme
                                    join s in _UMScontext.TblStudentStatus on p.AcadProgrameId equals s.AcadProgrameId
                                    where s.StudentId == stun_id
                                    orderby p.YearId descending, p.SemesterId descending
                                    select new
                                    {
                                        AcadProgrameId = p.AcadProgrameId,
                                        YearID = p.YearId,
                                        SemesterID = p.SemesterId,
                                        BatchID = p.BatchId,
                                        GroupID = p.GroupId,
                                        DegreeID = p.DegreeId,
                                        MajorID = p.MajorId,
                                        ShiftID = p.ShiftId,
                                        ClassID = p.ClassId,
                                        AcadDateStart = p.AcadDateStart,
                                        AcadDateEnd = p.AcadDateEnd
                                    }).FirstOrDefault();

                if (AcadPrograme == null)
                {
                    return StatusCode(404, "Data not found.");
                }

                return Ok(AcadPrograme);
            }
            catch (Exception)
            {
                return StatusCode(500, "An error has occurred.");
            }
        }

        // =========================  ========================= //
    }
}
