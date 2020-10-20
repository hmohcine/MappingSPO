
namespace MappingSPO.Project.DL.Entities
{
    public partial class WTodoExplorerEntity
    {
		public WTodoExplorerEntity()
        {
            InitializePartial();
		}

        public long ItemId { get; set; }
        public int ToDoMasterType { get; set; }
        public byte[] DisplayIcon { get; set; }
        public bool IsDone { get; set; }
        public bool IsDeleted { get; set; }
        public System.DateTime? StartDate { get; set; }
        public int? Days { get; set; }
        public int DisplayNumber { get; set; }
        public string DisplayText { get; set; }
        public string Subject { get; set; }
        public string Location { get; set; }
        public long? RelationId { get; set; }
        public int? ContactId { get; set; }
        public string RelationName { get; set; }
        public string RelationCity { get; set; }
        public string RelationPhone1 { get; set; }
        public string RelationPhone2 { get; set; }
        public string RelationFax1 { get; set; }
        public string RelationFax2 { get; set; }
        public string RelationEmail1 { get; set; }
        public string RelationEmail2 { get; set; }
        public string ContactGsm { get; set; }
        public string ContactPhone { get; set; }
        public string ContactFax { get; set; }
        public string ContactEmail { get; set; }
        public string ContactName { get; set; }
        public string ContactCity { get; set; }
        public string ContactPrivePhone { get; set; }
        public string ContactPriveFax { get; set; }
        public string ContactPriveEmail { get; set; }
        public string ContactPriveGsm { get; set; }
        public System.DateTime? DueDate { get; set; }
        public System.DateTime? DoneDate { get; set; }
        public int Owner { get; set; }
        public string OwnerName { get; set; }
        public long? ProjectId { get; set; }
        public string ProjectType { get; set; }
        public string ProjectNrText { get; set; }
        public string ProjectName { get; set; }
        public string CurrentState { get; set; }
        public byte[] CurrentStateIcon { get; set; }
        public string CurrentStateWorkflow { get; set; }
        public string WerfName { get; set; }
        public int? WerfState { get; set; }
        public bool IsActive { get; set; }
        public bool? OlSyncronisedYn { get; set; }
        public System.DateTime? OlLastSyncTime { get; set; }
        public bool HasReminder { get; set; }
        public System.DateTime? ReminderTime { get; set; }
        public bool? AllDayEvent { get; set; }
        public long? WerfId { get; set; }
        public int? EmployeeId { get; set; }
        public string Employee { get; set; }
        public string TodoNrText { get; set; }
        public string ExterneRef { get; set; }
        public string Melder { get; set; }
        public string MelderEmail { get; set; }
        public int Prioriteit { get; set; }
        public string InkoopCat { get; set; }
        public string InkoopCatGroup { get; set; }
        public string VerkoopCat { get; set; }
        public string VerkoopCatGroup { get; set; }
        public string Activiteit { get; set; }
        public string ActiviteitGroup { get; set; }
        public string StatusDescription { get; set; }
        public string Werfnummer { get; set; }
             
        partial void InitializePartial();
    }
}
