using MappingSPO.Project.DL.Entities;

namespace MappingSPO.Project.DL.Configurations
{
    public class WShareAtWorkWerfInfoEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<WShareAtWorkWerfInfoEntity>
    {
        public WShareAtWorkWerfInfoEntityConfiguration()
            : this("dbo")
        {
        }

        public WShareAtWorkWerfInfoEntityConfiguration(string schema)
        {
            ToTable("vwShareAtWorkWerfInfo", schema);
            HasKey(x => new { x.WerfId, x.WerfState, x.WerfName });

            Property(x => x.WerfId).HasColumnName(@"WerfID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.WerfState).HasColumnName(@"WerfState").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.FullWerfNumber).HasColumnName(@"FullWerfNumber").HasColumnType("nvarchar").IsOptional().HasMaxLength(39);
            Property(x => x.DefaultCompany).HasColumnName(@"DefaultCompany").HasColumnType("nvarchar").IsOptional().HasMaxLength(120);
            Property(x => x.Code1).HasColumnName(@"Code1").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.WerfName).HasColumnName(@"WerfName").HasColumnType("nvarchar").IsRequired().HasMaxLength(200).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ProjectLeider).HasColumnName(@"ProjectLeider").HasColumnType("nvarchar").IsOptional().HasMaxLength(201);
            Property(x => x.StartDate).HasColumnName(@"StartDate").HasColumnType("datetime").IsOptional();
            Property(x => x.EndDate).HasColumnName(@"EndDate").HasColumnType("datetime").IsOptional();
            Property(x => x.CheckInAtWorkYn).HasColumnName(@"CheckInAtWorkYn").HasColumnType("bit").IsOptional();
            Property(x => x.ExtNumber).HasColumnName(@"ExtNumber").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.WerfAdres).HasColumnName(@"WerfAdres").HasColumnType("nvarchar").IsOptional().HasMaxLength(120);
            Property(x => x.WerfAdresZip).HasColumnName(@"WerfAdresZip").HasColumnType("nvarchar").IsOptional().HasMaxLength(15);
            Property(x => x.WerfAdresCountry).HasColumnName(@"WerfAdresCountry").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.WerfAdresCity).HasColumnName(@"WerfAdresCity").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.CompanyOwner).HasColumnName(@"CompanyOwner").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.CompanyDepartment).HasColumnName(@"CompanyDepartment").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.KlantAdresName).HasColumnName(@"KlantAdresName").HasColumnType("nvarchar(max)").IsOptional();
        }
    }
}
