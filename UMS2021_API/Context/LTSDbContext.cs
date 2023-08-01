using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using UMS2021_API.Models.DB_LTS;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace UMS2021_API.Context
{
    public partial class LTSDbContext : DbContext
    {
        public LTSDbContext()
        {
        }

        public LTSDbContext(DbContextOptions<LTSDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Sysdiagrams> Sysdiagrams { get; set; }
        public virtual DbSet<Tbl4ReportTotalFinalDetail> Tbl4ReportTotalFinalDetail { get; set; }
        public virtual DbSet<TblAcademicDetail> TblAcademicDetail { get; set; }
        public virtual DbSet<TblActivateType> TblActivateType { get; set; }
        public virtual DbSet<TblAddress> TblAddress { get; set; }
        public virtual DbSet<TblAddressAudit> TblAddressAudit { get; set; }
        public virtual DbSet<TblAddressStatuss> TblAddressStatuss { get; set; }
        public virtual DbSet<TblAssignedNote> TblAssignedNote { get; set; }
        public virtual DbSet<TblAssignedTask> TblAssignedTask { get; set; }
        public virtual DbSet<TblAuthorAndResearch> TblAuthorAndResearch { get; set; }
        public virtual DbSet<TblBatch> TblBatch { get; set; }
        public virtual DbSet<TblBonus> TblBonus { get; set; }
        public virtual DbSet<TblBranch> TblBranch { get; set; }
        public virtual DbSet<TblBrand> TblBrand { get; set; }
        public virtual DbSet<TblBuilding> TblBuilding { get; set; }
        public virtual DbSet<TblClasses> TblClasses { get; set; }
        public virtual DbSet<TblCloseProcess> TblCloseProcess { get; set; }
        public virtual DbSet<TblContractPeriod> TblContractPeriod { get; set; }
        public virtual DbSet<TblCredit> TblCredit { get; set; }
        public virtual DbSet<TblDay> TblDay { get; set; }
        public virtual DbSet<TblDegree> TblDegree { get; set; }
        public virtual DbSet<TblDegreeX> TblDegreeX { get; set; }
        public virtual DbSet<TblDepartment> TblDepartment { get; set; }
        public virtual DbSet<TblDocAtt> TblDocAtt { get; set; }
        public virtual DbSet<TblEducationType> TblEducationType { get; set; }
        public virtual DbSet<TblEqmtFeature> TblEqmtFeature { get; set; }
        public virtual DbSet<TblEqmtStatus> TblEqmtStatus { get; set; }
        public virtual DbSet<TblEquitment> TblEquitment { get; set; }
        public virtual DbSet<TblFaculty> TblFaculty { get; set; }
        public virtual DbSet<TblFamily> TblFamily { get; set; }
        public virtual DbSet<TblFunction> TblFunction { get; set; }
        public virtual DbSet<TblGender> TblGender { get; set; }
        public virtual DbSet<TblGroup> TblGroup { get; set; }
        public virtual DbSet<TblLanguage> TblLanguage { get; set; }
        public virtual DbSet<TblLanguageCertificate> TblLanguageCertificate { get; set; }
        public virtual DbSet<TblLanguageDeatial> TblLanguageDeatial { get; set; }
        public virtual DbSet<TblLocation> TblLocation { get; set; }
        public virtual DbSet<TblLocationType> TblLocationType { get; set; }
        public virtual DbSet<TblMainCategorie> TblMainCategorie { get; set; }
        public virtual DbSet<TblMaritalStatus> TblMaritalStatus { get; set; }
        public virtual DbSet<TblMention> TblMention { get; set; }
        public virtual DbSet<TblMultiPosition> TblMultiPosition { get; set; }
        public virtual DbSet<TblNational> TblNational { get; set; }
        public virtual DbSet<TblNationalitydetail> TblNationalitydetail { get; set; }
        public virtual DbSet<TblPerson> TblPerson { get; set; }
        public virtual DbSet<TblPersonAudit> TblPersonAudit { get; set; }
        public virtual DbSet<TblPersonPart> TblPersonPart { get; set; }
        public virtual DbSet<TblPersonSecurityPassword> TblPersonSecurityPassword { get; set; }
        public virtual DbSet<TblPersonType> TblPersonType { get; set; }
        public virtual DbSet<TblPosition> TblPosition { get; set; }
        public virtual DbSet<TblPositionMulti> TblPositionMulti { get; set; }
        public virtual DbSet<TblProject> TblProject { get; set; }
        public virtual DbSet<TblRate> TblRate { get; set; }
        public virtual DbSet<TblRoom> TblRoom { get; set; }
        public virtual DbSet<TblRoomEquitmentAssign> TblRoomEquitmentAssign { get; set; }
        public virtual DbSet<TblScanLcd> TblScanLcd { get; set; }
        public virtual DbSet<TblSchedule> TblSchedule { get; set; }
        public virtual DbSet<TblSchool> TblSchool { get; set; }
        public virtual DbSet<TblSchoolLevel> TblSchoolLevel { get; set; }
        public virtual DbSet<TblSemester> TblSemester { get; set; }
        public virtual DbSet<TblSession> TblSession { get; set; }
        public virtual DbSet<TblSkillDetail> TblSkillDetail { get; set; }
        public virtual DbSet<TblStaffStatus> TblStaffStatus { get; set; }
        public virtual DbSet<TblStatus> TblStatus { get; set; }
        public virtual DbSet<TblStopWork> TblStopWork { get; set; }
        public virtual DbSet<TblStudyDetail> TblStudyDetail { get; set; }
        public virtual DbSet<TblSubCategorie> TblSubCategorie { get; set; }
        public virtual DbSet<TblSubDpt> TblSubDpt { get; set; }
        public virtual DbSet<TblSubject> TblSubject { get; set; }
        public virtual DbSet<TblSubjectAssigned> TblSubjectAssigned { get; set; }
        public virtual DbSet<TblSubjectCredit> TblSubjectCredit { get; set; }
        public virtual DbSet<TblSupplier> TblSupplier { get; set; }
        public virtual DbSet<TblTaskDetail> TblTaskDetail { get; set; }
        public virtual DbSet<TblTeachingNote> TblTeachingNote { get; set; }
        public virtual DbSet<TblTime> TblTime { get; set; }
        public virtual DbSet<TblTime2> TblTime2 { get; set; }
        public virtual DbSet<TblTimeSheet> TblTimeSheet { get; set; }
        public virtual DbSet<TblTimeSheetBackup> TblTimeSheetBackup { get; set; }
        public virtual DbSet<TblTimeType> TblTimeType { get; set; }
        public virtual DbSet<TblWork> TblWork { get; set; }
        public virtual DbSet<Tblacademic> Tblacademic { get; set; }
        public virtual DbSet<Tblcommune> Tblcommune { get; set; }
        public virtual DbSet<Tbldistrict> Tbldistrict { get; set; }
        public virtual DbSet<Tblmajor> Tblmajor { get; set; }
        public virtual DbSet<TblmajorX> TblmajorX { get; set; }
        public virtual DbSet<Tblprovince> Tblprovince { get; set; }
        public virtual DbSet<Tblvillage> Tblvillage { get; set; }
        public virtual DbSet<Tblyear> Tblyear { get; set; }
        public virtual DbSet<TotalFinalReportRate> TotalFinalReportRate { get; set; }
        public virtual DbSet<VFinalTotal> VFinalTotal { get; set; }
        public virtual DbSet<VTotalEquipment> VTotalEquipment { get; set; }
        public virtual DbSet<VViewPersonalInfo> VViewPersonalInfo { get; set; }
        public virtual DbSet<VViewStudyHistory> VViewStudyHistory { get; set; }
        public virtual DbSet<VViewStudyRecord> VViewStudyRecord { get; set; }
        public virtual DbSet<VViewWorkHistory> VViewWorkHistory { get; set; }
        public virtual DbSet<View3> View3 { get; set; }
        public virtual DbSet<View4> View4 { get; set; }
        public virtual DbSet<View5> View5 { get; set; }
        public virtual DbSet<View6> View6 { get; set; }
        public virtual DbSet<View7ToTangheng> View7ToTangheng { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DRXTECH\\SQLEXPRESS;Database=LTS011208;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sysdiagrams>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sysdiagrams");

                entity.Property(e => e.Definition).HasColumnName("definition");

                entity.Property(e => e.DiagramId).HasColumnName("diagram_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(128);

                entity.Property(e => e.PrincipalId).HasColumnName("principal_id");

                entity.Property(e => e.Version).HasColumnName("version");
            });

            modelBuilder.Entity<Tbl4ReportTotalFinalDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl4ReportTotalFinalDetail");

                entity.Property(e => e.AcademicName).HasMaxLength(50);

                entity.Property(e => e.BatchName).HasMaxLength(50);

                entity.Property(e => e.CloseDate).HasMaxLength(50);

                entity.Property(e => e.DateTeach).HasColumnType("datetime");

                entity.Property(e => e.DegreeName).HasMaxLength(50);

                entity.Property(e => e.FacultyId).HasColumnName("FacultyID");

                entity.Property(e => e.FacultyName).HasMaxLength(100);

                entity.Property(e => e.FullName).HasMaxLength(50);

                entity.Property(e => e.GroupName).HasMaxLength(50);

                entity.Property(e => e.MajorName).HasMaxLength(50);

                entity.Property(e => e.Other).HasMaxLength(50);

                entity.Property(e => e.Period).HasMaxLength(50);

                entity.Property(e => e.PersonId)
                    .HasColumnName("PersonID")
                    .HasMaxLength(50);

                entity.Property(e => e.SemesterName).HasMaxLength(50);

                entity.Property(e => e.SessionName).HasMaxLength(50);

                entity.Property(e => e.Subject).HasMaxLength(50);

                entity.Property(e => e.SubjectAssignedId).HasColumnName("SubjectAssignedID");

                entity.Property(e => e.TeachingNote).HasMaxLength(50);

                entity.Property(e => e.YearName).HasMaxLength(50);
            });

            modelBuilder.Entity<TblAcademicDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblAcademicDetail");

                entity.Property(e => e.AcademicId).HasColumnName("AcademicID");

                entity.Property(e => e.AcademicIddetail).HasColumnName("AcademicIDDetail");

                entity.Property(e => e.DateEnd1).HasColumnType("datetime");

                entity.Property(e => e.DateEnd2).HasColumnType("datetime");

                entity.Property(e => e.DateStart1).HasColumnType("datetime");

                entity.Property(e => e.DateStart2).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblActivateType>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ActivateId).HasColumnName("ActivateID");

                entity.Property(e => e.ActivateType).HasMaxLength(50);
            });

            modelBuilder.Entity<TblAddress>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AddressId).HasColumnName("AddressID");

                entity.Property(e => e.AddressStatusId).HasColumnName("AddressStatusID");

                entity.Property(e => e.ComId)
                    .HasColumnName("Com_ID")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DistCode)
                    .HasColumnName("Dist_Code")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.HomeNum).HasMaxLength(50);

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.Property(e => e.ProCode)
                    .HasColumnName("Pro_Code")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StreetNum).HasMaxLength(50);

                entity.Property(e => e.UserLog).HasMaxLength(50);

                entity.Property(e => e.VillId)
                    .HasColumnName("Vill_ID")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblAddressAudit>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TblAddress_Audit");

                entity.Property(e => e.Action).HasMaxLength(50);

                entity.Property(e => e.ActionDate).HasColumnType("datetime");

                entity.Property(e => e.AddressAuditId).HasColumnName("AddressAuditID");

                entity.Property(e => e.AddressId).HasColumnName("AddressID");

                entity.Property(e => e.AddressStatusId).HasColumnName("AddressStatusID");

                entity.Property(e => e.ComId)
                    .HasColumnName("Com_ID")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DistCode)
                    .HasColumnName("Dist_Code")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.HomeNum).HasMaxLength(50);

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.Property(e => e.ProCode)
                    .HasColumnName("Pro_Code")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StreetNum).HasMaxLength(50);

                entity.Property(e => e.UserLog).HasMaxLength(50);

                entity.Property(e => e.VillId)
                    .HasColumnName("Vill_ID")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblAddressStatuss>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Status).HasMaxLength(50);
            });

            modelBuilder.Entity<TblAssignedNote>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AssignedNote).HasMaxLength(20);

                entity.Property(e => e.AssignedNoteId).HasColumnName("AssignedNoteID");
            });

            modelBuilder.Entity<TblAssignedTask>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AssignedNoteId).HasColumnName("AssignedNoteID");

                entity.Property(e => e.AssignedTaskId).HasColumnName("AssignedTaskID");

                entity.Property(e => e.CreditId).HasColumnName("CreditID");

                entity.Property(e => e.DateDo).HasColumnType("datetime");

                entity.Property(e => e.OtherRateId).HasColumnName("OtherRateID");

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.Property(e => e.TimeId).HasColumnName("TimeID");
            });

            modelBuilder.Entity<TblAuthorAndResearch>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuthorId).HasColumnName("AuthorID");

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.Property(e => e.ResearchNote).HasMaxLength(200);
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

            modelBuilder.Entity<TblBonus>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.BonusId).HasColumnName("BonusID");

                entity.Property(e => e.BonusMoney).HasColumnType("money");

                entity.Property(e => e.BonusNote).HasMaxLength(50);
            });

            modelBuilder.Entity<TblBranch>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Branch).HasMaxLength(150);

                entity.Property(e => e.BranchId).HasColumnName("BranchID");
            });

            modelBuilder.Entity<TblBrand>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.BrandId).HasColumnName("BrandID");

                entity.Property(e => e.BrandName).HasMaxLength(50);
            });

            modelBuilder.Entity<TblBuilding>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Building).HasMaxLength(50);

                entity.Property(e => e.BuildingId).HasColumnName("BuildingID");
            });

            modelBuilder.Entity<TblClasses>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ClassId).HasColumnName("ClassID");

                entity.Property(e => e.Classes).HasMaxLength(7);
            });

            modelBuilder.Entity<TblCloseProcess>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CloseDate).HasColumnType("datetime");

                entity.Property(e => e.CloseNote).HasMaxLength(100);

                entity.Property(e => e.CloseProcessId).HasColumnName("CloseProcessID");

                entity.Property(e => e.OpenDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblContractPeriod>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ContractPeriodId).HasColumnName("ContractPeriodID");

                entity.Property(e => e.FromDate).HasMaxLength(50);

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.Property(e => e.PositionId).HasColumnName("PositionID");

                entity.Property(e => e.ToDate).HasMaxLength(50);
            });

            modelBuilder.Entity<TblCredit>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CreditId).HasColumnName("CreditID");
            });

            modelBuilder.Entity<TblDay>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Day).HasMaxLength(50);

                entity.Property(e => e.DayId).HasColumnName("DayID");

                entity.Property(e => e.SessionId).HasColumnName("SessionID");
            });

            modelBuilder.Entity<TblDegree>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblDegree");

                entity.Property(e => e.DegreeId).HasColumnName("DegreeID");

                entity.Property(e => e.DegreeKh).HasMaxLength(50);

                entity.Property(e => e.DegreeName).HasMaxLength(50);
            });

            modelBuilder.Entity<TblDegreeX>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.DegreeId).HasColumnName("DegreeID");

                entity.Property(e => e.DegreeName).HasMaxLength(50);
            });

            modelBuilder.Entity<TblDepartment>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Department).HasMaxLength(100);

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.DeptEng).HasMaxLength(50);
            });

            modelBuilder.Entity<TblDocAtt>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.DocAttId).HasColumnName("DocAttID");

                entity.Property(e => e.DocAttUrl)
                    .HasColumnName("DocAttURL")
                    .HasMaxLength(550);

                entity.Property(e => e.DocName).HasMaxLength(250);

                entity.Property(e => e.FileType).HasMaxLength(50);

                entity.Property(e => e.PersonId).HasColumnName("PersonID");
            });

            modelBuilder.Entity<TblEducationType>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.EducationType).HasMaxLength(50);

                entity.Property(e => e.EducationTypeEn)
                    .HasColumnName("EducationTypeEN")
                    .HasMaxLength(50);

                entity.Property(e => e.EducationTypeId).HasColumnName("EducationTypeID");
            });

            modelBuilder.Entity<TblEqmtFeature>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.EquitmentId)
                    .HasColumnName("EquitmentID")
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Feature).HasMaxLength(50);

                entity.Property(e => e.FeatureId).HasColumnName("FeatureID");
            });

            modelBuilder.Entity<TblEqmtStatus>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Status).HasMaxLength(20);

                entity.Property(e => e.StatusId).HasColumnName("StatusID");
            });

            modelBuilder.Entity<TblEquitment>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.BrandId).HasColumnName("BrandID");

                entity.Property(e => e.DateIn).HasColumnType("datetime");

                entity.Property(e => e.Equitment).HasMaxLength(50);

                entity.Property(e => e.EquitmentId)
                    .IsRequired()
                    .HasColumnName("EquitmentID")
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Idcard)
                    .HasColumnName("IDCard")
                    .HasMaxLength(12);

                entity.Property(e => e.Picture).HasMaxLength(50);

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.SubCategoryId).HasColumnName("SubCategoryID");

                entity.Property(e => e.SupplyerId).HasColumnName("SupplyerID");

                entity.Property(e => e.UnitPrice).HasColumnType("money");
            });

            modelBuilder.Entity<TblFaculty>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblFaculty");

                entity.Property(e => e.FacultyId).HasColumnName("FacultyID");

                entity.Property(e => e.FacultyName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblFamily>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Contact).HasMaxLength(50);

                entity.Property(e => e.FamilyId).HasColumnName("FamilyID");

                entity.Property(e => e.FamilyName).HasMaxLength(50);

                entity.Property(e => e.FunctionId).HasColumnName("FunctionID");

                entity.Property(e => e.PersonId).HasColumnName("PersonID");
            });

            modelBuilder.Entity<TblFunction>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.FunctionEng).HasMaxLength(50);

                entity.Property(e => e.FunctionId).HasColumnName("FunctionID");

                entity.Property(e => e.FunctionName).HasMaxLength(50);
            });

            modelBuilder.Entity<TblGender>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblGender");

                entity.Property(e => e.GenderId).HasColumnName("GenderID");

                entity.Property(e => e.GenderName).HasMaxLength(50);

                entity.Property(e => e.SexEng).HasMaxLength(6);
            });

            modelBuilder.Entity<TblGroup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblGroup");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.GroupName)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblLanguage>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.LanguageName)
                    .HasMaxLength(35)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblLanguageCertificate>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CertificateNote)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageCertificateId).HasColumnName("LanguageCertificateID");

                entity.Property(e => e.LanguageDetailId).HasColumnName("LanguageDetailID");
            });

            modelBuilder.Entity<TblLanguageDeatial>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.LanguageDetailId).HasColumnName("LanguageDetailID");

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.MentionId).HasColumnName("MentionID");

                entity.Property(e => e.PersonId).HasColumnName("PersonID");
            });

            modelBuilder.Entity<TblLocation>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Location)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.LocationTypeId).HasColumnName("LocationTypeID");
            });

            modelBuilder.Entity<TblLocationType>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.LocationType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LocationTypeId).HasColumnName("LocationTypeID");
            });

            modelBuilder.Entity<TblMainCategorie>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.MainCategoryId).HasColumnName("MainCategoryID");

                entity.Property(e => e.McategoryName)
                    .HasColumnName("MCategoryName")
                    .HasMaxLength(50);

                entity.Property(e => e.Mccode)
                    .HasColumnName("MCCode")
                    .HasMaxLength(2)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblMaritalStatus>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblMaritalStatus");

                entity.Property(e => e.Msid).HasColumnName("MSID");

                entity.Property(e => e.Msname)
                    .HasColumnName("MSName")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblMention>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Mention).HasMaxLength(50);

                entity.Property(e => e.MentionId).HasColumnName("MentionID");
            });

            modelBuilder.Entity<TblMultiPosition>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.MultiPositionDate).HasColumnType("datetime");

                entity.Property(e => e.MultiPositionId).HasColumnName("MultiPositionID");

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.Property(e => e.PersonPartId).HasColumnName("PersonPartID");

                entity.Property(e => e.PositionId).HasColumnName("PositionID");

                entity.Property(e => e.UserIdentify).HasMaxLength(50);
            });

            modelBuilder.Entity<TblNational>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblNational");

                entity.Property(e => e.NationalEng).HasMaxLength(20);

                entity.Property(e => e.NationalId).HasColumnName("NationalID");

                entity.Property(e => e.NationalName).HasMaxLength(50);
            });

            modelBuilder.Entity<TblNationalitydetail>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.NationalityDetailId).HasColumnName("NationalityDetailID");

                entity.Property(e => e.NationalityId).HasColumnName("NationalityID");

                entity.Property(e => e.PersonId).HasColumnName("PersonID");
            });

            modelBuilder.Entity<TblPerson>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.BranchId).HasColumnName("BranchID");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.Dob)
                    .HasColumnName("DOB")
                    .HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.FatherName).HasMaxLength(50);

                entity.Property(e => e.Fname)
                    .HasColumnName("FName")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.FunctionFid).HasColumnName("FunctionFID");

                entity.Property(e => e.FunctionMid).HasColumnName("FunctionMID");

                entity.Property(e => e.GenderId).HasColumnName("GenderID");

                entity.Property(e => e.Hobbies).HasMaxLength(100);

                entity.Property(e => e.Idcard)
                    .HasColumnName("IDCard")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.KhName).HasMaxLength(100);

                entity.Property(e => e.KhmerIdentityCard).HasMaxLength(50);

                entity.Property(e => e.Lname)
                    .HasColumnName("LName")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.MaritalStatusId).HasColumnName("MaritalStatusID");

                entity.Property(e => e.MotherName).HasMaxLength(50);

                entity.Property(e => e.NationalityId).HasColumnName("NationalityID");

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.Property(e => e.PersonTypeId).HasColumnName("PersonTypeID");

                entity.Property(e => e.Phone)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Photo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PositionId).HasColumnName("PositionID");

                entity.Property(e => e.Pwd)
                    .HasColumnName("pwd")
                    .HasMaxLength(200);

                entity.Property(e => e.ReasonResign).HasMaxLength(1500);

                entity.Property(e => e.RegisterDate).HasColumnType("datetime");

                entity.Property(e => e.SpecialNote).HasMaxLength(1500);

                entity.Property(e => e.SubDptId).HasColumnName("SubDptID");

                entity.Property(e => e.UserLog).HasMaxLength(50);

                entity.Property(e => e.Verifycode).HasMaxLength(50);

                entity.Property(e => e.WorkStartDate).HasColumnType("date");

                entity.Property(e => e.WorkStopDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblPersonAudit>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TblPerson_Audit");

                entity.Property(e => e.Action).HasMaxLength(50);

                entity.Property(e => e.ActionDate).HasColumnType("datetime");

                entity.Property(e => e.BranchId).HasColumnName("BranchID");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.Dob)
                    .HasColumnName("DOB")
                    .HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.FatherName).HasMaxLength(50);

                entity.Property(e => e.Fname)
                    .HasColumnName("FName")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.FunctionFid).HasColumnName("FunctionFID");

                entity.Property(e => e.FunctionMid).HasColumnName("FunctionMID");

                entity.Property(e => e.GenderId).HasColumnName("GenderID");

                entity.Property(e => e.Hobbies).HasMaxLength(100);

                entity.Property(e => e.Idcard)
                    .HasColumnName("IDCard")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.KhName).HasMaxLength(100);

                entity.Property(e => e.KhmerIdentityCard).HasMaxLength(50);

                entity.Property(e => e.Lname)
                    .HasColumnName("LName")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.MaritalStatusId).HasColumnName("MaritalStatusID");

                entity.Property(e => e.MotherName).HasMaxLength(50);

                entity.Property(e => e.NationalityId).HasColumnName("NationalityID");

                entity.Property(e => e.PersonAuditId).HasColumnName("PersonAuditID");

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.Property(e => e.PersonTypeId).HasColumnName("PersonTypeID");

                entity.Property(e => e.Phone)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Photo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PositionId).HasColumnName("PositionID");

                entity.Property(e => e.Pwd)
                    .HasColumnName("pwd")
                    .HasMaxLength(200);

                entity.Property(e => e.ReasonResign).HasMaxLength(1500);

                entity.Property(e => e.RegisterDate).HasColumnType("datetime");

                entity.Property(e => e.SpecialNote).HasMaxLength(1500);

                entity.Property(e => e.SubDptId).HasColumnName("SubDptID");

                entity.Property(e => e.UserLog).HasMaxLength(50);

                entity.Property(e => e.Verifycode).HasMaxLength(50);

                entity.Property(e => e.WorkStartDate).HasColumnType("date");

                entity.Property(e => e.WorkStopDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblPersonPart>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.PartEn)
                    .HasColumnName("PartEN")
                    .HasMaxLength(550);

                entity.Property(e => e.PartKh)
                    .HasColumnName("PartKH")
                    .HasMaxLength(550);

                entity.Property(e => e.PersonPartId).HasColumnName("PersonPartID");
            });

            modelBuilder.Entity<TblPersonSecurityPassword>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Idcard)
                    .HasColumnName("IDCard")
                    .HasMaxLength(10);

                entity.Property(e => e.Password).HasMaxLength(6);

                entity.Property(e => e.PasswordAnswer).HasMaxLength(50);

                entity.Property(e => e.PasswordChangeDate).HasColumnType("datetime");

                entity.Property(e => e.PaswordQuestion).HasMaxLength(50);
            });

            modelBuilder.Entity<TblPersonType>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.PersonTypeEn)
                    .HasColumnName("PersonTypeEN")
                    .HasMaxLength(50);

                entity.Property(e => e.PersonTypeId).HasColumnName("PersonTypeID");

                entity.Property(e => e.PersonTypeKh)
                    .HasColumnName("PersonTypeKH")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblPosition>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.PositionEn)
                    .HasColumnName("PositionEN")
                    .HasMaxLength(200);

                entity.Property(e => e.PositionId).HasColumnName("PositionID");

                entity.Property(e => e.PositionKh)
                    .HasColumnName("PositionKH")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<TblPositionMulti>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.EnName).HasMaxLength(250);

                entity.Property(e => e.KhName).HasMaxLength(250);

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.Property(e => e.PositionMultiId).HasColumnName("PositionMultiID");
            });

            modelBuilder.Entity<TblProject>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.ProjectName).HasMaxLength(50);
            });

            modelBuilder.Entity<TblRate>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Rate).HasColumnType("money");

                entity.Property(e => e.RateId).HasColumnName("RateID");
            });

            modelBuilder.Entity<TblRoom>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AreaSize)
                    .HasColumnName("Area_Size")
                    .HasMaxLength(50);

                entity.Property(e => e.BuildingId).HasColumnName("BuildingID");

                entity.Property(e => e.FixedSeats)
                    .HasColumnName("Fixed_Seats")
                    .HasMaxLength(3);

                entity.Property(e => e.ReservedSeats)
                    .HasColumnName("Reserved_Seats")
                    .HasMaxLength(3);

                entity.Property(e => e.Room).HasMaxLength(50);

                entity.Property(e => e.RoomId).HasColumnName("RoomID");
            });

            modelBuilder.Entity<TblRoomEquitmentAssign>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.EquitmentId)
                    .HasColumnName("EquitmentID")
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.RoomEquitmentAssignId).HasColumnName("RoomEquitmentAssignID");

                entity.Property(e => e.RoomId).HasColumnName("RoomID");
            });

            modelBuilder.Entity<TblScanLcd>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TblScanLCD");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.EquitmentId)
                    .HasColumnName("EquitmentID")
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.ReturnId).HasColumnName("ReturnID");

                entity.Property(e => e.ScanLcdid).HasColumnName("ScanLCDID");

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.Property(e => e.TimeTakeIn).HasColumnType("datetime");

                entity.Property(e => e.TimeTakeOut).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblSchedule>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AcademicId).HasColumnName("AcademicID");

                entity.Property(e => e.SchEnd)
                    .HasColumnName("sch_End")
                    .HasColumnType("datetime");

                entity.Property(e => e.SchNote)
                    .HasColumnName("sch_Note")
                    .HasMaxLength(100);

                entity.Property(e => e.SchStart)
                    .HasColumnName("sch_Start")
                    .HasColumnType("datetime");

                entity.Property(e => e.ScheduleId).HasColumnName("ScheduleID");
            });

            modelBuilder.Entity<TblSchool>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.School)
                    .HasMaxLength(55)
                    .IsUnicode(false);

                entity.Property(e => e.SchoolId).HasColumnName("SchoolID");
            });

            modelBuilder.Entity<TblSchoolLevel>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.BatchId).HasColumnName("BatchID");

                entity.Property(e => e.ClassId).HasColumnName("ClassID");

                entity.Property(e => e.DegreeId).HasColumnName("DegreeID");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.MajorId).HasColumnName("MajorID");

                entity.Property(e => e.ScheduleId).HasColumnName("ScheduleID");

                entity.Property(e => e.SchoolLevelId).HasColumnName("SchoolLevelID");

                entity.Property(e => e.SemesterId).HasColumnName("SemesterID");

                entity.Property(e => e.SessionId).HasColumnName("SessionID");

                entity.Property(e => e.YearId).HasColumnName("YearID");
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

            modelBuilder.Entity<TblSession>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblSession");

                entity.Property(e => e.SessionId).HasColumnName("SessionID");

                entity.Property(e => e.SessionName)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblSkillDetail>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.MajorId).HasColumnName("MajorID");

                entity.Property(e => e.SkillDetailId).HasColumnName("SkillDetailID");

                entity.Property(e => e.SkillName).HasMaxLength(50);
            });

            modelBuilder.Entity<TblStaffStatus>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.StaffStatus).HasMaxLength(20);

                entity.Property(e => e.StaffStatusId).HasColumnName("StaffStatusID");
            });

            modelBuilder.Entity<TblStatus>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.Property(e => e.StatusId).HasColumnName("StatusID");
            });

            modelBuilder.Entity<TblStopWork>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.Property(e => e.WorkId).HasColumnName("WorkID");
            });

            modelBuilder.Entity<TblStudyDetail>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.DegreeCode).HasMaxLength(10);

                entity.Property(e => e.DegreeId).HasColumnName("DegreeID");

                entity.Property(e => e.EducationTypeId).HasColumnName("EducationTypeID");

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.Property(e => e.School).HasMaxLength(100);

                entity.Property(e => e.SkillDetailId).HasColumnName("SkillDetailID");

                entity.Property(e => e.StudyDetailId).HasColumnName("StudyDetailID");

                entity.Property(e => e.YearStudy).HasMaxLength(20);
            });

            modelBuilder.Entity<TblSubCategorie>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CategoryName).HasMaxLength(20);

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.Image).HasMaxLength(50);

                entity.Property(e => e.MainCategoryId).HasColumnName("MainCategoryID");

                entity.Property(e => e.SubCategoryId).HasColumnName("SubCategoryID");
            });

            modelBuilder.Entity<TblSubDpt>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.SubDpt).HasMaxLength(150);

                entity.Property(e => e.SubDptEn)
                    .HasColumnName("SubDptEN")
                    .HasMaxLength(150);

                entity.Property(e => e.SubDptId).HasColumnName("SubDptID");
            });

            modelBuilder.Entity<TblSubject>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.DateUpdateId).HasColumnName("DateUpdateID");

                entity.Property(e => e.DegreeId).HasColumnName("DegreeID");

                entity.Property(e => e.MajorId).HasColumnName("MajorID");

                entity.Property(e => e.SemesterId).HasColumnName("SemesterID");

                entity.Property(e => e.Subject).HasMaxLength(100);

                entity.Property(e => e.SubjectId).HasColumnName("SubjectID");

                entity.Property(e => e.YearId).HasColumnName("YearID");
            });

            modelBuilder.Entity<TblSubjectAssigned>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.BonusId).HasColumnName("BonusID");

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.Property(e => e.RateId).HasColumnName("RateID");

                entity.Property(e => e.RoomId).HasColumnName("RoomID");

                entity.Property(e => e.SchoolLevelId).HasColumnName("SchoolLevelID");

                entity.Property(e => e.StaffStatusId).HasColumnName("StaffStatusID");

                entity.Property(e => e.SubjectAssignedId).HasColumnName("SubjectAssignedID");

                entity.Property(e => e.SubjectId).HasColumnName("SubjectID");
            });

            modelBuilder.Entity<TblSubjectCredit>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.SubjectId).HasColumnName("SubjectID");
            });

            modelBuilder.Entity<TblSupplier>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Address).HasMaxLength(100);

                entity.Property(e => e.CompanyName).HasMaxLength(100);

                entity.Property(e => e.ContactName).HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(30);

                entity.Property(e => e.Fax).HasMaxLength(30);

                entity.Property(e => e.Phone).HasMaxLength(30);

                entity.Property(e => e.SupplyerId).HasColumnName("SupplyerID");

                entity.Property(e => e.Website).HasMaxLength(30);
            });

            modelBuilder.Entity<TblTaskDetail>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AssignedTaskId).HasColumnName("AssignedTaskID");

                entity.Property(e => e.CreditId).HasColumnName("CreditID");

                entity.Property(e => e.DateDo).HasColumnType("datetime");

                entity.Property(e => e.SubjectId)
                    .HasColumnName("SubjectID")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.TaskDetailId).HasColumnName("TaskDetailID");

                entity.Property(e => e.TimeId).HasColumnName("TimeID");
            });

            modelBuilder.Entity<TblTeachingNote>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.TeachingNote).HasMaxLength(50);

                entity.Property(e => e.TeachingNoteId).HasColumnName("TeachingNoteID");
            });

            modelBuilder.Entity<TblTime>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Period).HasMaxLength(50);

                entity.Property(e => e.TimeId).HasColumnName("TimeID");
            });

            modelBuilder.Entity<TblTime2>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.SessionId)
                    .HasColumnName("SessionID")
                    .HasMaxLength(10);

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.TimeId).HasColumnName("TimeID");

                entity.Property(e => e.TimeNote).HasMaxLength(50);
            });

            modelBuilder.Entity<TblTimeSheet>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.DateTeach).HasColumnType("datetime");

                entity.Property(e => e.Other).HasMaxLength(100);

                entity.Property(e => e.SubjectAssignedId).HasColumnName("SubjectAssignedID");

                entity.Property(e => e.TimeId).HasColumnName("TimeID");

                entity.Property(e => e.TimeSheetId).HasColumnName("TimeSheetID");
            });

            modelBuilder.Entity<TblTimeSheetBackup>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CloseProcessId).HasColumnName("CloseProcessID");

                entity.Property(e => e.TimeSheetBackupId).HasColumnName("TimeSheetBackupID");

                entity.Property(e => e.TimeSheetType).HasMaxLength(20);
            });

            modelBuilder.Entity<TblTimeType>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.TimeType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TimeTypeId).HasColumnName("TimeTypeID");
            });

            modelBuilder.Entity<TblWork>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.FunctionId).HasColumnName("FunctionID");

                entity.Property(e => e.Location).HasMaxLength(200);

                entity.Property(e => e.LocationTypeId).HasColumnName("LocationTypeID");

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.Property(e => e.StartDateWork).HasColumnType("datetime");

                entity.Property(e => e.TimeTypeId).HasColumnName("TimeTypeID");

                entity.Property(e => e.WorkId).HasColumnName("WorkID");

                entity.Property(e => e.Year2Year).HasMaxLength(50);
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

            modelBuilder.Entity<Tblcommune>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBLCommune");

                entity.Property(e => e.ComCode)
                    .IsRequired()
                    .HasColumnName("Com_Code")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ComName)
                    .HasColumnName("Com_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.ComNameLimon)
                    .HasColumnName("Com_NameLimon")
                    .HasMaxLength(255);

                entity.Property(e => e.ComNameUnicode)
                    .HasColumnName("Com_NameUnicode")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Tbldistrict>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBLDistrict");

                entity.Property(e => e.DistCode)
                    .IsRequired()
                    .HasColumnName("Dist_Code")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DistName)
                    .HasColumnName("Dist_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.DistNameLimon)
                    .HasColumnName("Dist_NameLimon")
                    .HasMaxLength(255);

                entity.Property(e => e.DistNameUnicode)
                    .HasColumnName("Dist_NameUnicode")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Tblmajor>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBLMajor");

                entity.Property(e => e.FacultyId).HasColumnName("FacultyID");

                entity.Property(e => e.MajorId).HasColumnName("MajorID");

                entity.Property(e => e.MajorName).HasMaxLength(50);
            });

            modelBuilder.Entity<TblmajorX>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBLMajorX");

                entity.Property(e => e.MajorId).HasColumnName("MajorID");

                entity.Property(e => e.MajorName).HasMaxLength(50);
            });

            modelBuilder.Entity<Tblprovince>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBLProvince");

                entity.Property(e => e.ProCode)
                    .IsRequired()
                    .HasColumnName("Pro_Code")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProName)
                    .HasColumnName("Pro_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.ProNameLimon)
                    .HasColumnName("Pro_NameLimon")
                    .HasMaxLength(255);

                entity.Property(e => e.ProNameUniCode)
                    .HasColumnName("Pro_NameUniCode")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Tblvillage>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBLVillage");

                entity.Property(e => e.VillCode)
                    .IsRequired()
                    .HasColumnName("Vill_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.VillName)
                    .HasColumnName("Vill_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.VillNameLimon)
                    .HasColumnName("Vill_NameLimon")
                    .HasMaxLength(255);

                entity.Property(e => e.VillNameUnicode)
                    .HasColumnName("Vill_NameUnicode")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Tblyear>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBLYear");

                entity.Property(e => e.YearId).HasColumnName("YearID");

                entity.Property(e => e.YearName)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TotalFinalReportRate>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Total_final_report_rate");

                entity.Property(e => e.FullName)
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.Property(e => e.Rate).HasColumnType("money");

                entity.Property(e => e.SemesterId).HasColumnName("SemesterID");

                entity.Property(e => e.Subject).HasMaxLength(100);

                entity.Property(e => e.YearId).HasColumnName("YearID");
            });

            modelBuilder.Entity<VFinalTotal>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_Final_Total");

                entity.Property(e => e.FullName)
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.Property(e => e.SemesterId).HasColumnName("SemesterID");

                entity.Property(e => e.YearId).HasColumnName("YearID");
            });

            modelBuilder.Entity<VTotalEquipment>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_TotalEquipment");

                entity.Property(e => e.CategoryName).HasMaxLength(20);

                entity.Property(e => e.Status).HasMaxLength(20);

                entity.Property(e => e.TotalPrice).HasColumnType("money");
            });

            modelBuilder.Entity<VViewPersonalInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_ViewPersonalInfo");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.Dob)
                    .HasColumnName("DOB")
                    .HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.FatherName).HasMaxLength(50);

                entity.Property(e => e.Fname)
                    .HasColumnName("FName")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.FunctionFid).HasColumnName("FunctionFID");

                entity.Property(e => e.FunctionMid).HasColumnName("FunctionMID");

                entity.Property(e => e.GenderId).HasColumnName("GenderID");

                entity.Property(e => e.Hobbies).HasMaxLength(100);

                entity.Property(e => e.Idcard)
                    .HasColumnName("IDCard")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.KhName).HasMaxLength(100);

                entity.Property(e => e.KhmerIdentityCard).HasMaxLength(50);

                entity.Property(e => e.Lname)
                    .HasColumnName("LName")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.MaritalStatusId).HasColumnName("MaritalStatusID");

                entity.Property(e => e.MotherName).HasMaxLength(50);

                entity.Property(e => e.NationalityId).HasColumnName("NationalityID");

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.Property(e => e.PersonTypeId).HasColumnName("PersonTypeID");

                entity.Property(e => e.Phone)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Photo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PositionId).HasColumnName("PositionID");

                entity.Property(e => e.ReasonResign).HasMaxLength(1500);

                entity.Property(e => e.SpecialNote).HasMaxLength(1500);

                entity.Property(e => e.SubDptId).HasColumnName("SubDptID");

                entity.Property(e => e.WorkStartDate).HasColumnType("date");
            });

            modelBuilder.Entity<VViewStudyHistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_ViewStudyHistory");

                entity.Property(e => e.DegreeCode).HasMaxLength(10);

                entity.Property(e => e.DegreeId).HasColumnName("DegreeID");

                entity.Property(e => e.EducationTypeId).HasColumnName("EducationTypeID");

                entity.Property(e => e.MajorId).HasColumnName("MajorID");

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.Property(e => e.School).HasMaxLength(100);

                entity.Property(e => e.SkillDetailId).HasColumnName("SkillDetailID");

                entity.Property(e => e.StudyDetailId).HasColumnName("StudyDetailID");

                entity.Property(e => e.YearStudy).HasMaxLength(20);
            });

            modelBuilder.Entity<VViewStudyRecord>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_ViewStudyRecord");

                entity.Property(e => e.DegreeId).HasColumnName("DegreeID");

                entity.Property(e => e.MajorId).HasColumnName("MajorID");

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.Property(e => e.School).HasMaxLength(100);

                entity.Property(e => e.SkillDetailId).HasColumnName("SkillDetailID");

                entity.Property(e => e.StudyDetailId).HasColumnName("StudyDetailID");

                entity.Property(e => e.YearStudy).HasMaxLength(20);
            });

            modelBuilder.Entity<VViewWorkHistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_ViewWorkHistory");

                entity.Property(e => e.FunctionId).HasColumnName("FunctionID");

                entity.Property(e => e.Location).HasMaxLength(200);

                entity.Property(e => e.LocationTypeId).HasColumnName("LocationTypeID");

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.Property(e => e.StartDateWork).HasColumnType("datetime");

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.Property(e => e.TimeTypeId).HasColumnName("TimeTypeID");

                entity.Property(e => e.WorkId).HasColumnName("WorkID");

                entity.Property(e => e.Year2Year).HasMaxLength(50);
            });

            modelBuilder.Entity<View3>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_3");

                entity.Property(e => e.DateTeach).HasColumnType("datetime");

                entity.Property(e => e.Period).HasMaxLength(50);

                entity.Property(e => e.SubjectAssignedId).HasColumnName("SubjectAssignedID");

                entity.Property(e => e.TeachingNote).HasMaxLength(50);

                entity.Property(e => e.TeachingNoteId).HasColumnName("TeachingNoteID");

                entity.Property(e => e.TimeId).HasColumnName("TimeID");

                entity.Property(e => e.TimeSheetId).HasColumnName("TimeSheetID");
            });

            modelBuilder.Entity<View4>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_4");

                entity.Property(e => e.BonusMoney).HasColumnType("money");

                entity.Property(e => e.FullName)
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.Property(e => e.Rate).HasColumnType("money");

                entity.Property(e => e.SemesterId).HasColumnName("SemesterID");

                entity.Property(e => e.Subject).HasMaxLength(100);

                entity.Property(e => e.TotalPrice).HasColumnType("numeric(34, 5)");

                entity.Property(e => e.YearId).HasColumnName("YearID");
            });

            modelBuilder.Entity<View5>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_5");

                entity.Property(e => e.AcademicName)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.BatchName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CloseDate)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DateTeach).HasColumnType("datetime");

                entity.Property(e => e.DegreeName).HasMaxLength(50);

                entity.Property(e => e.FacultyId).HasColumnName("FacultyID");

                entity.Property(e => e.FacultyName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FullName)
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.GroupName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MajorName).HasMaxLength(50);

                entity.Property(e => e.Other).HasMaxLength(100);

                entity.Property(e => e.Period).HasMaxLength(50);

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.Property(e => e.SemesterName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SessionName)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Subject).HasMaxLength(100);

                entity.Property(e => e.SubjectAssignedId).HasColumnName("SubjectAssignedID");

                entity.Property(e => e.TeachingNote).HasMaxLength(50);

                entity.Property(e => e.YearName)
                    .HasMaxLength(26)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<View6>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_6");

                entity.Property(e => e.DegreeId).HasColumnName("DegreeID");

                entity.Property(e => e.DegreeKh).HasMaxLength(50);

                entity.Property(e => e.GenderId).HasColumnName("GenderID");

                entity.Property(e => e.NationalityId).HasColumnName("NationalityID");

                entity.Property(e => e.Nations)
                    .IsRequired()
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.SexEng).HasMaxLength(6);

                entity.Property(e => e.Total).HasColumnName("total");
            });

            modelBuilder.Entity<View7ToTangheng>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_7_To_Tangheng");

                entity.Property(e => e.Fname)
                    .HasColumnName("FName")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Idcard)
                    .HasColumnName("IDCard")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Lname)
                    .HasColumnName("LName")
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
