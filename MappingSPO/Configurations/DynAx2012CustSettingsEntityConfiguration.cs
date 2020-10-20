using MappingSPO.Entities;

namespace MappingSPO
{
    public class DynAx2012CustSettingsEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<DynAx2012CustSettingsEntity>
    {
        public DynAx2012CustSettingsEntityConfiguration()
            : this("Settings")
        {
        }

        public DynAx2012CustSettingsEntityConfiguration(string schema)
        {
            ToTable("tDynAx2012CustSettings", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.CompanyId).HasColumnName(@"CompanyID").HasColumnType("int").IsRequired();
            Property(x => x.AxCodeSettlement).HasColumnName(@"AxCodeSettlement").HasColumnType("nvarchar").IsRequired().HasMaxLength(20);
            Property(x => x.AxCodeLegalEntity).HasColumnName(@"AxCodeLegalEntity").HasColumnType("nvarchar").IsRequired().HasMaxLength(20);
            Property(x => x.AxNameLegalEntity).HasColumnName(@"AxNameLegalEntity").HasColumnType("nvarchar").IsRequired().HasMaxLength(100);
            Property(x => x.LocationSalesInvoice).HasColumnName(@"LocationSalesInvoice").HasColumnType("nvarchar").IsOptional().HasMaxLength(260);
            Property(x => x.LocationSalesCreditNota).HasColumnName(@"LocationSalesCreditNota").HasColumnType("nvarchar").IsOptional().HasMaxLength(260);
            Property(x => x.ShareAtWorkOwner).HasColumnName(@"ShareAtWorkOwner").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.ShareAtWorkDepartment).HasColumnName(@"ShareAtWorkDepartment").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.MailRoomId).HasColumnName(@"MailRoomID").HasColumnType("int").IsOptional();
            Property(x => x.LastUsedVoucher).HasColumnName(@"LastUsedVoucher").HasColumnType("nvarchar").IsOptional().HasMaxLength(20);

            HasRequired(a => a.Company).WithMany(b => b.DynAx2012CustSettings).HasForeignKey(c => c.CompanyId).WillCascadeOnDelete(false);
        }
    }
}
