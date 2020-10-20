
namespace MappingSPO.Entities
{
    public partial class CompanyEntity
    {
		public CompanyEntity()
        {
            ShowOgm = false;
            OgmPrefixInUse = false;
            CompanyType = 0;
            BoekPeriodes = new System.Collections.Generic.List<BoekPeriodeEntity>();
            CompanyRekeningens = new System.Collections.Generic.List<CompanyRekeningenEntity>();
            CompanyUserGroepRights = new System.Collections.Generic.List<CompanyUserGroepRightEntity>();
            CompanyUserRights = new System.Collections.Generic.List<CompanyUserRightEntity>();
            DynAx2012CustSettings = new System.Collections.Generic.List<DynAx2012CustSettingsEntity>();
            Employees = new System.Collections.Generic.List<EmployeeEntity>();
            ExactOnlineSettings = new System.Collections.Generic.List<ExactOnlineSettingEntity>();
            Invoices = new System.Collections.Generic.List<InvoiceEntity>();
            Reports = new System.Collections.Generic.List<ReportEntity>();
            SageBobCompanySettings = new System.Collections.Generic.List<SageBobCompanySettingEntity>();
            SysCalculationParas = new System.Collections.Generic.List<SysCalculationParaEntity>();
            Users = new System.Collections.Generic.List<UserEntity>();
            VeniceSettings = new System.Collections.Generic.List<VeniceSettingEntity>();
            WinbooksSettings = new System.Collections.Generic.List<WinbooksSettingEntity>();
            WingsSettings = new System.Collections.Generic.List<WingsSettingEntity>();
            InitializePartial();
		}

        public int CompanyId { get; set; }
        public byte[] Logo { get; set; }
        public string OnNumber { get; set; }
        public string Rpr { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }
        public string AdressLine1 { get; set; }
        public string AdressLine2 { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string StreetCode { get; set; }
        public string CountryCode { get; set; }
        public string Language { get; set; }
        public string NotesInternal { get; set; }
        public string NotesExternal { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Fax1 { get; set; }
        public string Fax2 { get; set; }
        public string Email1 { get; set; }
        public string Email2 { get; set; }
        public string Website { get; set; }
        public int? LastUpdatedBy { get; set; }
        public System.DateTime? LastUpdated { get; set; }
        public string Reknr1 { get; set; }
        public string Reknr2 { get; set; }
        public string Reknr3 { get; set; }
        public string RegNr { get; set; }
        public long? DefaultRekeningId { get; set; }
        public int? LogoType { get; set; }
        public byte[] ConvertedLogo { get; set; }
        public long? DefaultMagazijnId { get; set; }
        public long? DefaultToonzaalId { get; set; }
        public string OgmPrefix { get; set; }
        public bool ShowOgm { get; set; }
        public bool OgmPrefixInUse { get; set; }
        public long? RelationId { get; set; }
        public long? DefaultVerkoopCatId { get; set; }
        public string DefaultLoonCostKsIntern { get; set; }
        public double? DefaultLoonCostIntern { get; set; }
        public string DefaultLoonCostKsExtern { get; set; }
        public double? DefaultLoonCostExtern { get; set; }
        public string ExternalCode { get; set; }
        public int CompanyType { get; set; }
        public int? ParentCompanyId { get; set; }
        public decimal? VoorschotBedragPerRefDag { get; set; }
        public string VoorschotWerkCode { get; set; }
        public System.Collections.Generic.ICollection<BoekPeriodeEntity> BoekPeriodes { get; set; }
        public System.Collections.Generic.ICollection<CompanyRekeningenEntity> CompanyRekeningens { get; set; }
        public System.Collections.Generic.ICollection<CompanyUserGroepRightEntity> CompanyUserGroepRights { get; set; }
        public System.Collections.Generic.ICollection<CompanyUserRightEntity> CompanyUserRights { get; set; }
        public System.Collections.Generic.ICollection<DynAx2012CustSettingsEntity> DynAx2012CustSettings { get; set; }
        public System.Collections.Generic.ICollection<EmployeeEntity> Employees { get; set; }
        public System.Collections.Generic.ICollection<ExactOnlineSettingEntity> ExactOnlineSettings { get; set; }
        public System.Collections.Generic.ICollection<InvoiceEntity> Invoices { get; set; }
        public System.Collections.Generic.ICollection<ReportEntity> Reports { get; set; }
        public System.Collections.Generic.ICollection<SageBobCompanySettingEntity> SageBobCompanySettings { get; set; }
        public System.Collections.Generic.ICollection<SysCalculationParaEntity> SysCalculationParas { get; set; }
        public System.Collections.Generic.ICollection<UserEntity> Users { get; set; }
        public System.Collections.Generic.ICollection<VeniceSettingEntity> VeniceSettings { get; set; }
        public System.Collections.Generic.ICollection<WinbooksSettingEntity> WinbooksSettings { get; set; }
        public System.Collections.Generic.ICollection<WingsSettingEntity> WingsSettings { get; set; }
        public CountryEntity Country { get; set; }
        public LanguageEntity Language_Language { get; set; }
        public RelActiviteitEntity RelActiviteit { get; set; }
        public RelationEntity Relation { get; set; }
        public WerkCodeEntity WerkCode { get; set; }
             
        partial void InitializePartial();
    }
}
