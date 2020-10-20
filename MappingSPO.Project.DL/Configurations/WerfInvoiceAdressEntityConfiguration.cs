using MappingSPO.Project.DL.Entities;

namespace MappingSPO.Project.DL.Configurations
{
    public class WerfInvoiceAdressEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<WerfInvoiceAdressEntity>
    {
        public WerfInvoiceAdressEntityConfiguration()
            : this("Project")
        {
        }

        public WerfInvoiceAdressEntityConfiguration(string schema)
        {
            ToTable("tWerfInvoiceAdress", schema);
            HasKey(x => x.InvoiceAdressId);

            Property(x => x.WerfId).HasColumnName(@"WerfID").HasColumnType("bigint").IsRequired();
            Property(x => x.InvoiceAdressId).HasColumnName(@"InvoiceAdressID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.RelationId).HasColumnName(@"RelationID").HasColumnType("bigint").IsRequired();
            Property(x => x.ContactId).HasColumnName(@"ContactID").HasColumnType("int").IsOptional();
            Property(x => x.CompanyId).HasColumnName(@"CompanyID").HasColumnType("int").IsRequired();
            Property(x => x.RelationTypeId).HasColumnName(@"RelationTypeID").HasColumnType("int").IsRequired();
            Property(x => x.SchuldVorderingBody).HasColumnName(@"SchuldVorderingBody").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.PayConditionId).HasColumnName(@"PayConditionID").HasColumnType("nvarchar").IsOptional().HasMaxLength(10);
            Property(x => x.DefaultCashDiscountId).HasColumnName(@"DefaultCashDiscountID").HasColumnType("int").IsOptional();
            Property(x => x.LanguageCode).HasColumnName(@"LanguageCode").HasColumnType("nchar").IsOptional().IsFixedLength().HasMaxLength(4);
            Property(x => x.TotalNumberOfPrints).HasColumnName(@"TotalNumberOfPrints").HasColumnType("int").IsOptional();
            Property(x => x.LastPrintDate).HasColumnName(@"LastPrintDate").HasColumnType("datetime").IsOptional();
            Property(x => x.ReportId).HasColumnName(@"ReportID").HasColumnType("bigint").IsOptional();

            HasOptional(a => a.Contact).WithMany(b => b.WerfInvoiceAdresses).HasForeignKey(c => c.ContactId).WillCascadeOnDelete(false);
            HasRequired(a => a.Relation).WithMany(b => b.WerfInvoiceAdresses).HasForeignKey(c => c.RelationId).WillCascadeOnDelete(false);
            HasRequired(a => a.Werf).WithMany(b => b.WerfInvoiceAdresses).HasForeignKey(c => c.WerfId);
            HasRequired(a => a.WerfRelation).WithMany(b => b.WerfInvoiceAdresses).HasForeignKey(c => new { c.WerfId, c.RelationId, c.RelationTypeId }).WillCascadeOnDelete(false);
        }
    }
}
