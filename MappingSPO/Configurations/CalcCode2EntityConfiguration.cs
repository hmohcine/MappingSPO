using MappingSPO.Entities;

namespace MappingSPO
{
    public class CalcCode2EntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CalcCode2Entity>
    {
        public CalcCode2EntityConfiguration()
            : this("Project")
        {
        }

        public CalcCode2EntityConfiguration(string schema)
        {
            ToTable("tCalcCode2", schema);
            HasKey(x => x.CalcCodeId);

            Property(x => x.CalcCodeId).HasColumnName(@"CalcCodeID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.CalcCode).HasColumnName(@"CalcCode").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.CalcDisabled).HasColumnName(@"CalcDisabled").HasColumnType("bit").IsRequired();
            Property(x => x.Domain).HasColumnName(@"Domain").HasColumnType("nchar").IsRequired().IsFixedLength().HasMaxLength(1);
        }
    }
}
