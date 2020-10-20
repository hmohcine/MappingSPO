using MappingSPO.Project.DL.Entities;

namespace MappingSPO.Project.DL.Configurations
{
    public class CalcCode6EntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CalcCode6Entity>
    {
        public CalcCode6EntityConfiguration()
            : this("Project")
        {
        }

        public CalcCode6EntityConfiguration(string schema)
        {
            ToTable("tCalcCode6", schema);
            HasKey(x => x.CalcCodeId);

            Property(x => x.CalcCodeId).HasColumnName(@"CalcCodeID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.CalcCode).HasColumnName(@"CalcCode").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.CalcDisabled).HasColumnName(@"CalcDisabled").HasColumnType("bit").IsRequired();
            Property(x => x.Domain).HasColumnName(@"Domain").HasColumnType("nchar").IsRequired().IsFixedLength().HasMaxLength(1);
        }
    }
}
