using MappingSPO.Project.DL.Entities;

namespace MappingSPO.Project.DL.Configurations
{
    public class CalcTransIndirectPostEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CalcTransIndirectPostEntity>
    {
        public CalcTransIndirectPostEntityConfiguration()
            : this("Project")
        {
        }

        public CalcTransIndirectPostEntityConfiguration(string schema)
        {
            ToTable("tCalcTransIndirectPost", schema);
            HasKey(x => new { x.CalcId, x.TransActionNr, x.CalcDetailId });

            Property(x => x.CalcId).HasColumnName(@"CalcID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.TransActionNr).HasColumnName(@"TransActionNr").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CalcDetailId).HasColumnName(@"CalcDetailID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.TransState).HasColumnName(@"TransState").HasColumnType("int").IsOptional();

            HasRequired(a => a.CalcDetail).WithMany(b => b.CalcTransIndirectPosts).HasForeignKey(c => new { c.CalcDetailId, c.CalcId });
        }
    }
}
