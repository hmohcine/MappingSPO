using MappingSPO.Project.DL.Entities;

namespace MappingSPO.Project.DL
{
    using MappingSPO.Project.DL.Configurations;
    using MappingSPO.Project.DL.Contracts;
    using System.Linq;

    public partial class ProjectContext : System.Data.Entity.DbContext, IProjectContext
    {
        public System.Data.Entity.DbSet<BibUserEntity> BibUsers { get; set; }
        public System.Data.Entity.DbSet<CalcActiviteitenEntity> CalcActiviteitens { get; set; }
        public System.Data.Entity.DbSet<CalcAddTemplateEntity> CalcAddTemplates { get; set; }
        public System.Data.Entity.DbSet<CalcCode1Entity> CalcCode1 { get; set; }
        public System.Data.Entity.DbSet<CalcCode2Entity> CalcCode2 { get; set; }
        public System.Data.Entity.DbSet<CalcCode3Entity> CalcCode3 { get; set; }
        public System.Data.Entity.DbSet<CalcCode4Entity> CalcCode4 { get; set; }
        public System.Data.Entity.DbSet<CalcCode5Entity> CalcCode5 { get; set; }
        public System.Data.Entity.DbSet<CalcCode6Entity> CalcCode6 { get; set; }
        public System.Data.Entity.DbSet<CalcCode7Entity> CalcCode7 { get; set; }
        public System.Data.Entity.DbSet<CalcCode8Entity> CalcCode8 { get; set; }
        public System.Data.Entity.DbSet<CalcDetailEntity> CalcDetails { get; set; }
        public System.Data.Entity.DbSet<CalcDetailParameterValueEntity> CalcDetailParameterValues { get; set; }
        public System.Data.Entity.DbSet<CalcFilterEntity> CalcFilters { get; set; }
        public System.Data.Entity.DbSet<CalcHcEntity> CalcHcs { get; set; }
        public System.Data.Entity.DbSet<CalcImportTemplateEntity> CalcImportTemplates { get; set; }
        public System.Data.Entity.DbSet<CalcInkoopCategorieEntity> CalcInkoopCategories { get; set; }
        public System.Data.Entity.DbSet<CalcKEntity> CalcKs { get; set; }
        public System.Data.Entity.DbSet<CalcLibraryEntity> CalcLibraries { get; set; }
        public System.Data.Entity.DbSet<CalcLineTypeEntity> CalcLineTypes { get; set; }
        public System.Data.Entity.DbSet<CalcLogbookEntity> CalcLogbooks { get; set; }
        public System.Data.Entity.DbSet<CalcOfferClientEntity> CalcOfferClients { get; set; }
        public System.Data.Entity.DbSet<CalcParameterValueEntity> CalcParameterValues { get; set; }
        public System.Data.Entity.DbSet<CalcPropertyEntity> CalcProperties { get; set; }
        public System.Data.Entity.DbSet<CalcRelationEntity> CalcRelations { get; set; }
        public System.Data.Entity.DbSet<CalcRelationContactEntity> CalcRelationContacts { get; set; }
        public System.Data.Entity.DbSet<CalcStatusHistoriekEntity> CalcStatusHistorieks { get; set; }
        public System.Data.Entity.DbSet<CalcTextenEntity> CalcTextens { get; set; }
        public System.Data.Entity.DbSet<CalcTransactionEntity> CalcTransactions { get; set; }
        public System.Data.Entity.DbSet<CalcTransactionPostEntity> CalcTransactionPosts { get; set; }
        public System.Data.Entity.DbSet<CalcTransactionPostArticleEntity> CalcTransactionPostArticles { get; set; }
        public System.Data.Entity.DbSet<CalcTransIndirectPostEntity> CalcTransIndirectPosts { get; set; }
        public System.Data.Entity.DbSet<CalcTypeEntity> CalcTypes { get; set; }
        public System.Data.Entity.DbSet<CalculationEntity> Calculations { get; set; }
        public System.Data.Entity.DbSet<CalculationLogEntity> CalculationLogs { get; set; }
        public System.Data.Entity.DbSet<CalculationVersionEntity> CalculationVersions { get; set; }
        public System.Data.Entity.DbSet<ContactEntity> Contacts { get; set; }
        public System.Data.Entity.DbSet<CostDetailCoreEntity> CostDetailCores { get; set; }
        public System.Data.Entity.DbSet<CostHeaderEntity> CostHeaders { get; set; }
        public System.Data.Entity.DbSet<CostHeaderTypeEntity> CostHeaderTypes { get; set; }
        public System.Data.Entity.DbSet<LinkedTeamProjectEntity> LinkedTeamProjects { get; set; }
        public System.Data.Entity.DbSet<OpmetingFormulaEntity> OpmetingFormulas { get; set; }
        public System.Data.Entity.DbSet<OpmetingFormulaDetailEntity> OpmetingFormulaDetails { get; set; }
        public System.Data.Entity.DbSet<ParameterBibEntity> ParameterBibs { get; set; }
        public System.Data.Entity.DbSet<ParameterDefinitionEntity> ParameterDefinitions { get; set; }
        public System.Data.Entity.DbSet<ProjectEntity> Projects { get; set; }
        public System.Data.Entity.DbSet<ProjectCalculationEntity> ProjectCalculations { get; set; }
        public System.Data.Entity.DbSet<ProjectDocumentEntity> ProjectDocuments { get; set; }
        public System.Data.Entity.DbSet<ProjectRelationEntity> ProjectRelations { get; set; }
        public System.Data.Entity.DbSet<ProjectRelationContactEntity> ProjectRelationContacts { get; set; }
        public System.Data.Entity.DbSet<ProjectSubProjectEntity> ProjectSubProjects { get; set; }
        public System.Data.Entity.DbSet<ProjectUnitEntity> ProjectUnits { get; set; }
        public System.Data.Entity.DbSet<ProjectWerfEntity> ProjectWerfs { get; set; }
        public System.Data.Entity.DbSet<RelationEntity> Relations { get; set; }
        public System.Data.Entity.DbSet<RelationTypeEntity> RelationTypes { get; set; }
        public System.Data.Entity.DbSet<SbDetailEntity> SbDetails { get; set; }
        public System.Data.Entity.DbSet<SupplierPrijsAntwoordEntity> SupplierPrijsAntwoords { get; set; }
        public System.Data.Entity.DbSet<SysCalculationParaEntity> SysCalculationParas { get; set; }
        public System.Data.Entity.DbSet<SysProjectSettingEntity> SysProjectSettings { get; set; }
        public System.Data.Entity.DbSet<SysWerfParaEntity> SysWerfParas { get; set; }
        public System.Data.Entity.DbSet<TodoItemEntity> TodoItems { get; set; }
        public System.Data.Entity.DbSet<UsersGroepEntity> UsersGroeps { get; set; }
        public System.Data.Entity.DbSet<UserUserGroupEntity> UserUserGroups { get; set; }
        public System.Data.Entity.DbSet<WBestelBonDetailExplorerDxEntity> WBestelBonDetailExplorerDxes { get; set; }
        public System.Data.Entity.DbSet<WBestelBonExplorer2Entity> WBestelBonExplorer2 { get; set; }
        public System.Data.Entity.DbSet<WBestelbonExplorerDxEntity> WBestelbonExplorerDxes { get; set; }
        public System.Data.Entity.DbSet<WCalculationExplorer2Entity> WCalculationExplorer2 { get; set; }
        public System.Data.Entity.DbSet<WCalculationExplorerDxEntity> WCalculationExplorerDxes { get; set; }
        public System.Data.Entity.DbSet<WCalculationInkoopCatEntity> WCalculationInkoopCats { get; set; }
        public System.Data.Entity.DbSet<WContractExplorerEntity> WContractExplorers { get; set; }
        public System.Data.Entity.DbSet<WContractOaExplorerDxEntity> WContractOaExplorerDxes { get; set; }
        public System.Data.Entity.DbSet<WCostExplorerDxEntity> WCostExplorerDxes { get; set; }
        public System.Data.Entity.DbSet<WerfEntity> Werfs { get; set; }
        public System.Data.Entity.DbSet<WerfActiviteitenLinkDataEntity> WerfActiviteitenLinkDatas { get; set; }
        public System.Data.Entity.DbSet<WerfInvoiceAdressEntity> WerfInvoiceAdresses { get; set; }
        public System.Data.Entity.DbSet<WerfLijstEntity> WerfLijsts { get; set; }
        public System.Data.Entity.DbSet<WerfMultiAnaCodeEntity> WerfMultiAnaCodes { get; set; }
        public System.Data.Entity.DbSet<WerfRelationEntity> WerfRelations { get; set; }
        public System.Data.Entity.DbSet<WerfVoorraadEntity> WerfVoorraads { get; set; }
        public System.Data.Entity.DbSet<WerfVorderingInvoiceEntity> WerfVorderingInvoices { get; set; }
        public System.Data.Entity.DbSet<WKostenEntity> WKostens { get; set; }
        public System.Data.Entity.DbSet<WMasterProjectExplorerDxEntity> WMasterProjectExplorerDxes { get; set; }
        public System.Data.Entity.DbSet<WPrijsAntwoordExplorerDxEntity> WPrijsAntwoordExplorerDxes { get; set; }
        public System.Data.Entity.DbSet<WPrijsVraagExplorerDxEntity> WPrijsVraagExplorerDxes { get; set; }
        public System.Data.Entity.DbSet<WProjectExplorerEntity> WProjectExplorers { get; set; }
        public System.Data.Entity.DbSet<WProjectExplorerDxEntity> WProjectExplorerDxes { get; set; }
        public System.Data.Entity.DbSet<WProjectPrijslijstExpolorerEntity> WProjectPrijslijstExpolorers { get; set; }
        public System.Data.Entity.DbSet<WProjectRelationsDxEntity> WProjectRelationsDxes { get; set; }
        public System.Data.Entity.DbSet<WProjectUnitExplorerDxEntity> WProjectUnitExplorerDxes { get; set; }
        public System.Data.Entity.DbSet<WSearchBestelBonDetailEntity> WSearchBestelBonDetails { get; set; }
        public System.Data.Entity.DbSet<WShareAtWorkWerfInfoEntity> WShareAtWorkWerfInfoes { get; set; }
        public System.Data.Entity.DbSet<WTodoExplorerEntity> WTodoExplorers { get; set; }
        public System.Data.Entity.DbSet<WUserEntity> WUsers { get; set; }
        public System.Data.Entity.DbSet<WWerfExplorerEntity> WWerfExplorers { get; set; }
        public System.Data.Entity.DbSet<WWerfExplorerDxEntity> WWerfExplorerDxes { get; set; }

