using MappingSPO.Project.DL.Entities;

namespace MappingSPO.Project.DL.Configurations
{
    public class CalcTransactionEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CalcTransactionEntity>
    {
        public CalcTransactionEntityConfiguration()
            : this("Project")
        {
        }

        public CalcTransactionEntityConfiguration(string schema)
        {
            ToTable("tCalcTransaction", schema);
            HasKey(x => new { x.CalcId, x.TransActionNr });

            Property(x => x.CalcId).HasColumnName(@"CalcID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.TransActionNr).HasColumnName(@"TransActionNr").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.TransActionType).HasColumnName(@"TransActionType").HasColumnType("int").IsOptional();
            Property(x => x.Description).HasColumnName(@"Description").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.Notes).HasColumnName(@"Notes").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.LockArtikel).HasColumnName(@"LockArtikel").HasColumnType("bit").IsOptional();
            Property(x => x.OrigineelObject).HasColumnName(@"OrigineelObject").HasColumnType("varchar(max)").IsOptional().IsUnicode(false);
            Property(x => x.VerdeelWijze).HasColumnName(@"VerdeelWijze").HasColumnType("int").IsOptional();
            Property(x => x.ArtikelChilds).HasColumnName(@"ArtikelChilds").HasColumnType("bigint").IsOptional();
            Property(x => x.PostParents).HasColumnName(@"PostParents").HasColumnType("bigint").IsOptional();
            Property(x => x.State).HasColumnName(@"State").HasColumnType("int").IsOptional();
            Property(x => x.TWeightKp).HasColumnName(@"TWeightKP").HasColumnType("float").IsOptional();
            Property(x => x.Tkp).HasColumnName(@"TKP").HasColumnType("float").IsOptional();
            Property(x => x.TWeightVp).HasColumnName(@"TWeightVP").HasColumnType("float").IsOptional();
            Property(x => x.Tvp).HasColumnName(@"TVP").HasColumnType("float").IsOptional();
            Property(x => x.TransDate).HasColumnName(@"TransDate").HasColumnType("datetime").IsOptional();
            Property(x => x.SelectAllPosts).HasColumnName(@"SelectAllPosts").HasColumnType("int").IsOptional();
            Property(x => x.ShowParts).HasColumnName(@"ShowParts").HasColumnType("nvarchar").IsOptional().HasMaxLength(10);

            HasRequired(a => a.Calculation).WithMany(b => b.CalcTransactions).HasForeignKey(c => c.CalcId);
        }
    }
}
