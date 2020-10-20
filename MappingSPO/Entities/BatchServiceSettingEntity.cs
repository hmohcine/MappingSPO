
namespace MappingSPO.Entities
{
    public partial class BatchServiceSettingEntity
    {
		public BatchServiceSettingEntity()
        {
            BatchJobUserId = 0;
            Interval = 60;
            InitializePartial();
		}

        public int Id { get; set; }
        public int BatchJobUserId { get; set; }
        public int Interval { get; set; }
        public string UserLanguage { get; set; }
        public UserEntity User { get; set; }
             
        partial void InitializePartial();
    }
}
