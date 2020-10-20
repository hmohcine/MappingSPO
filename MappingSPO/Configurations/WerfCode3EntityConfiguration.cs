using MappingSPO.Entities;

namespace MappingSPO
{
    public class WerfCode3EntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<WerfCode3Entity>
    {
        public WerfCode3EntityConfiguration()
            : this("Project")
        {
        }

        public WerfCode3EntityConfiguration(string schema)
        {
            ToTable("tWerfCode3", schema);
            HasKey(x => x.CodeId);

            Property(x => x.CodeId).HasColumnName(@"CodeID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Code).HasColumnName(@"Code").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Disabled).HasColumnName(@"Disabled").HasColumnType("bit").IsOptional();
            Property(x => x.Domain).HasColumnName(@"Domain").HasColumnType("nchar").IsRequired().IsFixedLength().HasMaxLength(1);
        }
    }
}
