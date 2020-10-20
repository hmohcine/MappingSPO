
namespace MappingSPO.Entities
{
    public partial class PrijsAntwoordSoortEntity
    {
		public PrijsAntwoordSoortEntity()
        {
            InitializePartial();
		}

        public long AntwoordSoortId { get; set; }
        public string Code { get; set; }
             
        partial void InitializePartial();
    }
}
