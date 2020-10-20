
namespace MappingSPO.Entities
{
    public partial class MobiliteitsCodeEntity
    {
		public MobiliteitsCodeEntity()
        {
            Employees = new System.Collections.Generic.List<EmployeeEntity>();
            MobiliteitsCodeTarievens = new System.Collections.Generic.List<MobiliteitsCodeTarievenEntity>();
            MobiliteitTariefDetails = new System.Collections.Generic.List<MobiliteitTariefDetailEntity>();
            InitializePartial();
		}

        public string Code { get; set; }
        public string Description { get; set; }
        public int? MasterType { get; set; }
        public System.Collections.Generic.ICollection<EmployeeEntity> Employees { get; set; }
        public System.Collections.Generic.ICollection<MobiliteitsCodeTarievenEntity> MobiliteitsCodeTarievens { get; set; }
        public System.Collections.Generic.ICollection<MobiliteitTariefDetailEntity> MobiliteitTariefDetails { get; set; }
             
        partial void InitializePartial();
    }
}
