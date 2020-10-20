
namespace MappingSPO.Project.DL.Entities
{
    public partial class WSearchBestelBonDetailEntity
    {
		public WSearchBestelBonDetailEntity()
        {
            InitializePartial();
		}

        public long Sbid { get; set; }
        public string SbNrTxt { get; set; }
        public long? SbNr { get; set; }
        public System.DateTime? Datum { get; set; }
        public int? Jaar { get; set; }
        public System.DateTime? AskDeliveryDate { get; set; }
        public long? RelationId { get; set; }
        public string RelationName { get; set; }
        public string RelationAdressLine1 { get; set; }
        public string RelationZipCode { get; set; }
        public string RelationCity { get; set; }
        public int Status { get; set; }
        public System.DateTime? CreateDate { get; set; }
        public string UserAlias { get; set; }
        public string OrderbevestigingsNr { get; set; }
        public System.DateTime? VermoedelijkeLeverdatum { get; set; }
        public long DetailId { get; set; }
        public int LineOrder { get; set; }
        public int LineType { get; set; }
        public double? Aantal { get; set; }
        public double? Prijs { get; set; }
        public double? Totaal { get; set; }
        public string Uc { get; set; }
        public string BestelCode { get; set; }
        public string Description { get; set; }
        public string Ks { get; set; }
        public long? LeveradresId { get; set; }
        public long? MagazijnId { get; set; }
        public string Code1 { get; set; }
        public string Code2 { get; set; }
        public string Code3 { get; set; }
        public string Code4 { get; set; }
        public string Code5 { get; set; }
        public string Code6 { get; set; }
        public string Code7 { get; set; }
        public string Code8 { get; set; }
        public double GeleverdAantal { get; set; }
        public double GeleverdBedrag { get; set; }
        public double GeleverdAantalInOntwerp { get; set; }
        public double GeleverdBedragInOntwerp { get; set; }
        public double? Televeren { get; set; }
        public string Magazijn { get; set; }
        public string LeverAdres { get; set; }
        public string Code { get; set; }
        public long? WerfId { get; set; }
        public string WerfName { get; set; }
        public string WerfNr { get; set; }
        public string Verantwoordelijke { get; set; }
        public string DefaultAddTypeText { get; set; }
        public int DefaultAddType { get; set; }
        public double? CostAantal { get; set; }
        public double? CostKp { get; set; }
        public long AddedOnLevering { get; set; }
        public string WerfTypeId { get; set; }
        public int? WerfYear { get; set; }
        public int? WerfNumber { get; set; }
        public string RefIntern { get; set; }
        public string RefExtrern { get; set; }
        public string Company { get; set; }
        public string ProjectNrText { get; set; }
        public long? ProjectId { get; set; }
        public string ProjectType { get; set; }
        public string ProjectName { get; set; }
        public string Domain { get; set; }
             
        partial void InitializePartial();
    }
}
