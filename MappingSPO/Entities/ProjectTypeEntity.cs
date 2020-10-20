
namespace MappingSPO.Entities
{
    public partial class ProjectTypeEntity
    {
		public ProjectTypeEntity()
        {
            HasExtendedSecurity = false;
            TotalsColumn = 0;
            ProjectTypeUserGroups = new System.Collections.Generic.List<ProjectTypeUserGroupEntity>();
            ProjectTypeUsers = new System.Collections.Generic.List<ProjectTypeUserEntity>();
            ProjectTypeWorkFlows = new System.Collections.Generic.List<ProjectTypeWorkFlowEntity>();
            SysProjectUserSettings = new System.Collections.Generic.List<SysProjectUserSettingEntity>();
            InitializePartial();
		}

        public string ProjectType_ { get; set; }
        public string Description { get; set; }
        public int ProjectMasterType { get; set; }
        public int DigitsDocumentnummer { get; set; }
        public bool Disabled { get; set; }
        public bool ForeCastingYn { get; set; }
        public int DefaultCodeRange { get; set; }
        public bool AutoLinkWerfYnOnCreate { get; set; }
        public bool HasExtendedSecurity { get; set; }
        public int TotalsColumn { get; set; }
        public int? ProjectNumberStyle { get; set; }
        public int? ProjectYearMode { get; set; }
        public int? ProjectNumberDigits { get; set; }
        public System.Collections.Generic.ICollection<ProjectTypeUserEntity> ProjectTypeUsers { get; set; }
        public System.Collections.Generic.ICollection<ProjectTypeUserGroupEntity> ProjectTypeUserGroups { get; set; }
        public System.Collections.Generic.ICollection<ProjectTypeWorkFlowEntity> ProjectTypeWorkFlows { get; set; }
        public System.Collections.Generic.ICollection<SysProjectUserSettingEntity> SysProjectUserSettings { get; set; }
             
        partial void InitializePartial();
    }
}
