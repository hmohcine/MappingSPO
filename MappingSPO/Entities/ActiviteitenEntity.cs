
namespace MappingSPO.Entities
{
    public partial class ActiviteitenEntity
    {
		public ActiviteitenEntity()
        {
            ShowAsMode = 0;
            AutoAddToWerfMode = 0;
            AfmeldingPuntTypes = new System.Collections.Generic.List<AfmeldingPuntTypeEntity>();
            Documents = new System.Collections.Generic.List<DocumentEntity>();
            Ks = new System.Collections.Generic.List<KsEntity>();
            RelActiviteits = new System.Collections.Generic.List<RelActiviteitEntity>();
            InitializePartial();
		}

        public long ActiviteitId { get; set; }
        public string Description { get; set; }
        public string ExternalCode { get; set; }
        public long? ActGroupId { get; set; }
        public string Code { get; set; }
        public int ShowAsMode { get; set; }
        public string ShowAs { get; set; }
        public string Notas { get; set; }
        public long? WerfId { get; set; }
        public string GpsRef { get; set; }
        public string ActiviteitEc { get; set; }
        public long? CalcId { get; set; }
        public long? CalcDetailId { get; set; }
        public int AutoAddToWerfMode { get; set; }
        public int? DefOpmetingsDefinitionId { get; set; }
        public System.Collections.Generic.ICollection<AfmeldingPuntTypeEntity> AfmeldingPuntTypes { get; set; }
        public System.Collections.Generic.ICollection<DocumentEntity> Documents { get; set; }
        public System.Collections.Generic.ICollection<KsEntity> Ks { get; set; }
        public System.Collections.Generic.ICollection<RelActiviteitEntity> RelActiviteits { get; set; }
        public ActiviteitGroupEntity ActiviteitGroup { get; set; }
        public UcEntity Uc { get; set; }
             
        partial void InitializePartial();
    }
}
