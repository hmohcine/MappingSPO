
namespace MappingSPO.Project.DL.Entities
{
    public partial class SbDetailEntity
    {
		public SbDetailEntity()
        {
            LineType = 0;
            AddedOnLevering = 0;
            InitializePartial();
		}

        public long DetailId { get; set; }
        public int LineOrder { get; set; }
        public int LineType { get; set; }
        public long? ArtId { get; set; }
        public long? Sbid { get; set; }
        public double? Aantal { get; set; }
        public long? MagazijnId { get; set; }
        public long? TermijnDays { get; set; }
        public string Code { get; set; }
        public string Uc { get; set; }
        public double? Prijs { get; set; }
        public double? Factor { get; set; }
        public byte[] Timestamp { get; set; }
        public string Description { get; set; }
        public string NotesExternal { get; set; }
        public string NotesInternal { get; set; }
        public long? WerfLijstId { get; set; }
        public long? WerfId { get; set; }
        public long? LeveradresId { get; set; }
        public string Code1 { get; set; }
        public string Code2 { get; set; }
        public string Code3 { get; set; }
        public string Code4 { get; set; }
        public string Code5 { get; set; }
        public string Code6 { get; set; }
        public string Code7 { get; set; }
        public string Code8 { get; set; }
        public string Ks { get; set; }
        public string FullCode { get; set; }
        public int? AddCount { get; set; }
        public long AddedOnLevering { get; set; }
        public long? EmmaArticleId { get; set; }
        public long? InkoopCatId { get; set; }
        public long? BaReplaceWerflijstId { get; set; }
        public long? Vko { get; set; }
        public long? VkoLine { get; set; }
        public string LeverancierRef { get; set; }
        public WerfLijstEntity WerfLijst { get; set; }
             
        partial void InitializePartial();
    }
}
