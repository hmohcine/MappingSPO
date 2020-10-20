
namespace MappingSPO.Project.DL.Entities
{
    public partial class CalcTransactionPostArticleEntity
    {
		public CalcTransactionPostArticleEntity()
        {
            InitializePartial();
		}

        public long CalcId { get; set; }
        public int TransActionNr { get; set; }
        public long CalcDetailIdPost { get; set; }
        public long CalcDetailIdArticle { get; set; }
        public CalcDetailEntity CalcDetail { get; set; }
        public CalcTransactionPostEntity CalcTransactionPost { get; set; }
             
        partial void InitializePartial();
    }
}
