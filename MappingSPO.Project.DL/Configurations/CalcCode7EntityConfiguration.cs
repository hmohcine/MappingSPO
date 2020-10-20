using MappingSPO.Project.DL.Entities;

namespace MappingSPO.Project.DL.Configurations
{
    public class CalcCode7EntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CalcCode7Entity>
    {
        public CalcCode7EntityConfiguration()
            : this("Project")
        {
        }

        public CalcCode7EntityConfiguration(string schema)
        {
            ToTable("tCalcCode7", schema);
            HasKey(x => x.CalcCodeId);

            Property(x => x.CalcCodeId).HasColumnName(@"CalcCodeID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.CalcCode).HasColumnName(@"CalcCode").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.CalcDisabled).HasColumnName(@"CalcDisabled").HasColumnType("bit").IsRequired();
            Property(x => x.Domain).HasColumnName(@"Domain").HasColumnType("nchar").IsRequired().IsFixedLength().HasMaxLength(1);
        }
    }
}