        static ProjectContext()
        {
            System.Data.Entity.Database.SetInitializer<ProjectContext>(null);
        }

        public ProjectContext()
            : base("Name=DevConnection")
        {
            InitializePartial();
        }

        public ProjectContext(string connectionString)
            : base(connectionString)
        {
            InitializePartial();
        }

        public ProjectContext(string connectionString, System.Data.Entity.Infrastructure.DbCompiledModel model)
            : base(connectionString, model)
        {
            InitializePartial();
        }

        public ProjectContext(System.Data.Common.DbConnection existingConnection, bool contextOwnsConnection)
            : base(existingConnection, contextOwnsConnection)
        {
            InitializePartial();
        }

        public ProjectContext(System.Data.Common.DbConnection existingConnection, System.Data.Entity.Infrastructure.DbCompiledModel model, bool contextOwnsConnection)
            : base(existingConnection, model, contextOwnsConnection)
        {
            InitializePartial();
        }

        public ProjectContext(System.Data.Entity.Core.Objects.ObjectContext objectContext, bool dbContextOwnsObjectContext)
            : base(objectContext, dbContextOwnsObjectContext)
        {
            InitializePartial();
        }

        protected override void Dispose(bool disposing)
        {
            DisposePartial(disposing);
            base.Dispose(disposing);
        }

