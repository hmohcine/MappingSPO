using MappingSPO.Entities;

namespace MappingSPO
{
    public class ActiviteitenEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<ActiviteitenEntity>
    {
        public ActiviteitenEntityConfiguration()
            : this("Settings")
        {
        }

        public ActiviteitenEntityConfiguration(string schema)
        {
            ToTable("tActiviteiten", schema);
            HasKey(x => x.ActiviteitId);

            Property(x => x.ActiviteitId).HasColumnName(@"ActiviteitID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Description).HasColumnName(@"Description").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.ExternalCode).HasColumnName(@"ExternalCode").HasColumnType("nvarchar").IsOptional().HasMaxLength(75);
            Property(x => x.ActGroupId).HasColumnName(@"ActGroupID").HasColumnType("bigint").IsOptional();
            Property(x => x.Code).HasColumnName(@"Code").HasColumnType("nvarchar").IsOptional().HasMaxLength(15);
            Property(x => x.ShowAsMode).HasColumnName(@"ShowASMode").HasColumnType("int").IsRequired();
            Property(x => x.ShowAs).HasColumnName(@"ShowAs").HasColumnType("nvarchar").IsOptional().HasMaxLength(120);
            Property(x => x.Notas).HasColumnName(@"Notas").HasColumnType("nvarchar").IsOptional().HasMaxLength(4000);
            Property(x => x.WerfId).HasColumnName(@"WerfID").HasColumnType("bigint").IsOptional();
            Property(x => x.GpsRef).HasColumnName(@"GPSRef").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.ActiviteitEc).HasColumnName(@"ActiviteitEC").HasColumnType("nvarchar").IsOptional().HasMaxLength(10);
            Property(x => x.CalcId).HasColumnName(@"CalcID").HasColumnType("bigint").IsOptional();
            Property(x => x.CalcDetailId).HasColumnName(@"CalcDetailID").HasColumnType("bigint").IsOptional();
            Property(x => x.AutoAddToWerfMode).HasColumnName(@"AutoAddToWerfMode").HasColumnType("int").IsRequired();
            Property(x => x.DefOpmetingsDefinitionId).HasColumnName(@"DefOpmetingsDefinitionId").HasColumnType("int").IsOptional();

            HasOptional(a => a.ActiviteitGroup).WithMany(b => b.Activiteitens).HasForeignKey(c => c.ActGroupId).WillCascadeOnDelete(false);
            HasOptional(a => a.Uc).WithMany(b => b.Activiteitens).HasForeignKey(c => c.ActiviteitEc).WillCascadeOnDelete(false);
        }
    }
}
