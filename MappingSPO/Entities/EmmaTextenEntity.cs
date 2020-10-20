
namespace MappingSPO.Entities
{
    public partial class EmmaTextenEntity
    {
		public EmmaTextenEntity()
        {
            KeepToghether = false;
            Disabled = false;
            LinePosition = 0;
            EmmaOfferLabelValues = new System.Collections.Generic.List<EmmaOfferLabelValueEntity>();
            InitializePartial();
		}

        public long TextId { get; set; }
        public string ReferentieIntern { get; set; }
        public string RtfText { get; set; }
        public bool ShowOnOffer { get; set; }
        public bool ShowOnVko { get; set; }
        public bool ShowOnInvoice { get; set; }
        public bool ShowOnLeverbon { get; set; }
        public bool ShowOnBestelbon { get; set; }
        public bool KeepToghether { get; set; }
        public byte Type { get; set; }
        public bool Disabled { get; set; }
        public long GroupId { get; set; }
        public int LinePosition { get; set; }
        public string LanguageCode { get; set; }
        public System.Collections.Generic.ICollection<EmmaOfferLabelValueEntity> EmmaOfferLabelValues { get; set; }
        public EmmaTextGroupEntity EmmaTextGroup { get; set; }
        public LanguageEntity Language { get; set; }
             
        partial void InitializePartial();
    }
}
