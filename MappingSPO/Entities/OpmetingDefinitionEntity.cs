
namespace MappingSPO.Entities
{
    public partial class OpmetingDefinitionEntity
    {
		public OpmetingDefinitionEntity()
        {
            ActiveColumns = 1;
            IsDefault = false;
            InitializePartial();
		}

        public string Uc { get; set; }
        public int OpmetingDefinitionId { get; set; }
        public string OpmetingDefinition_ { get; set; }
        public short ActiveColumns { get; set; }
        public string Formula { get; set; }
        public string Label1 { get; set; }
        public string Label2 { get; set; }
        public string Label3 { get; set; }
        public string Label4 { get; set; }
        public string Label5 { get; set; }
        public string Label6 { get; set; }
        public string ResultFormula { get; set; }
        public float? Label1Weight { get; set; }
        public float? Label2Weight { get; set; }
        public float? Label3Weight { get; set; }
        public float? Label4Weight { get; set; }
        public float? Label5Weight { get; set; }
        public float? Label6Weight { get; set; }
        public float? CodeWeight { get; set; }
        public float? DescriptionWeight { get; set; }
        public float? NotesWeight { get; set; }
        public bool? ExtendedMode { get; set; }
        public int? ResultRoundDigits { get; set; }
        public string Name { get; set; }
        public float? ResultWeight { get; set; }
        public string ColumnOrder { get; set; }
        public int? MaatType1 { get; set; }
        public int? MaatType2 { get; set; }
        public int? MaatType3 { get; set; }
        public int? MaatType4 { get; set; }
        public int? MaatType5 { get; set; }
        public int? MaatType6 { get; set; }
        public string Uc1 { get; set; }
        public string Uc2 { get; set; }
        public string Uc3 { get; set; }
        public string Uc4 { get; set; }
        public string Uc5 { get; set; }
        public string Uc6 { get; set; }
        public float? PrintCodeWeight { get; set; }
        public string ResultFormulaNum1 { get; set; }
        public string ResultFormulaNum2 { get; set; }
        public string ResultFormulaNum3 { get; set; }
        public string ResultFormulaNum4 { get; set; }
        public string ResultFormulaNum5 { get; set; }
        public string ResultFormulaNum6 { get; set; }
        public string ResultFormulaNum7 { get; set; }
        public string ResultFormulaNum8 { get; set; }
        public string FormulaNum1 { get; set; }
        public string FormulaNum2 { get; set; }
        public string FormulaNum3 { get; set; }
        public string FormulaNum4 { get; set; }
        public string FormulaNum5 { get; set; }
        public string FormulaNum6 { get; set; }
        public string FormulaNum7 { get; set; }
        public string FormulaNum8 { get; set; }
        public bool IsDefault { get; set; }
        public MaatTypeEntity MaatType_MaatType1 { get; set; }
        public MaatTypeEntity MaatType_MaatType2 { get; set; }
        public MaatTypeEntity MaatType_MaatType3 { get; set; }
        public MaatTypeEntity MaatType_MaatType4 { get; set; }
        public MaatTypeEntity MaatType_MaatType5 { get; set; }
        public MaatTypeEntity MaatType_MaatType6 { get; set; }
        public UcEntity Uc_Uc { get; set; }
        public UcEntity Uc_Uc1 { get; set; }
        public UcEntity Uc_Uc2 { get; set; }
        public UcEntity Uc_Uc3 { get; set; }
        public UcEntity Uc_Uc4 { get; set; }
        public UcEntity Uc_Uc5 { get; set; }
        public UcEntity Uc_Uc6 { get; set; }
             
        partial void InitializePartial();
    }
}
