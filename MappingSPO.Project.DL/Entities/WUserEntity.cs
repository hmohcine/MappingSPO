
namespace MappingSPO.Project.DL.Entities
{
    public partial class WUserEntity
    {
		public WUserEntity()
        {
            InitializePartial();
		}

        public int UserId { get; set; }
        public string UserSname { get; set; }
        public string UserAlias { get; set; }
        public int? EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ProperName { get; set; }
        public bool? AutoStartReminderService { get; set; }
        public long? ReminderReloadDataMinuts { get; set; }
        public long? ReminderIntervalSec { get; set; }
        public long? DelayTimeToDoReminder { get; set; }
        public string OlMailAdress { get; set; }
        public bool? WfActionsHideNotifications { get; set; }
        public bool Disabled { get; set; }
             
        partial void InitializePartial();
    }
}