        public bool IsSqlParameterNull(System.Data.SqlClient.SqlParameter param)
        {
            var sqlValue = param.SqlValue;
            var nullableValue = sqlValue as System.Data.SqlTypes.INullable;
            if (nullableValue != null)
                return nullableValue.IsNull;
            return (sqlValue == null || sqlValue == System.DBNull.Value);
        }

        protected override void OnModelCreating(System.Data.Entity.DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Conventions.Add(new CodeFirstStoreFunctions.FunctionsConvention<ProjectContext>("dbo"));
            modelBuilder.ComplexType<FnMaakWerfChecksReturnModel>();

            modelBuilder.Configurations.Add(new BibUserEntityConfiguration());
            modelBuilder.Configurations.Add(new CalcActiviteitenEntityConfiguration());
            modelBuilder.Configurations.Add(new CalcAddTemplateEntityConfiguration());
            modelBuilder.Configurations.Add(new CalcCode1EntityConfiguration());
            modelBuilder.Configurations.Add(new CalcCode2EntityConfiguration());
            modelBuilder.Configurations.Add(new CalcCode3EntityConfiguration());
            modelBuilder.Configurations.Add(new CalcCode4EntityConfiguration());
            modelBuilder.Configurations.Add(new CalcCode5EntityConfiguration());
            modelBuilder.Configurations.Add(new CalcCode6EntityConfiguration());
            modelBuilder.Configurations.Add(new CalcCode7EntityConfiguration());
            modelBuilder.Configurations.Add(new CalcCode8EntityConfiguration());
            modelBuilder.Configurations.Add(new CalcDetailEntityConfiguration());
            modelBuilder.Configurations.Add(new CalcDetailParameterValueEntityConfiguration());
            modelBuilder.Configurations.Add(new CalcFilterEntityConfiguration());
            modelBuilder.Configurations.Add(new CalcHcEntityConfiguration());
            modelBuilder.Configurations.Add(new CalcImportTemplateEntityConfiguration());
            modelBuilder.Configurations.Add(new CalcInkoopCategorieEntityConfiguration());
            modelBuilder.Configurations.Add(new CalcKEntityConfiguration());
            modelBuilder.Configurations.Add(new CalcLibraryEntityConfiguration());
            modelBuilder.Configurations.Add(new CalcLineTypeEntityConfiguration());
            modelBuilder.Configurations.Add(new CalcLogbookEntityConfiguration());
            modelBuilder.Configurations.Add(new CalcOfferClientEntityConfiguration());
            modelBuilder.Configurations.Add(new CalcParameterValueEntityConfiguration());
            modelBuilder.Configurations.Add(new CalcPropertyEntityConfiguration());
            modelBuilder.Configurations.Add(new CalcRelationEntityConfiguration());
            modelBuilder.Configurations.Add(new CalcRelationContactEntityConfiguration());
            modelBuilder.Configurations.Add(new CalcStatusHistoriekEntityConfiguration());
            modelBuilder.Configurations.Add(new CalcTextenEntityConfiguration());
            modelBuilder.Configurations.Add(new CalcTransactionEntityConfiguration());
            modelBuilder.Configurations.Add(new CalcTransactionPostEntityConfiguration());
            modelBuilder.Configurations.Add(new CalcTransactionPostArticleEntityConfiguration());
            modelBuilder.Configurations.Add(new CalcTransIndirectPostEntityConfiguration());
            modelBuilder.Configurations.Add(new CalcTypeEntityConfiguration());
            modelBuilder.Configurations.Add(new CalculationEntityConfiguration());
            modelBuilder.Configurations.Add(new CalculationLogEntityConfiguration());
            modelBuilder.Configurations.Add(new CalculationVersionEntityConfiguration());
            modelBuilder.Configurations.Add(new ContactEntityConfiguration());
            modelBuilder.Configurations.Add(new CostDetailCoreEntityConfiguration());
            modelBuilder.Configurations.Add(new CostHeaderEntityConfiguration());
            modelBuilder.Configurations.Add(new CostHeaderTypeEntityConfiguration());
            modelBuilder.Configurations.Add(new LinkedTeamProjectEntityConfiguration());
            modelBuilder.Configurations.Add(new OpmetingFormulaEntityConfiguration());
            modelBuilder.Configurations.Add(new OpmetingFormulaDetailEntityConfiguration());
            modelBuilder.Configurations.Add(new ParameterBibEntityConfiguration());
            modelBuilder.Configurations.Add(new ParameterDefinitionEntityConfiguration());
            modelBuilder.Configurations.Add(new ProjectEntityConfiguration());
            modelBuilder.Configurations.Add(new ProjectCalculationEntityConfiguration());
            modelBuilder.Configurations.Add(new ProjectDocumentEntityConfiguration());
            modelBuilder.Configurations.Add(new ProjectRelationEntityConfiguration());
            modelBuilder.Configurations.Add(new ProjectRelationContactEntityConfiguration());
            modelBuilder.Configurations.Add(new ProjectSubProjectEntityConfiguration());
            modelBuilder.Configurations.Add(new ProjectUnitEntityConfiguration());
            modelBuilder.Configurations.Add(new ProjectWerfEntityConfiguration());
            modelBuilder.Configurations.Add(new RelationEntityConfiguration());
            modelBuilder.Configurations.Add(new RelationTypeEntityConfiguration());
            modelBuilder.Configurations.Add(new SbDetailEntityConfiguration());
            modelBuilder.Configurations.Add(new SupplierPrijsAntwoordEntityConfiguration());
            modelBuilder.Configurations.Add(new SysCalculationParaEntityConfiguration());
            modelBuilder.Configurations.Add(new SysProjectSettingEntityConfiguration());
            modelBuilder.Configurations.Add(new SysWerfParaEntityConfiguration());
            modelBuilder.Configurations.Add(new TodoItemEntityConfiguration());
            modelBuilder.Configurations.Add(new UsersGroepEntityConfiguration());
            modelBuilder.Configurations.Add(new UserUserGroupEntityConfiguration());
            modelBuilder.Configurations.Add(new WBestelBonDetailExplorerDxEntityConfiguration());
            modelBuilder.Configurations.Add(new WBestelBonExplorer2EntityConfiguration());
            modelBuilder.Configurations.Add(new WBestelbonExplorerDxEntityConfiguration());
            modelBuilder.Configurations.Add(new WCalculationExplorer2EntityConfiguration());
            modelBuilder.Configurations.Add(new WCalculationExplorerDxEntityConfiguration());
            modelBuilder.Configurations.Add(new WCalculationInkoopCatEntityConfiguration());
            modelBuilder.Configurations.Add(new WContractExplorerEntityConfiguration());
            modelBuilder.Configurations.Add(new WContractOaExplorerDxEntityConfiguration());
            modelBuilder.Configurations.Add(new WCostExplorerDxEntityConfiguration());
            modelBuilder.Configurations.Add(new WerfEntityConfiguration());
            modelBuilder.Configurations.Add(new WerfActiviteitenLinkDataEntityConfiguration());
            modelBuilder.Configurations.Add(new WerfInvoiceAdressEntityConfiguration());
            modelBuilder.Configurations.Add(new WerfLijstEntityConfiguration());
            modelBuilder.Configurations.Add(new WerfMultiAnaCodeEntityConfiguration());
            modelBuilder.Configurations.Add(new WerfRelationEntityConfiguration());
            modelBuilder.Configurations.Add(new WerfVoorraadEntityConfiguration());
            modelBuilder.Configurations.Add(new WerfVorderingInvoiceEntityConfiguration());
            modelBuilder.Configurations.Add(new WKostenEntityConfiguration());
            modelBuilder.Configurations.Add(new WMasterProjectExplorerDxEntityConfiguration());
            modelBuilder.Configurations.Add(new WPrijsAntwoordExplorerDxEntityConfiguration());
            modelBuilder.Configurations.Add(new WPrijsVraagExplorerDxEntityConfiguration());
            modelBuilder.Configurations.Add(new WProjectExplorerEntityConfiguration());
            modelBuilder.Configurations.Add(new WProjectExplorerDxEntityConfiguration());
            modelBuilder.Configurations.Add(new WProjectPrijslijstExpolorerEntityConfiguration());
            modelBuilder.Configurations.Add(new WProjectRelationsDxEntityConfiguration());
            modelBuilder.Configurations.Add(new WProjectUnitExplorerDxEntityConfiguration());
            modelBuilder.Configurations.Add(new WSearchBestelBonDetailEntityConfiguration());
            modelBuilder.Configurations.Add(new WShareAtWorkWerfInfoEntityConfiguration());
            modelBuilder.Configurations.Add(new WTodoExplorerEntityConfiguration());
            modelBuilder.Configurations.Add(new WUserEntityConfiguration());
            modelBuilder.Configurations.Add(new WWerfExplorerEntityConfiguration());
            modelBuilder.Configurations.Add(new WWerfExplorerDxEntityConfiguration());

            OnModelCreatingPartial(modelBuilder);
        }

