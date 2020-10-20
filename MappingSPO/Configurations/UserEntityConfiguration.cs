using MappingSPO.Entities;

namespace MappingSPO
{
    public class UserEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<UserEntity>
    {
        public UserEntityConfiguration()
            : this("HumanResources")
        {
        }

        public UserEntityConfiguration(string schema)
        {
            ToTable("tUsers", schema);
            HasKey(x => x.UserId);

            Property(x => x.UserId).HasColumnName(@"UserID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.UserSname).HasColumnName(@"User_Sname").HasColumnType("nvarchar").IsRequired().HasMaxLength(256);
            Property(x => x.UserAlias).HasColumnName(@"UserAlias").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.FirstLogoff).HasColumnName(@"FirstLogoff").HasColumnType("datetime").IsOptional();
            Property(x => x.LastLogoff).HasColumnName(@"LastLogoff").HasColumnType("datetime").IsOptional();
            Property(x => x.Handtekening1).HasColumnName(@"Handtekening1").HasColumnType("nvarchar").IsOptional().HasMaxLength(250);
            Property(x => x.Handtekening2).HasColumnName(@"Handtekening2").HasColumnType("nvarchar").IsOptional().HasMaxLength(250);
            Property(x => x.Handtekening3).HasColumnName(@"Handtekening3").HasColumnType("nvarchar").IsOptional().HasMaxLength(250);
            Property(x => x.Handtekening4).HasColumnName(@"Handtekening4").HasColumnType("nvarchar").IsOptional().HasMaxLength(250);
            Property(x => x.Handtekening5).HasColumnName(@"Handtekening5").HasColumnType("nvarchar").IsOptional().HasMaxLength(250);
            Property(x => x.Handtekening6).HasColumnName(@"Handtekening6").HasColumnType("nvarchar").IsOptional().HasMaxLength(250);
            Property(x => x.MainMenuNumber).HasColumnName(@"MainMenuNumber").HasColumnType("bigint").IsOptional();
            Property(x => x.MainMenuParaMeters).HasColumnName(@"MainMenuParaMeters").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.OutlookAddinVersion).HasColumnName(@"OutlookAddinVersion").HasColumnType("int").IsOptional();
            Property(x => x.OutlookAddinVersionDate).HasColumnName(@"OutlookAddinVersionDate").HasColumnType("datetime").IsOptional();
            Property(x => x.AutoBackupCalculationYn).HasColumnName(@"AutoBackupCalculationYn").HasColumnType("bit").IsOptional();
            Property(x => x.EmployeeId).HasColumnName(@"EmployeeID").HasColumnType("int").IsOptional();
            Property(x => x.AutoStartReminderService).HasColumnName(@"AutoStartReminderService").HasColumnType("bit").IsOptional();
            Property(x => x.ReminderReloadDataMinuts).HasColumnName(@"ReminderReloadDataMinuts").HasColumnType("bigint").IsOptional();
            Property(x => x.ReminderIntervalSec).HasColumnName(@"ReminderIntervalSec").HasColumnType("bigint").IsOptional();
            Property(x => x.DelayTimeToDoReminder).HasColumnName(@"DelayTimeToDoReminder").HasColumnType("bigint").IsOptional();
            Property(x => x.OlLastSyncTime).HasColumnName(@"olLastSyncTime").HasColumnType("datetime").IsOptional();
            Property(x => x.OlMailAdress).HasColumnName(@"olMailAdress").HasColumnType("nvarchar").IsOptional().HasMaxLength(500);
            Property(x => x.OlSyncIntervalInMinutes).HasColumnName(@"olSyncIntervalInMinutes").HasColumnType("float").IsOptional();
            Property(x => x.OlSyncBodyYn).HasColumnName(@"olSyncBodyYn").HasColumnType("bit").IsOptional();
            Property(x => x.OlConflictResolveMode).HasColumnName(@"olConflictResolveMode").HasColumnType("int").IsOptional();
            Property(x => x.OlSyncEnabled).HasColumnName(@"olSyncEnabled").HasColumnType("bit").IsOptional();
            Property(x => x.OlSyncFromDate).HasColumnName(@"olSyncFromDate").HasColumnType("datetime").IsOptional();
            Property(x => x.OlMaxDaysInPast).HasColumnName(@"olMaxDaysInPast").HasColumnType("int").IsOptional();
            Property(x => x.WfActionsHideNotifications).HasColumnName(@"WFActionsHideNotifications").HasColumnType("bit").IsOptional();
            Property(x => x.LanguageCode).HasColumnName(@"LanguageCode").HasColumnType("nchar").IsOptional().IsFixedLength().HasMaxLength(4);
            Property(x => x.DefaultCompanyId).HasColumnName(@"DefaultCompanyID").HasColumnType("int").IsOptional();
            Property(x => x.DefaultMagazijnId).HasColumnName(@"DefaultMagazijnID").HasColumnType("bigint").IsOptional();
            Property(x => x.DefaultToonzaalId).HasColumnName(@"DefaultToonzaalID").HasColumnType("bigint").IsOptional();
            Property(x => x.DefaultCompanyIdStock).HasColumnName(@"DefaultCompanyIDStock").HasColumnType("int").IsOptional();
            Property(x => x.ManualUpdateDwEnabled).HasColumnName(@"ManualUpdateDWEnabled").HasColumnType("bit").IsOptional();
            Property(x => x.UiLanguageCode).HasColumnName(@"UILanguageCode").HasColumnType("nvarchar").IsOptional().HasMaxLength(5);
            Property(x => x.Disabled).HasColumnName(@"Disabled").HasColumnType("bit").IsRequired();
            Property(x => x.ShowPrintDialogOnPrintDirect).HasColumnName(@"ShowPrintDialogOnPrintDirect").HasColumnType("bit").IsRequired();
            Property(x => x.ShowWerfExtendedXrm).HasColumnName(@"ShowWerfExtendedXRM").HasColumnType("int").IsRequired();
            Property(x => x.DefaultPathExportXmlVordering).HasColumnName(@"DefaultPathExportXMLVordering").HasColumnType("nvarchar").IsOptional().HasMaxLength(4000);
            Property(x => x.RtfZoomFactor).HasColumnName(@"RTFZoomFactor").HasColumnType("real").IsOptional();
            Property(x => x.IsLicensedBuild).HasColumnName(@"IsLicensedBuild").HasColumnType("bit").IsRequired();
            Property(x => x.IsLicensedEmma).HasColumnName(@"IsLicensedEmma").HasColumnType("bit").IsRequired();
            Property(x => x.ShowWerfExplorer).HasColumnName(@"ShowWerfExplorer").HasColumnType("bit").IsRequired();
            Property(x => x.DefaultSkin).HasColumnName(@"DefaultSkin").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.BestModPrefilter).HasColumnName(@"BestModPrefilter").HasColumnType("nvarchar").IsOptional().HasMaxLength(4000);

            HasOptional(a => a.Company).WithMany(b => b.Users).HasForeignKey(c => c.DefaultCompanyId).WillCascadeOnDelete(false);
            HasOptional(a => a.Language).WithMany(b => b.Users).HasForeignKey(c => c.LanguageCode).WillCascadeOnDelete(false);
        }
    }
}
