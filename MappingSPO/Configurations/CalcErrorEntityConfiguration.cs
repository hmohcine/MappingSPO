using MappingSPO.Entities;

namespace MappingSPO
{
    public class CalcErrorEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CalcErrorEntity>
    {
        public CalcErrorEntityConfiguration()
            : this("Settings")
        {
        }

        public CalcErrorEntityConfiguration(string schema)
        {
            ToTable("tCalcErrors", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Code).HasColumnName(@"Code").HasColumnType("nvarchar").IsRequired().HasMaxLength(50);
            Property(x => x.Description).HasColumnName(@"Description").HasColumnType("nvarchar(max)").IsRequired();
            Property(x => x.Severity).HasColumnName(@"Severity").HasColumnType("int").IsRequired();
            Property(x => x.Column).HasColumnName(@"Column").HasColumnType("nvarchar").IsRequired().HasMaxLength(50);
        }
    }
}
