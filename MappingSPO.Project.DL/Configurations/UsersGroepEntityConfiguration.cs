using MappingSPO.Project.DL.Entities;

namespace MappingSPO.Project.DL.Configurations
{
    public class UsersGroepEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<UsersGroepEntity>
    {
        public UsersGroepEntityConfiguration()
            : this("HumanResources")
        {
        }

        public UsersGroepEntityConfiguration(string schema)
        {
            ToTable("tUsersGroep", schema);
            HasKey(x => x.UserGroupId);

            Property(x => x.UserGroupId).HasColumnName(@"UserGroupID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.UserGroup).HasColumnName(@"UserGroup").HasColumnType("nvarchar").IsRequired().HasMaxLength(255);
            Property(x => x.IsAdministrator).HasColumnName(@"IsAdministrator").HasColumnType("bit").IsRequired();
            Property(x => x.IsPowerUser).HasColumnName(@"IsPowerUser").HasColumnType("bit").IsRequired();
            Property(x => x.IsSysGroup).HasColumnName(@"IsSysGroup").HasColumnType("bit").IsRequired();
            Property(x => x.IsManagement).HasColumnName(@"IsManagement").HasColumnType("bit").IsOptional();
            Property(x => x.CanChangeEmmaArticles).HasColumnName(@"CanChangeEmmaArticles").HasColumnType("bit").IsOptional();
            Property(x => x.InvoiceCreate).HasColumnName(@"InvoiceCreate").HasColumnType("bit").IsRequired();
            Property(x => x.InvoiceSearch).HasColumnName(@"InvoiceSearch").HasColumnType("bit").IsRequired();
            Property(x => x.EmployeeSearch).HasColumnName(@"EmployeeSearch").HasColumnType("bit").IsOptional();
            Property(x => x.EmployeeFinancial).HasColumnName(@"EmployeeFinancial").HasColumnType("bit").IsOptional();
            Property(x => x.EmployeeChange).HasColumnName(@"EmployeeChange").HasColumnType("bit").IsOptional();
            Property(x => x.ShowOnlyCalculatorBoundCalculations).HasColumnName(@"ShowOnlyCalculatorBoundCalculations").HasColumnType("bit").IsOptional();
            Property(x => x.ShowOnlyOmzetOffertes).HasColumnName(@"ShowOnlyOmzetOffertes").HasColumnType("bit").IsOptional();
        }
    }
}
