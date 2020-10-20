using MappingSPO.Entities;

namespace MappingSPO
{
    public class WerfDocSearchMapUserSettingEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<WerfDocSearchMapUserSettingEntity>
    {
        public WerfDocSearchMapUserSettingEntityConfiguration()
            : this("Settings")
        {
        }

        public WerfDocSearchMapUserSettingEntityConfiguration(string schema)
        {
            ToTable("tWerfDocSearchMapUserSettings", schema);
            HasKey(x => new { x.UserId, x.MapNr, x.DocMayorType });

            Property(x => x.UserId).HasColumnName(@"UserID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.MapNr).HasColumnName(@"MapNr").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.DocMayorType).HasColumnName(@"DocMayorType").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.MapName).HasColumnName(@"MapName").HasColumnType("nvarchar").IsRequired().HasMaxLength(50);
            Property(x => x.GroupByLevel0).HasColumnName(@"GroupByLevel0").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.GroupByLevel1).HasColumnName(@"GroupByLevel1").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.GroupByLevel2).HasColumnName(@"GroupByLevel2").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.GroupByLevel3).HasColumnName(@"GroupByLevel3").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.GroupByLevel4).HasColumnName(@"GroupByLevel4").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.GroupByLevel5).HasColumnName(@"GroupByLevel5").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
        }
    }
}
