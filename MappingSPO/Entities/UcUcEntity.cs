
namespace MappingSPO.Entities
{
    public partial class UcUcEntity
    {
		public UcUcEntity()
        {
            Factor = 1;
            InitializePartial();
		}

        public string UcParent { get; set; }
        public string Uc { get; set; }
        public double? Factor { get; set; }
        public UcEntity Uc_Uc { get; set; }
        public UcEntity Uc_UcParent { get; set; }
             
        partial void InitializePartial();
    }
}
