using MappingSPO.Entities;

namespace MappingSPO
{
    public class InvoiceEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<InvoiceEntity>
    {
        public InvoiceEntityConfiguration()
            : this("Invoice")
        {
        }

        public InvoiceEntityConfiguration(string schema)
        {
            ToTable("tInvoice", schema);
            HasKey(x => x.InvoiceId);

            Property(x => x.InvoiceId).HasColumnName(@"InvoiceID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.BoekPeriodeCompanyId).HasColumnName(@"BoekPeriodeCompanyID").HasColumnType("int").IsOptional();
            Property(x => x.BoekPeriode).HasColumnName(@"BoekPeriode").HasColumnType("int").IsOptional();
            Property(x => x.InvoiceState).HasColumnName(@"InvoiceState").HasColumnType("int").IsRequired();
            Property(x => x.InvoiceType).HasColumnName(@"InvoiceType").HasColumnType("int").IsOptional();
            Property(x => x.InvoiceNrTxt).HasColumnName(@"InvoiceNrTxt").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.InvoiceDate).HasColumnName(@"InvoiceDate").HasColumnType("datetime").IsOptional();
            Property(x => x.PayConditionId).HasColumnName(@"PayConditionID").HasColumnType("nvarchar").IsOptional().HasMaxLength(10);
            Property(x => x.VervalDate).HasColumnName(@"VervalDate").HasColumnType("datetime").IsOptional();
            Property(x => x.NotesExternal).HasColumnName(@"NotesExternal").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.NotesInternal).HasColumnName(@"NotesInternal").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.CreateDate).HasColumnName(@"CreateDate").HasColumnType("datetime").IsOptional();
            Property(x => x.CreatedBy).HasColumnName(@"CreatedBy").HasColumnType("int").IsRequired();
            Property(x => x.DigitsUnit).HasColumnName(@"DigitsUnit").HasColumnType("int").IsOptional();
            Property(x => x.DigitsTotal).HasColumnName(@"DigitsTotal").HasColumnType("int").IsOptional();
            Property(x => x.InvoiceNr).HasColumnName(@"InvoiceNR").HasColumnType("bigint").IsOptional();
            Property(x => x.InvoiceAdressId).HasColumnName(@"InvoiceAdressID").HasColumnType("bigint").IsOptional();
            Property(x => x.ContactId).HasColumnName(@"ContactID").HasColumnType("int").IsOptional();
            Property(x => x.RelationId).HasColumnName(@"RelationID").HasColumnType("bigint").IsOptional();
            Property(x => x.WerfId).HasColumnName(@"WerfID").HasColumnType("bigint").IsOptional();
            Property(x => x.LastChangedDate).HasColumnName(@"LastChangedDate").HasColumnType("datetime").IsOptional();
            Property(x => x.LastChangedBy).HasColumnName(@"LastChangedBy").HasColumnType("int").IsRequired();
            Property(x => x.CompanyId).HasColumnName(@"CompanyID").HasColumnType("int").IsOptional();
            Property(x => x.TvpExcl).HasColumnName(@"TVPExcl").HasColumnType("decimal").IsRequired().HasPrecision(20,8);
            Property(x => x.VatAmount).HasColumnName(@"VATAmount").HasColumnType("decimal").IsRequired().HasPrecision(20,8);
            Property(x => x.TvpIncl).HasColumnName(@"TVPIncl").HasColumnType("decimal").IsRequired().HasPrecision(20,8);
            Property(x => x.DefaultBtwRegime).HasColumnName(@"DefaultBTWRegime").HasColumnType("int").IsOptional();
            Property(x => x.DefaultVatCode).HasColumnName(@"DefaultVatCode").HasColumnType("int").IsOptional();
            Property(x => x.InvoiceSoort).HasColumnName(@"InvoiceSoort").HasColumnType("char").IsOptional().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.NotesExternal2).HasColumnName(@"NotesExternal2").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.ReferentieIntern).HasColumnName(@"ReferentieIntern").HasColumnType("nvarchar").IsOptional().HasMaxLength(200);
            Property(x => x.DeliveryDate).HasColumnName(@"DeliveryDate").HasColumnType("date").IsOptional();
            Property(x => x.OgmNumber).HasColumnName(@"OGMNumber").HasColumnType("nvarchar").IsOptional().HasMaxLength(12);
            Property(x => x.OgmNumberTxt).HasColumnName(@"OGMNumberTxt").HasColumnType("nvarchar").IsOptional().HasMaxLength(30);
            Property(x => x.DefaultCashDiscountId).HasColumnName(@"DefaultCashDiscountID").HasColumnType("int").IsOptional();
            Property(x => x.DefaultCashDiscountpct).HasColumnName(@"DefaultCashDiscountpct").HasColumnType("float").IsOptional();
            Property(x => x.DefaultCashDiscountDays).HasColumnName(@"DefaultCashDiscountDays").HasColumnType("int").IsOptional();
            Property(x => x.CashDiscount).HasColumnName(@"CashDiscount").HasColumnType("decimal").IsRequired().HasPrecision(20,8);
            Property(x => x.CodaBoxId).HasColumnName(@"CodaBoxID").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.CodaboxCreateDate).HasColumnName(@"CodaboxCreateDate").HasColumnType("datetime").IsOptional();
            Property(x => x.CodaBoxState).HasColumnName(@"CodaBoxState").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.LanguageCode).HasColumnName(@"LanguageCode").HasColumnType("nchar").IsOptional().IsFixedLength().HasMaxLength(4);
            Property(x => x.TotalNumberOfPrints).HasColumnName(@"TotalNumberOfPrints").HasColumnType("int").IsOptional();
            Property(x => x.LastPrintDate).HasColumnName(@"LastPrintDate").HasColumnType("datetime").IsOptional();
            Property(x => x.ExportBkhDate).HasColumnName(@"ExportBKHDate").HasColumnType("datetime").IsOptional();
            Property(x => x.NumberBkh).HasColumnName(@"NumberBKH").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.DefaultVerkoopCatId).HasColumnName(@"DefaultVerkoopCatID").HasColumnType("bigint").IsOptional();
            Property(x => x.ActiviteitId).HasColumnName(@"ActiviteitID").HasColumnType("bigint").IsOptional();
            Property(x => x.DisplayInvoiceDate).HasColumnName(@"DisplayInvoiceDate").HasColumnType("date").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.DisplayVervalDate).HasColumnName(@"DisplayVervalDate").HasColumnType("date").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.BookDate).HasColumnName(@"BookDate").HasColumnType("datetime").IsOptional();
            Property(x => x.CodaBoxTransmissionId).HasColumnName(@"CodaBoxTransmissionID").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);

            HasOptional(a => a.BoekPeriode_BoekPeriode).WithMany(b => b.Invoices).HasForeignKey(c => new { c.BoekPeriodeCompanyId, c.BoekPeriode }).WillCascadeOnDelete(false);
            HasOptional(a => a.Company).WithMany(b => b.Invoices).HasForeignKey(c => c.CompanyId).WillCascadeOnDelete(false);
            HasOptional(a => a.Contact).WithMany(b => b.Invoices).HasForeignKey(c => c.ContactId).WillCascadeOnDelete(false);
            HasOptional(a => a.DefaultCashDiscount).WithMany(b => b.Invoices).HasForeignKey(c => c.DefaultCashDiscountId).WillCascadeOnDelete(false);
            HasOptional(a => a.Language).WithMany(b => b.Invoices).HasForeignKey(c => c.LanguageCode).WillCascadeOnDelete(false);
            HasOptional(a => a.PayCondition).WithMany(b => b.Invoices).HasForeignKey(c => c.PayConditionId).WillCascadeOnDelete(false);
            HasOptional(a => a.RelActiviteit).WithMany(b => b.Invoices).HasForeignKey(c => c.DefaultVerkoopCatId).WillCascadeOnDelete(false);
            HasOptional(a => a.Relation).WithMany(b => b.Invoices).HasForeignKey(c => c.RelationId).WillCascadeOnDelete(false);
            HasOptional(a => a.Vat).WithMany(b => b.Invoices).HasForeignKey(c => c.DefaultVatCode).WillCascadeOnDelete(false);
            HasOptional(a => a.VatRegime).WithMany(b => b.Invoices).HasForeignKey(c => c.DefaultBtwRegime).WillCascadeOnDelete(false);
            HasRequired(a => a.User_CreatedBy).WithMany(b => b.Invoices_CreatedBy).HasForeignKey(c => c.CreatedBy).WillCascadeOnDelete(false);
            HasRequired(a => a.User_LastChangedBy).WithMany(b => b.Invoices_LastChangedBy).HasForeignKey(c => c.LastChangedBy).WillCascadeOnDelete(false);
        }
    }
}
