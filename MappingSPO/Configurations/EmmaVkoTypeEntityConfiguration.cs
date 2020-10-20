using MappingSPO.Entities;

namespace MappingSPO
{
    public class EmmaVkoTypeEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<EmmaVkoTypeEntity>
    {
        public EmmaVkoTypeEntityConfiguration()
            : this("Settings")
        {
        }

        public EmmaVkoTypeEntityConfiguration(string schema)
        {
            ToTable("tEmmaVKOTypes", schema);
            HasKey(x => x.VkoType);

            Property(x => x.VkoType).HasColumnName(@"VKOType").HasColumnType("nvarchar").IsRequired().HasMaxLength(2).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Description).HasColumnName(@"Description").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.VkoMasterType).HasColumnName(@"VKOMasterType").HasColumnType("int").IsRequired();
            Property(x => x.DigitsDocumentnummer).HasColumnName(@"DigitsDocumentnummer").HasColumnType("int").IsRequired();
            Property(x => x.Disabled).HasColumnName(@"Disabled").HasColumnType("bit").IsRequired();
            Property(x => x.CreateInvoiceYn).HasColumnName(@"CreateInvoiceYn").HasColumnType("bit").IsRequired();
            Property(x => x.Code1Required).HasColumnName(@"Code1Required").HasColumnType("bit").IsRequired();
            Property(x => x.Code1ErrorRequired).HasColumnName(@"Code1ErrorRequired").HasColumnType("bit").IsRequired();
            Property(x => x.Code1Default).HasColumnName(@"Code1Default").HasColumnType("bigint").IsOptional();
            Property(x => x.Code2Required).HasColumnName(@"Code2Required").HasColumnType("bit").IsRequired();
            Property(x => x.Code2ErrorRequired).HasColumnName(@"Code2ErrorRequired").HasColumnType("bit").IsRequired();
            Property(x => x.Code2Default).HasColumnName(@"Code2Default").HasColumnType("bigint").IsOptional();
            Property(x => x.Code3Required).HasColumnName(@"Code3Required").HasColumnType("bit").IsRequired();
            Property(x => x.Code3ErrorRequired).HasColumnName(@"Code3ErrorRequired").HasColumnType("bit").IsRequired();
            Property(x => x.Code3Default).HasColumnName(@"Code3Default").HasColumnType("bigint").IsOptional();
            Property(x => x.Code4Required).HasColumnName(@"Code4Required").HasColumnType("bit").IsRequired();
            Property(x => x.Code4ErrorRequired).HasColumnName(@"Code4ErrorRequired").HasColumnType("bit").IsRequired();
            Property(x => x.Code4Default).HasColumnName(@"Code4Default").HasColumnType("bigint").IsOptional();
            Property(x => x.ClientRelationTypeId).HasColumnName(@"ClientRelationTypeID").HasColumnType("int").IsRequired();
            Property(x => x.DeliveryAdressRelationTypeId).HasColumnName(@"DeliveryAdressRelationTypeID").HasColumnType("int").IsRequired();
            Property(x => x.InvoiceAdressRelationTypeId).HasColumnName(@"InvoiceAdressRelationTypeID").HasColumnType("int").IsRequired();
            Property(x => x.DigitsUnit).HasColumnName(@"DigitsUnit").HasColumnType("int").IsRequired();
            Property(x => x.DigitsTotal).HasColumnName(@"DigitsTotal").HasColumnType("int").IsRequired();
            Property(x => x.CalculateIncl).HasColumnName(@"CalculateIncl").HasColumnType("bit").IsRequired();
            Property(x => x.DefaultVerkoopCat).HasColumnName(@"DefaultVerkoopCat").HasColumnType("bigint").IsOptional();
            Property(x => x.StockModeFromParent).HasColumnName(@"StockModeFromParent").HasColumnType("bit").IsRequired();
            Property(x => x.AutostockMode).HasColumnName(@"AutostockMode").HasColumnType("int").IsRequired();
            Property(x => x.AutoStockBResBsMode).HasColumnName(@"AutoStockBResBSMode").HasColumnType("int").IsRequired();
            Property(x => x.AutoStockMinAantalInMagazijn).HasColumnName(@"AutoStockMinAantalInMagazijn").HasColumnType("decimal").IsRequired().HasPrecision(18,6);
            Property(x => x.AutoStockMinAantalInToonzaal).HasColumnName(@"AutoStockMinAantalInToonzaal").HasColumnType("decimal").IsRequired().HasPrecision(18,6);
            Property(x => x.AutoStockMaToMode).HasColumnName(@"AutoStockMaTOMode").HasColumnType("int").IsRequired();
            Property(x => x.AutoStockMaToVolgorde).HasColumnName(@"AutoStockMaToVolgorde").HasColumnType("int").IsRequired();

            HasOptional(a => a.RelActiviteit).WithMany(b => b.EmmaVkoTypes).HasForeignKey(c => c.DefaultVerkoopCat).WillCascadeOnDelete(false);
            HasRequired(a => a.ClientRelationType).WithMany(b => b.EmmaVkoTypes_ClientRelationTypeId).HasForeignKey(c => c.ClientRelationTypeId).WillCascadeOnDelete(false);
            HasRequired(a => a.DeliveryAdressRelationType).WithMany(b => b.EmmaVkoTypes_DeliveryAdressRelationTypeId).HasForeignKey(c => c.DeliveryAdressRelationTypeId).WillCascadeOnDelete(false);
            HasRequired(a => a.InvoiceAdressRelationType).WithMany(b => b.EmmaVkoTypes_InvoiceAdressRelationTypeId).HasForeignKey(c => c.InvoiceAdressRelationTypeId).WillCascadeOnDelete(false);
        }
    }
}
