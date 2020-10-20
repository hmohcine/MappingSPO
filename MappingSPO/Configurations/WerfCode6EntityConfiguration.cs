using MappingSPO.Entities;

namespace MappingSPO
{
    public class WerfCode6EntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<WerfCode6Entity>
    {
        public WerfCode6EntityConfiguration()
            : this("Project")
        {
        }

        public WerfCode6EntityConfiguration(string schema)
        {
            ToTable("tWerfCode6", schema);
            HasKey(x => x.CodeId);

            Property(x => x.CodeId).HasColumnName(@"CodeID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Code).HasColumnName(@"Code").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Disabled).HasColumnName(@"Disabled").HasColumnType("bit").IsOptional();
            Property(x => x.Domain).HasColumnName(@"Domain").HasColumnType("nchar").IsRequired().IsFixedLength().HasMaxLength(1);
        }
    }
}
