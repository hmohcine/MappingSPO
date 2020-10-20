using MappingSPO.Project.DL.Entities;

namespace MappingSPO.Project.DL.Configurations
{
    public class TodoItemEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<TodoItemEntity>
    {
        public TodoItemEntityConfiguration()
            : this("Project")
        {
        }

        public TodoItemEntityConfiguration(string schema)
        {
            ToTable("tTodoItems", schema);
            HasKey(x => x.ItemId);

            Property(x => x.ItemId).HasColumnName(@"ItemID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.TodoTypeId).HasColumnName(@"TodoTypeID").HasColumnType("bigint").IsRequired();
            Property(x => x.Subject).HasColumnName(@"Subject").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Location).HasColumnName(@"Location").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.Notes).HasColumnName(@"Notes").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.ItemStateId).HasColumnName(@"ItemStateID").HasColumnType("int").IsOptional();
            Property(x => x.IsActive).HasColumnName(@"IsActive").HasColumnType("bit").IsRequired();
            Property(x => x.IsDone).HasColumnName(@"IsDone").HasColumnType("bit").IsRequired();
            Property(x => x.IsDeleted).HasColumnName(@"IsDeleted").HasColumnType("bit").IsRequired();
            Property(x => x.AllDayEvent).HasColumnName(@"AllDayEvent").HasColumnType("bit").IsOptional();
            Property(x => x.StartDate).HasColumnName(@"StartDate").HasColumnType("datetime").IsOptional();
            Property(x => x.DueDate).HasColumnName(@"DueDate").HasColumnType("datetime").IsOptional();
            Property(x => x.DoneDate).HasColumnName(@"DoneDate").HasColumnType("datetime").IsOptional();
            Property(x => x.Owner).HasColumnName(@"Owner").HasColumnType("int").IsRequired();
            Property(x => x.CreatedDate).HasColumnName(@"CreatedDate").HasColumnType("datetime").IsRequired();
            Property(x => x.CreatedBy).HasColumnName(@"CreatedBy").HasColumnType("int").IsRequired();
            Property(x => x.UpdatedDate).HasColumnName(@"UpdatedDate").HasColumnType("datetime").IsRequired();
            Property(x => x.UpdatedBy).HasColumnName(@"UpdatedBy").HasColumnType("int").IsRequired();
            Property(x => x.ProjectId).HasColumnName(@"ProjectID").HasColumnType("bigint").IsOptional();
            Property(x => x.ProjectType).HasColumnName(@"ProjectType").HasColumnType("nvarchar").IsOptional().HasMaxLength(2);
            Property(x => x.RelationTypeId).HasColumnName(@"RelationTypeID").HasColumnType("int").IsOptional();
            Property(x => x.RelationId).HasColumnName(@"RelationID").HasColumnType("bigint").IsOptional();
            Property(x => x.ContactId).HasColumnName(@"ContactID").HasColumnType("int").IsOptional();
            Property(x => x.WerfId).HasColumnName(@"WerfID").HasColumnType("bigint").IsOptional();
            Property(x => x.HasReminder).HasColumnName(@"HasReminder").HasColumnType("bit").IsRequired();
            Property(x => x.ReminderTime).HasColumnName(@"ReminderTime").HasColumnType("datetime").IsOptional();
            Property(x => x.ReminderMinutes).HasColumnName(@"ReminderMinutes").HasColumnType("int").IsOptional();
            Property(x => x.ReminderMode).HasColumnName(@"ReminderMode").HasColumnType("int").IsOptional();
            Property(x => x.OlSyncronisedYn).HasColumnName(@"olSyncronisedYn").HasColumnType("bit").IsOptional();
            Property(x => x.OlSyncGuid).HasColumnName(@"olSyncGuid").HasColumnType("uniqueidentifier").IsOptional();
            Property(x => x.OlLastSyncTime).HasColumnName(@"olLastSyncTime").HasColumnType("datetime").IsOptional();
            Property(x => x.OlEntryId).HasColumnName(@"olEntryID").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.OlStoreId).HasColumnName(@"olStoreID").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.OlClass).HasColumnName(@"olClass").HasColumnType("int").IsOptional();
            Property(x => x.WorkflowId).HasColumnName(@"WorkflowID").HasColumnType("bigint").IsOptional();
            Property(x => x.TaskId).HasColumnName(@"TaskID").HasColumnType("bigint").IsOptional();
            Property(x => x.ExtraMinutes).HasColumnName(@"ExtraMinutes").HasColumnType("int").IsOptional();
            Property(x => x.NextReminderTime).HasColumnName(@"NextReminderTime").HasColumnType("datetime").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.EmployeeId).HasColumnName(@"EmployeeID").HasColumnType("int").IsOptional();
            Property(x => x.TodoYear).HasColumnName(@"TodoYear").HasColumnType("int").IsOptional();
            Property(x => x.TodoNr).HasColumnName(@"TodoNr").HasColumnType("int").IsOptional();
            Property(x => x.TodoNrText).HasColumnName(@"TodoNrText").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.InkoopCategorieActiviteitId).HasColumnName(@"InkoopCategorieActiviteitID").HasColumnType("bigint").IsOptional();
            Property(x => x.VerkoopCategorieActiviteitId).HasColumnName(@"VerkoopCategorieActiviteitID").HasColumnType("bigint").IsOptional();
            Property(x => x.ActiviteitId).HasColumnName(@"ActiviteitID").HasColumnType("bigint").IsOptional();
            Property(x => x.Prioriteit).HasColumnName(@"Prioriteit").HasColumnType("int").IsRequired();
            Property(x => x.ExterneRef).HasColumnName(@"ExterneRef").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.Melder).HasColumnName(@"Melder").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.MelderEmail).HasColumnName(@"MelderEmail").HasColumnType("nvarchar").IsOptional().HasMaxLength(250);
            Property(x => x.ReminderDelay).HasColumnName(@"ReminderDelay").HasColumnType("int").IsOptional();
            Property(x => x.ReminderTimeSchedule).HasColumnName(@"ReminderTimeSchedule").HasColumnType("int").IsOptional();

            HasOptional(a => a.Contact).WithMany(b => b.TodoItems).HasForeignKey(c => c.ContactId).WillCascadeOnDelete(false);
            HasOptional(a => a.Project).WithMany(b => b.TodoItems).HasForeignKey(c => new { c.ProjectId, c.ProjectType }).WillCascadeOnDelete(false);
            HasOptional(a => a.Relation).WithMany(b => b.TodoItems).HasForeignKey(c => c.RelationId).WillCascadeOnDelete(false);
            HasOptional(a => a.Werf).WithMany(b => b.TodoItems).HasForeignKey(c => c.WerfId).WillCascadeOnDelete(false);
        }
    }
}
