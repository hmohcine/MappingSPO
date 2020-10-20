
namespace MappingSPO.Entities
{
    public partial class EmmaUserSettingEntity
    {
		public EmmaUserSettingEntity()
        {
            AutoReWriteAantalOnStockBestelling = false;
            AutoFillMagazijnOnStockBestelling = false;
            InitializePartial();
		}

        public int UserId { get; set; }
        public bool AutoJumpAfterAdd { get; set; }
        public bool AutoReWriteAantalOnStockBestelling { get; set; }
        public bool AutoFillMagazijnOnStockBestelling { get; set; }
        public UserEntity User { get; set; }
             
        partial void InitializePartial();
    }
}
