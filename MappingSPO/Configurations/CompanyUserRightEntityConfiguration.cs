using MappingSPO.Entities;

namespace MappingSPO
{
    public class CompanyUserRightEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CompanyUserRightEntity>
    {
        public CompanyUserRightEntityConfiguration()
            : this("HumanResources")
        {
        }

        public CompanyUserRightEntityConfiguration(string schema)
        {
            ToTable("tCompanyUserRights", schema);
            HasKey(x => new { x.CompanyId, x.UserId });

            Property(x => x.CompanyId).HasColumnName(@"CompanyID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.UserId).HasColumnName(@"UserID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.PayrollAdminYn).HasColumnName(@"PayrollAdminYn").HasColumnType("bit").IsRequired();

            HasRequired(a => a.Company).WithMany(b => b.CompanyUserRights).HasForeignKey(c => c.CompanyId).WillCascadeOnDelete(false);
            HasRequired(a => a.User).WithMany(b => b.CompanyUserRights).HasForeignKey(c => c.UserId).WillCascadeOnDelete(false);
        }
    }
}
