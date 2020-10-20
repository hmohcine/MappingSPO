using MappingSPO.Entities;

namespace MappingSPO
{
    public class CostHeaderTypeEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CostHeaderTypeEntity>
    {
        public CostHeaderTypeEntityConfiguration()
            : this("Settings")
        {
        }

        public CostHeaderTypeEntityConfiguration(string schema)
        {
            ToTable("tCostHeaderType", schema);
            HasKey(x => x.CostHeaderType_);

            Property(x => x.CostHeaderType_).HasColumnName(@"CostHeaderType").HasColumnType("nvarchar").IsRequired().HasMaxLength(10).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Description).HasColumnName(@"Description").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.MasterType).HasColumnName(@"MasterType").HasColumnType("int").IsRequired();
            Property(x => x.LabelDocumentdatum).HasColumnName(@"LabelDocumentdatum").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.DefaultKs).HasColumnName(@"DefaultKS").HasColumnType("nvarchar").IsOptional().HasMaxLength(10);
            Property(x => x.DigitsDocumentnummer).HasColumnName(@"DigitsDocumentnummer").HasColumnType("int").IsOptional();
            Property(x => x.PrefixDocumentnummer).HasColumnName(@"PrefixDocumentnummer").HasColumnType("nvarchar").IsOptional().HasMaxLength(10);
            Property(x => x.Disabled).HasColumnName(@"Disabled").HasColumnType("bit").IsOptional();
            Property(x => x.AutoSelectWerfOnCreate).HasColumnName(@"AutoSelectWerfOnCreate").HasColumnType("bit").IsRequired();
            Property(x => x.WerfOnHeader).HasColumnName(@"WerfOnHeader").HasColumnType("bit").IsRequired();
            Property(x => x.LabelReferentie).HasColumnName(@"LabelReferentie").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.LabelReferentieIntern).HasColumnName(@"LabelReferentieIntern").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.GoedKeurenBijVerwerken).HasColumnName(@"GoedKeurenBijVerwerken").HasColumnType("bit").IsOptional();
            Property(x => x.VerwerkenBijBewaren).HasColumnName(@"VerwerkenBijBewaren").HasColumnType("bit").IsOptional();
            Property(x => x.WerfLijstAutoAdd).HasColumnName(@"WerfLijstAutoAdd").HasColumnType("bit").IsOptional();
            Property(x => x.WerfLijstSaldoOvernemen).HasColumnName(@"WerfLijstSaldoOvernemen").HasColumnType("bit").IsOptional();
            Property(x => x.UseExtendedEmployeeShop).HasColumnName(@"UseExtendedEmployeeShop").HasColumnType("bit").IsOptional();
            Property(x => x.ExtendedEmployeeNumber).HasColumnName(@"ExtendedEmployeeNumber").HasColumnType("int").IsOptional();

            HasOptional(a => a.Ks).WithMany(b => b.CostHeaderTypes).HasForeignKey(c => c.DefaultKs).WillCascadeOnDelete(false);
        }
    }
}
