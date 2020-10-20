using MappingSPO.Entities;

namespace MappingSPO
{
    public class TodoTypeEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<TodoTypeEntity>
    {
        public TodoTypeEntityConfiguration()
            : this("Settings")
        {
        }

        public TodoTypeEntityConfiguration(string schema)
        {
            ToTable("tTodoType", schema);
            HasKey(x => x.TodoTypeId);

            Property(x => x.TodoTypeId).HasColumnName(@"TodoTypeID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.DisplayNumber).HasColumnName(@"DisplayNumber").HasColumnType("int").IsRequired();
            Property(x => x.DisplayText).HasColumnName(@"DisplayText").HasColumnType("nvarchar").IsRequired().HasMaxLength(100);
            Property(x => x.DisplayIcon).HasColumnName(@"DisplayIcon").HasColumnType("image").IsRequired().HasMaxLength(2147483647);
            Property(x => x.Disabled).HasColumnName(@"Disabled").HasColumnType("bit").IsRequired();
            Property(x => x.SyncToOutlookMode).HasColumnName(@"SyncToOutlookMode").HasColumnType("int").IsRequired();
            Property(x => x.ToDoMasterType).HasColumnName(@"ToDoMasterType").HasColumnType("int").IsRequired();
        }
    }
}
