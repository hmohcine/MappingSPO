
namespace MappingSPO.Entities
{
    public partial class CodaBoxSettingEntity
    {
		public CodaBoxSettingEntity()
        {
            InitializePartial();
		}

        public string SettingName { get; set; }
        public string SettingValue { get; set; }
             
        partial void InitializePartial();
    }
}
