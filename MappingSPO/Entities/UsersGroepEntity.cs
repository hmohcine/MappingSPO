
namespace MappingSPO.Entities
{
    public partial class UsersGroepEntity
    {
		public UsersGroepEntity()
        {
            InvoiceCreate = true;
            InvoiceSearch = true;
            AddinContractsSecurities = new System.Collections.Generic.List<AddinContractsSecurityEntity>();
            CompanyUserGroepRights = new System.Collections.Generic.List<CompanyUserGroepRightEntity>();
            EmmaAddinContractsSecurities = new System.Collections.Generic.List<EmmaAddinContractsSecurityEntity>();
            ProjectTypeUserGroups = new System.Collections.Generic.List<ProjectTypeUserGroupEntity>();
            Queries = new System.Collections.Generic.List<QueryEntity>();
            Settings = new System.Collections.Generic.List<SettingEntity>();
            Users = new System.Collections.Generic.List<UserEntity>();
            InitializePartial();
		}

        public int UserGroupId { get; set; }
        public string UserGroup { get; set; }
        public bool IsAdministrator { get; set; }
        public bool IsPowerUser { get; set; }
        public bool IsSysGroup { get; set; }
        public bool? IsManagement { get; set; }
        public bool? CanChangeEmmaArticles { get; set; }
        public bool InvoiceCreate { get; set; }
        public bool InvoiceSearch { get; set; }
        public bool? EmployeeSearch { get; set; }
        public bool? EmployeeFinancial { get; set; }
        public bool? EmployeeChange { get; set; }
        public bool? ShowOnlyCalculatorBoundCalculations { get; set; }
        public bool? ShowOnlyOmzetOffertes { get; set; }
        public System.Collections.Generic.ICollection<AddinContractsSecurityEntity> AddinContractsSecurities { get; set; }
        public System.Collections.Generic.ICollection<CompanyUserGroepRightEntity> CompanyUserGroepRights { get; set; }
        public System.Collections.Generic.ICollection<EmmaAddinContractsSecurityEntity> EmmaAddinContractsSecurities { get; set; }
        public System.Collections.Generic.ICollection<ProjectTypeUserGroupEntity> ProjectTypeUserGroups { get; set; }
        public System.Collections.Generic.ICollection<QueryEntity> Queries { get; set; }
        public System.Collections.Generic.ICollection<SettingEntity> Settings { get; set; }
        public System.Collections.Generic.ICollection<UserEntity> Users { get; set; }
             
        partial void InitializePartial();
    }
}
