
namespace MappingSPO.Entities
{
    public partial class AfmeldingsPuntenEntity
    {
		public AfmeldingsPuntenEntity()
        {
            AutoAddToWerfMode = 0;
            Afdelings = new System.Collections.Generic.List<AfdelingEntity>();
            InitializePartial();
		}

        public long AfmpuntId { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public int ShowAsMode { get; set; }
        public string ShowAs { get; set; }
        public long? ActiviteitId { get; set; }
        public long? WerfId { get; set; }
        public string Notes { get; set; }
        public string GpsRef { get; set; }
        public int AfmpuntType { get; set; }
        public int AutoAddToWerfMode { get; set; }
        public int? AutoNumber { get; set; }
        public System.Collections.Generic.ICollection<AfdelingEntity> Afdelings { get; set; }
        public AfmeldingPuntTypeEntity AfmeldingPuntType { get; set; }
             
        partial void InitializePartial();
    }
}
