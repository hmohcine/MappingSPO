using MappingSPO.Entities;

namespace MappingSPO
{
    public class ReportEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<ReportEntity>
    {
        public ReportEntityConfiguration()
            : this("Documents")
        {
        }

        public ReportEntityConfiguration(string schema)
        {
            ToTable("tReports", schema);
            HasKey(x => x.ReportId);

            Property(x => x.ReportId).HasColumnName(@"ReportID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.ReportName).HasColumnName(@"ReportName").HasColumnType("nvarchar").IsRequired().HasMaxLength(150);
            Property(x => x.ReportDescription).HasColumnName(@"ReportDescription").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.ReportDomain).HasColumnName(@"ReportDomain").HasColumnType("int").IsRequired();
            Property(x => x.ReportType).HasColumnName(@"ReportType").HasColumnType("int").IsRequired();
            Property(x => x.IsReportTaxIncl).HasColumnName(@"IsReportTaxIncl").HasColumnType("bit").IsRequired();
            Property(x => x.FileSubDirectory).HasColumnName(@"FileSubDirectory").HasColumnType("nvarchar(max)").IsRequired();
            Property(x => x.FileName).HasColumnName(@"FileName").HasColumnType("nvarchar").IsRequired().HasMaxLength(255);
            Property(x => x.ShowAsStandardReport).HasColumnName(@"ShowAsStandardReport").HasColumnType("bit").IsRequired();
            Property(x => x.Disabled).HasColumnName(@"Disabled").HasColumnType("bit").IsRequired();
            Property(x => x.LanguageCode).HasColumnName(@"LanguageCode").HasColumnType("nchar").IsOptional().IsFixedLength().HasMaxLength(4);
            Property(x => x.CompanyId).HasColumnName(@"CompanyID").HasColumnType("int").IsOptional();
            Property(x => x.DesignerName).HasColumnName(@"DesignerName").HasColumnType("nvarchar").IsRequired().HasMaxLength(100);
            Property(x => x.DesignerId).HasColumnName(@"DesignerID").HasColumnType("bigint").IsRequired();
            Property(x => x.DesignerNotes).HasColumnName(@"DesignerNotes").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.DateCreated).HasColumnName(@"DateCreated").HasColumnType("datetime").IsRequired();
            Property(x => x.DateLastModified).HasColumnName(@"DateLastModified").HasColumnType("datetime").IsRequired();
            Property(x => x.SearchCode1).HasColumnName(@"SearchCode1").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.SearchCode2).HasColumnName(@"SearchCode2").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.SearchCode3).HasColumnName(@"SearchCode3").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.SearchCode4).HasColumnName(@"SearchCode4").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.PriorityOrder).HasColumnName(@"PriorityOrder").HasColumnType("int").IsOptional();
            Property(x => x.Printer).HasColumnName(@"Printer").HasColumnType("nvarchar").IsOptional().HasMaxLength(250);
            Property(x => x.DefaultReportId).HasColumnName(@"DefaultReportID").HasColumnType("int").IsOptional();
            Property(x => x.VersionMajor).HasColumnName(@"Version_Major").HasColumnType("int").IsOptional();
            Property(x => x.VersionMinor).HasColumnName(@"Version_Minor").HasColumnType("int").IsOptional();
            Property(x => x.VersionBuild).HasColumnName(@"Version_Build").HasColumnType("int").IsOptional();

            HasOptional(a => a.Company).WithMany(b => b.Reports).HasForeignKey(c => c.CompanyId).WillCascadeOnDelete(false);
            HasOptional(a => a.Language).WithMany(b => b.Reports).HasForeignKey(c => c.LanguageCode).WillCascadeOnDelete(false);
        }
    }
}
