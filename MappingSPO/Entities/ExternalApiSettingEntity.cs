
namespace MappingSPO.Entities
{
    public partial class ExternalApiSettingEntity
    {
		public ExternalApiSettingEntity()
        {
            InitializePartial();
		}

        public string Source { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
        public long Id { get; set; }
        public int? CompanyId { get; set; }
             
        partial void InitializePartial();
    }
}
