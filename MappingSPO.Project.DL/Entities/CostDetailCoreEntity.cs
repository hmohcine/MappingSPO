
namespace MappingSPO.Project.DL.Entities
{
    public partial class CostDetailCoreEntity
    {
		public CostDetailCoreEntity()
        {
            Aantal = 0;
            Ekp = 0;
            Kp = 0;
            TotWinstpct = 0;
            Ewinst = 0;
            Evp = 0;
            Vp = 0;
            Status = 0;
            LineType = -1;
            InitializePartial();
		}

        public long DetailId { get; set; }
        public long CostHeaderId { get; set; }
        public long? WerfId { get; set; }
        public string Ks { get; set; }
        public long? ActiviteitId { get; set; }
        public string Uc { get; set; }
        public string Code1 { get; set; }
        public string Code2 { get; set; }
        public string Code3 { get; set; }
        public string Code4 { get; set; }
        public string Code5 { get; set; }
        public string Code6 { get; set; }
        public string Code7 { get; set; }
        public string Code8 { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string Notes { get; set; }
        public double Aantal { get; set; }
        public double Ekp { get; set; }
        public double Kp { get; set; }
        public double TotWinstpct { get; set; }
        public double Ewinst { get; set; }
        public double Evp { get; set; }
        public double Vp { get; set; }
        public bool? RegieYn { get; set; }
        public int Status { get; set; }
        public int? DigitsUnit { get; set; }
        public int? DigitsTotal { get; set; }
        public int? LineOrder { get; set; }
        public System.DateTime? Documentdatum { get; set; }
        public string Referentie { get; set; }
        public string ReferentieIntern { get; set; }
        public string FactuurNr { get; set; }
        public System.DateTime? FactuurDatum { get; set; }
        public bool? Goedgekeurd { get; set; }
        public long? ArtId { get; set; }
        public long? MagazijnId { get; set; }
        public long? StockMoveId { get; set; }
        public byte[] TimeStamp { get; set; }
        public long? WerfLijstId { get; set; }
        public long? SbLeveringDetailId { get; set; }
        public long? LeveradresId { get; set; }
        public int LineType { get; set; }
        public string NotesExtern { get; set; }
        public long? InkoopCatId { get; set; }
        public string NotesExternOa { get; set; }
        public int? CompanyId { get; set; }
        public long? AfmpuntId { get; set; }
        public CostHeaderEntity CostHeader { get; set; }
        public WerfEntity Werf { get; set; }
        public WerfLijstEntity WerfLijst { get; set; }
             
        partial void InitializePartial();
    }
}
