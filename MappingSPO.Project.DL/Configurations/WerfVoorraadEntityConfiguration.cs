using MappingSPO.Project.DL.Entities;

namespace MappingSPO.Project.DL.Configurations
{
    public class WerfVoorraadEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<WerfVoorraadEntity>
    {
        public WerfVoorraadEntityConfiguration()
            : this("Project")
        {
        }

        public WerfVoorraadEntityConfiguration(string schema)
        {
            ToTable("tWerfVoorraad", schema);
            HasKey(x => x.DetailId);

            Property(x => x.DetailId).HasColumnName(@"DetailID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.WerfId).HasColumnName(@"WerfID").HasColumnType("bigint").IsRequired();
            Property(x => x.Voorraad).HasColumnName(@"Voorraad").HasColumnType("bigint").IsOptional();
            Property(x => x.FullCode).HasColumnName(@"FullCode").HasColumnType("nvarchar").IsOptional().HasMaxLength(2100);

            HasRequired(a => a.Werf).WithMany(b => b.WerfVoorraads).HasForeignKey(c => c.WerfId).WillCascadeOnDelete(false);
        }
    }
}
