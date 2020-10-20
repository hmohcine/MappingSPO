using MappingSPO.Project.DL.Entities;

namespace MappingSPO.Project.DL.Configurations
{
    public class CalcTransactionPostArticleEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CalcTransactionPostArticleEntity>
    {
        public CalcTransactionPostArticleEntityConfiguration()
            : this("Project")
        {
        }

        public CalcTransactionPostArticleEntityConfiguration(string schema)
        {
            ToTable("tCalcTransactionPostArticles", schema);
            HasKey(x => new { x.CalcId, x.TransActionNr, x.CalcDetailIdPost, x.CalcDetailIdArticle });

            Property(x => x.CalcId).HasColumnName(@"CalcID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.TransActionNr).HasColumnName(@"TransActionNr").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CalcDetailIdPost).HasColumnName(@"CalcDetailIDPost").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CalcDetailIdArticle).HasColumnName(@"CalcDetailIDArticle").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);

            HasRequired(a => a.CalcDetail).WithMany(b => b.CalcTransactionPostArticles).HasForeignKey(c => new { c.CalcDetailIdArticle, c.CalcId });
            HasRequired(a => a.CalcTransactionPost).WithMany(b => b.CalcTransactionPostArticles).HasForeignKey(c => new { c.CalcId, c.TransActionNr, c.CalcDetailIdPost }).WillCascadeOnDelete(false);
        }
    }
}
