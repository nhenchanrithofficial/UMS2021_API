using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UMS2021_API.Context;
using UMS2023_API.Models.Proc_Models;
using UMS2023_API.Models.PROC_UMS;

namespace UMS2021_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class studentController : ControllerBase
    {
        private readonly UMSDbContext _UMScontext;
        public studentController(UMSDbContext UMScontext, LTSDbContext LTScontext)
        {
            _UMScontext = UMScontext;
        }

        // ========================= Student Profiles ========================= //

        [HttpGet]
        [Route("profile")]
        public IActionResult StudentProfiles()
        {
            var studentProfile = _UMScontext.TblstudentDetail.ToList();

            return Ok(studentProfile);
        }

        [HttpGet]
        [Route("profile/{student_id}")]
        public IActionResult StudentProfiles(int student_id)
        {
            var studentProfile = _UMScontext.TblstudentDetail.Select(s => new
            {
                StudentId = s.StudentId,
                Photo = s.Photo,
                NameKh = s.NameKh,
                FirstName = s.Fname,
                LastName = s.Lname,
                GenderId = s.GenderId, // relation with tblGender
                GenderName = s.TblGender.GenderName,
                GenderKh = s.TblGender.GenderKh,
                MsId = s.Msid, // relation with tblMsid
                MsName = s.TblMgstatus.Msname,
                RaceId = s.RaceId, // relation with tblRace
                                   //Race = s.TblRace.Race,
                NationalId = s.NationalId, // relation with tblNational
                NationalName = s.TblNational.NationalName,
                NationalKh = s.TblNational.NationalKh,
                Passport = s.Passport,
                // ===== Place Of Birth ===== //
                // Commune
                // District
                // City/Province

                // ===== Address ===== //
                // No
                // Street
                // Village
                // Commune
                // District
                // City/Province

                Email = s.Email,
                RegisterDate = s.RegisterDate,
                // FromSchool = 
                IsActivated = s.IsActivated
            }).Where(s => s.StudentId == student_id).FirstOrDefault();

            return Ok(studentProfile);
        }

        [HttpGet]
        [Route("address/{student_id}/{add_type_id}")]
        public IActionResult StudentAddress(int student_id, int add_type_id)
        {
            var studentAddress = _UMScontext.TblAddress.Select(s => new
            {
                AddressId = s.AddressId,
                StudentId = s.StudentId,
                AddTypeId = s.AddTypeId,
                ProvinceId = s.ProvinceId,
                DistrictId = s.DistrictId,
                CommuneId = s.CommuneId,
                VillageId = s.VillageId,
                HomeNum = s.HomeNum,
                StreetNum = s.StreetNum
            }).Where(s => s.StudentId == student_id && s.AddTypeId == add_type_id).ToList();

            return Ok(studentAddress);
        }

        [HttpGet]
        [Route("family/{student_id}")]
        public IActionResult StudentFamily(int student_id)
        {
            var studentFamily = _UMScontext.TblFamily.Select(s => new
            {
                FamilyId = s.FamilyId,
                StudentId = s.StudentId,
                ConnectionId = s.ConnectionId, // relation with TblConnection
                Connection = s.TblConnection.Connection,
                Name = s.Name,
                KhName = s.KhName,
                Education = s.Education,
                Occupation = s.Occupation,
                Income = s.Income,
                City = s.City,
                Status = s.Status,
                Country = s.Country,
                OfficePhone = s.OfficePhone,
                MobilePhone = s.MobilePhone,
                Email = s.Email
            }).Where(s => s.StudentId == student_id).ToList();

            return Ok(studentFamily);
    }

        // ========================= End of Student Profiles ========================= //

        // ========================= Student Courses ========================= //

        [HttpGet]
        [Route("courses")]
        public IActionResult StudentCourses()
        {
            var studentCourse = _UMScontext.StudentCourses.FromSqlRaw<StudentCourses>($"Sp54_StudentProfile_Course 46290, '4', '1st'").ToList();

            return Ok(studentCourse);
        }

        [HttpGet]
        [Route("courses/{student_id}/{year_name}/{semester_name}")]
        public IActionResult StudentCourses(int student_id, string year_name, string semester_name)
        {
            var studentCourse = _UMScontext.StudentCourses.FromSqlRaw<StudentCourses>($"Sp54_StudentProfile_Course { student_id }, '{ year_name }', '{ semester_name }'").ToList();

            return Ok(studentCourse);
        }

        // ========================= Student Attendance ========================= //

        [HttpGet]
        [Route("attendance")]
        public IActionResult StudentAttendance()
        {
            var studentAttendance = _UMScontext.SelectAttendances.FromSqlRaw<SelectAttendances>($"Sp18_SelectStudentAtts 46290, 4, 2").ToList();

            return Ok(studentAttendance);
        }

        [HttpGet]
        [Route("attendance/{student_id}/{year_id}/{semester_id}")]
        public IActionResult StudentAttendance(int student_id, int year_id, int semester_id)
        {
            var studentAtt = _UMScontext.SelectAttendances.FromSqlRaw<SelectAttendances>($"Sp18_SelectStudentAtts { student_id }, { year_id }, { semester_id }").ToList();

            return Ok(studentAtt);
        }
        
        // ========================= Student Fee ========================= //

        [HttpGet]
        [Route("fee")]
        public IActionResult StudentFee()
        {
            var studentFee = _UMScontext.StudentFee.FirstOrDefault();

            return Ok(studentFee);
        }

        [HttpGet]
        [Route("fee/{student_id}")]
        public IActionResult StudentFee(int student_id)
        {
            var studentFee = _UMScontext.StudentFee.Where(s => s.StudentId == student_id).ToList();

            return Ok(studentFee);
        }

        [HttpGet]
        [Route("fee_by_views/{student_id}")]
        public IActionResult StudentFeeByViews(int student_id)
        {
            var studentFee = _UMScontext.VStudentFees.Where(s => s.StudentId == student_id).ToList();

            return Ok(studentFee);
        }

        // ========================= Student Documents ========================= //

        [HttpGet]
        [Route("documents")]
        public IActionResult StudentDocuments()
        {
            var studentDocument = _UMScontext.TblDocAttached.Where(s => s.StudentId == 22306).ToList();

            return Ok(studentDocument);
        }

        [HttpGet]
        [Route("documents/{student_id}")]
        public IActionResult StudentDocuments(int student_id)
        {
            var studentDocument = _UMScontext.TblDocAttached.Select(s => new
            {
                AttachedId = s.AttachedId,
                DocAttached = s.DocAttached,
                FileAttached = s.FileAttached,
                StudentId = s.StudentId,
                DocTypeId = s.TblDocType.DocTypeId,
                DocName = s.TblDocType.DocName,
                DocNameKh = s.TblDocType.DocNameKh
            }).Where(s => s.StudentId == student_id).ToList();

            return Ok(studentDocument);
        }

        // ========================= Student Schedules ========================= //

        [HttpGet]
        [Route("schedules")]
        public IActionResult StudentSchedules()
        {
            var studentSchedule = _UMScontext.StuSchedule.FromSqlRaw<StuSchedule>($"Pro_StuSchedule 22306").ToList();

            return Ok(studentSchedule);
        }

        [HttpGet]
        [Route("schedules/{student_id}")]
        public IActionResult StudentSchedules(int student_id)
        {
            var studentSchedule = _UMScontext.StuSchedule.FromSqlRaw<StuSchedule>($"Pro_StuSchedule { student_id }").ToList();

            return Ok(studentSchedule);
        }

        [HttpGet]
        [Route("schecule-by-acadprogrameid")]
        public IActionResult StudentAcadProgrameId()
        {
            var acadProgrameId = _UMScontext.SelectSchedule.FromSqlRaw<SelectSchedule>($"Sp21_SelectSchedule 9920").ToList();

            return Ok(acadProgrameId);
        }

        [HttpGet]
        [Route("schecule-by-acadprogrameid/{acad_programe_id}")]
        public IActionResult StudentAcadProgrameId(int acad_programe_id)
        {
            var acadProgrameId = _UMScontext.SelectSchedule.FromSqlRaw<SelectSchedule>($"Sp21_SelectSchedule { acad_programe_id }").ToList();

            return Ok(acadProgrameId);
        }

        // ========================= Student My Tasks ========================= //

        // coming soon...

        // ========================= Student Award ========================= //

        // coming soon...

        // ========================= Student Educational Resources ========================= //

        // coming soon...

        // ========================= Student News & Events ========================= //

        [HttpGet]
        [Route("news_and_events")]
        public IActionResult StudentNewsandEvents()
        {
            var studentNewsEvents = _UMScontext.TblEvenInfo.Take(10).OrderByDescending(e => e.EvenId).ToList();

            return Ok(studentNewsEvents);
        }

        [HttpGet]
        [Route("news_and_events/{event_id}")]
        public IActionResult StudentNewsandEvents(int event_id)
        {
            var studentNewsEvents = _UMScontext.TblEvenInfo.Where(e => e.EvenId == event_id).OrderByDescending(e => e.EvenId).ToList();

            return Ok(studentNewsEvents);
        }
    }
}
