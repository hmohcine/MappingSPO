
namespace MappingSPO.Project.DL.Entities
{
    public partial class CalcImportTemplateEntity
    {
		public CalcImportTemplateEntity()
        {
            InitializePartial();
		}

        public long Id { get; set; }
        public string Name { get; set; }
        public string Template { get; set; }
             
        partial void InitializePartial();
    }
}
