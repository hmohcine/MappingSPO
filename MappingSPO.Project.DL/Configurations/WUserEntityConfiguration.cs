using MappingSPO.Project.DL.Entities;

namespace MappingSPO.Project.DL.Configurations
{
    public class WUserEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<WUserEntity>
    {
        public WUserEntityConfiguration()
            : this("dbo")
        {
        }

        public WUserEntityConfiguration(string schema)
        {
            ToTable("vwUsers", schema);
            HasKey(x => new { x.UserId, x.UserSname, x.Disabled });

            Property(x => x.UserId).HasColumnName(@"UserID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.UserSname).HasColumnName(@"User_Sname").HasColumnType("nvarchar").IsRequired().HasMaxLength(256).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.UserAlias).HasColumnName(@"UserAlias").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.EmployeeId).HasColumnName(@"EmployeeID").HasColumnType("int").IsOptional();
            Property(x => x.FirstName).HasColumnName(@"FirstName").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.LastName).HasColumnName(@"LastName").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.ProperName).HasColumnName(@"ProperName").HasColumnType("nvarchar").IsOptional().HasMaxLength(201);
            Property(x => x.AutoStartReminderService).HasColumnName(@"AutoStartReminderService").HasColumnType("bit").IsOptional();
            Property(x => x.ReminderReloadDataMinuts).HasColumnName(@"ReminderReloadDataMinuts").HasColumnType("bigint").IsOptional();
            Property(x => x.ReminderIntervalSec).HasColumnName(@"ReminderIntervalSec").HasColumnType("bigint").IsOptional();
            Property(x => x.DelayTimeToDoReminder).HasColumnName(@"DelayTimeToDoReminder").HasColumnType("bigint").IsOptional();
            Property(x => x.OlMailAdress).HasColumnName(@"olMailAdress").HasColumnType("nvarchar").IsOptional().HasMaxLength(500);
            Property(x => x.WfActionsHideNotifications).HasColumnName(@"WFActionsHideNotifications").HasColumnType("bit").IsOptional();
            Property(x => x.Disabled).HasColumnName(@"Disabled").HasColumnType("bit").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
        }
    }
}
