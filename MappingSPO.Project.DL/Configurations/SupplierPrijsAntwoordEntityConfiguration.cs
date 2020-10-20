using MappingSPO.Project.DL.Entities;

namespace MappingSPO.Project.DL.Configurations
{
    public class SupplierPrijsAntwoordEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SupplierPrijsAntwoordEntity>
    {
        public SupplierPrijsAntwoordEntityConfiguration()
            : this("Project")
        {
        }

        public SupplierPrijsAntwoordEntityConfiguration(string schema)
        {
            ToTable("tSupplierPrijsAntwoord", schema);
            HasKey(x => new { x.PrijsVraagId, x.SupplierId, x.RelationTypeId, x.AntwoordId });

            Property(x => x.PrijsVraagId).HasColumnName(@"PrijsVraagID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.SupplierId).HasColumnName(@"SupplierID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.RelationTypeId).HasColumnName(@"RelationTypeID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.AntwoordId).HasColumnName(@"AntwoordID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.AntwoordType).HasColumnName(@"AntwoordType").HasColumnType("int").IsRequired();
            Property(x => x.AntwoordSoortId).HasColumnName(@"AntwoordSoortID").HasColumnType("bigint").IsOptional();

            HasRequired(a => a.Calculation).WithMany(b => b.SupplierPrijsAntwoords).HasForeignKey(c => c.AntwoordId).WillCascadeOnDelete(false);
        }
    }
}
