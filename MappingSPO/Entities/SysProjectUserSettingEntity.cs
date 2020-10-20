
namespace MappingSPO.Entities
{
    public partial class SysProjectUserSettingEntity
    {
		public SysProjectUserSettingEntity()
        {
            CenterAutoOpenOnStart = false;
            CenterOnNewScreen = false;
            CenterSplitterPct = 75;
            CenterMaxActive = 50;
            TodoPlusDays = 30;
            ProjectSplitterpct = 75;
            ProjectXrmSplitter = 25;
            ProjectTabIndex = 0;
            ShowAProjAlgemeen = true;
            ShowAProjTexten = true;
            ShowBWfHistoriek = true;
            ShowBWfStateTask = true;
            ShowBWfTask = true;
            ShowCXrmRelations = true;
            ShowCXrmContacts = true;
            ShowCXrmRelationsVia = true;
            ShowCXrmContactsVia = true;
            ShowDCalcAlgemeen = true;
            ShowDCalcTotalKs = true;
            ShowDProjTotalKs = true;
            ShowEWerfAlgemeen = true;
            ShowEWerfVordering = true;
            ShowEWerfInvoice = true;
            ShowFForeCastCurrent = true;
            ShowFForeCastHistoriek = true;
            ShowGAnaAlgemeen = false;
            ShowGAnaDetailKs = false;
            ShowGAnaTime = false;
            DefaultReminderMinutes = 15;
            DefaultReminderMode = 0;
            EnableReminderService = true;
            CenterTodoTaskSplitterpct = 600;
            DefaultReminderTimeSchedule = 1;
            InitializePartial();
		}

        public string Id { get; set; }
        public int UserId { get; set; }
        public string DefaultProjectType { get; set; }
        public bool CenterAutoOpenOnStart { get; set; }
        public bool CenterOnNewScreen { get; set; }
        public int CenterSplitterPct { get; set; }
        public int CenterMaxActive { get; set; }
        public int? CenterProjectTabIndex { get; set; }
        public int TodoPlusDays { get; set; }
        public long? DefaultTodoTypeId { get; set; }
        public int ProjectSplitterpct { get; set; }
        public int ProjectXrmSplitter { get; set; }
        public int ProjectTabIndex { get; set; }
        public int? DefaultProjectResult { get; set; }
        public int? ProjectSearchDaysPast { get; set; }
        public bool ShowAProjAlgemeen { get; set; }
        public bool ShowAProjTexten { get; set; }
        public bool ShowBWfHistoriek { get; set; }
        public bool ShowBWfStateTask { get; set; }
        public bool ShowBWfTask { get; set; }
        public bool ShowCXrmRelations { get; set; }
        public bool ShowCXrmContacts { get; set; }
        public bool ShowCXrmRelationsVia { get; set; }
        public bool ShowCXrmContactsVia { get; set; }
        public bool ShowDCalcAlgemeen { get; set; }
        public bool ShowDCalcTotalKs { get; set; }
        public bool ShowDProjTotalKs { get; set; }
        public bool ShowEWerfAlgemeen { get; set; }
        public bool ShowEWerfVordering { get; set; }
        public bool ShowEWerfInvoice { get; set; }
        public bool ShowFForeCastCurrent { get; set; }
        public bool ShowFForeCastHistoriek { get; set; }
        public bool ShowGAnaAlgemeen { get; set; }
        public bool ShowGAnaDetailKs { get; set; }
        public bool ShowGAnaTime { get; set; }
        public int DefaultReminderMinutes { get; set; }
        public int DefaultReminderMode { get; set; }
        public bool EnableReminderService { get; set; }
        public int CenterTodoTaskSplitterpct { get; set; }
        public string DefaultPathExportXml { get; set; }
        public int DefaultReminderTimeSchedule { get; set; }
        public ProjectTypeEntity ProjectType { get; set; }
        public TodoTypeEntity TodoType { get; set; }
        public UserEntity User { get; set; }
             
        partial void InitializePartial();
    }
}
