using MappingSPO.Entities;

namespace MappingSPO
{
    public class WerfCode1EntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<WerfCode1Entity>
    {
        public WerfCode1EntityConfiguration()
            : this("Project")
        {
        }

        public WerfCode1EntityConfiguration(string schema)
        {
            ToTable("tWerfCode1", schema);
            HasKey(x => x.CodeId);

            Property(x => x.CodeId).HasColumnName(@"CodeID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Code).HasColumnName(@"Code").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Disabled).HasColumnName(@"Disabled").HasColumnType("bit").IsOptional();
            Property(x => x.Domain).HasColumnName(@"Domain").HasColumnType("nchar").IsRequired().IsFixedLength().HasMaxLength(1);
        }
    }
}
