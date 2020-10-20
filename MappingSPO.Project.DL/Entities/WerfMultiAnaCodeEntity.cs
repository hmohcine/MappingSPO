
namespace MappingSPO.Project.DL.Entities
{
    public partial class WerfMultiAnaCodeEntity
    {
		public WerfMultiAnaCodeEntity()
        {
            Disable = false;
            Domain = "C";
            Werfs = new System.Collections.Generic.List<WerfEntity>();
            InitializePartial();
		}

        public long MultiId { get; set; }
        public int MultiIndex { get; set; }
        public string MultiName { get; set; }
        public bool Disable { get; set; }
        public string Domain { get; set; }
        public System.Collections.Generic.ICollection<WerfEntity> Werfs { get; set; }
             
        partial void InitializePartial();
    }
}