        public static System.Data.Entity.DbModelBuilder CreateModel(System.Data.Entity.DbModelBuilder modelBuilder, string schema)
        {
            modelBuilder.Configurations.Add(new BibUserEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new CalcActiviteitenEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new CalcAddTemplateEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new CalcCode1EntityConfiguration(schema));
            modelBuilder.Configurations.Add(new CalcCode2EntityConfiguration(schema));
            modelBuilder.Configurations.Add(new CalcCode3EntityConfiguration(schema));
            modelBuilder.Configurations.Add(new CalcCode4EntityConfiguration(schema));
            modelBuilder.Configurations.Add(new CalcCode5EntityConfiguration(schema));
            modelBuilder.Configurations.Add(new CalcCode6EntityConfiguration(schema));
            modelBuilder.Configurations.Add(new CalcCode7EntityConfiguration(schema));
            modelBuilder.Configurations.Add(new CalcCode8EntityConfiguration(schema));
            modelBuilder.Configurations.Add(new CalcDetailEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new CalcDetailParameterValueEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new CalcFilterEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new CalcHcEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new CalcImportTemplateEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new CalcInkoopCategorieEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new CalcKEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new CalcLibraryEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new CalcLineTypeEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new CalcLogbookEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new CalcOfferClientEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new CalcParameterValueEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new CalcPropertyEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new CalcRelationEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new CalcRelationContactEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new CalcStatusHistoriekEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new CalcTextenEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new CalcTransactionEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new CalcTransactionPostEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new CalcTransactionPostArticleEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new CalcTransIndirectPostEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new CalcTypeEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new CalculationEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new CalculationLogEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new CalculationVersionEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new ContactEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new CostDetailCoreEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new CostHeaderEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new CostHeaderTypeEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new LinkedTeamProjectEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new OpmetingFormulaEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new OpmetingFormulaDetailEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new ParameterBibEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new ParameterDefinitionEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new ProjectEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new ProjectCalculationEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new ProjectDocumentEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new ProjectRelationEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new ProjectRelationContactEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new ProjectSubProjectEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new ProjectUnitEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new ProjectWerfEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new RelationEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new RelationTypeEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new SbDetailEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new SupplierPrijsAntwoordEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new SysCalculationParaEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new SysProjectSettingEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new SysWerfParaEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new TodoItemEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new UsersGroepEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new UserUserGroupEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new WBestelBonDetailExplorerDxEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new WBestelBonExplorer2EntityConfiguration(schema));
            modelBuilder.Configurations.Add(new WBestelbonExplorerDxEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new WCalculationExplorer2EntityConfiguration(schema));
            modelBuilder.Configurations.Add(new WCalculationExplorerDxEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new WCalculationInkoopCatEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new WContractExplorerEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new WContractOaExplorerDxEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new WCostExplorerDxEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new WerfEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new WerfActiviteitenLinkDataEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new WerfInvoiceAdressEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new WerfLijstEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new WerfMultiAnaCodeEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new WerfRelationEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new WerfVoorraadEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new WerfVorderingInvoiceEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new WKostenEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new WMasterProjectExplorerDxEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new WPrijsAntwoordExplorerDxEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new WPrijsVraagExplorerDxEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new WProjectExplorerEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new WProjectExplorerDxEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new WProjectPrijslijstExpolorerEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new WProjectRelationsDxEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new WProjectUnitExplorerDxEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new WSearchBestelBonDetailEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new WShareAtWorkWerfInfoEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new WTodoExplorerEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new WUserEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new WWerfExplorerEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new WWerfExplorerDxEntityConfiguration(schema));
            OnCreateModelPartial(modelBuilder, schema);
            return modelBuilder;
        }

