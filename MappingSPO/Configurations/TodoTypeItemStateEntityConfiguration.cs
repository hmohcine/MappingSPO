using MappingSPO.Entities;

namespace MappingSPO
{
    public class TodoTypeItemStateEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<TodoTypeItemStateEntity>
    {
        public TodoTypeItemStateEntityConfiguration()
            : this("Settings")
        {
        }

        public TodoTypeItemStateEntityConfiguration(string schema)
        {
            ToTable("tTodoTypeItemStates", schema);
            HasKey(x => x.TodoTypeItemStateId);

            Property(x => x.TodoTypeItemStateId).HasColumnName(@"TodoTypeItemStateID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.TodoTypeId).HasColumnName(@"TodoTypeID").HasColumnType("bigint").IsRequired();
            Property(x => x.ItemStateId).HasColumnName(@"ItemStateID").HasColumnType("int").IsRequired();
            Property(x => x.TypeStateOrder).HasColumnName(@"TypeStateOrder").HasColumnType("int").IsRequired();

            HasRequired(a => a.ToDoItemState).WithMany(b => b.TodoTypeItemStates).HasForeignKey(c => c.ItemStateId).WillCascadeOnDelete(false);
            HasRequired(a => a.TodoType).WithMany(b => b.TodoTypeItemStates).HasForeignKey(c => c.TodoTypeId).WillCascadeOnDelete(false);
        }
    }
}
