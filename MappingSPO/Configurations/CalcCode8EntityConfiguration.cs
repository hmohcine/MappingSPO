using MappingSPO.Entities;

namespace MappingSPO
{
    public class CalcCode8EntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CalcCode8Entity>
    {
        public CalcCode8EntityConfiguration()
            : this("Project")
        {
        }

        public CalcCode8EntityConfiguration(string schema)
        {
            ToTable("tCalcCode8", schema);
            HasKey(x => x.CalcCodeId);

            Property(x => x.CalcCodeId).HasColumnName(@"CalcCodeID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.CalcCode).HasColumnName(@"CalcCode").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.CalcDisabled).HasColumnName(@"CalcDisabled").HasColumnType("bit").IsRequired();
            Property(x => x.Domain).HasColumnName(@"Domain").HasColumnType("nchar").IsRequired().IsFixedLength().HasMaxLength(1);
        }
    }
}
