
namespace MappingSPO.Project.DL.Entities
{
    public partial class WCostExplorerDxEntity
    {
		public WCostExplorerDxEntity()
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
        public string VerantwoordelijkeIngave { get; set; }
        public string VerantwoordelijkeIngaveGsm { get; set; }
        public long? RelationId { get; set; }
        public string SupplierName { get; set; }
        public string SupplierAdressLine1 { get; set; }
        public string SupplierAdressLine2 { get; set; }
        public string SupplierZip { get; set; }
        public string SupplierCity { get; set; }
        public string SupplierCountryCode { get; set; }
        public int? ContactId { get; set; }
        public string ContactName { get; set; }
        public long? WerfId { get; set; }
        public int? WerfState { get; set; }
        public string FullWerfNumber { get; set; }
        public string WerfName { get; set; }
        public string WerfLeider { get; set; }
        public string ProjectLeider { get; set; }
        public long? ProjectId { get; set; }
        public string ProjectType { get; set; }
        public string ProjectNumber { get; set; }
        public string ProjectNaam { get; set; }
        public long? MasterProjectId { get; set; }
        public string MasterProjectType { get; set; }
        public string MasterProjectNumber { get; set; }
        public string MasterProjectName { get; set; }
        public string Ks { get; set; }
        public int? Kg { get; set; }
        public string Activiteit { get; set; }
        public string ActiviteitGroup { get; set; }
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
        public double Aantal { get; set; }
        public double Ekp { get; set; }
        public double Kp { get; set; }
        public double Evp { get; set; }
        public double Vp { get; set; }
        public bool? RegieYn { get; set; }
        public int Status { get; set; }
        public System.DateTime? Documentdatum { get; set; }
        public string Referentie { get; set; }
        public string ReferentieIntern { get; set; }
        public string FactuurNr { get; set; }
        public System.DateTime? FactuurDatum { get; set; }
        public bool? Goedgekeurd { get; set; }
        public string InkoopCat { get; set; }
        public string InkoopCatGroup { get; set; }
        public string Company { get; set; }
        public string AfmeldingsPunt { get; set; }
        public string EmpName { get; set; }
        public string WerkCode { get; set; }
        public string WerkCodeDescription { get; set; }
        public bool? IsWerkend { get; set; }
        public string WerkCodeExtern { get; set; }
        public string MobiliteitsCode { get; set; }
        public string Mobiliteit { get; set; }
        public System.DateTime? StartUur { get; set; }
        public System.DateTime? EindUur { get; set; }
        public long? RustTijd { get; set; }
        public long? LaadLosTijd { get; set; }
        public long? ExtraTijd { get; set; }
        public long? ContractId { get; set; }
        public System.DateTime? StartDate { get; set; }
        public System.DateTime? EndDate { get; set; }
        public System.DateTime? VoorlopigeOpleveringsdatum { get; set; }
        public System.DateTime? DefinitieveOpleveringsdatum { get; set; }
        public string SupplierLanguage { get; set; }
             
        partial void InitializePartial();
    }
}
