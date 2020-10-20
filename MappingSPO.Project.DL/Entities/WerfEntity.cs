
namespace MappingSPO.Project.DL.Entities
{
    public partial class WerfEntity
    {
		public WerfEntity()
        {
            WerfState = 0;
            WithPrijsHerziening = -1;
            VordStructModeStaat1 = 0;
            VordStructModeStaat2 = 0;
            VordStructModeStaat3 = 0;
            VordPostMode1 = 0;
            VordDetailMode = 0;
            VordHerzieningMode = 0;
            VordSamenvattingMode = 0;
            VordSchuldVorderingMode = 0;
            VordPostMode2 = 0;
            VordPostMode3 = 0;
            VordShowSubTotalsOnHfst = false;
            Domain = "C";
            CostDetailCores = new System.Collections.Generic.List<CostDetailCoreEntity>();
            CostHeaders = new System.Collections.Generic.List<CostHeaderEntity>();
            ProjectWerfs = new System.Collections.Generic.List<ProjectWerfEntity>();
            TodoItems = new System.Collections.Generic.List<TodoItemEntity>();
            WerfInvoiceAdresses = new System.Collections.Generic.List<WerfInvoiceAdressEntity>();
            WerfRelations = new System.Collections.Generic.List<WerfRelationEntity>();
            WerfVoorraads = new System.Collections.Generic.List<WerfVoorraadEntity>();
            Werfs_ContractWerfId = new System.Collections.Generic.List<WerfEntity>();
            Werfs_WerfId = new System.Collections.Generic.List<WerfEntity>();
            WerfMultiAnaCodes = new System.Collections.Generic.List<WerfMultiAnaCodeEntity>();
            InitializePartial();
		}

        public long WerfId { get; set; }
        public int WerfState { get; set; }
        public string WerfTypeId { get; set; }
        public int WerfYear { get; set; }
        public int WerfNumber { get; set; }
        public string WerfName { get; set; }
        public string NotesInternal { get; set; }
        public string NotesExternal { get; set; }
        public int? Code1 { get; set; }
        public int? Code2 { get; set; }
        public int? Code3 { get; set; }
        public int? Code4 { get; set; }
        public int? Code5 { get; set; }
        public int? Code6 { get; set; }
        public int? Code7 { get; set; }
        public int? Code8 { get; set; }
        public System.DateTime? CreatedDate { get; set; }
        public System.DateTime? StartDate { get; set; }
        public System.DateTime? EndDate { get; set; }
        public int ExtentionShowOverOnPart { get; set; }
        public int OfferShowOnPart { get; set; }
        public int OfferShowOverOnPart { get; set; }
        public int ExtentionShowOnPart { get; set; }
        public long? DefaultInvoiceAdressId { get; set; }
        public int WerfCategory { get; set; }
        public int? Creator { get; set; }
        public int? CompanyId { get; set; }
        public int FacturationMode { get; set; }
        public int WithPrijsHerziening { get; set; }
        public int VordStructModeStaat1 { get; set; }
        public int VordStructModeStaat2 { get; set; }
        public int VordStructModeStaat3 { get; set; }
        public int VordPostMode1 { get; set; }
        public int VordDetailMode { get; set; }
        public int VordHerzieningMode { get; set; }
        public int VordSamenvattingMode { get; set; }
        public int VordSchuldVorderingMode { get; set; }
        public int VordPostMode2 { get; set; }
        public int VordPostMode3 { get; set; }
        public int? WerfAdresContactId { get; set; }
        public long? WerfAdresRelationId { get; set; }
        public int? WerfAdresRelationTypeId { get; set; }
        public long? WerfAdresWerfId { get; set; }
        public string PathDocsFileSystem { get; set; }
        public bool? DefaultRegieYn { get; set; }
        public int? Werfleider { get; set; }
        public int? ProjectLeider { get; set; }
        public double? BegrotingPct { get; set; }
        public string UriWebSystem { get; set; }
        public string Ref1 { get; set; }
        public string Ref2 { get; set; }
        public string Ref3 { get; set; }
        public string Ref4 { get; set; }
        public long? DefaultMagazijnId { get; set; }
        public long? DefaultLeveradresId { get; set; }
        public int? AddPostenToVordMode { get; set; }
        public long? WerfadresId { get; set; }
        public int? DefaultBtwRegime { get; set; }
        public int? DefaultVatCode { get; set; }
        public double? AfstandWerfInKm { get; set; }
        public double? TotVergoedingPassagier { get; set; }
        public double? TotVergoedingBestuurder { get; set; }
        public int? DuurVerificatieTermijn { get; set; }
        public decimal? VerwijlIntrestRentevoet { get; set; }
        public string ExtNumber { get; set; }
        public bool? CheckInAtWorkYn { get; set; }
        public string CExtNumber { get; private set; }
        public bool? VordShowSubTotalsOnHfst { get; set; }
        public double? ExtraNum1 { get; set; }
        public double? ExtraNum2 { get; set; }
        public double? ExtraNum3 { get; set; }
        public double? ExtraNum4 { get; set; }
        public double? ExtraNum5 { get; set; }
        public double? ExtraNum6 { get; set; }
        public double? ExtraNum7 { get; set; }
        public double? ExtraNum8 { get; set; }
        public int? VordShowCncMode { get; set; }
        public int? VordShowDigitsUnits { get; set; }
        public int? VordShowDigitsEprijs { get; set; }
        public int? VordShowDigitsPrijs { get; set; }
        public System.DateTime? VoorlopigeOpleveringsdatum { get; set; }
        public System.DateTime? DefinitieveOpleveringsdatum { get; set; }
        public string Domain { get; set; }
        public System.DateTime? ExtraDate1 { get; set; }
        public System.DateTime? ExtraDate2 { get; set; }
        public System.DateTime? ExtraDate3 { get; set; }
        public System.DateTime? ExtraDate4 { get; set; }
        public System.DateTime? ExtraDate5 { get; set; }
        public System.DateTime? ExtraDate6 { get; set; }
        public System.DateTime? ExtraDate7 { get; set; }
        public System.DateTime? ExtraDate8 { get; set; }
        public long? DefaultVerkoopCat { get; set; }
        public int? PlanningsMode { get; set; }
        public long? BsMagazijnId { get; set; }
        public long? BsToonzaalId { get; set; }
        public System.Collections.Generic.ICollection<CostDetailCoreEntity> CostDetailCores { get; set; }
        public System.Collections.Generic.ICollection<CostHeaderEntity> CostHeaders { get; set; }
        public System.Collections.Generic.ICollection<ProjectWerfEntity> ProjectWerfs { get; set; }
        public System.Collections.Generic.ICollection<TodoItemEntity> TodoItems { get; set; }
        public System.Collections.Generic.ICollection<WerfEntity> Werfs_ContractWerfId { get; set; }
        public System.Collections.Generic.ICollection<WerfEntity> Werfs_WerfId { get; set; }
        public System.Collections.Generic.ICollection<WerfInvoiceAdressEntity> WerfInvoiceAdresses { get; set; }
        public System.Collections.Generic.ICollection<WerfMultiAnaCodeEntity> WerfMultiAnaCodes { get; set; }
        public System.Collections.Generic.ICollection<WerfRelationEntity> WerfRelations { get; set; }
        public System.Collections.Generic.ICollection<WerfVoorraadEntity> WerfVoorraads { get; set; }
        public WerfInvoiceAdressEntity WerfInvoiceAdress { get; set; }
        public WerfRelationEntity WerfRelation { get; set; }
             
        partial void InitializePartial();
    }
}
