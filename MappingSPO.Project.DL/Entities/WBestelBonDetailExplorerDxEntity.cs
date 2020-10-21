
namespace MappingSPO.Project.DL.Entities
{
    public partial class WBestelBonDetailExplorerDxEntity
    {
		public WBestelBonDetailExplorerDxEntity()
        {
            InitializePartial();
		}

        public long DetailId { get; set; }
        public long? Sbid { get; set; }
        public int LineOrder { get; set; }
        public int LineType { get; set; }
        public double? Prijs { get; set; }
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
        public string FullCode { get; set; }
        public long? WerfId { get; set; }
        public long AddedOnLevering { get; set; }
        public long? WerfLijstId { get; set; }
        public long? InkoopCatId { get; set; }
        public string InkoopCat { get; set; }
        public string InkoopCatGroup { get; set; }
        public string LeverancierRef { get; set; }
        public int? WerfState { get; set; }
        public string FullWerfNumber { get; set; }
        public string WerfName { get; set; }
        public string WerfLeider { get; set; }
        public string ProjectLeider { get; set; }
        public System.DateTime? StartDate { get; set; }
        public System.DateTime? EndDate { get; set; }
        public System.DateTime? VoorlopigeOpleveringsdatum { get; set; }
        public System.DateTime? DefinitieveOpleveringsdatum { get; set; }
        public long? ProjectId { get; set; }
        public string ProjectType { get; set; }
        public string ProjectNumber { get; set; }
        public string ProjectNaam { get; set; }
        public long? MasterProjectId { get; set; }
        public string MasterProjectType { get; set; }
        public string MasterProjectNumber { get; set; }
        public string MasterProjectName { get; set; }
        public string SbNrTxt { get; set; }
        public System.DateTime? Datum { get; set; }
        public System.DateTime? AskDeliveryDate { get; set; }
        public int Status { get; set; }
        public System.DateTime? CreateDate { get; set; }
        public string OrderbevestigingsNr { get; set; }
        public System.DateTime? VermoedelijkeLeverdatum { get; set; }
        public string Verantwoordelijke { get; set; }
        public string VerantwoordelijkeGsm { get; set; }
        public string Creator { get; set; }
        public string RefIntern { get; set; }
        public string RefExtrern { get; set; }
        public long? SupplierId { get; set; }
        public string SupplierName { get; set; }
        public string SupplierAdress1 { get; set; }
        public string SupplierAdress2 { get; set; }
        public string SupplierZip { get; set; }
        public string SupplierCity { get; set; }
        public string SupplierCountryCode { get; set; }
        public bool? ExternalLocked { get; set; }
        public System.DateTime? LastChangedDate { get; set; }
        public string LastChangedBy { get; set; }
        public long? DefaultWerfId { get; set; }
        public string ContactPerson { get; set; }
        public double? BesteldAantal { get; set; }
        public double? Besteld { get; set; }
        public double? GeleverdAantal { get; set; }
        public double? Geleverd { get; set; }
        public double? GeleverdAndUsedAantal { get; set; }
        public double? GeleverdAndUsed { get; set; }
        public string Activiteit { get; set; }
        public string Activiteitgroup { get; set; }
        public int? CompanyId { get; set; }
        public string Company { get; set; }
        public int BestelBonType { get; set; }
        public string LanguageCode { get; set; }
             
        partial void InitializePartial();
    }
}
