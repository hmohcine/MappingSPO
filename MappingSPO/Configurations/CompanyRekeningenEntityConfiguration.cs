using MappingSPO.Entities;

namespace MappingSPO
{
    public class CompanyRekeningenEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CompanyRekeningenEntity>
    {
        public CompanyRekeningenEntityConfiguration()
            : this("Relations")
        {
        }

        public CompanyRekeningenEntityConfiguration(string schema)
        {
            ToTable("tCompanyRekeningen", schema);
            HasKey(x => new { x.CompanyId, x.RekeningId });

            Property(x => x.CompanyId).HasColumnName(@"CompanyID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.RekeningId).HasColumnName(@"RekeningID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Lineorder).HasColumnName(@"Lineorder").HasColumnType("int").IsOptional();

            HasRequired(a => a.Company).WithMany(b => b.CompanyRekeningens).HasForeignKey(c => c.CompanyId);
            HasRequired(a => a.RekeningNr).WithMany(b => b.CompanyRekeningens).HasForeignKey(c => c.RekeningId).WillCascadeOnDelete(false);
        }
    }
}
