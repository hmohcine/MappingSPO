
namespace MappingSPO.Project.DL.Entities
{
    public partial class WKostenEntity
    {
		public WKostenEntity()
        {
            InitializePartial();
		}

        public long DetailId { get; set; }
        public long CostHeaderId { get; set; }
        public string CostHeaderType { get; set; }
        public int MasterType { get; set; }
        public string CostHeaderTypeDescription { get; set; }
        public System.DateTime? IngaveDatum { get; set; }
        public string Documentnummer { get; set; }
        public string VerantwIngave { get; set; }
        public string Relation { get; set; }
        public int? Kg { get; set; }
        public string WerfName { get; set; }
        public string WerfNummer { get; set; }
        public long? WerfId { get; set; }
        public string WerfLeider { get; set; }
        public string Ks { get; set; }
        public string Activiteit { get; set; }
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
        public double Evp { get; set; }
        public double Vp { get; set; }
        public bool? RegieYn { get; set; }
        public int Status { get; set; }
        public int? LineOrder { get; set; }
        public System.DateTime? Documentdatum { get; set; }
        public string Referentie { get; set; }
        public string ReferentieIntern { get; set; }
        public string FactuurNr { get; set; }
        public System.DateTime? FactuurDatum { get; set; }
        public bool Goedgekeurd { get; set; }
        public int? ArbeiderId { get; set; }
        public string WerkCode { get; set; }
        public string MobiliteitsCode { get; set; }
        public System.DateTime? StartUur { get; set; }
        public System.DateTime? EindUur { get; set; }
        public long? RustTijd { get; set; }
        public long? LaadLosTijd { get; set; }
        public long? ExtraTijd { get; set; }
        public string Arbeider { get; set; }
        public long? WerfLijstId { get; set; }
        public long? ArtId { get; set; }
        public long? MagazijnId { get; set; }
        public string BestelBonNr { get; set; }
        public System.DateTime? BestelBonDatum { get; set; }
        public double? BestelAantal { get; set; }
        public double? BestelPrijs { get; set; }
        public double? LeverAantal { get; set; }
        public double? LeverPrijs { get; set; }
        public int? LeveringNr { get; set; }
        public System.DateTime? LeveringDatum { get; set; }
        public double? AfstandWerfInKm { get; set; }
        public double? TotVergoedingPassagier { get; set; }
        public double? TotVergoedingBestuurder { get; set; }
        public int? MobiliteitMasterType { get; set; }
        public long? SbLeveringId { get; set; }
        public long? Sbid { get; set; }
        public long? SbLeveringDetailId { get; set; }
        public int? CostNrYear { get; set; }
        public long? CostNr { get; set; }
        public string WerfTypeId { get; set; }
        public int? WerfYear { get; set; }
        public int? WerfNumber { get; set; }
        public int? BbYear { get; set; }
        public long? SbNr { get; set; }
        public int? ProjectYear { get; set; }
        public int? ProjectNumber { get; set; }
        public string ProjectNrText { get; set; }
        public string ProjectName { get; set; }
        public long? InkoopCatId { get; set; }
        public string Domain { get; set; }
        public long? ContractId { get; set; }
        public string ProjectType { get; set; }
        public long? ProjectId { get; set; }
        public long? RelationId { get; set; }
        public int? CompanyId { get; set; }
             
        partial void InitializePartial();
    }
}
