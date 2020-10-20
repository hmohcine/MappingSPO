using MappingSPO.Project.DL.Entities;

namespace MappingSPO.Project.DL.Configurations
{
    public class CalcTextenEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CalcTextenEntity>
    {
        public CalcTextenEntityConfiguration()
            : this("Project")
        {
        }

        public CalcTextenEntityConfiguration(string schema)
        {
            ToTable("tCalcTexten", schema);
            HasKey(x => new { x.CalcId, x.TextId });

            Property(x => x.CalcId).HasColumnName(@"CalcID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.TextId).HasColumnName(@"TextID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Location).HasColumnName(@"Location").HasColumnType("tinyint").IsRequired();
            Property(x => x.Type).HasColumnName(@"Type").HasColumnType("tinyint").IsRequired();
            Property(x => x.ReferentieIntern).HasColumnName(@"ReferentieIntern").HasColumnType("nvarchar").IsRequired().HasMaxLength(250);
            Property(x => x.RtfText).HasColumnName(@"rtfText").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.ShowOnOffer).HasColumnName(@"ShowOnOffer").HasColumnType("bit").IsRequired();
            Property(x => x.LinePosition).HasColumnName(@"LinePosition").HasColumnType("int").IsRequired();
            Property(x => x.KeepToghether).HasColumnName(@"KeepToghether").HasColumnType("bit").IsRequired();
            Property(x => x.LinkTextId).HasColumnName(@"LinkTextID").HasColumnType("bigint").IsOptional();
            Property(x => x.NormalText).HasColumnName(@"NormalText").HasColumnType("nvarchar(max)").IsOptional();

            HasRequired(a => a.Calculation).WithMany(b => b.CalcTextens).HasForeignKey(c => c.CalcId);
        }
    }
}
