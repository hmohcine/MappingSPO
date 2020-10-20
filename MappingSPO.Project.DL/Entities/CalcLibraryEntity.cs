
namespace MappingSPO.Project.DL.Entities
{
    public partial class CalcLibraryEntity
    {
		public CalcLibraryEntity()
        {
            InitializePartial();
		}

        public long CalcId { get; set; }
        public long ItemId { get; set; }
        public long? LibraryId { get; set; }
        public long? ArticleId { get; set; }
        public string Code1 { get; set; }
        public string Code2 { get; set; }
        public string Code3 { get; set; }
        public string Code4 { get; set; }
        public string Code5 { get; set; }
        public string Code6 { get; set; }
        public string Code7 { get; set; }
        public string Code8 { get; set; }
        public string Description { get; set; }
        public string Uc { get; set; }
        public double? Ekp { get; set; }
        public System.DateTime? DateUpdatedEkp { get; set; }
        public string Ks { get; set; }
        public double? ExtraNum1 { get; set; }
        public double? ExtraNum2 { get; set; }
        public double? ExtraNum3 { get; set; }
        public double? ExtraNum4 { get; set; }
        public double? ExtraNum5 { get; set; }
        public double? ExtraNum6 { get; set; }
        public double? ExtraNum7 { get; set; }
        public double? ExtraNum8 { get; set; }
        public long? InkoopCatId { get; set; }
        public CalculationEntity Calculation { get; set; }
             
        partial void InitializePartial();
    }
}
