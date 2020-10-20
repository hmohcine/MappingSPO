using MappingSPO.Entities;

namespace MappingSPO
{
    public class RelActiviteitEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<RelActiviteitEntity>
    {
        public RelActiviteitEntityConfiguration()
            : this("Settings")
        {
        }

        public RelActiviteitEntityConfiguration(string schema)
        {
            ToTable("tRelActiviteit", schema);
            HasKey(x => x.ActiviteitId);

            Property(x => x.ActiviteitId).HasColumnName(@"ActiviteitID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Description).HasColumnName(@"Description").HasColumnType("nvarchar").IsOptional().HasMaxLength(150);
            Property(x => x.ActGroupId).HasColumnName(@"ActGroupID").HasColumnType("bigint").IsOptional();
            Property(x => x.Code).HasColumnName(@"Code").HasColumnType("nvarchar").IsOptional().HasMaxLength(15);
            Property(x => x.ShowAsMode).HasColumnName(@"ShowASMode").HasColumnType("int").IsRequired();
            Property(x => x.ShowAs).HasColumnName(@"ShowAs").HasColumnType("nvarchar").IsOptional().HasMaxLength(120);
            Property(x => x.Notas).HasColumnName(@"Notas").HasColumnType("nvarchar").IsOptional().HasMaxLength(4000);
            Property(x => x.DefaultCbsActiviteitId).HasColumnName(@"DefaultCBSActiviteitID").HasColumnType("bigint").IsOptional();
            Property(x => x.CatType).HasColumnName(@"CatType").HasColumnType("int").IsRequired();
            Property(x => x.Rekening).HasColumnName(@"Rekening").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.ProductGroup).HasColumnName(@"ProductGroup").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.CostCenter).HasColumnName(@"CostCenter").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);

            HasOptional(a => a.Activiteiten).WithMany(b => b.RelActiviteits).HasForeignKey(c => c.DefaultCbsActiviteitId).WillCascadeOnDelete(false);
            HasOptional(a => a.RelActiviteitGroup).WithMany(b => b.RelActiviteits).HasForeignKey(c => c.ActGroupId).WillCascadeOnDelete(false);
        }
    }
}