        partial void InitializePartial();
        partial void DisposePartial(bool disposing);
        partial void OnModelCreatingPartial(System.Data.Entity.DbModelBuilder modelBuilder);
		static partial void OnCreateModelPartial(System.Data.Entity.DbModelBuilder modelBuilder, string schema);        

        // Stored Procedures
        public System.Collections.Generic.List<SpMaakWerfReturnModel> SpMaakWerf(long? calcId, int? currentState, int? werfYear, string newWerfTypeId)
        {
            int procResult;
            return SpMaakWerf(calcId, currentState, werfYear, newWerfTypeId, out procResult);
        }

        public System.Collections.Generic.List<SpMaakWerfReturnModel> SpMaakWerf(long? calcId, int? currentState, int? werfYear, string newWerfTypeId, out int procResult)
        {
            var calcIdParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@CalcID", SqlDbType = System.Data.SqlDbType.BigInt, Direction = System.Data.ParameterDirection.Input, Value = calcId.GetValueOrDefault(), Precision = 19, Scale = 0 };
            if (!calcId.HasValue)
                calcIdParam.Value = System.DBNull.Value;

            var currentStateParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@CurrentState", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = currentState.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!currentState.HasValue)
                currentStateParam.Value = System.DBNull.Value;

            var werfYearParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@WerfYear", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = werfYear.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!werfYear.HasValue)
                werfYearParam.Value = System.DBNull.Value;

            var newWerfTypeIdParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@NewWerfTypeID", SqlDbType = System.Data.SqlDbType.NChar, Direction = System.Data.ParameterDirection.Input, Value = newWerfTypeId, Size = 2 };
            if (newWerfTypeIdParam.Value == null)
                newWerfTypeIdParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };
            var procResultData = Database.SqlQuery<SpMaakWerfReturnModel>("EXEC @procResult = [dbo].[spMaakWerf] @CalcID, @CurrentState, @WerfYear, @NewWerfTypeID", calcIdParam, currentStateParam, werfYearParam, newWerfTypeIdParam, procResultParam).ToList();

