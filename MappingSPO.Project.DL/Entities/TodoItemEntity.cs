
namespace MappingSPO.Project.DL.Entities
{
    public partial class TodoItemEntity
    {
		public TodoItemEntity()
        {
            IsActive = false;
            HasReminder = false;
            ReminderMinutes = 0;
            ReminderMode = 0;
            OlSyncGuid = System.Guid.NewGuid();
            Prioriteit = 2;
            InitializePartial();
		}

        public long ItemId { get; set; }
        public long TodoTypeId { get; set; }
        public string Subject { get; set; }
        public string Location { get; set; }
        public string Notes { get; set; }
        public int? ItemStateId { get; set; }
        public bool IsActive { get; set; }
        public bool IsDone { get; set; }
        public bool IsDeleted { get; set; }
        public bool? AllDayEvent { get; set; }
        public System.DateTime? StartDate { get; set; }
        public System.DateTime? DueDate { get; set; }
        public System.DateTime? DoneDate { get; set; }
        public int Owner { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime UpdatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public long? ProjectId { get; set; }
        public string ProjectType { get; set; }
        public int? RelationTypeId { get; set; }
        public long? RelationId { get; set; }
        public int? ContactId { get; set; }
        public long? WerfId { get; set; }
        public bool HasReminder { get; set; }
        public System.DateTime? ReminderTime { get; set; }
        public int? ReminderMinutes { get; set; }
        public int? ReminderMode { get; set; }
        public bool? OlSyncronisedYn { get; set; }
        public System.Guid? OlSyncGuid { get; set; }
        public System.DateTime? OlLastSyncTime { get; set; }
        public string OlEntryId { get; set; }
        public string OlStoreId { get; set; }
        public int? OlClass { get; set; }
        public long? WorkflowId { get; set; }
        public long? TaskId { get; set; }
        public int? ExtraMinutes { get; set; }
        public System.DateTime? NextReminderTime { get; private set; }
        public int? EmployeeId { get; set; }
        public int? TodoYear { get; set; }
        public int? TodoNr { get; set; }
        public string TodoNrText { get; set; }
        public long? InkoopCategorieActiviteitId { get; set; }
        public long? VerkoopCategorieActiviteitId { get; set; }
        public long? ActiviteitId { get; set; }
        public int Prioriteit { get; set; }
        public string ExterneRef { get; set; }
        public string Melder { get; set; }
        public string MelderEmail { get; set; }
        public int? ReminderDelay { get; set; }
        public int? ReminderTimeSchedule { get; set; }
        public ContactEntity Contact { get; set; }
        public ProjectEntity Project { get; set; }
        public RelationEntity Relation { get; set; }
        public WerfEntity Werf { get; set; }
             
        partial void InitializePartial();
    }
}
