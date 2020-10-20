using MappingSPO.Entities;

namespace MappingSPO
{
    public class QueryEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<QueryEntity>
    {
        public QueryEntityConfiguration()
            : this("Settings")
        {
        }

        public QueryEntityConfiguration(string schema)
        {
            ToTable("tQuerys", schema);
            HasKey(x => x.Number);

            Property(x => x.Number).HasColumnName(@"Number").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasColumnName(@"Name").HasColumnType("nvarchar").IsRequired().HasMaxLength(15);
            Property(x => x.Alias).HasColumnName(@"Alias").HasColumnType("nvarchar").IsRequired().HasMaxLength(75);
            Property(x => x.Description).HasColumnName(@"Description").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Notes).HasColumnName(@"Notes").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.SpCreateStatement).HasColumnName(@"spCreateStatement").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.DesignDate).HasColumnName(@"DesignDate").HasColumnType("datetime").IsOptional();
            Property(x => x.Copyright).HasColumnName(@"Copyright").HasColumnType("nvarchar").IsOptional().HasMaxLength(150);
            Property(x => x.Enabled).HasColumnName(@"Enabled").HasColumnType("bit").IsRequired();
            Property(x => x.UserGroupId).HasColumnName(@"UserGroupID").HasColumnType("int").IsRequired();
            Property(x => x.Creator).HasColumnName(@"Creator").HasColumnType("int").IsRequired();
            Property(x => x.CreatedOn).HasColumnName(@"CreatedOn").HasColumnType("datetime").IsRequired();
            Property(x => x.TableNames).HasColumnName(@"TableNames").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.DefaultTimeoutInSec).HasColumnName(@"DefaultTimeoutInSec").HasColumnType("int").IsOptional();

            HasRequired(a => a.User).WithMany(b => b.Queries).HasForeignKey(c => c.Creator).WillCascadeOnDelete(false);
            HasRequired(a => a.UsersGroep).WithMany(b => b.Queries).HasForeignKey(c => c.UserGroupId).WillCascadeOnDelete(false);
        }
    }
}
