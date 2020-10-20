using MappingSPO.Entities;

namespace MappingSPO
{
    public class ExternalInvoiceUserSettingEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<ExternalInvoiceUserSettingEntity>
    {
        public ExternalInvoiceUserSettingEntityConfiguration()
            : this("Settings")
        {
        }

        public ExternalInvoiceUserSettingEntityConfiguration(string schema)
        {
            ToTable("tExternalInvoiceUserSetting", schema);
            HasKey(x => x.UserId);

            Property(x => x.UserId).HasColumnName(@"UserID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.GroupByLevel0).HasColumnName(@"GroupByLevel0").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.GroupByLevel1).HasColumnName(@"GroupByLevel1").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.GroupByLevel2).HasColumnName(@"GroupByLevel2").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.GroupByLevel3).HasColumnName(@"GroupByLevel3").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.OpenWithLineState).HasColumnName(@"OpenWithLineState").HasColumnType("int").IsOptional();
        }
    }
}
