
namespace MappingSPO.Entities
{
    public partial class AfmeldingPuntTypeEntity
    {
		public AfmeldingPuntTypeEntity()
        {
            AutoNumberYn = false;
            AfmeldingsPuntens = new System.Collections.Generic.List<AfmeldingsPuntenEntity>();
            InitializePartial();
		}

        public int AfmpuntType { get; set; }
        public string Description { get; set; }
        public string PrefixCode { get; set; }
        public bool AutoNumberYn { get; set; }
        public int? NumberOfDigits { get; set; }
        public long? ActivityId { get; set; }
        public System.Collections.Generic.ICollection<AfmeldingsPuntenEntity> AfmeldingsPuntens { get; set; }
        public ActiviteitenEntity Activiteiten { get; set; }
             
        partial void InitializePartial();
    }
}
