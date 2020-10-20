
namespace MappingSPO.Entities
{
    public partial class AutomaticCalcSettingEntity
    {
		public AutomaticCalcSettingEntity()
        {
            AutomaticCalcLibraries = new System.Collections.Generic.List<AutomaticCalcLibraryEntity>();
            InitializePartial();
		}

        public long Id { get; set; }
        public string Name { get; set; }
        public bool IsTempSet { get; set; }
        public int Owner { get; set; }
        public System.DateTime CreateDate { get; set; }
        public int? OnlyForUser { get; set; }
        public int Mode { get; set; }
        public string SourceCodes { get; set; }
        public string SourceSkipChars { get; set; }
        public bool? SourceSkipBlancs { get; set; }
        public string TargetCodes { get; set; }
        public string TargetSkipChars { get; set; }
        public bool? TargetSkipBlancs { get; set; }
        public string CompareCode { get; set; }
        public string ReplaceEmptyKsWith { get; set; }
        public bool? SelectMostRecentPrice { get; set; }
        public bool? OverwriteExistingValues { get; set; }
        public System.Collections.Generic.ICollection<AutomaticCalcLibraryEntity> AutomaticCalcLibraries { get; set; }
        public KsEntity Ks { get; set; }
        public UserEntity User_OnlyForUser { get; set; }
        public UserEntity User_Owner { get; set; }
             
        partial void InitializePartial();
    }
}
