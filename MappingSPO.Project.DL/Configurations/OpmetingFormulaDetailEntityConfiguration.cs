using MappingSPO.Project.DL.Entities;

namespace MappingSPO.Project.DL.Configurations
{
    public class OpmetingFormulaDetailEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<OpmetingFormulaDetailEntity>
    {
        public OpmetingFormulaDetailEntityConfiguration()
            : this("Project")
        {
        }

        public OpmetingFormulaDetailEntityConfiguration(string schema)
        {
            ToTable("tOpmetingFormulaDetail", schema);
            HasKey(x => new { x.CalcDetailId, x.CalcId, x.Line });

            Property(x => x.CalcDetailId).HasColumnName(@"CalcDetailID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CalcId).HasColumnName(@"CalcID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Line).HasColumnName(@"Line").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.P1).HasColumnName(@"P1").HasColumnType("float").IsOptional();
            Property(x => x.P2).HasColumnName(@"P2").HasColumnType("float").IsOptional();
            Property(x => x.P3).HasColumnName(@"P3").HasColumnType("float").IsOptional();
            Property(x => x.P4).HasColumnName(@"P4").HasColumnType("float").IsOptional();
            Property(x => x.P5).HasColumnName(@"P5").HasColumnType("float").IsOptional();
            Property(x => x.P6).HasColumnName(@"P6").HasColumnType("float").IsOptional();
            Property(x => x.Code).HasColumnName(@"Code").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.Description).HasColumnName(@"Description").HasColumnType("nvarchar").IsOptional().HasMaxLength(150);
            Property(x => x.Notes).HasColumnName(@"Notes").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.LineOrder).HasColumnName(@"LineOrder").HasColumnType("int").IsRequired();
            Property(x => x.SubResult).HasColumnName(@"SubResult").HasColumnType("float").IsOptional();
            Property(x => x.PrintCode).HasColumnName(@"PrintCode").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.BimName).HasColumnName(@"BimName").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.SubResultNum1).HasColumnName(@"SubResultNum1").HasColumnType("float").IsOptional();
            Property(x => x.SubResultNum2).HasColumnName(@"SubResultNum2").HasColumnType("float").IsOptional();
            Property(x => x.SubResultNum3).HasColumnName(@"SubResultNum3").HasColumnType("float").IsOptional();
            Property(x => x.SubResultNum4).HasColumnName(@"SubResultNum4").HasColumnType("float").IsOptional();
            Property(x => x.SubResultNum5).HasColumnName(@"SubResultNum5").HasColumnType("float").IsOptional();
            Property(x => x.SubResultNum6).HasColumnName(@"SubResultNum6").HasColumnType("float").IsOptional();
            Property(x => x.SubResultNum7).HasColumnName(@"SubResultNum7").HasColumnType("float").IsOptional();
            Property(x => x.SubResultNum8).HasColumnName(@"SubResultNum8").HasColumnType("float").IsOptional();

            HasRequired(a => a.OpmetingFormula).WithMany(b => b.OpmetingFormulaDetails).HasForeignKey(c => new { c.CalcDetailId, c.CalcId });
        }
    }
}
