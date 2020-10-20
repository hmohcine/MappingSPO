using MappingSPO.Project.DL.Entities;

namespace MappingSPO.Project.DL.Configurations
{
    public class CalcKEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CalcKEntity>
    {
        public CalcKEntityConfiguration()
            : this("Project")
        {
        }

        public CalcKEntityConfiguration(string schema)
        {
            ToTable("tCalcKS", schema);
            HasKey(x => new { x.CalcId, x.MayorTypeCode, x.CalcKs, x.TypeLine });

            Property(x => x.CalcId).HasColumnName(@"CalcID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.MayorTypeCode).HasColumnName(@"MayorTypeCode").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CalcKs).HasColumnName(@"CalcKS").HasColumnType("nvarchar").IsRequired().HasMaxLength(20).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.TypeLine).HasColumnName(@"TypeLine").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Tkp).HasColumnName(@"TKP").HasColumnType("float").IsOptional();
            Property(x => x.Tvp).HasColumnName(@"TVP").HasColumnType("float").IsOptional();
            Property(x => x.TWinst).HasColumnName(@"TWinst").HasColumnType("float").IsOptional();
            Property(x => x.TWinstpct).HasColumnName(@"TWinstpct").HasColumnType("float").IsOptional();
            Property(x => x.CountLines).HasColumnName(@"CountLines").HasColumnType("bigint").IsOptional();
            Property(x => x.EcAantal).HasColumnName(@"ECAantal").HasColumnType("float").IsOptional();
            Property(x => x.Ec).HasColumnName(@"EC").HasColumnType("nvarchar").IsOptional().HasMaxLength(10);
            Property(x => x.EcValid).HasColumnName(@"ECValid").HasColumnType("bit").IsOptional();
            Property(x => x.W01Pct).HasColumnName(@"W01pct").HasColumnType("float").IsOptional();
            Property(x => x.W02Pct).HasColumnName(@"W02pct").HasColumnType("float").IsOptional();
            Property(x => x.W03Pct).HasColumnName(@"W03pct").HasColumnType("float").IsOptional();
            Property(x => x.W04Pct).HasColumnName(@"W04pct").HasColumnType("float").IsOptional();
            Property(x => x.BudgetVerlaging1Pct).HasColumnName(@"BudgetVerlaging1pct").HasColumnType("float").IsOptional();
            Property(x => x.BudgetVerlaging2Pct).HasColumnName(@"BudgetVerlaging2pct").HasColumnType("float").IsOptional();
            Property(x => x.BudgetVerlaging1).HasColumnName(@"BudgetVerlaging1").HasColumnType("float").IsOptional();
            Property(x => x.BudgetVerlaging2).HasColumnName(@"BudgetVerlaging2").HasColumnType("float").IsOptional();
            Property(x => x.TvpLocked).HasColumnName(@"TVPLocked").HasColumnType("float").IsOptional();
            Property(x => x.TkpLocked).HasColumnName(@"TKPLocked").HasColumnType("float").IsOptional();
            Property(x => x.TWinstLocked).HasColumnName(@"TWinstLocked").HasColumnType("float").IsOptional();
            Property(x => x.TWinstpctLocked).HasColumnName(@"TWinstpctLocked").HasColumnType("float").IsOptional();

            HasRequired(a => a.Calculation).WithMany(b => b.CalcKs).HasForeignKey(c => c.CalcId);
        }
    }
}
