
namespace MappingSPO.Entities
{
    public partial class ActiviteitGroupEntity
    {
		public ActiviteitGroupEntity()
        {
            ShowAsMode = 0;
            Activiteitens = new System.Collections.Generic.List<ActiviteitenEntity>();
            InitializePartial();
		}

        public long ActGroupId { get; set; }
        public string ActGroup { get; set; }
        public string Code { get; set; }
        public int ShowAsMode { get; set; }
        public string ShowAs { get; set; }
        public System.Collections.Generic.ICollection<ActiviteitenEntity> Activiteitens { get; set; }
             
        partial void InitializePartial();
    }
}