            procResult = (int) procResultParam.Value;
            return procResultData;
        }

        public async System.Threading.Tasks.Task<System.Collections.Generic.List<SpMaakWerfReturnModel>> SpMaakWerfAsync(long? calcId, int? currentState, int? werfYear, string newWerfTypeId)
        {
            var calcIdParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@CalcID", SqlDbType = System.Data.SqlDbType.BigInt, Direction = System.Data.ParameterDirection.Input, Value = calcId.GetValueOrDefault(), Precision = 19, Scale = 0 };
            if (!calcId.HasValue)
                calcIdParam.Value = System.DBNull.Value;

            var currentStateParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@CurrentState", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = currentState.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!currentState.HasValue)
                currentStateParam.Value = System.DBNull.Value;

            var werfYearParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@WerfYear", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = werfYear.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!werfYear.HasValue)
                werfYearParam.Value = System.DBNull.Value;

            var newWerfTypeIdParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@NewWerfTypeID", SqlDbType = System.Data.SqlDbType.NChar, Direction = System.Data.ParameterDirection.Input, Value = newWerfTypeId, Size = 2 };
            if (newWerfTypeIdParam.Value == null)
                newWerfTypeIdParam.Value = System.DBNull.Value;

            var procResultData = await Database.SqlQuery<SpMaakWerfReturnModel>("EXEC [dbo].[spMaakWerf] @CalcID, @CurrentState, @WerfYear, @NewWerfTypeID", calcIdParam, currentStateParam, werfYearParam, newWerfTypeIdParam).ToListAsync();

            return procResultData;
        }

