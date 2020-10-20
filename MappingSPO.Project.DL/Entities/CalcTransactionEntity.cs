
namespace MappingSPO.Project.DL.Entities
{
    public partial class CalcTransactionEntity
    {
		public CalcTransactionEntity()
        {
            CalcTransactionPosts = new System.Collections.Generic.List<CalcTransactionPostEntity>();
            InitializePartial();
		}

        public long CalcId { get; set; }
        public int TransActionNr { get; set; }
        public int? TransActionType { get; set; }
        public string Description { get; set; }
        public string Notes { get; set; }
        public bool? LockArtikel { get; set; }
        public string OrigineelObject { get; set; }
        public int? VerdeelWijze { get; set; }
        public long? ArtikelChilds { get; set; }
        public long? PostParents { get; set; }
        public int? State { get; set; }
        public double? TWeightKp { get; set; }
        public double? Tkp { get; set; }
        public double? TWeightVp { get; set; }
        public double? Tvp { get; set; }
        public System.DateTime? TransDate { get; set; }
        public int? SelectAllPosts { get; set; }
        public string ShowParts { get; set; }
        public System.Collections.Generic.ICollection<CalcTransactionPostEntity> CalcTransactionPosts { get; set; }
        public CalculationEntity Calculation { get; set; }
             
        partial void InitializePartial();
    }
}
