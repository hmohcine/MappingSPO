using MappingSPO.Project.DL.Entities;

namespace MappingSPO.Project.DL.Configurations
{
    public class WTodoExplorerEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<WTodoExplorerEntity>
    {
        public WTodoExplorerEntityConfiguration()
            : this("dbo")
        {
        }

        public WTodoExplorerEntityConfiguration(string schema)
        {
            ToTable("vwTodoExplorer", schema);
            HasKey(x => new { x.ItemId, x.ToDoMasterType, x.DisplayIcon, x.IsDone, x.IsDeleted, x.DisplayNumber, x.DisplayText, x.Owner, x.IsActive, x.HasReminder, x.Prioriteit });

            Property(x => x.ItemId).HasColumnName(@"ItemID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ToDoMasterType).HasColumnName(@"ToDoMasterType").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.DisplayIcon).HasColumnName(@"DisplayIcon").HasColumnType("image").IsRequired().HasMaxLength(2147483647).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IsDone).HasColumnName(@"IsDone").HasColumnType("bit").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IsDeleted).HasColumnName(@"IsDeleted").HasColumnType("bit").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.StartDate).HasColumnName(@"StartDate").HasColumnType("datetime").IsOptional();
            Property(x => x.Days).HasColumnName(@"days").HasColumnType("int").IsOptional();
            Property(x => x.DisplayNumber).HasColumnName(@"DisplayNumber").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.DisplayText).HasColumnName(@"DisplayText").HasColumnType("nvarchar").IsRequired().HasMaxLength(100).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Subject).HasColumnName(@"Subject").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Location).HasColumnName(@"Location").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.RelationId).HasColumnName(@"RelationID").HasColumnType("bigint").IsOptional();
            Property(x => x.ContactId).HasColumnName(@"ContactID").HasColumnType("int").IsOptional();
            Property(x => x.RelationName).HasColumnName(@"RelationName").HasColumnType("nvarchar").IsOptional().HasMaxLength(120);
            Property(x => x.RelationCity).HasColumnName(@"RelationCity").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.RelationPhone1).HasColumnName(@"RelationPhone1").HasColumnType("nvarchar").IsOptional().HasMaxLength(40);
            Property(x => x.RelationPhone2).HasColumnName(@"RelationPhone2").HasColumnType("nvarchar").IsOptional().HasMaxLength(40);
            Property(x => x.RelationFax1).HasColumnName(@"RelationFax1").HasColumnType("nvarchar").IsOptional().HasMaxLength(40);
            Property(x => x.RelationFax2).HasColumnName(@"RelationFax2").HasColumnType("nvarchar").IsOptional().HasMaxLength(40);
            Property(x => x.RelationEmail1).HasColumnName(@"RelationEmail1").HasColumnType("nvarchar").IsOptional().HasMaxLength(250);
            Property(x => x.RelationEmail2).HasColumnName(@"RelationEmail2").HasColumnType("nvarchar").IsOptional().HasMaxLength(250);
            Property(x => x.ContactGsm).HasColumnName(@"ContactGSM").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.ContactPhone).HasColumnName(@"ContactPhone").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.ContactFax).HasColumnName(@"ContactFax").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.ContactEmail).HasColumnName(@"ContactEmail").HasColumnType("nvarchar").IsOptional().HasMaxLength(250);
            Property(x => x.ContactName).HasColumnName(@"ContactName").HasColumnType("nvarchar").IsOptional().HasMaxLength(120);
            Property(x => x.ContactCity).HasColumnName(@"ContactCity").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.ContactPrivePhone).HasColumnName(@"ContactPrivePhone").HasColumnType("nvarchar").IsOptional().HasMaxLength(40);
            Property(x => x.ContactPriveFax).HasColumnName(@"ContactPriveFax").HasColumnType("nvarchar").IsOptional().HasMaxLength(40);
            Property(x => x.ContactPriveEmail).HasColumnName(@"ContactPriveEmail").HasColumnType("nvarchar").IsOptional().HasMaxLength(250);
            Property(x => x.ContactPriveGsm).HasColumnName(@"ContactPriveGSM").HasColumnType("nvarchar").IsOptional().HasMaxLength(40);
            Property(x => x.DueDate).HasColumnName(@"DueDate").HasColumnType("datetime").IsOptional();
            Property(x => x.DoneDate).HasColumnName(@"DoneDate").HasColumnType("datetime").IsOptional();
            Property(x => x.Owner).HasColumnName(@"Owner").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.OwnerName).HasColumnName(@"OwnerName").HasColumnType("nvarchar").IsOptional().HasMaxLength(201);
            Property(x => x.ProjectId).HasColumnName(@"ProjectID").HasColumnType("bigint").IsOptional();
            Property(x => x.ProjectType).HasColumnName(@"ProjectType").HasColumnType("nvarchar").IsOptional().HasMaxLength(2);
            Property(x => x.ProjectNrText).HasColumnName(@"ProjectNrText").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.ProjectName).HasColumnName(@"ProjectName").HasColumnType("nvarchar").IsOptional().HasMaxLength(250);
            Property(x => x.CurrentState).HasColumnName(@"CurrentState").HasColumnType("nvarchar").IsOptional().HasMaxLength(200);
            Property(x => x.CurrentStateIcon).HasColumnName(@"CurrentStateIcon").HasColumnType("image").IsOptional().HasMaxLength(2147483647);
            Property(x => x.CurrentStateWorkflow).HasColumnName(@"CurrentStateWorkflow").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.WerfName).HasColumnName(@"WerfName").HasColumnType("nvarchar").IsOptional().HasMaxLength(200);
            Property(x => x.WerfState).HasColumnName(@"WerfState").HasColumnType("int").IsOptional();
            Property(x => x.IsActive).HasColumnName(@"IsActive").HasColumnType("bit").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.OlSyncronisedYn).HasColumnName(@"olSyncronisedYn").HasColumnType("bit").IsOptional();
            Property(x => x.OlLastSyncTime).HasColumnName(@"olLastSyncTime").HasColumnType("datetime").IsOptional();
            Property(x => x.HasReminder).HasColumnName(@"HasReminder").HasColumnType("bit").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ReminderTime).HasColumnName(@"ReminderTime").HasColumnType("datetime").IsOptional();
            Property(x => x.AllDayEvent).HasColumnName(@"AllDayEvent").HasColumnType("bit").IsOptional();
            Property(x => x.WerfId).HasColumnName(@"WerfID").HasColumnType("bigint").IsOptional();
            Property(x => x.EmployeeId).HasColumnName(@"EmployeeID").HasColumnType("int").IsOptional();
            Property(x => x.Employee).HasColumnName(@"Employee").HasColumnType("nvarchar").IsOptional().HasMaxLength(201);
            Property(x => x.TodoNrText).HasColumnName(@"TodoNrText").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.ExterneRef).HasColumnName(@"ExterneRef").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.Melder).HasColumnName(@"Melder").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.MelderEmail).HasColumnName(@"MelderEmail").HasColumnType("nvarchar").IsOptional().HasMaxLength(250);
            Property(x => x.Prioriteit).HasColumnName(@"Prioriteit").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.InkoopCat).HasColumnName(@"InkoopCat").HasColumnType("nvarchar").IsOptional().HasMaxLength(120);
            Property(x => x.InkoopCatGroup).HasColumnName(@"InkoopCatGroup").HasColumnType("nvarchar").IsOptional().HasMaxLength(120);
            Property(x => x.VerkoopCat).HasColumnName(@"VerkoopCat").HasColumnType("nvarchar").IsOptional().HasMaxLength(120);
            Property(x => x.VerkoopCatGroup).HasColumnName(@"VerkoopCatGroup").HasColumnType("nvarchar").IsOptional().HasMaxLength(120);
            Property(x => x.Activiteit).HasColumnName(@"Activiteit").HasColumnType("nvarchar").IsOptional().HasMaxLength(120);
            Property(x => x.ActiviteitGroup).HasColumnName(@"ActiviteitGroup").HasColumnType("nvarchar").IsOptional().HasMaxLength(120);
            Property(x => x.StatusDescription).HasColumnName(@"StatusDescription").HasColumnType("nvarchar").IsOptional().HasMaxLength(150);
            Property(x => x.Werfnummer).HasColumnName(@"Werfnummer").HasColumnType("nvarchar").IsOptional().HasMaxLength(39);
        }
    }
}
