using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using UMS2021_API.Models.DB_UMS;
using UMS2023_API.Models.Proc_Models;
using UMS2023_API.Models.PROC_UMS;

namespace UMS2021_API.Context
{
    public partial class UMSDbContext : DbContext
    {
        public UMSDbContext()
        {
        }

        public UMSDbContext(DbContextOptions<UMSDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AllMbabatch> AllMbabatch { get; set; }
        public virtual DbSet<AllPhDbatch> AllPhDbatch { get; set; }
        public virtual DbSet<CopiedSbjTakenUpdate> CopiedSbjTakenUpdate { get; set; }
        public virtual DbSet<DeleteTransaction> DeleteTransaction { get; set; }
        public virtual DbSet<EditTransaction> EditTransaction { get; set; }
        public virtual DbSet<EmpyeeAttendance> EmpyeeAttendance { get; set; }
        public virtual DbSet<FeeHeading> FeeHeading { get; set; }
        public virtual DbSet<FeeType> FeeType { get; set; }
        public virtual DbSet<Fees> Fees { get; set; }
        public virtual DbSet<NewTransaction> NewTransaction { get; set; }
        public virtual DbSet<Presentation> Presentation { get; set; }
        public virtual DbSet<ResearchDocument> ResearchDocument { get; set; }
        public virtual DbSet<SelectAcademic> SelectAcademic { get; set; }
        public virtual DbSet<Sheet1> Sheet1 { get; set; }
        public virtual DbSet<Show> Show { get; set; }
        public virtual DbSet<StudentFee> StudentFee { get; set; }
        public virtual DbSet<StunChoice> StunChoice { get; set; }
        public virtual DbSet<TblAcadNoted> TblAcadNoted { get; set; }
        public virtual DbSet<TblAcadPrograme> TblAcadPrograme { get; set; }
        public virtual DbSet<TblAddType> TblAddType { get; set; }
        public virtual DbSet<TblAddress> TblAddress { get; set; }
        public virtual DbSet<TblAttendanc> TblAttendanc { get; set; }
        public virtual DbSet<TblAuditAddScores> TblAuditAddScores { get; set; }
        public virtual DbSet<TblAuditDeleteScores> TblAuditDeleteScores { get; set; }
        public virtual DbSet<TblAuditEditScores> TblAuditEditScores { get; set; }
        public virtual DbSet<TblBatch> TblBatch { get; set; }
        public virtual DbSet<TblBuilding> TblBuilding { get; set; }
        public virtual DbSet<TblClass> TblClass { get; set; }
        public virtual DbSet<TblConnection> TblConnection { get; set; }
        public virtual DbSet<TblDateExam> TblDateExam { get; set; }
        public virtual DbSet<TblDayWeek> TblDayWeek { get; set; }
        public virtual DbSet<TblDegree> TblDegree { get; set; }
        public virtual DbSet<TblDepartment> TblDepartment { get; set; }
        public virtual DbSet<TblDocAttached> TblDocAttached { get; set; }
        public virtual DbSet<TblDocType> TblDocType { get; set; }
        public virtual DbSet<TblEvenInfo> TblEvenInfo { get; set; }
        public virtual DbSet<TblEvenRegister> TblEvenRegister { get; set; }
        public virtual DbSet<TblEventOrganizer> TblEventOrganizer { get; set; }
        public virtual DbSet<TblEventSchedule> TblEventSchedule { get; set; }
        public virtual DbSet<TblEventScheduleResource> TblEventScheduleResource { get; set; }
        public virtual DbSet<TblEvents> TblEvents { get; set; }
        public virtual DbSet<TblExaminationNote> TblExaminationNote { get; set; }
        public virtual DbSet<TblFaculty> TblFaculty { get; set; }
        public virtual DbSet<TblFamily> TblFamily { get; set; }
        public virtual DbSet<TblGender> TblGender { get; set; }
        public virtual DbSet<TblGroup> TblGroup { get; set; }
        public virtual DbSet<TblLuckyDraw> TblLuckyDraw { get; set; }
        public virtual DbSet<TblMgstatus> TblMgstatus { get; set; }
        public virtual DbSet<TblNational> TblNational { get; set; }
        public virtual DbSet<TblNotedType> TblNotedType { get; set; }
        public virtual DbSet<TblOccupations> TblOccupations { get; set; }
        public virtual DbSet<TblPresenter> TblPresenter { get; set; }
        public virtual DbSet<TblRace> TblRace { get; set; }
        public virtual DbSet<TblReceiptDetail> TblReceiptDetail { get; set; }
        public virtual DbSet<TblReceipts> TblReceipts { get; set; }
        public virtual DbSet<TblRecordType> TblRecordType { get; set; }
        public virtual DbSet<TblReferences> TblReferences { get; set; }
        public virtual DbSet<TblRelationPp> TblRelationPp { get; set; }
        public virtual DbSet<TblRequestType> TblRequestType { get; set; }
        public virtual DbSet<TblRoom> TblRoom { get; set; }
        public virtual DbSet<TblSbjTaken> TblSbjTaken { get; set; }
        public virtual DbSet<TblSbjType> TblSbjType { get; set; }
        public virtual DbSet<TblSchedule> TblSchedule { get; set; }
        public virtual DbSet<TblScholarGranted> TblScholarGranted { get; set; }
        public virtual DbSet<TblScholarship> TblScholarship { get; set; }
        public virtual DbSet<TblScholarshipTemp> TblScholarshipTemp { get; set; }
        public virtual DbSet<TblSemester> TblSemester { get; set; }
        public virtual DbSet<TblShift> TblShift { get; set; }
        public virtual DbSet<TblSkill> TblSkill { get; set; }
        public virtual DbSet<TblStudentSituations> TblStudentSituations { get; set; }
        public virtual DbSet<TblStudentStatus> TblStudentStatus { get; set; }
        public virtual DbSet<TblStudentTranscript> TblStudentTranscript { get; set; }
        public virtual DbSet<TblStunRecord> TblStunRecord { get; set; }
        public virtual DbSet<TblSubject> TblSubject { get; set; }
        public virtual DbSet<TblSubjectBatch> TblSubjectBatch { get; set; }
        public virtual DbSet<TblSubjectKhmer> TblSubjectKhmer { get; set; }
        public virtual DbSet<TblSubjectOriented> TblSubjectOriented { get; set; }
        public virtual DbSet<TblSubjectOriginal> TblSubjectOriginal { get; set; }
        public virtual DbSet<TblTime> TblTime { get; set; }
        public virtual DbSet<Tblacademic> Tblacademic { get; set; }
        public virtual DbSet<Tblcommune> Tblcommune { get; set; }
        public virtual DbSet<Tbldaykhmer> Tbldaykhmer { get; set; }
        public virtual DbSet<Tbldistrict> Tbldistrict { get; set; }
        public virtual DbSet<TblkhmerMonth> TblkhmerMonth { get; set; }
        public virtual DbSet<TblkhmerYear> TblkhmerYear { get; set; }
        public virtual DbSet<TblkhmerYearName> TblkhmerYearName { get; set; }
        public virtual DbSet<Tblmajor> Tblmajor { get; set; }
        public virtual DbSet<Tblprovince> Tblprovince { get; set; }
        public virtual DbSet<TblstudentDetail> TblstudentDetail { get; set; }
        public virtual DbSet<Tblvillage> Tblvillage { get; set; }
        public virtual DbSet<Tblyear> Tblyear { get; set; }
        public virtual DbSet<Transaction> Transaction { get; set; }
        public virtual DbSet<Tz01ConstantData> Tz01ConstantData { get; set; }
        public virtual DbSet<Tz02BuildingPlan> Tz02BuildingPlan { get; set; }
        public virtual DbSet<V2SelectAcademicDetails> V2SelectAcademicDetails { get; set; }
        public virtual DbSet<V3CountTeachersReport> V3CountTeachersReport { get; set; }
        public virtual DbSet<V4ReExam> V4ReExam { get; set; }
        public virtual DbSet<V4TotalStudentReport> V4TotalStudentReport { get; set; }
        public virtual DbSet<V5SchoolPromotion> V5SchoolPromotion { get; set; }
        public virtual DbSet<V5TotalAttandence> V5TotalAttandence { get; set; }
        public virtual DbSet<V6StudentChangedFromOtherSchool> V6StudentChangedFromOtherSchool { get; set; }
        public virtual DbSet<V7StudentReExamScores> V7StudentReExamScores { get; set; }
        public virtual DbSet<VDailyCollectionFee> VDailyCollectionFee { get; set; }
        public virtual DbSet<VListAcademic> VListAcademic { get; set; }
        public virtual DbSet<VSelectAcadeTitle> VSelectAcadeTitle { get; set; }
        public virtual DbSet<VSelectAcademicTitle> VSelectAcademicTitle { get; set; }
        public virtual DbSet<VSelectAcademicTitleStudentId> VSelectAcademicTitleStudentId { get; set; }
        public virtual DbSet<VStudentFees> VStudentFees { get; set; }
        public virtual DbSet<VStudentFeesTransac> VStudentFeesTransac { get; set; }
        public virtual DbSet<VStudentScholarship> VStudentScholarship { get; set; }
        public virtual DbSet<VStudentStatus> VStudentStatus { get; set; }
        public virtual DbSet<Vapi1StudentLevels> Vapi1StudentLevels { get; set; }
        public virtual DbSet<VapiStudentAddress> VapiStudentAddress { get; set; }
        public virtual DbSet<VapiStudentProfile> VapiStudentProfile { get; set; }
        public virtual DbSet<ViewIndividual> ViewIndividual { get; set; }
        public virtual DbSet<VsTeachersReport> VsTeachersReport { get; set; }

        // ================================================================================//

        public virtual DbSet<StudentCourses> StudentCourses { get; set; }
        public virtual DbSet<SelectAttendances> SelectAttendances { get; set; }
        public virtual DbSet<StuSchedule> StuSchedule { get; set; }
        public virtual DbSet<SelectSchedule> SelectSchedule { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DRXTECH\\SQLEXPRESS;Database=UMS06012014;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblstudentDetail>().HasOne(a => a.TblGender).WithMany(a => a.TblstudentDetails).HasForeignKey(a => a.GenderId).OnDelete(DeleteBehavior.SetNull);
            modelBuilder.Entity<TblstudentDetail>().HasOne(a => a.TblMgstatus).WithMany(a => a.TblstudentDetails).HasForeignKey(a => a.Msid).OnDelete(DeleteBehavior.SetNull);
            //modelBuilder.Entity<TblstudentDetail>().HasOne(a => a.TblRace).WithMany(a => a.TblstudentDetails).HasForeignKey(a => a.RaceId).OnDelete(DeleteBehavior.SetNull);
            modelBuilder.Entity<TblstudentDetail>().HasOne(a => a.TblNational).WithMany(a => a.TblstudentDetails).HasForeignKey(a => a.NationalId).OnDelete(DeleteBehavior.SetNull);
            // ========================= TblStudentDetail Relation ========================= //
            modelBuilder.Entity<TblDocAttached>().HasOne(a => a.TblDocType).WithMany(a => a.TblDocAttached).HasForeignKey(a => a.DocTypeId).OnDelete(DeleteBehavior.SetNull);
            // ========================= TblDocAttached Relation ========================= //
            modelBuilder.Entity<TblAddress>().HasOne(a => a.TblAddType).WithMany(a => a.TblAddresses).HasForeignKey(a => a.AddTypeId).OnDelete(DeleteBehavior.SetNull);
            modelBuilder.Entity<TblAddress>().HasOne(a => a.Tblprovince).WithMany(a => a.TblAddresses).HasForeignKey(a => a.ProvinceId).OnDelete(DeleteBehavior.SetNull);
            //modelBuilder.Entity<TblAddress>().HasOne(a => a.TblAddType).WithMany(a => a.TblAddresses).HasForeignKey(a => a.AddTypeId).OnDelete(DeleteBehavior.SetNull);
            //modelBuilder.Entity<TblAddress>().HasOne(a => a.TblAddType).WithMany(a => a.TblAddresses).HasForeignKey(a => a.AddTypeId).OnDelete(DeleteBehavior.SetNull);
            //modelBuilder.Entity<TblAddress>().HasOne(a => a.TblAddType).WithMany(a => a.TblAddresses).HasForeignKey(a => a.AddTypeId).OnDelete(DeleteBehavior.SetNull);
            // ========================= TblAddress Relation ========================= //
            modelBuilder.Entity<TblFamily>().HasOne(a => a.TblConnection).WithMany(a => a.TblFamily).HasForeignKey(a => a.ConnectionId).OnDelete(DeleteBehavior.SetNull);
            // ========================= TblFamily Relation ========================= //

            modelBuilder.Entity<AllMbabatch>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AllMBABatch");

                entity.Property(e => e.AcadProgrameId).HasColumnName("AcadProgrameID");

                entity.Property(e => e.Dob)
                    .HasColumnName("DOB")
                    .HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(35);

                entity.Property(e => e.Fname)
                    .HasColumnName("FName")
                    .HasMaxLength(25);

                entity.Property(e => e.FullName)
                    .HasColumnName("Full Name")
                    .HasMaxLength(255);

                entity.Property(e => e.GenderId).HasColumnName("GenderID");

                entity.Property(e => e.Lname)
                    .HasColumnName("LName")
                    .HasMaxLength(25);

                entity.Property(e => e.NameKh).HasMaxLength(100);

                entity.Property(e => e.Phone).HasMaxLength(25);

                entity.Property(e => e.Pob).HasColumnName("POB");

                entity.Property(e => e.StudentId)
                    .HasColumnName("StudentID")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<AllPhDbatch>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AllPhDBatch");

                entity.Property(e => e.AcadProgrameId).HasColumnName("AcadProgrameID");

                entity.Property(e => e.Dob)
                    .HasColumnName("DOB")
                    .HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(35);

                entity.Property(e => e.Fname)
                    .HasColumnName("FName")
                    .HasMaxLength(25);

                entity.Property(e => e.FullName)
                    .HasColumnName("Full Name")
                    .HasMaxLength(255);

                entity.Property(e => e.GenderId).HasColumnName("GenderID");

                entity.Property(e => e.Lname)
                    .HasColumnName("LName")
                    .HasMaxLength(25);

                entity.Property(e => e.NameKh).HasMaxLength(100);

                entity.Property(e => e.Phone).HasMaxLength(25);

                entity.Property(e => e.Pob).HasColumnName("POB");

                entity.Property(e => e.StudentId)
                    .HasColumnName("StudentID")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<CopiedSbjTakenUpdate>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.LogDate).HasColumnType("datetime");

                entity.Property(e => e.LogId).HasColumnName("LogID");

                entity.Property(e => e.LogType)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LogUser)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.SubjectId).HasColumnName("SubjectID");
            });

            modelBuilder.Entity<DeleteTransaction>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAmountPaid)
                    .HasColumnName("audit_amountPaid")
                    .HasColumnType("money");

                entity.Property(e => e.AuditChanged)
                    .HasColumnName("audit_changed")
                    .HasColumnType("datetime");

                entity.Property(e => e.AuditFeesAmount)
                    .HasColumnName("audit_feesAmount")
                    .HasColumnType("money");

                entity.Property(e => e.AuditLogId).HasColumnName("audit_log_id");

                entity.Property(e => e.AuditLogType)
                    .HasColumnName("audit_log_type")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AuditMoneyIdentifier)
                    .HasColumnName("audit_moneyIdentifier")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AuditNote)
                    .HasColumnName("audit_Note")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.AuditRecieptId)
                    .HasColumnName("audit_RecieptID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AuditUser)
                    .HasColumnName("audit_user")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.Property(e => e.StudentName).HasMaxLength(100);
            });

            modelBuilder.Entity<EditTransaction>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAmountPaid)
                    .HasColumnName("audit_amountPaid")
                    .HasColumnType("money");

                entity.Property(e => e.AuditChanged)
                    .HasColumnName("audit_changed")
                    .HasColumnType("datetime");

                entity.Property(e => e.AuditFeesAmount)
                    .HasColumnName("audit_feesAmount")
                    .HasColumnType("money");

                entity.Property(e => e.AuditLogId).HasColumnName("audit_log_id");

                entity.Property(e => e.AuditLogType)
                    .HasColumnName("audit_log_type")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AuditMoneyIdentifier)
                    .HasColumnName("audit_moneyIdentifier")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AuditNote)
                    .HasColumnName("audit_Note")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.AuditRecieptId)
                    .HasColumnName("audit_RecieptID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AuditUser)
                    .HasColumnName("audit_user")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.Property(e => e.StudentName).HasMaxLength(100);
            });

            modelBuilder.Entity<EmpyeeAttendance>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.DateCaption)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DateIssue).HasColumnType("date");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.EmpAttId).HasColumnName("EmpAttID");

                entity.Property(e => e.FilePath)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FeeHeading>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.FeeHeading1)
                    .HasColumnName("FeeHeading")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.FeeHeadingId).HasColumnName("FeeHeadingID");
            });

            modelBuilder.Entity<FeeType>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.FeeType1)
                    .HasColumnName("FeeType")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.FeeTypeId).HasColumnName("FeeTypeID");
            });

            modelBuilder.Entity<Fees>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AcadProgrameId).HasColumnName("AcadProgrameID");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.BatchId).HasColumnName("BatchID");

                entity.Property(e => e.DegreeId).HasColumnName("DegreeID");

                entity.Property(e => e.FeeHeading)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FeeId).HasColumnName("FeeID");

                entity.Property(e => e.FeeTypeId).HasColumnName("FeeTypeID");

                entity.Property(e => e.MajorId).HasColumnName("MajorID");

                entity.Property(e => e.SemesterId).HasColumnName("SemesterID");

                entity.Property(e => e.YearId).HasColumnName("YearID");
            });

            modelBuilder.Entity<NewTransaction>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAmountPaid)
                    .HasColumnName("audit_amountPaid")
                    .HasColumnType("money");

                entity.Property(e => e.AuditChanged)
                    .HasColumnName("audit_changed")
                    .HasColumnType("datetime");

                entity.Property(e => e.AuditFeesAmount)
                    .HasColumnName("audit_feesAmount")
                    .HasColumnType("money");

                entity.Property(e => e.AuditLogId).HasColumnName("audit_log_id");

                entity.Property(e => e.AuditLogType)
                    .HasColumnName("audit_log_type")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AuditMoneyIdentifier)
                    .HasColumnName("audit_moneyIdentifier")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AuditNote)
                    .HasColumnName("audit_Note")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.AuditRecieptId)
                    .HasColumnName("audit_RecieptID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AuditUser)
                    .HasColumnName("audit_user")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.Property(e => e.StudentName).HasMaxLength(100);
            });

            modelBuilder.Entity<Presentation>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Assessors)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DateIssue).HasColumnType("date");

                entity.Property(e => e.Evaluation)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.IsApproval).HasColumnName("isApproval");

                entity.Property(e => e.Location)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PresentId).HasColumnName("PresentID");

                entity.Property(e => e.Rdid).HasColumnName("RDID");

                entity.Property(e => e.ShowId).HasColumnName("ShowID");

                entity.Property(e => e.Title).HasMaxLength(400);
            });

            modelBuilder.Entity<ResearchDocument>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Advisors)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ChoiceId).HasColumnName("ChoiceID");

                entity.Property(e => e.Rdid).HasColumnName("RDID");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.Topic)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TopicKh)
                    .HasColumnName("TopicKH")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<SelectAcademic>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SelectAcademic");

                entity.Property(e => e.AcadDateEnd).HasColumnType("datetime");

                entity.Property(e => e.AcadDateStart).HasColumnType("datetime");

                entity.Property(e => e.AcadProgrameId).HasColumnName("AcadProgrameID");

                entity.Property(e => e.AcadTitle)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.AcademicId).HasColumnName("AcademicID");

                entity.Property(e => e.BatchId).HasColumnName("BatchID");

                entity.Property(e => e.DegreeId).HasColumnName("DegreeID");

                entity.Property(e => e.FacultyId).HasColumnName("FacultyID");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.KeyCode).HasMaxLength(5);

                entity.Property(e => e.MajorId).HasColumnName("MajorID");

                entity.Property(e => e.SemesterId).HasColumnName("SemesterID");

                entity.Property(e => e.ShiftId).HasColumnName("ShiftID");

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.Property(e => e.YearId).HasColumnName("YearID");
            });

            modelBuilder.Entity<Sheet1>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.NameLimon).HasMaxLength(255);

                entity.Property(e => e.NameUnicode).HasMaxLength(255);

                entity.Property(e => e.StunId).HasColumnName("Stun#ID");
            });

            modelBuilder.Entity<Show>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ChoiceId).HasColumnName("ChoiceID");

                entity.Property(e => e.ShowId).HasColumnName("ShowID");

                entity.Property(e => e.ShowWhat)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StudentFee>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.FeeId).HasColumnName("FeeID");

                entity.Property(e => e.IsOld).HasColumnName("isOld");

                entity.Property(e => e.SemesterId).HasColumnName("SemesterID");

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.Property(e => e.YearId).HasColumnName("YearID");
            });

            modelBuilder.Entity<StunChoice>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ChoiceId).HasColumnName("ChoiceID");

                entity.Property(e => e.StunChoice1)
                    .HasColumnName("StunChoice")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblAcadNoted>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblAcadNoted");

                entity.Property(e => e.AcadProgramId).HasColumnName("AcadProgramID");

                entity.Property(e => e.ChangClassId).HasColumnName("ChangClassID");

                entity.Property(e => e.DateIsue).HasColumnType("date");

                entity.Property(e => e.LastMajor).HasMaxLength(200);

                entity.Property(e => e.Note).HasMaxLength(500);

                entity.Property(e => e.NotedId).HasColumnName("NotedID");

                entity.Property(e => e.SchoolNameKh).HasMaxLength(200);

                entity.Property(e => e.Status)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StatusId).HasColumnName("StatusID");
            });

            modelBuilder.Entity<TblAcadPrograme>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AcadDateEnd).HasColumnType("datetime");

                entity.Property(e => e.AcadDateIsue).HasColumnType("datetime");

                entity.Property(e => e.AcadDateStart).HasColumnType("datetime");

                entity.Property(e => e.AcadProgrameId).HasColumnName("AcadProgrameID");

                entity.Property(e => e.AcadTitle)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.AcademicId).HasColumnName("AcademicID");

                entity.Property(e => e.BatchId).HasColumnName("BatchID");

                entity.Property(e => e.ClassId).HasColumnName("ClassID");

                entity.Property(e => e.DateCompletion).HasColumnType("date");

                entity.Property(e => e.DegreeId).HasColumnName("DegreeID");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.KeyCode).HasMaxLength(5);

                entity.Property(e => e.MajorId).HasColumnName("MajorID");

                entity.Property(e => e.SemesterId).HasColumnName("SemesterID");

                entity.Property(e => e.ShiftId).HasColumnName("ShiftID");

                entity.Property(e => e.YearId).HasColumnName("YearID");
            });

            //modelBuilder.Entity<TblAddType>(entity =>
            //{
            //    entity.HasNoKey();

            //    entity.Property(e => e.AddType)
            //        .HasMaxLength(30)
            //        .IsUnicode(false);

            //    entity.Property(e => e.AddTypeId).HasColumnName("AddTypeID");
            //});

            //modelBuilder.Entity<TblAddress>(entity =>
            //{
            //    entity.HasNoKey();

            //    entity.Property(e => e.AddTypeId).HasColumnName("AddTypeID");

            //    entity.Property(e => e.AddressId).HasColumnName("AddressID");

            //    entity.Property(e => e.CommuneId)
            //        .HasColumnName("CommuneID")
            //        .HasMaxLength(6)
            //        .IsUnicode(false)
            //        .IsFixedLength();

            //    entity.Property(e => e.DistrictId)
            //        .HasColumnName("DistrictID")
            //        .HasMaxLength(4)
            //        .IsUnicode(false)
            //        .IsFixedLength();

            //    entity.Property(e => e.HomeNum)
            //        .HasMaxLength(30)
            //        .IsUnicode(false);

            //    entity.Property(e => e.ProvinceId)
            //        .HasColumnName("ProvinceID")
            //        .HasMaxLength(2)
            //        .IsUnicode(false)
            //        .IsFixedLength();

            //    entity.Property(e => e.StreetNum)
            //        .HasMaxLength(30)
            //        .IsUnicode(false);

            //    entity.Property(e => e.StudentId).HasColumnName("StudentID");

            //    entity.Property(e => e.VillageId)
            //        .HasColumnName("VillageID")
            //        .HasMaxLength(8)
            //        .IsUnicode(false)
            //        .IsFixedLength();
            //});

            modelBuilder.Entity<TblAttendanc>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AteIssue).HasColumnType("date");

                entity.Property(e => e.AttendId).HasColumnName("AttendID");

                entity.Property(e => e.AttendNote)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Attended)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DateIssue).HasColumnType("datetime");

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.Property(e => e.Section)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.SubjectId).HasColumnName("SubjectID");

                entity.Property(e => e.User).HasMaxLength(100);
            });

            modelBuilder.Entity<TblAuditAddScores>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblAuditAddScores");

                entity.Property(e => e.AuditDatetime)
                    .HasColumnName("audit_datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.AuditId).HasColumnName("audit_id");

                entity.Property(e => e.AuditNote)
                    .HasColumnName("audit_note")
                    .HasMaxLength(100);

                entity.Property(e => e.AuditType)
                    .HasColumnName("audit_type")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AuditUser)
                    .HasColumnName("audit_user")
                    .HasMaxLength(50);

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.Property(e => e.SubjectId).HasColumnName("SubjectID");
            });

            modelBuilder.Entity<TblAuditDeleteScores>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblAuditDeleteScores");

                entity.Property(e => e.AuditDatetime)
                    .HasColumnName("audit_datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.AuditId).HasColumnName("audit_id");

                entity.Property(e => e.AuditNote)
                    .HasColumnName("audit_note")
                    .HasMaxLength(100);

                entity.Property(e => e.AuditType)
                    .HasColumnName("audit_type")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AuditUser)
                    .HasColumnName("audit_user")
                    .HasMaxLength(50);

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.Property(e => e.SubjectId).HasColumnName("SubjectID");
            });

            modelBuilder.Entity<TblAuditEditScores>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblAuditEditScores");

                entity.Property(e => e.AuditDatetime)
                    .HasColumnName("audit_datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.AuditId).HasColumnName("audit_id");

                entity.Property(e => e.AuditNote)
                    .HasColumnName("audit_note")
                    .HasMaxLength(100);

                entity.Property(e => e.AuditType)
                    .HasColumnName("audit_type")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AuditUser)
                    .HasColumnName("audit_user")
                    .HasMaxLength(50);

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.Property(e => e.SubjectId).HasColumnName("SubjectID");
            });

            modelBuilder.Entity<TblBatch>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblBatch");

                entity.Property(e => e.BatchId).HasColumnName("BatchID");

                entity.Property(e => e.BatchName)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblBuilding>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblBuilding");

                entity.Property(e => e.Building)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BuildingId).HasColumnName("BuildingID");
            });

            modelBuilder.Entity<TblClass>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ClassId).HasColumnName("ClassID");

                entity.Property(e => e.Classes).HasMaxLength(7);
            });

            //modelBuilder.Entity<TblConnection>(entity =>
            //{
            //    entity.HasNoKey();

            //    entity.ToTable("tblConnection");

            //    entity.Property(e => e.Connection)
            //        .HasMaxLength(20)
            //        .IsUnicode(false);

            //    entity.Property(e => e.ConnectionId).HasColumnName("ConnectionID");
            //});

            modelBuilder.Entity<TblDateExam>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblDateExam");

                entity.Property(e => e.DateExam).HasMaxLength(50);

                entity.Property(e => e.Exam).HasMaxLength(50);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ListNumber).HasMaxLength(50);

                entity.Property(e => e.Room).HasMaxLength(50);

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.Property(e => e.Table).HasMaxLength(50);
            });

            modelBuilder.Entity<TblDayWeek>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblDayWeek");

                entity.Property(e => e.DayWeek)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DayWeekId).HasColumnName("DayWeekID");

                entity.Property(e => e.ShiftId).HasColumnName("ShiftID");
            });

            modelBuilder.Entity<TblDegree>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblDegree");

                entity.Property(e => e.DegreeId).HasColumnName("DegreeID");

                entity.Property(e => e.DegreeKh).HasMaxLength(50);

                entity.Property(e => e.DegreeName)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblDepartment>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Department).HasMaxLength(100);

                entity.Property(e => e.DeptId).HasColumnName("DeptID");
            });

            //modelBuilder.Entity<TblDocAttached>(entity =>
            //{
            //    entity.HasNoKey();

            //    entity.ToTable("tblDocAttached");

            //    entity.Property(e => e.AttachedId).HasColumnName("AttachedID");

            //    entity.Property(e => e.DocAttached)
            //        .HasMaxLength(50)
            //        .IsUnicode(false);

            //    entity.Property(e => e.DocTypeId).HasColumnName("DocTypeID");

            //    entity.Property(e => e.FileAttached)
            //        .HasMaxLength(350)
            //        .IsUnicode(false);

            //    entity.Property(e => e.StudentId).HasColumnName("StudentID");
            //});

            //modelBuilder.Entity<TblDocType>(entity =>
            //{
            //    entity.HasNoKey();

            //    entity.ToTable("tblDocType");

            //    entity.Property(e => e.DocName).HasMaxLength(50);

            //    entity.Property(e => e.DocNameKh).HasMaxLength(200);

            //    entity.Property(e => e.DocTypeId).HasColumnName("DocTypeID");
            //});

            modelBuilder.Entity<TblEvenInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblEvenInfo");

                entity.Property(e => e.BuildingId).HasColumnName("BuildingID");

                entity.Property(e => e.CreateByUser).HasMaxLength(100);

                entity.Property(e => e.DateClosed).HasColumnType("date");

                entity.Property(e => e.DateIssue).HasMaxLength(100);

                entity.Property(e => e.DateKh).HasMaxLength(254);

                entity.Property(e => e.EndTime).HasMaxLength(500);

                entity.Property(e => e.EorgId).HasColumnName("EorgID");

                entity.Property(e => e.EvenId).HasColumnName("EvenID");

                entity.Property(e => e.EvenTitle).HasMaxLength(1000);

                entity.Property(e => e.EventTypeId).HasColumnName("EventTypeID");

                entity.Property(e => e.Note).HasMaxLength(1000);

                entity.Property(e => e.Orginize).HasMaxLength(50);

                entity.Property(e => e.RoomId).HasColumnName("RoomID");

                entity.Property(e => e.StartTime).HasMaxLength(500);
            });

            modelBuilder.Entity<TblEvenRegister>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblEvenRegister");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("date");

                entity.Property(e => e.Email).HasMaxLength(40);

                entity.Property(e => e.EvenId).HasColumnName("EvenID");

                entity.Property(e => e.FromUniversity).HasMaxLength(100);

                entity.Property(e => e.Gender).HasMaxLength(50);

                entity.Property(e => e.Major).HasMaxLength(1000);

                entity.Property(e => e.Name).HasMaxLength(150);

                entity.Property(e => e.Phone).HasMaxLength(40);

                entity.Property(e => e.Photo).HasMaxLength(100);

                entity.Property(e => e.RegisterId).HasColumnName("RegisterID");

                entity.Property(e => e.StudentId)
                    .IsRequired()
                    .HasColumnName("StudentID")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblEventOrganizer>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblEventOrganizer");

                entity.Property(e => e.EorgId).HasColumnName("EorgID");

                entity.Property(e => e.EorgName).HasMaxLength(100);

                entity.Property(e => e.EorgNamekh).HasMaxLength(100);
            });

            modelBuilder.Entity<TblEventSchedule>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblEventSchedule");

                entity.Property(e => e.Edate).HasColumnType("date");

                entity.Property(e => e.EdatePresent).HasColumnType("date");

                entity.Property(e => e.Edescription).HasMaxLength(2000);

                entity.Property(e => e.EendTime)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EimageUrl)
                    .HasColumnName("EImageURL")
                    .HasMaxLength(200);

                entity.Property(e => e.EscheduleId).HasColumnName("EscheduleID");

                entity.Property(e => e.EstartTime)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Estitle).HasMaxLength(200);

                entity.Property(e => e.EventId).HasColumnName("EventID");

                entity.Property(e => e.PresenterId).HasColumnName("PresenterID");
            });

            modelBuilder.Entity<TblEventScheduleResource>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblEventScheduleResource");

                entity.Property(e => e.EscheduleId).HasColumnName("EscheduleID");

                entity.Property(e => e.Rdate).HasColumnType("date");

                entity.Property(e => e.Rdescription)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.ResourceId).HasColumnName("ResourceID");

                entity.Property(e => e.Rresource)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Rtitle)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblEvents>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.DateEvent).HasColumnType("date");

                entity.Property(e => e.DatePost).HasColumnType("date");

                entity.Property(e => e.Description).HasColumnType("ntext");

                entity.Property(e => e.EventId).HasColumnName("EventID");

                entity.Property(e => e.EventTypeId).HasColumnName("EventTypeID");

                entity.Property(e => e.PhotoCaption)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PhotoUrl)
                    .HasColumnName("PhotoURL")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Title).HasMaxLength(200);
            });

            modelBuilder.Entity<TblExaminationNote>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ExamNoteId).HasColumnName("ExamNoteID");

                entity.Property(e => e.IsPassed).HasColumnName("isPassed");

                entity.Property(e => e.IssuDate).HasColumnType("date");

                entity.Property(e => e.Other).HasMaxLength(100);

                entity.Property(e => e.RoomId).HasColumnName("RoomID");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.SubjectId).HasColumnName("SubjectID");

                entity.Property(e => e.Taken)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblFaculty>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblFaculty");

                entity.Property(e => e.FacultyId).HasColumnName("FacultyID");

                entity.Property(e => e.FacultyKh).HasMaxLength(100);

                entity.Property(e => e.FacultyName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            //modelBuilder.Entity<TblFamily>(entity =>
            //{
            //    entity.HasNoKey();

            //    entity.ToTable("tblFamily");

            //    entity.Property(e => e.City)
            //        .HasMaxLength(50)
            //        .IsUnicode(false);

            //    entity.Property(e => e.ConnectionId).HasColumnName("ConnectionID");

            //    entity.Property(e => e.Country)
            //        .HasMaxLength(30)
            //        .IsUnicode(false);

            //    entity.Property(e => e.Education)
            //        .HasMaxLength(50)
            //        .IsUnicode(false);

            //    entity.Property(e => e.Email)
            //        .HasMaxLength(50)
            //        .IsUnicode(false);

            //    entity.Property(e => e.FamilyId).HasColumnName("FamilyID");

            //    entity.Property(e => e.Income).HasColumnType("money");

            //    entity.Property(e => e.KhName).HasMaxLength(100);

            //    entity.Property(e => e.MobilePhone)
            //        .HasMaxLength(30)
            //        .IsUnicode(false);

            //    entity.Property(e => e.Name)
            //        .HasMaxLength(30)
            //        .IsUnicode(false);

            //    entity.Property(e => e.Occupation).HasMaxLength(200);

            //    entity.Property(e => e.OfficePhone)
            //        .HasMaxLength(50)
            //        .IsUnicode(false);

            //    entity.Property(e => e.Status)
            //        .HasMaxLength(50)
            //        .IsUnicode(false);

            //    entity.Property(e => e.StudentId).HasColumnName("StudentID");

            //    entity.Property(e => e.Yob).HasColumnName("YOB");
            //});

            //modelBuilder.Entity<TblGender>(entity =>
            //{
            //    entity.HasKey(e => e.GenderId);

            //    entity.ToTable("tblGender");

            //    entity.Property(e => e.GenderId)
            //        .HasColumnName("GenderID")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.GenderKh).HasMaxLength(10);

            //    entity.Property(e => e.GenderName)
            //        .HasMaxLength(10)
            //        .IsUnicode(false);
            //});

            modelBuilder.Entity<TblGroup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblGroup");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.GroupName)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblLuckyDraw>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.DateIssue).HasColumnType("date");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.EvenId).HasColumnName("EvenID");

                entity.Property(e => e.FromUniversity).HasMaxLength(100);

                entity.Property(e => e.Image).HasMaxLength(100);

                entity.Property(e => e.Major).HasMaxLength(100);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.Sex).HasMaxLength(50);

                entity.Property(e => e.VisitorId)
                    .HasColumnName("VisitorID")
                    .HasMaxLength(50);

                entity.Property(e => e.WinId).HasColumnName("WinID");
            });

            //modelBuilder.Entity<TblMgstatus>(entity =>
            //{
            //    entity.HasKey(e => e.Msid);

            //    entity.ToTable("tblMGStatus");

            //    entity.Property(e => e.Msid)
            //        .HasColumnName("MSID")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Msname)
            //        .HasColumnName("MSName")
            //        .HasMaxLength(20)
            //        .IsUnicode(false);
            //});

            //modelBuilder.Entity<TblNational>(entity =>
            //{
            //    entity.HasKey(e => e.NationalId);

            //    entity.ToTable("tblNational");

            //    entity.Property(e => e.NationalId)
            //        .HasColumnName("NationalID")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Country).HasMaxLength(50);

            //    entity.Property(e => e.NationalKh).HasMaxLength(50);

            //    entity.Property(e => e.NationalName)
            //        .HasMaxLength(20)
            //        .IsUnicode(false);
            //});

            modelBuilder.Entity<TblNotedType>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Noted)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NotedId).HasColumnName("NotedID");
            });

            modelBuilder.Entity<TblOccupations>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Occupation).HasMaxLength(200);

                entity.Property(e => e.OccupationId).HasColumnName("OccupationID");

                entity.Property(e => e.OccupationKh).HasMaxLength(200);
            });

            modelBuilder.Entity<TblPresenter>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblPresenter");

                entity.Property(e => e.GenderId).HasColumnName("GenderID");

                entity.Property(e => e.Paddress)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Pdate).HasColumnType("date");

                entity.Property(e => e.Pdetail)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Pemail)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Pname)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Pphone)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblRace>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblRace");

                entity.Property(e => e.Race)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RaceId).HasColumnName("RaceID");
            });

            modelBuilder.Entity<TblReceiptDetail>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ReceiptId).HasColumnName("ReceiptID");

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.Property(e => e.TransacId)
                    .IsRequired()
                    .HasColumnName("TransacID")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblReceipts>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ReceiptId).HasColumnName("ReceiptID");
            });

            modelBuilder.Entity<TblRecordType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblRecordType");

                entity.Property(e => e.StunInfoId).HasColumnName("StunInfoID");

                entity.Property(e => e.StunInfoType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblReferences>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblReferences");

                entity.Property(e => e.CertificateId)
                    .HasColumnName("CertificateID")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.DateApproved).HasColumnType("date");

                entity.Property(e => e.DateChecked).HasColumnType("date");

                entity.Property(e => e.DateIssue).HasColumnType("date");

                entity.Property(e => e.DatePrinted).HasColumnType("date");

                entity.Property(e => e.Employee1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Employee2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Employee3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Reason)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RefApproved)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenceFile)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenceId)
                    .IsRequired()
                    .HasColumnName("ReferenceID")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.RequestTypeId).HasColumnName("RequestTypeID");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");
            });

            modelBuilder.Entity<TblRelationPp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TblRelationPP");

                entity.Property(e => e.Gender).HasMaxLength(20);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Nationality).HasMaxLength(50);

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.RelateId).HasColumnName("RelateID");

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.Property(e => e.WorkPlace).HasMaxLength(100);
            });

            modelBuilder.Entity<TblRequestType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblRequestType");

                entity.Property(e => e.RequestName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RequestTypeId).HasColumnName("RequestTypeID");
            });

            modelBuilder.Entity<TblRoom>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblRoom");

                entity.Property(e => e.BuildingId).HasColumnName("BuildingID");

                entity.Property(e => e.Note).HasMaxLength(20);

                entity.Property(e => e.Room)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RoomId).HasColumnName("RoomID");
            });

            modelBuilder.Entity<TblSbjTaken>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ReExam1).HasColumnName("ReExam_1");

                entity.Property(e => e.ReExam2).HasColumnName("ReExam_2");

                entity.Property(e => e.ReExam3).HasColumnName("ReExam_3");

                entity.Property(e => e.SbjTakenId).HasColumnName("SbjTakenID");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.SubjectId).HasColumnName("SubjectID");

                entity.Property(e => e.UserEntried).HasMaxLength(50);
            });

            modelBuilder.Entity<TblSbjType>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.SbjType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SbjTypeId).HasColumnName("SbjTypeID");
            });

            modelBuilder.Entity<TblSchedule>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblSchedule");

                entity.Property(e => e.AcadProgrameId).HasColumnName("AcadProgrameID");

                entity.Property(e => e.DateEnd).HasColumnType("date");

                entity.Property(e => e.DateStart).HasColumnType("date");

                entity.Property(e => e.DayWeekId).HasColumnName("DayWeekID");

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.Property(e => e.RoomId).HasColumnName("RoomID");

                entity.Property(e => e.ScheduleId).HasColumnName("ScheduleID");

                entity.Property(e => e.SubjectId).HasColumnName("SubjectID");

                entity.Property(e => e.TimeId).HasColumnName("TimeID");
            });

            modelBuilder.Entity<TblScholarGranted>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.GrantedDate).HasColumnType("date");

                entity.Property(e => e.RequestedBy).HasMaxLength(100);

                entity.Property(e => e.SchGrantedId).HasColumnName("SchGrantedID");

                entity.Property(e => e.ScholarshipId).HasColumnName("ScholarshipID");

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.Property(e => e.YearId).HasColumnName("YearID");
            });

            modelBuilder.Entity<TblScholarship>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Scholarship).HasMaxLength(100);

                entity.Property(e => e.ScholarshipId).HasColumnName("ScholarshipID");
            });

            modelBuilder.Entity<TblScholarshipTemp>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.DateIssued).HasColumnType("date");

                entity.Property(e => e.DateRecord).HasColumnType("datetime");

                entity.Property(e => e.DegreeId).HasColumnName("DegreeID");

                entity.Property(e => e.Dob)
                    .HasColumnName("DOB")
                    .HasColumnType("date");

                entity.Property(e => e.Duration)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName).HasMaxLength(200);

                entity.Property(e => e.GenderId).HasColumnName("GenderID");

                entity.Property(e => e.KhmerName).HasMaxLength(400);

                entity.Property(e => e.LastName).HasMaxLength(200);

                entity.Property(e => e.MajorId).HasColumnName("MajorID");

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.ProviderId).HasColumnName("ProviderID");

                entity.Property(e => e.Requester).HasMaxLength(400);

                entity.Property(e => e.StudentId).HasColumnName("StudentID");
            });

            modelBuilder.Entity<TblSemester>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblSemester");

                entity.Property(e => e.SemesterId).HasColumnName("SemesterID");

                entity.Property(e => e.SemesterName)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblShift>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblShift");

                entity.Property(e => e.Shift)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ShiftId).HasColumnName("ShiftID");

                entity.Property(e => e.ShiftKh).HasMaxLength(50);
            });

            modelBuilder.Entity<TblSkill>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblSkill");

                entity.Property(e => e.LevelRated)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Skill)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SkillId).HasColumnName("SkillID");

                entity.Property(e => e.StudentId).HasColumnName("StudentID");
            });

            modelBuilder.Entity<TblStudentSituations>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblStudentSituations");

                entity.Property(e => e.SituationEn).HasMaxLength(100);

                entity.Property(e => e.SituationKh).HasMaxLength(200);

                entity.Property(e => e.Ssid).HasColumnName("SSId");
            });

            modelBuilder.Entity<TblStudentStatus>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblStudentStatus");

                entity.Property(e => e.AcadProgrameId).HasColumnName("AcadProgrameID");

                entity.Property(e => e.AssignDate).HasColumnType("datetime");

                entity.Property(e => e.Assigned).HasMaxLength(100);

                entity.Property(e => e.Note).HasMaxLength(200);

                entity.Property(e => e.RoomId).HasColumnName("RoomID");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.Property(e => e.TimeId).HasColumnName("TimeID");
            });

            modelBuilder.Entity<TblStudentTranscript>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblStudentTranscript");

                entity.Property(e => e.AcadProgrameId).HasColumnName("AcadProgrameID");

                entity.Property(e => e.Stid).HasColumnName("STID");

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.Property(e => e.SubjectId).HasColumnName("SubjectID");
            });

            modelBuilder.Entity<TblStunRecord>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblStunRecord");

                entity.Property(e => e.EducationId).HasColumnName("EducationID");

                entity.Property(e => e.RecordDetail).HasMaxLength(1200);

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.Property(e => e.StunInfoId).HasColumnName("StunInfoID");
            });

            modelBuilder.Entity<TblSubject>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AcademicId).HasColumnName("AcademicID");

                entity.Property(e => e.DateIsue).HasColumnType("date");

                entity.Property(e => e.DegreeId).HasColumnName("DegreeID");

                entity.Property(e => e.KhSubject).HasMaxLength(100);

                entity.Property(e => e.MajorId).HasColumnName("MajorID");

                entity.Property(e => e.SbjCode).HasMaxLength(20);

                entity.Property(e => e.SbjTypeId).HasColumnName("SbjTypeID");

                entity.Property(e => e.SemesterId).HasColumnName("SemesterID");

                entity.Property(e => e.Subject)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SubjectId).HasColumnName("SubjectID");

                entity.Property(e => e.YearId).HasColumnName("YearID");
            });

            modelBuilder.Entity<TblSubjectBatch>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.BtchId).HasColumnName("BtchID");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.Status)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Usid).HasColumnName("USID");
            });

            modelBuilder.Entity<TblSubjectKhmer>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.KhmerName)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.SubjectId).HasColumnName("SubjectID");
            });

            modelBuilder.Entity<TblSubjectOriented>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.FacultyId).HasColumnName("FacultyID");

                entity.Property(e => e.SubjectId).HasColumnName("SubjectID");
            });

            modelBuilder.Entity<TblSubjectOriginal>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.SubjectId).HasColumnName("SubjectID");

                entity.Property(e => e.SubjectName)
                    .HasMaxLength(65)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblTime>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblTime");

                entity.Property(e => e.ShiftId).HasColumnName("ShiftID");

                entity.Property(e => e.Time).HasMaxLength(20);

                entity.Property(e => e.TimeId).HasColumnName("TimeID");

                entity.Property(e => e.TimeRang)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Tblacademic>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBLAcademic");

                entity.Property(e => e.AcademicId).HasColumnName("AcademicID");

                entity.Property(e => e.AcademicName)
                    .HasMaxLength(9)
                    .IsUnicode(false);
            });

            //modelBuilder.Entity<Tblcommune>(entity =>
            //{
            //    entity.HasNoKey();

            //    entity.ToTable("TBLCommune");

            //    entity.Property(e => e.ComCode)
            //        .IsRequired()
            //        .HasColumnName("Com_Code")
            //        .HasMaxLength(6)
            //        .IsUnicode(false)
            //        .IsFixedLength();

            //    entity.Property(e => e.ComName)
            //        .HasColumnName("Com_Name")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.ComNameLimon)
            //        .HasColumnName("Com_NameLimon")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.ComNameUnicode)
            //        .HasColumnName("Com_NameUnicode")
            //        .HasMaxLength(255);
            //});

            modelBuilder.Entity<Tbldaykhmer>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbldaykhmer");

                entity.Property(e => e.Day)
                    .HasColumnName("day")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Dayimg)
                    .HasColumnName("dayimg")
                    .HasMaxLength(100);

                entity.Property(e => e.Daykhmer)
                    .HasColumnName("daykhmer")
                    .HasMaxLength(200);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Month)
                    .HasColumnName("month")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Publicholiday)
                    .HasColumnName("publicholiday")
                    .HasMaxLength(500);

                entity.Property(e => e.Year).HasColumnName("year");
            });

            //modelBuilder.Entity<Tbldistrict>(entity =>
            //{
            //    entity.HasNoKey();

            //    entity.ToTable("TBLDistrict");

            //    entity.Property(e => e.DistCode)
            //        .IsRequired()
            //        .HasColumnName("Dist_Code")
            //        .HasMaxLength(4)
            //        .IsUnicode(false)
            //        .IsFixedLength();

            //    entity.Property(e => e.DistName)
            //        .HasColumnName("Dist_Name")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.DistNameLimon)
            //        .HasColumnName("Dist_NameLimon")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.DistNameUnicode)
            //        .HasColumnName("Dist_NameUnicode")
            //        .HasMaxLength(255);
            //});

            modelBuilder.Entity<TblkhmerMonth>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblkhmerMonth");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Monthkh)
                    .HasColumnName("monthkh")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblkhmerYear>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblkhmerYear");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Year)
                    .HasColumnName("year")
                    .HasMaxLength(50);

                entity.Property(e => e.Yearkh)
                    .HasColumnName("yearkh")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblkhmerYearName>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblkhmerYearName");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.YearName).HasMaxLength(100);
            });

            modelBuilder.Entity<Tblmajor>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBLMajor");

                entity.Property(e => e.DegreeLabelId).HasColumnName("DegreeLabelID");

                entity.Property(e => e.DeptId).HasColumnName("DeptID");

                entity.Property(e => e.FacultyId).HasColumnName("FacultyID");

                entity.Property(e => e.MajorId).HasColumnName("MajorID");

                entity.Property(e => e.MajorKh).HasMaxLength(200);

                entity.Property(e => e.MajorName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            //modelBuilder.Entity<Tblprovince>(entity =>
            //{
            //    entity.HasNoKey();

            //    entity.ToTable("TBLProvince");

            //    entity.Property(e => e.ProCode)
            //        .IsRequired()
            //        .HasColumnName("Pro_Code")
            //        .HasMaxLength(2)
            //        .IsUnicode(false)
            //        .IsFixedLength();

            //    entity.Property(e => e.ProName)
            //        .HasColumnName("Pro_Name")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.ProNameLimon)
            //        .HasColumnName("Pro_NameLimon")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.ProNameUniCode)
            //        .HasColumnName("Pro_NameUniCode")
            //        .HasMaxLength(255);
            //});

            //modelBuilder.Entity<TblstudentDetail>(entity =>
            //{
            //    entity.HasKey(e => e.StudentId);

            //    entity.ToTable("TBLStudentDetail");

            //    entity.Property(e => e.StudentId)
            //        .HasColumnName("StudentID")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.AcadProgrameId).HasColumnName("AcadProgrameID");

            //    entity.Property(e => e.Dob)
            //        .HasColumnName("DOB")
            //        .HasColumnType("datetime");

            //    entity.Property(e => e.Email)
            //        .HasMaxLength(35)
            //        .IsUnicode(false);

            //    entity.Property(e => e.Fname)
            //        .HasColumnName("FName")
            //        .HasMaxLength(25)
            //        .IsUnicode(false);

            //    entity.Property(e => e.GenderId).HasColumnName("GenderID");

            //    entity.Property(e => e.Lname)
            //        .HasColumnName("LName")
            //        .HasMaxLength(25)
            //        .IsUnicode(false);

            //    entity.Property(e => e.Mname)
            //        .HasColumnName("MName")
            //        .HasMaxLength(25)
            //        .IsUnicode(false);

            //    entity.Property(e => e.Msid).HasColumnName("MSID");

            //    entity.Property(e => e.NameKh).HasMaxLength(100);

            //    entity.Property(e => e.NationalId).HasColumnName("NationalID");

            //    entity.Property(e => e.Occupation)
            //        .HasMaxLength(50)
            //        .IsUnicode(false);

            //    entity.Property(e => e.Passport)
            //        .HasMaxLength(50)
            //        .IsUnicode(false);

            //    entity.Property(e => e.Phone)
            //        .HasMaxLength(25)
            //        .IsUnicode(false);

            //    entity.Property(e => e.Phone2)
            //        .HasMaxLength(25)
            //        .IsUnicode(false);

            //    entity.Property(e => e.Photo)
            //        .HasMaxLength(50)
            //        .IsUnicode(false);

            //    entity.Property(e => e.Pob).HasColumnName("POB");

            //    entity.Property(e => e.Pwd)
            //        .HasColumnName("pwd")
            //        .HasMaxLength(200);

            //    entity.Property(e => e.RaceId).HasColumnName("RaceID");

            //    entity.Property(e => e.RegisterDate).HasColumnType("date");

            //    entity.Property(e => e.Ssid).HasColumnName("SSId");

            //    entity.Property(e => e.Verifycode).HasMaxLength(10);

            //    //entity.HasOne(d => d.Gender)
            //    //    .WithMany(p => p.TblstudentDetail)
            //    //    .HasForeignKey(d => d.GenderId)
            //    //    .HasConstraintName("FK_TBLStudentDetail_tblGender1");

            //    //entity.HasOne(d => d.Ms)
            //    //    .WithMany(p => p.TblstudentDetail)
            //    //    .HasForeignKey(d => d.Msid)
            //    //    .HasConstraintName("FK_TBLStudentDetail_tblMGStatus");

            //    //entity.HasOne(d => d.National)
            //    //    .WithMany(p => p.TblstudentDetail)
            //    //    .HasForeignKey(d => d.NationalId)
            //    //    .HasConstraintName("FK_TBLStudentDetail_tblNational");
            //});

            //modelBuilder.Entity<Tblvillage>(entity =>
            //{
            //    entity.HasNoKey();

            //    entity.ToTable("TBLVillage");

            //    entity.Property(e => e.VillCode)
            //        .IsRequired()
            //        .HasColumnName("Vill_Code")
            //        .HasMaxLength(8)
            //        .IsUnicode(false)
            //        .IsFixedLength();

            //    entity.Property(e => e.VillName)
            //        .HasColumnName("Vill_Name")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.VillNameLimon)
            //        .HasColumnName("Vill_NameLimon")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.VillNameUnicode)
            //        .HasColumnName("Vill_NameUnicode")
            //        .HasMaxLength(255);
            //});

            modelBuilder.Entity<Tblyear>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBLYear");

                entity.Property(e => e.YearId).HasColumnName("YearID");

                entity.Property(e => e.YearName)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Transaction>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.Credit).HasColumnType("money");

                entity.Property(e => e.Debit).HasColumnType("money");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Employee)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FeeId).HasColumnName("FeeID");

                entity.Property(e => e.Remark)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.Property(e => e.TransacDate).HasColumnType("datetime");

                entity.Property(e => e.TransacId).HasColumnName("TransacID");
            });

            modelBuilder.Entity<Tz01ConstantData>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TZ01_ConstantData");

                entity.Property(e => e.DateIssue).HasColumnType("datetime");

                entity.Property(e => e.DateValue).HasColumnType("date");

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.KeyNote).HasMaxLength(200);

                entity.Property(e => e.TextValue).HasMaxLength(200);
            });

            modelBuilder.Entity<Tz02BuildingPlan>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TZ02_BuildingPlan");

                entity.Property(e => e.BuildId).HasColumnName("BuildID");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.Image).HasMaxLength(200);

                entity.Property(e => e.Pid).HasColumnName("PID");

                entity.Property(e => e.SubTitle).HasMaxLength(200);

                entity.Property(e => e.Title).HasMaxLength(200);
            });

            modelBuilder.Entity<V2SelectAcademicDetails>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V2_SelectAcademicDetails");

                entity.Property(e => e.AcadDateEnd).HasColumnType("datetime");

                entity.Property(e => e.AcadDateStart).HasColumnType("datetime");

                entity.Property(e => e.AcadProgrameId).HasColumnName("AcadProgrameID");

                entity.Property(e => e.AcademicId).HasColumnName("AcademicID");

                entity.Property(e => e.AcademicName)
                    .HasMaxLength(78)
                    .IsUnicode(false);

                entity.Property(e => e.BatchId).HasColumnName("BatchID");

                entity.Property(e => e.BatchName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ClassId).HasColumnName("ClassID");

                entity.Property(e => e.Classes).HasMaxLength(7);

                entity.Property(e => e.DegreeId).HasColumnName("DegreeID");

                entity.Property(e => e.DegreeName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Expr1)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.Expr2)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FacultyId).HasColumnName("FacultyID");

                entity.Property(e => e.FacultyKh).HasMaxLength(100);

                entity.Property(e => e.FacultyName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.KeyCode).HasMaxLength(5);

                entity.Property(e => e.MajorId).HasColumnName("MajorID");

                entity.Property(e => e.MajorKh).HasMaxLength(200);

                entity.Property(e => e.MajorName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SemesterId).HasColumnName("SemesterID");

                entity.Property(e => e.SemesterName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Shift)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ShiftId).HasColumnName("ShiftID");

                entity.Property(e => e.ShiftKh).HasMaxLength(50);

                entity.Property(e => e.YearId).HasColumnName("YearID");

                entity.Property(e => e.YearName)
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<V3CountTeachersReport>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V3_CountTeachersReport");

                entity.Property(e => e.AcadProgrameId).HasColumnName("AcadProgrameID");

                entity.Property(e => e.AcademicId).HasColumnName("AcademicID");

                entity.Property(e => e.AcademicName)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.DegreeId).HasColumnName("DegreeID");

                entity.Property(e => e.DegreeName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FacultyId).HasColumnName("FacultyID");

                entity.Property(e => e.FacultyName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MajorId).HasColumnName("MajorID");

                entity.Property(e => e.MajorName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.SemesterId).HasColumnName("SemesterID");

                entity.Property(e => e.SemesterName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Subject)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.YearId).HasColumnName("YearID");

                entity.Property(e => e.YearName)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<V4ReExam>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V4_ReExam");

                entity.Property(e => e.AcademicId).HasColumnName("AcademicID");

                entity.Property(e => e.AcademicName)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.BatchName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DegreeId).HasColumnName("DegreeID");

                entity.Property(e => e.DegreeName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FacultyId).HasColumnName("FacultyID");

                entity.Property(e => e.FacultyName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fname)
                    .HasColumnName("FName")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Lname)
                    .HasColumnName("LName")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.MajorId).HasColumnName("MajorID");

                entity.Property(e => e.MajorName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SemesterId).HasColumnName("SemesterID");

                entity.Property(e => e.SemesterName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Shift)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ShiftId).HasColumnName("ShiftID");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.Property(e => e.Subject)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SubjectId).HasColumnName("SubjectID");

                entity.Property(e => e.YearId).HasColumnName("YearID");

                entity.Property(e => e.YearName)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<V4TotalStudentReport>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V4_TotalStudentReport");

                entity.Property(e => e.AcadDateEnd).HasColumnType("datetime");

                entity.Property(e => e.AcadDateStart).HasColumnType("datetime");

                entity.Property(e => e.AcadProgrameId).HasColumnName("AcadProgrameID");

                entity.Property(e => e.Academic)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.AcademicId).HasColumnName("AcademicID");

                entity.Property(e => e.AcademicName)
                    .HasMaxLength(110)
                    .IsUnicode(false);

                entity.Property(e => e.BatchId).HasColumnName("BatchID");

                entity.Property(e => e.BatchName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ClassId).HasColumnName("ClassID");

                entity.Property(e => e.Classes).HasMaxLength(7);

                entity.Property(e => e.DegreeId).HasColumnName("DegreeID");

                entity.Property(e => e.DegreeName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FacultyId).HasColumnName("FacultyID");

                entity.Property(e => e.FacultyKh).HasMaxLength(100);

                entity.Property(e => e.FacultyName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GenderId).HasColumnName("GenderID");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.KeyCode).HasMaxLength(5);

                entity.Property(e => e.MajorId).HasColumnName("MajorID");

                entity.Property(e => e.MajorKh).HasMaxLength(200);

                entity.Property(e => e.MajorName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SemesterId).HasColumnName("SemesterID");

                entity.Property(e => e.SemesterName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Shift)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ShiftId).HasColumnName("ShiftID");

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.Property(e => e.YearId).HasColumnName("YearID");

                entity.Property(e => e.YearName)
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<V5SchoolPromotion>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V5_SchoolPromotion");

                entity.Property(e => e.AcademicId).HasColumnName("AcademicID");

                entity.Property(e => e.BatchId).HasColumnName("BatchID");

                entity.Property(e => e.DegreeId).HasColumnName("DegreeID");

                entity.Property(e => e.Email)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.MajorId).HasColumnName("MajorID");

                entity.Property(e => e.Name)
                    .HasMaxLength(51)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.SemesterId).HasColumnName("SemesterID");

                entity.Property(e => e.ShiftId).HasColumnName("ShiftID");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.Property(e => e.YearId).HasColumnName("YearID");
            });

            modelBuilder.Entity<V5TotalAttandence>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V5_TotalAttandence");

                entity.Property(e => e.AcadProgrameId).HasColumnName("AcadProgrameID");

                entity.Property(e => e.AcademicId).HasColumnName("AcademicID");

                entity.Property(e => e.Attended)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BatchId).HasColumnName("BatchID");

                entity.Property(e => e.DegreeId).HasColumnName("DegreeID");

                entity.Property(e => e.Email)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.MajorId).HasColumnName("MajorID");

                entity.Property(e => e.Name)
                    .HasMaxLength(51)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ShiftId).HasColumnName("ShiftID");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.Property(e => e.Subject)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SubjectId).HasColumnName("SubjectID");
            });

            modelBuilder.Entity<V6StudentChangedFromOtherSchool>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V6_StudentChangedFromOtherSchool");

                entity.Property(e => e.AcademicId).HasColumnName("AcademicID");

                entity.Property(e => e.BatchId).HasColumnName("BatchID");

                entity.Property(e => e.BatchName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DateIsue).HasColumnType("date");

                entity.Property(e => e.DegreeId).HasColumnName("DegreeID");

                entity.Property(e => e.DegreeName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FacultyId).HasColumnName("FacultyID");

                entity.Property(e => e.FacultyName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fname)
                    .HasColumnName("FName")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.GenderId).HasColumnName("GenderID");

                entity.Property(e => e.GroupName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Lname)
                    .HasColumnName("LName")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.MajorId).HasColumnName("MajorID");

                entity.Property(e => e.MajorName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Note).HasMaxLength(500);

                entity.Property(e => e.NotedId).HasColumnName("NotedID");

                entity.Property(e => e.RegisterDate).HasColumnType("date");

                entity.Property(e => e.SemesterName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShiftId).HasColumnName("ShiftID");

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.Property(e => e.YearId).HasColumnName("YearID");

                entity.Property(e => e.YearName)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<V7StudentReExamScores>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V7_StudentReExamScores");

                entity.Property(e => e.AcadProgrameId).HasColumnName("AcadProgrameID");

                entity.Property(e => e.Name)
                    .HasMaxLength(51)
                    .IsUnicode(false);

                entity.Property(e => e.ReExam1).HasColumnName("ReExam_1");

                entity.Property(e => e.ReExam2).HasColumnName("ReExam_2");

                entity.Property(e => e.ReExam3).HasColumnName("ReExam_3");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.Property(e => e.Subject)
                    .HasMaxLength(106)
                    .IsUnicode(false);

                entity.Property(e => e.UserEntried).HasMaxLength(50);
            });

            modelBuilder.Entity<VDailyCollectionFee>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vDailyCollectionFee");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.EmployeeName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FeeHead)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiptDate).HasColumnType("datetime");

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.Property(e => e.StudentName)
                    .HasMaxLength(51)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VListAcademic>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vListAcademic");

                entity.Property(e => e.AcadTitle).HasMaxLength(152);

                entity.Property(e => e.FacultyName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MajorName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VSelectAcadeTitle>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSelectAcadeTitle");

                entity.Property(e => e.AcadProgrameId).HasColumnName("AcadProgrameID");

                entity.Property(e => e.AcadeTitle).HasMaxLength(292);
            });

            modelBuilder.Entity<VSelectAcademicTitle>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSelectAcademicTitle");

                entity.Property(e => e.AcadProgrameId).HasColumnName("AcadProgrameID");

                entity.Property(e => e.AcademicTitle).HasMaxLength(291);
            });

            modelBuilder.Entity<VSelectAcademicTitleStudentId>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_SelectAcademicTitle_StudentID");

                entity.Property(e => e.AcademicTitle).HasMaxLength(294);

                entity.Property(e => e.Name)
                    .HasMaxLength(51)
                    .IsUnicode(false);

                entity.Property(e => e.StudentId).HasColumnName("StudentID");
            });

            modelBuilder.Entity<VStudentFees>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vStudentFees");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.FeeId).HasColumnName("FeeID");

                entity.Property(e => e.Fees).HasColumnType("money");

                entity.Property(e => e.SemesterId).HasColumnName("SemesterID");

                entity.Property(e => e.SemesterName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.Property(e => e.YearId).HasColumnName("YearID");

                entity.Property(e => e.YearName)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VStudentFeesTransac>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vStudentFeesTransac");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Employee)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FeeId).HasColumnName("FeeID");

                entity.Property(e => e.Fname)
                    .HasColumnName("FName")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Lname)
                    .HasColumnName("LName")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Paid).HasColumnType("money");

                entity.Property(e => e.Phone)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiptId).HasColumnName("ReceiptID");

                entity.Property(e => e.Remark)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SemesterName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.Property(e => e.TransacDate).HasColumnType("datetime");

                entity.Property(e => e.TransacId)
                    .IsRequired()
                    .HasColumnName("TransacID")
                    .HasMaxLength(50);

                entity.Property(e => e.YearName)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VStudentScholarship>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vStudentScholarship");

                entity.Property(e => e.GrantedDate).HasColumnType("date");

                entity.Property(e => e.SchGrantedId).HasColumnName("SchGrantedID");

                entity.Property(e => e.Scholarship).HasMaxLength(100);

                entity.Property(e => e.ScholarshipId).HasColumnName("ScholarshipID");

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.Property(e => e.YearId).HasColumnName("YearID");
            });

            modelBuilder.Entity<VStudentStatus>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vStudentStatus");

                entity.Property(e => e.AcadDateEnd).HasColumnType("datetime");

                entity.Property(e => e.AcadDateStart).HasColumnType("datetime");

                entity.Property(e => e.AcadProgrameId).HasColumnName("AcadProgrameID");

                entity.Property(e => e.AcademicId).HasColumnName("AcademicID");

                entity.Property(e => e.AcademicName)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.BatchId).HasColumnName("BatchID");

                entity.Property(e => e.BatchName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ClassId).HasColumnName("ClassID");

                entity.Property(e => e.Classes).HasMaxLength(7);

                entity.Property(e => e.DegreeId).HasColumnName("DegreeID");

                entity.Property(e => e.DegreeKh).HasMaxLength(50);

                entity.Property(e => e.DegreeName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Fname)
                    .HasColumnName("FName")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.GroupName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.KeyCode).HasMaxLength(5);

                entity.Property(e => e.Lname)
                    .HasColumnName("LName")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.MajorId).HasColumnName("MajorID");

                entity.Property(e => e.MajorKh).HasMaxLength(200);

                entity.Property(e => e.MajorName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.SemesterId).HasColumnName("SemesterID");

                entity.Property(e => e.SemesterName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Shift)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ShiftId).HasColumnName("ShiftID");

                entity.Property(e => e.ShiftKh).HasMaxLength(50);

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.Property(e => e.YearId).HasColumnName("YearID");

                entity.Property(e => e.YearName)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Vapi1StudentLevels>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VAPI1_StudentLevels");

                entity.Property(e => e.AcadDateEnd).HasColumnType("datetime");

                entity.Property(e => e.AcadDateStart).HasColumnType("datetime");

                entity.Property(e => e.AcadProgrameId).HasColumnName("AcadProgrameID");

                entity.Property(e => e.AcademicId).HasColumnName("AcademicID");

                entity.Property(e => e.BatchId).HasColumnName("BatchID");

                entity.Property(e => e.ClassId).HasColumnName("ClassID");

                entity.Property(e => e.DegreeId).HasColumnName("DegreeID");

                entity.Property(e => e.FacultyId).HasColumnName("FacultyID");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.MajorId).HasColumnName("MajorID");

                entity.Property(e => e.SemesterId).HasColumnName("SemesterID");

                entity.Property(e => e.ShiftId).HasColumnName("ShiftID");

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.Property(e => e.YearId).HasColumnName("YearID");
            });

            modelBuilder.Entity<VapiStudentAddress>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VAPI_StudentAddress");

                entity.Property(e => e.AddType)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AddTypeId).HasColumnName("AddTypeID");

                entity.Property(e => e.AddressId).HasColumnName("AddressID");

                entity.Property(e => e.ComName)
                    .HasColumnName("Com_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.ComNameUnicode)
                    .HasColumnName("Com_NameUnicode")
                    .HasMaxLength(255);

                entity.Property(e => e.CommuneId)
                    .HasColumnName("CommuneID")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DistName)
                    .HasColumnName("Dist_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.DistNameUnicode)
                    .HasColumnName("Dist_NameUnicode")
                    .HasMaxLength(255);

                entity.Property(e => e.DistrictId)
                    .HasColumnName("DistrictID")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.HomeNum)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ProName)
                    .HasColumnName("Pro_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.ProNameUniCode)
                    .HasColumnName("Pro_NameUniCode")
                    .HasMaxLength(255);

                entity.Property(e => e.ProvinceId)
                    .HasColumnName("ProvinceID")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StreetNum)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.Property(e => e.VillName)
                    .HasColumnName("Vill_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.VillNameUnicode)
                    .HasColumnName("Vill_NameUnicode")
                    .HasMaxLength(255);

                entity.Property(e => e.VillageId)
                    .HasColumnName("VillageID")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<VapiStudentProfile>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VAPI_StudentProfile");

                entity.Property(e => e.AcadProgrameId).HasColumnName("AcadProgrameID");

                entity.Property(e => e.Dob)
                    .HasColumnName("DOB")
                    .HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.Fname)
                    .HasColumnName("FName")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.GenderId).HasColumnName("GenderID");

                entity.Property(e => e.GenderName)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Lname)
                    .HasColumnName("LName")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Mname)
                    .HasColumnName("MName")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Msid).HasColumnName("MSID");

                entity.Property(e => e.Msname)
                    .HasColumnName("MSName")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NameKh).HasMaxLength(100);

                entity.Property(e => e.NationalId).HasColumnName("NationalID");

                entity.Property(e => e.NationalName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Occupation)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Passport)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Phone2)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Photo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pob).HasColumnName("POB");

                entity.Property(e => e.Race)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RaceId).HasColumnName("RaceID");

                entity.Property(e => e.RegisterDate).HasColumnType("date");

                entity.Property(e => e.StudentId).HasColumnName("StudentID");
            });

            modelBuilder.Entity<ViewIndividual>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Individual");

                entity.Property(e => e.AddTypeId).HasColumnName("AddTypeID");

                entity.Property(e => e.BatchId)
                    .HasColumnName("BatchID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Bid).HasColumnName("BID");

                entity.Property(e => e.ComNameUnicode)
                    .HasColumnName("Com_NameUnicode")
                    .HasMaxLength(255);

                entity.Property(e => e.ConnectionId).HasColumnName("ConnectionID");

                entity.Property(e => e.DateExam).HasMaxLength(50);

                entity.Property(e => e.DegreeKh).HasMaxLength(50);

                entity.Property(e => e.DistNameUnicode)
                    .HasColumnName("Dist_NameUnicode")
                    .HasMaxLength(255);

                entity.Property(e => e.Dob)
                    .HasColumnName("DOB")
                    .HasColumnType("datetime");

                entity.Property(e => e.Exam).HasMaxLength(50);

                entity.Property(e => e.Gender).HasMaxLength(20);

                entity.Property(e => e.GenderId).HasColumnName("GenderID");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.GroupName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.KhName).HasMaxLength(100);

                entity.Property(e => e.LatinName)
                    .HasMaxLength(51)
                    .IsUnicode(false);

                entity.Property(e => e.ListNumber).HasMaxLength(50);

                entity.Property(e => e.MajorKh).HasMaxLength(200);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.NameKh).HasMaxLength(100);

                entity.Property(e => e.NationalKh).HasMaxLength(50);

                entity.Property(e => e.Nationality).HasMaxLength(50);

                entity.Property(e => e.Occupation)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.Photo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProNameUniCode)
                    .HasColumnName("Pro_NameUniCode")
                    .HasMaxLength(255);

                entity.Property(e => e.RelateId).HasColumnName("RelateID");

                entity.Property(e => e.Room).HasMaxLength(50);

                entity.Property(e => e.SemesterId).HasColumnName("SemesterID");

                entity.Property(e => e.SemesterName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShiftKh).HasMaxLength(50);

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.Property(e => e.Table).HasMaxLength(50);

                entity.Property(e => e.VillNameUnicode)
                    .HasColumnName("Vill_NameUnicode")
                    .HasMaxLength(255);

                entity.Property(e => e.WorkPlace).HasMaxLength(100);

                entity.Property(e => e.YearId).HasColumnName("YearID");

                entity.Property(e => e.YearName)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VsTeachersReport>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vs_TeachersReport");

                entity.Property(e => e.AcadProgrameId).HasColumnName("AcadProgrameID");

                entity.Property(e => e.AcadProgrameTitle).HasMaxLength(238);

                entity.Property(e => e.AcademicId).HasColumnName("AcademicID");

                entity.Property(e => e.AcademicName)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.DayWeek)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DayWeekId).HasColumnName("DayWeekID");

                entity.Property(e => e.DegreeId).HasColumnName("DegreeID");

                entity.Property(e => e.FacultyId).HasColumnName("FacultyID");

                entity.Property(e => e.FacultyName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MajorId).HasColumnName("MajorID");

                entity.Property(e => e.MajorName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.Property(e => e.Phone)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.RoomId).HasColumnName("RoomID");

                entity.Property(e => e.ShiftId).HasColumnName("ShiftID");

                entity.Property(e => e.Subject)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TimeId).HasColumnName("TimeID");

                entity.Property(e => e.YearId).HasColumnName("YearID");

                entity.Property(e => e.YearName)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            // ================================================================================//

            modelBuilder.Entity<StudentCourses>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<SelectAttendances>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<StuSchedule>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<SelectSchedule>(entity =>
            {
                entity.HasNoKey();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