        public System.Collections.Generic.List<SpWerfVoorraadReturnModel> SpWerfVoorraad(long? werfId, System.DateTime? voorraadDatum)
        {
            int procResult;
            return SpWerfVoorraad(werfId, voorraadDatum, out procResult);
        }

        public System.Collections.Generic.List<SpWerfVoorraadReturnModel> SpWerfVoorraad(long? werfId, System.DateTime? voorraadDatum, out int procResult)
        {
            var werfIdParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@WerfID", SqlDbType = System.Data.SqlDbType.BigInt, Direction = System.Data.ParameterDirection.Input, Value = werfId.GetValueOrDefault(), Precision = 19, Scale = 0 };
            if (!werfId.HasValue)
                werfIdParam.Value = System.DBNull.Value;

            var voorraadDatumParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@VoorraadDatum", SqlDbType = System.Data.SqlDbType.DateTime, Direction = System.Data.ParameterDirection.Input, Value = voorraadDatum.GetValueOrDefault() };
            if (!voorraadDatum.HasValue)
                voorraadDatumParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };
            var procResultData = Database.SqlQuery<SpWerfVoorraadReturnModel>("EXEC @procResult = [dbo].[spWerfVoorraad] @WerfID, @VoorraadDatum", werfIdParam, voorraadDatumParam, procResultParam).ToList();

