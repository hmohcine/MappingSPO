using MappingSPO.Entities;

namespace MappingSPO
{
    public class CompanyUserGroepRightEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CompanyUserGroepRightEntity>
    {
        public CompanyUserGroepRightEntityConfiguration()
            : this("HumanResources")
        {
        }

        public CompanyUserGroepRightEntityConfiguration(string schema)
        {
            ToTable("tCompanyUserGroepRights", schema);
            HasKey(x => new { x.CompanyId, x.UserGroupId });

            Property(x => x.CompanyId).HasColumnName(@"CompanyID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.UserGroupId).HasColumnName(@"UserGroupID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.PayrollAdminYn).HasColumnName(@"PayrollAdminYn").HasColumnType("bit").IsRequired();

            HasRequired(a => a.Company).WithMany(b => b.CompanyUserGroepRights).HasForeignKey(c => c.CompanyId).WillCascadeOnDelete(false);
            HasRequired(a => a.UsersGroep).WithMany(b => b.CompanyUserGroepRights).HasForeignKey(c => c.UserGroupId).WillCascadeOnDelete(false);
        }
    }
}
