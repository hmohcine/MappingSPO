
namespace MappingSPO.Entities
{
    public partial class CurrencyEntity
    {
		public CurrencyEntity()
        {
            ArticleDefaults = new System.Collections.Generic.List<ArticleDefaultEntity>();
            InitializePartial();
		}

        public string CurrencyCode { get; set; }
        public string Description { get; set; }
        public string IsoCode { get; set; }
        public string Symbol { get; set; }
        public double ExchangeRate { get; set; }
        public int RoundPosition { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.DateTime UpdateDate { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
        public System.DateTime ExchangeRateDate { get; set; }
        public System.Collections.Generic.ICollection<ArticleDefaultEntity> ArticleDefaults { get; set; }
        public UserEntity User_CreatedBy { get; set; }
        public UserEntity User_UpdatedBy { get; set; }
             
        partial void InitializePartial();
    }
}