            procResult = (int) procResultParam.Value;
            return procResultData;
        }

        public async System.Threading.Tasks.Task<System.Collections.Generic.List<SpWerfVoorraadReturnModel>> SpWerfVoorraadAsync(long? werfId, System.DateTime? voorraadDatum)
        {
            var werfIdParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@WerfID", SqlDbType = System.Data.SqlDbType.BigInt, Direction = System.Data.ParameterDirection.Input, Value = werfId.GetValueOrDefault(), Precision = 19, Scale = 0 };
            if (!werfId.HasValue)
                werfIdParam.Value = System.DBNull.Value;

            var voorraadDatumParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@VoorraadDatum", SqlDbType = System.Data.SqlDbType.DateTime, Direction = System.Data.ParameterDirection.Input, Value = voorraadDatum.GetValueOrDefault() };
            if (!voorraadDatum.HasValue)
                voorraadDatumParam.Value = System.DBNull.Value;

            var procResultData = await Database.SqlQuery<SpWerfVoorraadReturnModel>("EXEC [dbo].[spWerfVoorraad] @WerfID, @VoorraadDatum", werfIdParam, voorraadDatumParam).ToListAsync();

            return procResultData;
        }

        // Table Valued Functions
        [System.Data.Entity.DbFunction("ProjectContext", "fnMaakWerfChecks")]
        [CodeFirstStoreFunctions.DbFunctionDetails(DatabaseSchema = "dbo")]
        public IQueryable<FnMaakWerfChecksReturnModel> FnMaakWerfChecks(int? currentState, long? calcId)
        {
            var currentStateParam = new System.Data.Entity.Core.Objects.ObjectParameter("CurrentState", typeof(int)) { Value = (object)currentState ?? System.DBNull.Value };
            var calcIdParam = new System.Data.Entity.Core.Objects.ObjectParameter("CalcID", typeof(long)) { Value = (object)calcId ?? System.DBNull.Value };

            return ((System.Data.Entity.Infrastructure.IObjectContextAdapter)this).ObjectContext.CreateQuery<FnMaakWerfChecksReturnModel>("[ProjectContext].[fnMaakWerfChecks](@CurrentState, @CalcID)", currentStateParam, calcIdParam);
        }

    }
}
