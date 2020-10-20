using MappingSPO.Entities;

namespace MappingSPO
{
    public class EmailTypeEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<EmailTypeEntity>
    {
        public EmailTypeEntityConfiguration()
            : this("Settings")
        {
        }

        public EmailTypeEntityConfiguration(string schema)
        {
            ToTable("tEmailType", schema);
            HasKey(x => x.EmailTypeId);

            Property(x => x.EmailTypeId).HasColumnName(@"EmailTypeId").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ApiKey).HasColumnName(@"ApiKey").HasColumnType("nvarchar").IsOptional().HasMaxLength(150);
            Property(x => x.FromEmail).HasColumnName(@"FromEmail").HasColumnType("nvarchar").IsRequired().HasMaxLength(255);
            Property(x => x.CcEmail).HasColumnName(@"CcEmail").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.BccEmail).HasColumnName(@"BccEmail").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
        }
    }
}
