using MappingSPO.Entities;

namespace MappingSPO
{
    public class WinbookEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<WinbookEntity>
    {
        public WinbookEntityConfiguration()
            : this("Settings")
        {
        }

        public WinbookEntityConfiguration(string schema)
        {
            ToTable("tWinbooks", schema);
            HasKey(x => x.Wbid);

            Property(x => x.Wbid).HasColumnName(@"WBID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.SourceConnectionString).HasColumnName(@"SourceConnectionString").HasColumnType("nvarchar").IsRequired().HasMaxLength(400);
            Property(x => x.TargetConnectionString).HasColumnName(@"TargetConnectionString").HasColumnType("nvarchar").IsRequired().HasMaxLength(400);
            Property(x => x.TargetDocumentLocation).HasColumnName(@"TargetDocumentLocation").HasColumnType("nvarchar").IsRequired().HasMaxLength(400);
            Property(x => x.TempLocation).HasColumnName(@"TempLocation").HasColumnType("nvarchar").IsRequired().HasMaxLength(400);
            Property(x => x.PdfToolLocation).HasColumnName(@"PDFToolLocation").HasColumnType("nvarchar").IsRequired().HasMaxLength(400);
            Property(x => x.RecognitionQualityFieldName).HasColumnName(@"RecognitionQualityFieldName").HasColumnType("nvarchar").IsRequired().HasMaxLength(400);
            Property(x => x.RecognizedtextFieldName).HasColumnName(@"RecognizedtextFieldName").HasColumnType("nvarchar").IsRequired().HasMaxLength(400);
            Property(x => x.CommandTimeoutTimeInSeconds).HasColumnName(@"CommandTimeoutTimeInSeconds").HasColumnType("int").IsRequired();
        }
    }
}
