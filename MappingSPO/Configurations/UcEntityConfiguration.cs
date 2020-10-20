using MappingSPO.Entities;

namespace MappingSPO
{
    public class UcEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<UcEntity>
    {
        public UcEntityConfiguration()
            : this("Settings")
        {
        }

        public UcEntityConfiguration(string schema)
        {
            ToTable("tUC", schema);
            HasKey(x => x.Uc_);

            Property(x => x.Uc_).HasColumnName(@"UC").HasColumnType("nvarchar").IsRequired().HasMaxLength(10).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Description).HasColumnName(@"Description").HasColumnType("nvarchar").IsOptional().HasMaxLength(30);
            Property(x => x.IsExtendedUc).HasColumnName(@"IsExtendedUC").HasColumnType("bit").IsRequired();
            Property(x => x.RangOrder).HasColumnName(@"RangOrder").HasColumnType("int").IsOptional();
            Property(x => x.UcGroupId).HasColumnName(@"UCGroupID").HasColumnType("int").IsOptional();
            Property(x => x.IsVerpakking).HasColumnName(@"IsVerpakking").HasColumnType("bit").IsOptional();
        }
    }
}
