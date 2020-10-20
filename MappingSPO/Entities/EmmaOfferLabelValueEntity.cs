
namespace MappingSPO.Entities
{
    public partial class EmmaOfferLabelValueEntity
    {
		public EmmaOfferLabelValueEntity()
        {
            InitializePartial();
		}

        public long LabelId { get; set; }
        public string OfferType { get; set; }
        public string LanguageCode { get; set; }
        public byte LabelType { get; set; }
        public string LabelValue { get; set; }
        public long? TextId { get; set; }
        public EmmaOfferTypeEntity EmmaOfferType { get; set; }
        public EmmaTextenEntity EmmaTexten { get; set; }
        public LanguageEntity Language { get; set; }
             
        partial void InitializePartial();
    }
}
