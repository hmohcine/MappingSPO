using MappingSPO.Project.DL.Entities;

namespace MappingSPO.Project.DL.Configurations
{
    public class OpmetingFormulaEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<OpmetingFormulaEntity>
    {
        public OpmetingFormulaEntityConfiguration()
            : this("Project")
        {
        }

        public OpmetingFormulaEntityConfiguration(string schema)
        {
            ToTable("tOpmetingFormula", schema);
            HasKey(x => new { x.CalcDetailId, x.CalcId });

            Property(x => x.CalcDetailId).HasColumnName(@"CalcDetailID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CalcId).HasColumnName(@"CalcID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.OpmetingDefinition).HasColumnName(@"OpmetingDefinition").HasColumnType("nvarchar").IsRequired().HasMaxLength(100);
            Property(x => x.ActiveColumns).HasColumnName(@"ActiveColumns").HasColumnType("smallint").IsRequired();
            Property(x => x.Formula).HasColumnName(@"Formula").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.Label1).HasColumnName(@"Label1").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.Label2).HasColumnName(@"Label2").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.Label3).HasColumnName(@"Label3").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.Label4).HasColumnName(@"Label4").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.Label5).HasColumnName(@"Label5").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.Label6).HasColumnName(@"Label6").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.ResultFormula).HasColumnName(@"ResultFormula").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.Label1Weight).HasColumnName(@"Label1Weight").HasColumnType("real").IsOptional();
            Property(x => x.Label2Weight).HasColumnName(@"Label2Weight").HasColumnType("real").IsOptional();
            Property(x => x.Label3Weight).HasColumnName(@"Label3Weight").HasColumnType("real").IsOptional();
            Property(x => x.Label4Weight).HasColumnName(@"Label4Weight").HasColumnType("real").IsOptional();
            Property(x => x.Label5Weight).HasColumnName(@"Label5Weight").HasColumnType("real").IsOptional();
            Property(x => x.Label6Weight).HasColumnName(@"Label6Weight").HasColumnType("real").IsOptional();
            Property(x => x.CodeWeight).HasColumnName(@"CodeWeight").HasColumnType("real").IsOptional();
            Property(x => x.DescriptionWeight).HasColumnName(@"DescriptionWeight").HasColumnType("real").IsOptional();
            Property(x => x.NotesWeight).HasColumnName(@"NotesWeight").HasColumnType("real").IsOptional();
            Property(x => x.ExtendedMode).HasColumnName(@"ExtendedMode").HasColumnType("bit").IsOptional();
            Property(x => x.ResultRoundDigits).HasColumnName(@"ResultRoundDigits").HasColumnType("int").IsOptional();
            Property(x => x.Name).HasColumnName(@"Name").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.ResultWeight).HasColumnName(@"ResultWeight").HasColumnType("real").IsOptional();
            Property(x => x.ColumnOrder).HasColumnName(@"ColumnOrder").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.Result).HasColumnName(@"Result").HasColumnType("float").IsOptional();
            Property(x => x.Activated).HasColumnName(@"Activated").HasColumnType("bit").IsOptional();
            Property(x => x.MaatType1).HasColumnName(@"MaatType1").HasColumnType("int").IsOptional();
            Property(x => x.MaatType2).HasColumnName(@"MaatType2").HasColumnType("int").IsOptional();
            Property(x => x.MaatType3).HasColumnName(@"MaatType3").HasColumnType("int").IsOptional();
            Property(x => x.MaatType4).HasColumnName(@"MaatType4").HasColumnType("int").IsOptional();
            Property(x => x.MaatType5).HasColumnName(@"MaatType5").HasColumnType("int").IsOptional();
            Property(x => x.MaatType6).HasColumnName(@"MaatType6").HasColumnType("int").IsOptional();
            Property(x => x.Uc1).HasColumnName(@"UC1").HasColumnType("nvarchar").IsOptional().HasMaxLength(10);
            Property(x => x.Uc2).HasColumnName(@"UC2").HasColumnType("nvarchar").IsOptional().HasMaxLength(10);
            Property(x => x.Uc3).HasColumnName(@"UC3").HasColumnType("nvarchar").IsOptional().HasMaxLength(10);
            Property(x => x.Uc4).HasColumnName(@"UC4").HasColumnType("nvarchar").IsOptional().HasMaxLength(10);
            Property(x => x.Uc5).HasColumnName(@"UC5").HasColumnType("nvarchar").IsOptional().HasMaxLength(10);
            Property(x => x.Uc6).HasColumnName(@"UC6").HasColumnType("nvarchar").IsOptional().HasMaxLength(10);
            Property(x => x.PrintCodeWeight).HasColumnName(@"PrintCodeWeight").HasColumnType("real").IsOptional();
            Property(x => x.ResultFormulaNum1).HasColumnName(@"ResultFormulaNum1").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.ResultFormulaNum2).HasColumnName(@"ResultFormulaNum2").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.ResultFormulaNum3).HasColumnName(@"ResultFormulaNum3").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.ResultFormulaNum4).HasColumnName(@"ResultFormulaNum4").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.ResultFormulaNum5).HasColumnName(@"ResultFormulaNum5").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.ResultFormulaNum6).HasColumnName(@"ResultFormulaNum6").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.ResultFormulaNum7).HasColumnName(@"ResultFormulaNum7").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.ResultFormulaNum8).HasColumnName(@"ResultFormulaNum8").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.FormulaNum1).HasColumnName(@"FormulaNum1").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.FormulaNum2).HasColumnName(@"FormulaNum2").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.FormulaNum3).HasColumnName(@"FormulaNum3").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.FormulaNum4).HasColumnName(@"FormulaNum4").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.FormulaNum5).HasColumnName(@"FormulaNum5").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.FormulaNum6).HasColumnName(@"FormulaNum6").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.FormulaNum7).HasColumnName(@"FormulaNum7").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.FormulaNum8).HasColumnName(@"FormulaNum8").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.ResultNum1).HasColumnName(@"ResultNum1").HasColumnType("float").IsOptional();
            Property(x => x.ResultNum2).HasColumnName(@"ResultNum2").HasColumnType("float").IsOptional();
            Property(x => x.ResultNum3).HasColumnName(@"ResultNum3").HasColumnType("float").IsOptional();
            Property(x => x.ResultNum4).HasColumnName(@"ResultNum4").HasColumnType("float").IsOptional();
            Property(x => x.ResultNum5).HasColumnName(@"ResultNum5").HasColumnType("float").IsOptional();
            Property(x => x.ResultNum6).HasColumnName(@"ResultNum6").HasColumnType("float").IsOptional();
            Property(x => x.ResultNum7).HasColumnName(@"ResultNum7").HasColumnType("float").IsOptional();
            Property(x => x.ResultNum8).HasColumnName(@"ResultNum8").HasColumnType("float").IsOptional();

            HasRequired(a => a.CalcDetail).WithOptional(b => b.OpmetingFormula);
        }
    }
}
