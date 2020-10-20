
namespace MappingSPO.Project.DL.Entities
{
    public partial class WBestelbonExplorerDxEntity
    {
		public WBestelbonExplorerDxEntity()
        {
            InitializePartial();
		}

        public long Sbid { get; set; }
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
        public int BestelBonType { get; set; }
        public decimal? TotalPrice { get; set; }
        public decimal? Geleverd { get; set; }
        public decimal? GeleverdAndUsed { get; set; }
        public decimal? Gefactureerd { get; set; }
        public string LanguageCode { get; set; }
        public int? TotalNumberOfPrints { get; set; }
        public System.DateTime? LastPrintDate { get; set; }
        public System.DateTime? LastChangedDate { get; set; }
        public string LastChangedBy { get; set; }
        public long? DefaultWerfId { get; set; }
        public string Domain { get; set; }
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
        public string ContactPerson { get; set; }
        public string InkoopCats { get; set; }
        public string InkoopCatGroups { get; set; }
        public string Company { get; set; }
        public bool IsRetour { get; set; }
             
        partial void InitializePartial();
    }
}
