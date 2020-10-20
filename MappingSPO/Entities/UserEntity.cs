
namespace MappingSPO.Entities
{
    public partial class UserEntity
    {
		public UserEntity()
        {
            MainMenuNumber = 0;
            Disabled = false;
            ShowPrintDialogOnPrintDirect = true;
            ShowWerfExtendedXrm = 0;
            IsLicensedBuild = false;
            IsLicensedEmma = false;
            ShowWerfExplorer = true;
            AutomaticCalcSettings_OnlyForUser = new System.Collections.Generic.List<AutomaticCalcSettingEntity>();
            AutomaticCalcSettings_Owner = new System.Collections.Generic.List<AutomaticCalcSettingEntity>();
            BatchServiceSettings = new System.Collections.Generic.List<BatchServiceSettingEntity>();
            BoekPeriodes = new System.Collections.Generic.List<BoekPeriodeEntity>();
            CalcFilters = new System.Collections.Generic.List<CalcFilterEntity>();
            CompanyUserRights = new System.Collections.Generic.List<CompanyUserRightEntity>();
            Contacts = new System.Collections.Generic.List<ContactEntity>();
            Currencies_CreatedBy = new System.Collections.Generic.List<CurrencyEntity>();
            Currencies_UpdatedBy = new System.Collections.Generic.List<CurrencyEntity>();
            Documents = new System.Collections.Generic.List<DocumentEntity>();
            Invoices_CreatedBy = new System.Collections.Generic.List<InvoiceEntity>();
            Invoices_LastChangedBy = new System.Collections.Generic.List<InvoiceEntity>();
            ProjectTypeUsers = new System.Collections.Generic.List<ProjectTypeUserEntity>();
            Queries = new System.Collections.Generic.List<QueryEntity>();
            Relations = new System.Collections.Generic.List<RelationEntity>();
            SysProjectUserSettings = new System.Collections.Generic.List<SysProjectUserSettingEntity>();
            SysUserSettingUserObjects = new System.Collections.Generic.List<SysUserSettingUserObjectEntity>();
            WorkFlows_CreatedBy = new System.Collections.Generic.List<WorkFlowEntity>();
            WorkFlows_UpdatedBy = new System.Collections.Generic.List<WorkFlowEntity>();
            WorkOrderTypeAfdelings = new System.Collections.Generic.List<WorkOrderTypeAfdelingEntity>();
            UsersGroeps = new System.Collections.Generic.List<UsersGroepEntity>();
            InitializePartial();
		}

        public int UserId { get; set; }
        public string UserSname { get; set; }
        public string UserAlias { get; set; }
        public System.DateTime? FirstLogoff { get; set; }
        public System.DateTime? LastLogoff { get; set; }
        public string Handtekening1 { get; set; }
        public string Handtekening2 { get; set; }
        public string Handtekening3 { get; set; }
        public string Handtekening4 { get; set; }
        public string Handtekening5 { get; set; }
        public string Handtekening6 { get; set; }
        public long? MainMenuNumber { get; set; }
        public string MainMenuParaMeters { get; set; }
        public int? OutlookAddinVersion { get; set; }
        public System.DateTime? OutlookAddinVersionDate { get; set; }
        public bool? AutoBackupCalculationYn { get; set; }
        public int? EmployeeId { get; set; }
        public bool? AutoStartReminderService { get; set; }
        public long? ReminderReloadDataMinuts { get; set; }
        public long? ReminderIntervalSec { get; set; }
        public long? DelayTimeToDoReminder { get; set; }
        public System.DateTime? OlLastSyncTime { get; set; }
        public string OlMailAdress { get; set; }
        public double? OlSyncIntervalInMinutes { get; set; }
        public bool? OlSyncBodyYn { get; set; }
        public int? OlConflictResolveMode { get; set; }
        public bool? OlSyncEnabled { get; set; }
        public System.DateTime? OlSyncFromDate { get; set; }
        public int? OlMaxDaysInPast { get; set; }
        public bool? WfActionsHideNotifications { get; set; }
        public string LanguageCode { get; set; }
        public int? DefaultCompanyId { get; set; }
        public long? DefaultMagazijnId { get; set; }
        public long? DefaultToonzaalId { get; set; }
        public int? DefaultCompanyIdStock { get; set; }
        public bool? ManualUpdateDwEnabled { get; set; }
        public string UiLanguageCode { get; set; }
        public bool Disabled { get; set; }
        public bool ShowPrintDialogOnPrintDirect { get; set; }
        public int ShowWerfExtendedXrm { get; set; }
        public string DefaultPathExportXmlVordering { get; set; }
        public float? RtfZoomFactor { get; set; }
        public bool IsLicensedBuild { get; set; }
        public bool IsLicensedEmma { get; set; }
        public bool ShowWerfExplorer { get; set; }
        public string DefaultSkin { get; set; }
        public string BestModPrefilter { get; set; }
        public EmmaUserSettingEntity EmmaUserSetting { get; set; }
        public System.Collections.Generic.ICollection<AutomaticCalcSettingEntity> AutomaticCalcSettings_OnlyForUser { get; set; }
        public System.Collections.Generic.ICollection<AutomaticCalcSettingEntity> AutomaticCalcSettings_Owner { get; set; }
        public System.Collections.Generic.ICollection<BatchServiceSettingEntity> BatchServiceSettings { get; set; }
        public System.Collections.Generic.ICollection<BoekPeriodeEntity> BoekPeriodes { get; set; }
        public System.Collections.Generic.ICollection<CalcFilterEntity> CalcFilters { get; set; }
        public System.Collections.Generic.ICollection<CompanyUserRightEntity> CompanyUserRights { get; set; }
        public System.Collections.Generic.ICollection<ContactEntity> Contacts { get; set; }
        public System.Collections.Generic.ICollection<CurrencyEntity> Currencies_CreatedBy { get; set; }
        public System.Collections.Generic.ICollection<CurrencyEntity> Currencies_UpdatedBy { get; set; }
        public System.Collections.Generic.ICollection<DocumentEntity> Documents { get; set; }
        public System.Collections.Generic.ICollection<InvoiceEntity> Invoices_CreatedBy { get; set; }
        public System.Collections.Generic.ICollection<InvoiceEntity> Invoices_LastChangedBy { get; set; }
        public System.Collections.Generic.ICollection<ProjectTypeUserEntity> ProjectTypeUsers { get; set; }
        public System.Collections.Generic.ICollection<QueryEntity> Queries { get; set; }
        public System.Collections.Generic.ICollection<RelationEntity> Relations { get; set; }
        public System.Collections.Generic.ICollection<SysProjectUserSettingEntity> SysProjectUserSettings { get; set; }
        public System.Collections.Generic.ICollection<SysUserSettingUserObjectEntity> SysUserSettingUserObjects { get; set; }
        public System.Collections.Generic.ICollection<UsersGroepEntity> UsersGroeps { get; set; }
        public System.Collections.Generic.ICollection<WorkFlowEntity> WorkFlows_CreatedBy { get; set; }
        public System.Collections.Generic.ICollection<WorkFlowEntity> WorkFlows_UpdatedBy { get; set; }
        public System.Collections.Generic.ICollection<WorkOrderTypeAfdelingEntity> WorkOrderTypeAfdelings { get; set; }
        public CompanyEntity Company { get; set; }
        public LanguageEntity Language { get; set; }
             
        partial void InitializePartial();
    }
}
