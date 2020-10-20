using MappingSPO.Project.DL.Entities;

namespace MappingSPO.Project.DL.Configurations
{
    public class CalcTransactionPostEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CalcTransactionPostEntity>
    {
        public CalcTransactionPostEntityConfiguration()
            : this("Project")
        {
        }

        public CalcTransactionPostEntityConfiguration(string schema)
        {
            ToTable("tCalcTransactionPost", schema);
            HasKey(x => new { x.CalcId, x.TransActionNr, x.CalcDetailId });

            Property(x => x.CalcId).HasColumnName(@"CalcID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.TransActionNr).HasColumnName(@"TransActionNr").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CalcDetailId).HasColumnName(@"CalcDetailID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.WeightKp).HasColumnName(@"WeightKP").HasColumnType("float").IsOptional();
            Property(x => x.Kp).HasColumnName(@"KP").HasColumnType("float").IsOptional();
            Property(x => x.WeightVp).HasColumnName(@"WeightVP").HasColumnType("float").IsOptional();
            Property(x => x.Vp).HasColumnName(@"VP").HasColumnType("float").IsOptional();

            HasRequired(a => a.CalcDetail).WithMany(b => b.CalcTransactionPosts).HasForeignKey(c => new { c.CalcDetailId, c.CalcId });
            HasRequired(a => a.CalcTransaction).WithMany(b => b.CalcTransactionPosts).HasForeignKey(c => new { c.CalcId, c.TransActionNr }).WillCascadeOnDelete(false);
        }
    }
}
