using MappingSPO.Project.DL.Entities;

namespace MappingSPO.Project.DL.Configurations
{
    public class BibUserEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<BibUserEntity>
    {
        public BibUserEntityConfiguration()
            : this("Project")
        {
        }

        public BibUserEntityConfiguration(string schema)
        {
            ToTable("tBibUser", schema);
            HasKey(x => new { x.CalcId, x.UserId });

            Property(x => x.CalcId).HasColumnName(@"CalcID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.UserId).HasColumnName(@"UserID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);

            HasRequired(a => a.Calculation).WithMany(b => b.BibUsers).HasForeignKey(c => c.CalcId);
        }
    }
}
