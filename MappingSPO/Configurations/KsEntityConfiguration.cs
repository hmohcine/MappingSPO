using MappingSPO.Entities;

namespace MappingSPO
{
    public class KsEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<KsEntity>
    {
        public KsEntityConfiguration()
            : this("Settings")
        {
        }

        public KsEntityConfiguration(string schema)
        {
            ToTable("tKS", schema);
            HasKey(x => x.Ks_);

            Property(x => x.Ks_).HasColumnName(@"KS").HasColumnType("nvarchar").IsRequired().HasMaxLength(10).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Description).HasColumnName(@"Description").HasColumnType("nvarchar").IsOptional().HasMaxLength(30);
            Property(x => x.DefWinstPct).HasColumnName(@"DefWinstPct").HasColumnType("float").IsOptional();
            Property(x => x.Kg).HasColumnName(@"KG").HasColumnType("int").IsOptional();
            Property(x => x.BColor).HasColumnName(@"bColor").HasColumnType("int").IsOptional();
            Property(x => x.ExternalCode).HasColumnName(@"ExternalCode").HasColumnType("nvarchar").IsOptional().HasMaxLength(75);
            Property(x => x.W01Default).HasColumnName(@"W01Default").HasColumnType("float").IsOptional();
            Property(x => x.W02Default).HasColumnName(@"W02Default").HasColumnType("float").IsOptional();
            Property(x => x.W03Default).HasColumnName(@"W03Default").HasColumnType("float").IsOptional();
            Property(x => x.W04Default).HasColumnName(@"W04Default").HasColumnType("float").IsOptional();
            Property(x => x.DefaultCbsActiviteitId).HasColumnName(@"DefaultCBSActiviteitID").HasColumnType("bigint").IsOptional();

            HasOptional(a => a.Activiteiten).WithMany(b => b.Ks).HasForeignKey(c => c.DefaultCbsActiviteitId).WillCascadeOnDelete(false);
        }
    }
}
