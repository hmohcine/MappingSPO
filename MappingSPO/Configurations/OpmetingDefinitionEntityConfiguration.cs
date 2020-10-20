using MappingSPO.Entities;

namespace MappingSPO
{
    public class OpmetingDefinitionEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<OpmetingDefinitionEntity>
    {
        public OpmetingDefinitionEntityConfiguration()
            : this("Settings")
        {
        }

        public OpmetingDefinitionEntityConfiguration(string schema)
        {
            ToTable("tOpmetingDefinition", schema);
            HasKey(x => x.OpmetingDefinitionId);

            Property(x => x.Uc).HasColumnName(@"UC").HasColumnType("nvarchar").IsRequired().HasMaxLength(10);
            Property(x => x.OpmetingDefinitionId).HasColumnName(@"OpmetingDefinitionID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.OpmetingDefinition_).HasColumnName(@"OpmetingDefinition").HasColumnType("nvarchar").IsRequired().HasMaxLength(100);
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
            Property(x => x.IsDefault).HasColumnName(@"IsDefault").HasColumnType("bit").IsRequired();

            HasOptional(a => a.MaatType_MaatType1).WithMany(b => b.OpmetingDefinitions_MaatType1).HasForeignKey(c => c.MaatType1).WillCascadeOnDelete(false);
            HasOptional(a => a.MaatType_MaatType2).WithMany(b => b.OpmetingDefinitions_MaatType2).HasForeignKey(c => c.MaatType2).WillCascadeOnDelete(false);
            HasOptional(a => a.MaatType_MaatType3).WithMany(b => b.OpmetingDefinitions_MaatType3).HasForeignKey(c => c.MaatType3).WillCascadeOnDelete(false);
            HasOptional(a => a.MaatType_MaatType4).WithMany(b => b.OpmetingDefinitions_MaatType4).HasForeignKey(c => c.MaatType4).WillCascadeOnDelete(false);
            HasOptional(a => a.MaatType_MaatType5).WithMany(b => b.OpmetingDefinitions_MaatType5).HasForeignKey(c => c.MaatType5).WillCascadeOnDelete(false);
            HasOptional(a => a.MaatType_MaatType6).WithMany(b => b.OpmetingDefinitions_MaatType6).HasForeignKey(c => c.MaatType6).WillCascadeOnDelete(false);
            HasOptional(a => a.Uc_Uc1).WithMany(b => b.OpmetingDefinitions_Uc1).HasForeignKey(c => c.Uc1).WillCascadeOnDelete(false);
            HasOptional(a => a.Uc_Uc2).WithMany(b => b.OpmetingDefinitions_Uc2).HasForeignKey(c => c.Uc2).WillCascadeOnDelete(false);
            HasOptional(a => a.Uc_Uc3).WithMany(b => b.OpmetingDefinitions_Uc3).HasForeignKey(c => c.Uc3).WillCascadeOnDelete(false);
            HasOptional(a => a.Uc_Uc4).WithMany(b => b.OpmetingDefinitions_Uc4).HasForeignKey(c => c.Uc4).WillCascadeOnDelete(false);
            HasOptional(a => a.Uc_Uc5).WithMany(b => b.OpmetingDefinitions_Uc5).HasForeignKey(c => c.Uc5).WillCascadeOnDelete(false);
            HasOptional(a => a.Uc_Uc6).WithMany(b => b.OpmetingDefinitions_Uc6).HasForeignKey(c => c.Uc6).WillCascadeOnDelete(false);
            HasRequired(a => a.Uc_Uc).WithMany(b => b.OpmetingDefinitions_Uc).HasForeignKey(c => c.Uc);
        }
    }
}
