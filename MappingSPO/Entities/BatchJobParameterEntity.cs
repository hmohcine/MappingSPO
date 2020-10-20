
namespace MappingSPO.Entities
{
    public partial class BatchJobParameterEntity
    {
		public BatchJobParameterEntity()
        {
            InitializePartial();
		}

        public long Id { get; set; }
        public long BatchJobId { get; set; }
        public string ParamKey { get; set; }
        public string ParamValue { get; set; }
        public BatchJobEntity BatchJob { get; set; }
             
        partial void InitializePartial();
    }
}
