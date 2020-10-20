using MappingSPO.Entities;

namespace MappingSPO
{
    public class ToDoItemStateEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<ToDoItemStateEntity>
    {
        public ToDoItemStateEntityConfiguration()
            : this("Settings")
        {
        }

        public ToDoItemStateEntityConfiguration(string schema)
        {
            ToTable("tToDoItemStates", schema);
            HasKey(x => x.ItemStateId);

            Property(x => x.ItemStateId).HasColumnName(@"ItemStateID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.StateOrder).HasColumnName(@"StateOrder").HasColumnType("int").IsRequired();
            Property(x => x.Description).HasColumnName(@"Description").HasColumnType("nvarchar").IsRequired().HasMaxLength(150);
            Property(x => x.Disabled).HasColumnName(@"Disabled").HasColumnType("bit").IsRequired();
        }
    }
}
