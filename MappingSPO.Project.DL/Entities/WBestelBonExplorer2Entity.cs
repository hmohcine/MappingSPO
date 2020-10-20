
namespace MappingSPO.Project.DL.Entities
{
    public partial class WBestelBonExplorer2Entity
    {
		public WBestelBonExplorer2Entity()
        {
            InitializePartial();
		}

        public long Sbid { get; set; }
        public string SbNrTxt { get; set; }
        public long? SbNr { get; set; }
        public int? Jaar { get; set; }
        public System.DateTime? Datum { get; set; }
        public System.DateTime? AskDeliveryDate { get; set; }
        public int Status { get; set; }
        public System.DateTime? CreateDate { get; set; }
        public string OrderbevestigingsNr { get; set; }
        public System.DateTime? VermoedelijkeLeverdatum { get; set; }
        public string Verantwoordelijke { get; set; }
        public string CreatedBy { get; set; }
        public string RefIntern { get; set; }
        public string RefExtrern { get; set; }
        public string Name { get; set; }
        public long? RelationId { get; set; }
        public string SupplierType { get; set; }
        public string SuplierName { get; set; }
        public string SupplierContact { get; set; }
        public string SuplierAdress1 { get; set; }
        public string SuplierAdress2 { get; set; }
        public string SuplierZipCode { get; set; }
        public string SuplierCity { get; set; }
        public string SuplierCountryCode { get; set; }
        public string SuplierCountry { get; set; }
        public bool? ExternalLocked { get; set; }
        public int BestelbonType { get; set; }
        public decimal? TotalPrice { get; set; }
        public double? Geleverd { get; set; }
        public double? Kost { get; set; }
        public decimal? Gefactureerd { get; set; }
        public string LanguageCode { get; set; }
        public int? TotalNumberOfPrints { get; set; }
        public System.DateTime? LastPrintDate { get; set; }
        public System.DateTime? LastChangedDate { get; set; }
        public string LastChangedBy { get; set; }
        public long? WerfId { get; set; }
        public string WerfTypeId { get; set; }
        public int? WerfYear { get; set; }
        public int? WerfNumber { get; set; }
        public string WerfName { get; set; }
        public string ProjectNrText { get; set; }
        public string ProjectName { get; set; }
        public string MasterProjectNr { get; set; }
        public string MasterProjectName { get; set; }
        public long? ProjectId { get; set; }
        public string ProjectType { get; set; }
             
        partial void InitializePartial();
    }
}
