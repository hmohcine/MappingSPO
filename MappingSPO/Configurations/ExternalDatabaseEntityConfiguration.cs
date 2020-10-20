using MappingSPO.Entities;

namespace MappingSPO
{
    public class ExternalDatabaseEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<ExternalDatabaseEntity>
    {
        public ExternalDatabaseEntityConfiguration()
            : this("Settings")
        {
        }

        public ExternalDatabaseEntityConfiguration(string schema)
        {
            ToTable("tExternalDatabase", schema);
            HasKey(x => x.ExternalDbid);

            Property(x => x.ExternalDbid).HasColumnName(@"ExternalDBID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ExternalDbName).HasColumnName(@"ExternalDBName").HasColumnType("nvarchar").IsRequired().HasMaxLength(128);
            Property(x => x.StartLastSync).HasColumnName(@"StartLastSync").HasColumnType("datetime").IsOptional();
            Property(x => x.EndLastSync).HasColumnName(@"EndLastSync").HasColumnType("datetime").IsOptional();
            Property(x => x.SupplierId).HasColumnName(@"SupplierID").HasColumnType("bigint").IsRequired();
        }
    }
}
