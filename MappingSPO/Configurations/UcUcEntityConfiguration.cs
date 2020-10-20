using MappingSPO.Entities;

namespace MappingSPO
{
    public class UcUcEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<UcUcEntity>
    {
        public UcUcEntityConfiguration()
            : this("Settings")
        {
        }

        public UcUcEntityConfiguration(string schema)
        {
            ToTable("tUC_UC", schema);
            HasKey(x => new { x.UcParent, x.Uc });

            Property(x => x.UcParent).HasColumnName(@"UC_Parent").HasColumnType("nvarchar").IsRequired().HasMaxLength(10).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Uc).HasColumnName(@"UC").HasColumnType("nvarchar").IsRequired().HasMaxLength(10).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Factor).HasColumnName(@"Factor").HasColumnType("float").IsOptional();

            HasRequired(a => a.Uc_Uc).WithMany(b => b.UcUcs_Uc).HasForeignKey(c => c.Uc).WillCascadeOnDelete(false);
            HasRequired(a => a.Uc_UcParent).WithMany(b => b.UcUcs_UcParent).HasForeignKey(c => c.UcParent);
        }
    }
}
