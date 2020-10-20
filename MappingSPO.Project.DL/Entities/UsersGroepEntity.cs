
namespace MappingSPO.Project.DL.Entities
{
    public partial class UsersGroepEntity
    {
		public UsersGroepEntity()
        {
            InvoiceCreate = true;
            InvoiceSearch = true;
            UserUserGroups = new System.Collections.Generic.List<UserUserGroupEntity>();
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
        public System.Collections.Generic.ICollection<UserUserGroupEntity> UserUserGroups { get; set; }
             
        partial void InitializePartial();
    }
}
