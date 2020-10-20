using MappingSPO.Entities;

namespace MappingSPO
{
    public class BoekPeriodeEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<BoekPeriodeEntity>
    {
        public BoekPeriodeEntityConfiguration()
            : this("Invoice")
        {
        }

        public BoekPeriodeEntityConfiguration(string schema)
        {
            ToTable("tBoekPeriodes", schema);
            HasKey(x => new { x.CompanyId, x.BoekPeriode_ });

            Property(x => x.CompanyId).HasColumnName(@"CompanyID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.BoekPeriode_).HasColumnName(@"BoekPeriode").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Prefixperiode).HasColumnName(@"Prefixperiode").HasColumnType("nvarchar").IsOptional().HasMaxLength(20);
            Property(x => x.PrefixperiodeCn).HasColumnName(@"PrefixperiodeCN").HasColumnType("nvarchar").IsOptional().HasMaxLength(20);
            Property(x => x.PeriodeStart).HasColumnName(@"PeriodeStart").HasColumnType("datetime").IsOptional();
            Property(x => x.PeriodeEnd).HasColumnName(@"PeriodeEnd").HasColumnType("datetime").IsOptional();
            Property(x => x.CnAfzonderlijk).HasColumnName(@"CNAfzonderlijk").HasColumnType("bit").IsOptional();
            Property(x => x.StartNr).HasColumnName(@"StartNr").HasColumnType("bigint").IsOptional();
            Property(x => x.StartNrCn).HasColumnName(@"StartNrCN").HasColumnType("bigint").IsOptional();
            Property(x => x.FormatNr).HasColumnName(@"FormatNr").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.Activated).HasColumnName(@"Activated").HasColumnType("bit").IsOptional();
            Property(x => x.Locked).HasColumnName(@"Locked").HasColumnType("bit").IsOptional();
            Property(x => x.NextNr).HasColumnName(@"NextNr").HasColumnType("bigint").IsOptional();
            Property(x => x.NextNrCn).HasColumnName(@"NextNrCN").HasColumnType("bigint").IsOptional();
            Property(x => x.LastChangedBy).HasColumnName(@"LastChangedBy").HasColumnType("int").IsRequired();
            Property(x => x.LastChangedDate).HasColumnName(@"LastChangedDate").HasColumnType("datetime").IsRequired();
            Property(x => x.DagBoek).HasColumnName(@"DagBoek").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);

            HasRequired(a => a.Company).WithMany(b => b.BoekPeriodes).HasForeignKey(c => c.CompanyId);
            HasRequired(a => a.User).WithMany(b => b.BoekPeriodes).HasForeignKey(c => c.LastChangedBy).WillCascadeOnDelete(false);
        }
    }
}
