
namespace MappingSPO.Entities
{
    public partial class UcEntity
    {
		public UcEntity()
        {
            IsExtendedUc = false;
            Activiteitens = new System.Collections.Generic.List<ActiviteitenEntity>();
            ArticleDefaults_DefaultEc = new System.Collections.Generic.List<ArticleDefaultEntity>();
            ArticleDefaults_DefaultEcGewicht = new System.Collections.Generic.List<ArticleDefaultEntity>();
            ArticleDefaults_DefaultEcVolume = new System.Collections.Generic.List<ArticleDefaultEntity>();
            Employees_BasisLoonEc = new System.Collections.Generic.List<EmployeeEntity>();
            Employees_LoonCostEc = new System.Collections.Generic.List<EmployeeEntity>();
            IncomingInvoiceSettings = new System.Collections.Generic.List<IncomingInvoiceSettingEntity>();
            OpmetingDefinitions_Uc = new System.Collections.Generic.List<OpmetingDefinitionEntity>();
            OpmetingDefinitions_Uc1 = new System.Collections.Generic.List<OpmetingDefinitionEntity>();
            OpmetingDefinitions_Uc2 = new System.Collections.Generic.List<OpmetingDefinitionEntity>();
            OpmetingDefinitions_Uc3 = new System.Collections.Generic.List<OpmetingDefinitionEntity>();
            OpmetingDefinitions_Uc4 = new System.Collections.Generic.List<OpmetingDefinitionEntity>();
            OpmetingDefinitions_Uc5 = new System.Collections.Generic.List<OpmetingDefinitionEntity>();
            OpmetingDefinitions_Uc6 = new System.Collections.Generic.List<OpmetingDefinitionEntity>();
            UcUcs_Uc = new System.Collections.Generic.List<UcUcEntity>();
            UcUcs_UcParent = new System.Collections.Generic.List<UcUcEntity>();
            WholesalerUnitcodes = new System.Collections.Generic.List<WholesalerUnitcodeEntity>();
            InitializePartial();
		}

        public string Uc_ { get; set; }
        public string Description { get; set; }
        public bool IsExtendedUc { get; set; }
        public int? RangOrder { get; set; }
        public int? UcGroupId { get; set; }
        public bool? IsVerpakking { get; set; }
        public System.Collections.Generic.ICollection<ActiviteitenEntity> Activiteitens { get; set; }
        public System.Collections.Generic.ICollection<ArticleDefaultEntity> ArticleDefaults_DefaultEc { get; set; }
        public System.Collections.Generic.ICollection<ArticleDefaultEntity> ArticleDefaults_DefaultEcGewicht { get; set; }
        public System.Collections.Generic.ICollection<ArticleDefaultEntity> ArticleDefaults_DefaultEcVolume { get; set; }
        public System.Collections.Generic.ICollection<EmployeeEntity> Employees_BasisLoonEc { get; set; }
        public System.Collections.Generic.ICollection<EmployeeEntity> Employees_LoonCostEc { get; set; }
        public System.Collections.Generic.ICollection<IncomingInvoiceSettingEntity> IncomingInvoiceSettings { get; set; }
        public System.Collections.Generic.ICollection<OpmetingDefinitionEntity> OpmetingDefinitions_Uc { get; set; }
        public System.Collections.Generic.ICollection<OpmetingDefinitionEntity> OpmetingDefinitions_Uc1 { get; set; }
        public System.Collections.Generic.ICollection<OpmetingDefinitionEntity> OpmetingDefinitions_Uc2 { get; set; }
        public System.Collections.Generic.ICollection<OpmetingDefinitionEntity> OpmetingDefinitions_Uc3 { get; set; }
        public System.Collections.Generic.ICollection<OpmetingDefinitionEntity> OpmetingDefinitions_Uc4 { get; set; }
        public System.Collections.Generic.ICollection<OpmetingDefinitionEntity> OpmetingDefinitions_Uc5 { get; set; }
        public System.Collections.Generic.ICollection<OpmetingDefinitionEntity> OpmetingDefinitions_Uc6 { get; set; }
        public System.Collections.Generic.ICollection<UcUcEntity> UcUcs_Uc { get; set; }
        public System.Collections.Generic.ICollection<UcUcEntity> UcUcs_UcParent { get; set; }
        public System.Collections.Generic.ICollection<WholesalerUnitcodeEntity> WholesalerUnitcodes { get; set; }
             
        partial void InitializePartial();
    }
}
