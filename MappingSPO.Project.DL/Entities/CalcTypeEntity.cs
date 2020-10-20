
namespace MappingSPO.Project.DL.Entities
{
    public partial class CalcTypeEntity
    {
		public CalcTypeEntity()
        {
            Disabled = false;
            Domain = "C";
            DefaultCalcSoort = 0;
            Calculations = new System.Collections.Generic.List<CalculationEntity>();
            SysCalculationParas_AutoBackupRestoreCalcTypeId = new System.Collections.Generic.List<SysCalculationParaEntity>();
            SysCalculationParas_CalcDefaultType = new System.Collections.Generic.List<SysCalculationParaEntity>();
            InitializePartial();
		}

        public string CalcTypeId { get; set; }
        public string CalcMayorTypeCode { get; set; }
        public string CalcType_ { get; set; }
        public string CalcTypeDescription { get; set; }
        public int? ArticleLibraryType { get; set; }
        public long? ArticleLibraryId { get; set; }
        public int? ArticleLibrarySettings { get; set; }
        public int? PostLibraryType { get; set; }
        public long? PostLibraryId { get; set; }
        public int? PostLibrarySettings { get; set; }
        public bool? SetOfferDateToDay { get; set; }
        public bool? PostDontOverwrite { get; set; }
        public string DefaultCalcName { get; set; }
        public bool? ExcludeFromAutoBackup { get; set; }
        public int? WinstMode { get; set; }
        public bool Disabled { get; set; }
        public bool? AutoFillCalculatorWithOwner { get; set; }
        public string Domain { get; set; }
        public int DefaultCalcSoort { get; set; }
        public bool? PostLibraryIncludeQuantities { get; set; }
        public long? DefaultVerkoopCatId { get; set; }
        public System.Collections.Generic.ICollection<CalculationEntity> Calculations { get; set; }
        public System.Collections.Generic.ICollection<SysCalculationParaEntity> SysCalculationParas_AutoBackupRestoreCalcTypeId { get; set; }
        public System.Collections.Generic.ICollection<SysCalculationParaEntity> SysCalculationParas_CalcDefaultType { get; set; }
             
        partial void InitializePartial();
    }
}
