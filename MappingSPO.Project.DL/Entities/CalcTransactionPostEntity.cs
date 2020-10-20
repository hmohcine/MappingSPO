
namespace MappingSPO.Project.DL.Entities
{
    public partial class CalcTransactionPostEntity
    {
		public CalcTransactionPostEntity()
        {
            CalcTransactionPostArticles = new System.Collections.Generic.List<CalcTransactionPostArticleEntity>();
            InitializePartial();
		}

        public long CalcId { get; set; }
        public int TransActionNr { get; set; }
        public long CalcDetailId { get; set; }
        public double? WeightKp { get; set; }
        public double? Kp { get; set; }
        public double? WeightVp { get; set; }
        public double? Vp { get; set; }
        public System.Collections.Generic.ICollection<CalcTransactionPostArticleEntity> CalcTransactionPostArticles { get; set; }
        public CalcDetailEntity CalcDetail { get; set; }
        public CalcTransactionEntity CalcTransaction { get; set; }
             
        partial void InitializePartial();
    }
}
