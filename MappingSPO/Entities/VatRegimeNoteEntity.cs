
namespace MappingSPO.Entities
{
    public partial class VatRegimeNoteEntity
    {
		public VatRegimeNoteEntity()
        {
            InitializePartial();
		}

        public int BtwRegime { get; set; }
        public string LanguageCode { get; set; }
        public string Code { get; set; }
        public string NotesVat { get; set; }
        public LanguageEntity Language { get; set; }
        public VatRegimeEntity VatRegime { get; set; }
             
        partial void InitializePartial();
    }
}
