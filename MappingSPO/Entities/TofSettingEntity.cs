
namespace MappingSPO.Entities
{
    public partial class TofSettingEntity
    {
		public TofSettingEntity()
        {
            SupplierIdRequired = true;
            ReferenceRequired = false;
            DescriptionRequired = false;
            EcRequired = true;
            KsRequired = true;
            InkoopCatIdRequired = false;
            InitializePartial();
		}

        public long Id { get; set; }
        public bool TofEnabled { get; set; }
        public bool SupplierIdRequired { get; set; }
        public bool ReferenceRequired { get; set; }
        public bool DescriptionRequired { get; set; }
        public bool EcRequired { get; set; }
        public bool KsRequired { get; set; }
        public bool InkoopCatIdRequired { get; set; }
             
        partial void InitializePartial();
    }
}
