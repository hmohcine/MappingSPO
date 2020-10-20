
namespace MappingSPO.Project.DL.Entities
{
    public partial class WerfLijstEntity
    {
		public WerfLijstEntity()
        {
            Enabled = false;
            EPrijsFixed = false;
            AddedByMode = 0;
            CostDetailCores = new System.Collections.Generic.List<CostDetailCoreEntity>();
            SbDetails = new System.Collections.Generic.List<SbDetailEntity>();
            InitializePartial();
		}

        public long WerfLijstId { get; set; }
        public long WerfId { get; set; }
        public string Code1 { get; set; }
        public string Code2 { get; set; }
        public string Code3 { get; set; }
        public string Code4 { get; set; }
        public string Code5 { get; set; }
        public string Code6 { get; set; }
        public string Code7 { get; set; }
        public string Code8 { get; set; }
        public string Code { get; set; }
        public string Ks { get; set; }
        public string Uc { get; set; }
        public double TotBestelAantal { get; set; }
        public bool Enabled { get; set; }
        public double EPrijs { get; set; }
        public bool EPrijsFixed { get; set; }
        public long? ArtId { get; set; }
        public long? DefaultLeverancierId { get; set; }
        public long? DefaultMagazijnId { get; set; }
        public long? DefaultLeveradresId { get; set; }
        public string Description { get; set; }
        public string NotesExternal { get; set; }
        public string NotesInternal { get; set; }
        public System.DateTime Created { get; set; }
        public int CreatedBy { get; set; }
        public byte[] TimeStamp { get; set; }
        public System.DateTime LastChanged { get; set; }
        public int LastChangedBy { get; set; }
        public string BestelCode { get; set; }
        public string BestelUc { get; set; }
        public double? BestelPrijs { get; set; }
        public double? BestelFactor { get; set; }
        public double? EprijsLibrary { get; set; }
        public double? Aantal2 { get; set; }
        public long? Volgorde { get; set; }
        public int? AddedByMode { get; set; }
        public bool? IsDone { get; set; }
        public long? InkoopCatId { get; set; }
        public string LeverancierRef { get; set; }
        public System.Collections.Generic.ICollection<CostDetailCoreEntity> CostDetailCores { get; set; }
        public System.Collections.Generic.ICollection<SbDetailEntity> SbDetails { get; set; }
        public RelationEntity Relation { get; set; }
             
        partial void InitializePartial();
    }
}
