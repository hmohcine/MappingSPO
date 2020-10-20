
namespace MappingSPO.Entities
{
    public partial class ReportsDxFormLinkEntity
    {
		public ReportsDxFormLinkEntity()
        {
            LanguageDetemination = 0;
            Sequence = 0;
            IsDefaultReport = false;
            InitializePartial();
		}

        public long Id { get; set; }
        public System.Guid ReportId { get; set; }
        public System.Guid FormGuid { get; set; }
        public int LanguageDetemination { get; set; }
        public int Sequence { get; set; }
        public bool IsDefaultReport { get; set; }
        public ReportsDxEntity ReportsDx { get; set; }
             
        partial void InitializePartial();
    }
}
