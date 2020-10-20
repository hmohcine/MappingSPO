
namespace MappingSPO.Project.DL.Entities
{
    public partial class CostHeaderEntity
    {
		public CostHeaderEntity()
        {
            CostDetailCores = new System.Collections.Generic.List<CostDetailCoreEntity>();
            InitializePartial();
		}

        public long Id { get; set; }
        public string CostHeaderType { get; set; }
        public System.DateTime? DefaultDocumentdatum { get; set; }
        public System.DateTime? IngaveDatum { get; set; }
        public string Documentnummer { get; set; }
        public long? RelationId { get; set; }
        public int? ContactId { get; set; }
        public string DefaultReferentie { get; set; }
        public long? DefaultActiviteitId { get; set; }
        public long? DefaultWerfId { get; set; }
        public string DefaultKs { get; set; }
        public string Notes { get; set; }
        public int? Verantwoordelijke { get; set; }
        public System.DateTime? CreateDate { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime? LastChangedDate { get; set; }
        public int LastChangedBy { get; set; }
        public int? CostNrYear { get; set; }
        public long? CostNr { get; set; }
        public bool? DefaultRegieYn { get; set; }
        public string DefaultReferentieIntern { get; set; }
        public long? SbLeveringId { get; set; }
        public string NotesExternal { get; set; }
        public string NotesExternal2 { get; set; }
        public string NotesInternal { get; set; }
        public long? DefaultLeveradresId { get; set; }
        public long? DefaultMagazijnId { get; set; }
        public int? RelationTypeId { get; set; }
        public long? AnaCodeId { get; set; }
        public long? DefaultInkoopCatId { get; set; }
        public int? DefaultCompanyId { get; set; }
        public System.Collections.Generic.ICollection<CostDetailCoreEntity> CostDetailCores { get; set; }
        public ContactEntity Contact { get; set; }
        public CostHeaderTypeEntity CostHeaderType_CostHeaderType { get; set; }
        public RelationEntity Relation { get; set; }
        public WerfEntity Werf { get; set; }
             
        partial void InitializePartial();
    }
}
