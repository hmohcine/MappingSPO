using MappingSPO.Project.DL.Configurations;
using MappingSPO.Project.DL.Contracts;
using MappingSPO.Project.DL.Entities;

namespace MappingSPO.Project.DL
{
    using System.Linq;

    public partial class FakeProjectContext : IProjectContext
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

        public FakeProjectContext()
        {
            _changeTracker = null;
            _configuration = null;
            _database = null;

            BibUsers = new FakeDbSet<BibUserEntity>("CalcId", "UserId");
            CalcActiviteitens = new FakeDbSet<CalcActiviteitenEntity>("CalcId", "CalcActiviteitId");
            CalcAddTemplates = new FakeDbSet<CalcAddTemplateEntity>("CalcId");
            CalcCode1 = new FakeDbSet<CalcCode1Entity>("CalcCodeId");
            CalcCode2 = new FakeDbSet<CalcCode2Entity>("CalcCodeId");
            CalcCode3 = new FakeDbSet<CalcCode3Entity>("CalcCodeId");
            CalcCode4 = new FakeDbSet<CalcCode4Entity>("CalcCodeId");
            CalcCode5 = new FakeDbSet<CalcCode5Entity>("CalcCodeId");
            CalcCode6 = new FakeDbSet<CalcCode6Entity>("CalcCodeId");
            CalcCode7 = new FakeDbSet<CalcCode7Entity>("CalcCodeId");
            CalcCode8 = new FakeDbSet<CalcCode8Entity>("CalcCodeId");
            CalcDetails = new FakeDbSet<CalcDetailEntity>("CalcDetailId", "CalcId");
            CalcDetailParameterValues = new FakeDbSet<CalcDetailParameterValueEntity>("CalcDetailId", "CalcId", "ParameterName");
            CalcFilters = new FakeDbSet<CalcFilterEntity>("CalcFilterId");
            CalcHcs = new FakeDbSet<CalcHcEntity>("CalcId", "CalcHc_");
            CalcImportTemplates = new FakeDbSet<CalcImportTemplateEntity>("Id");
            CalcInkoopCategories = new FakeDbSet<CalcInkoopCategorieEntity>("CalcId", "ImpactType", "CalcInkoopCatId", "CatType");
            CalcKs = new FakeDbSet<CalcKEntity>("CalcId", "MayorTypeCode", "CalcKs", "TypeLine");
            CalcLibraries = new FakeDbSet<CalcLibraryEntity>("CalcId", "ItemId");
            CalcLineTypes = new FakeDbSet<CalcLineTypeEntity>("CalcLineTypeCode");
            CalcLogbooks = new FakeDbSet<CalcLogbookEntity>("CalcId", "VolgNr");
            CalcOfferClients = new FakeDbSet<CalcOfferClientEntity>("CalcId", "RelationTypeId", "RelationId");
            CalcParameterValues = new FakeDbSet<CalcParameterValueEntity>("CalcId", "ParameterName");
            CalcProperties = new FakeDbSet<CalcPropertyEntity>("CalcId", "PropertyName");
            CalcRelations = new FakeDbSet<CalcRelationEntity>("CalcId", "RelationId", "RelationTypeId");
            CalcRelationContacts = new FakeDbSet<CalcRelationContactEntity>("CalcId", "RelationId", "ContactId", "RelationTypeId");
            CalcStatusHistorieks = new FakeDbSet<CalcStatusHistoriekEntity>("CalcId", "DateChanged");
            CalcTextens = new FakeDbSet<CalcTextenEntity>("CalcId", "TextId");
            CalcTransactions = new FakeDbSet<CalcTransactionEntity>("CalcId", "TransActionNr");
            CalcTransactionPosts = new FakeDbSet<CalcTransactionPostEntity>("CalcId", "TransActionNr", "CalcDetailId");
            CalcTransactionPostArticles = new FakeDbSet<CalcTransactionPostArticleEntity>("CalcId", "TransActionNr", "CalcDetailIdPost", "CalcDetailIdArticle");
            CalcTransIndirectPosts = new FakeDbSet<CalcTransIndirectPostEntity>("CalcId", "TransActionNr", "CalcDetailId");
            CalcTypes = new FakeDbSet<CalcTypeEntity>("CalcTypeId");
            Calculations = new FakeDbSet<CalculationEntity>("CalcId");
            CalculationLogs = new FakeDbSet<CalculationLogEntity>("LogId", "CalcId");
            CalculationVersions = new FakeDbSet<CalculationVersionEntity>("VersionCalcId");
            Contacts = new FakeDbSet<ContactEntity>("ContactId");
            CostDetailCores = new FakeDbSet<CostDetailCoreEntity>("DetailId", "CostHeaderId");
            CostHeaders = new FakeDbSet<CostHeaderEntity>("Id");
            CostHeaderTypes = new FakeDbSet<CostHeaderTypeEntity>("CostHeaderType_");
            LinkedTeamProjects = new FakeDbSet<LinkedTeamProjectEntity>("ProjectId", "ProjectType");
            OpmetingFormulas = new FakeDbSet<OpmetingFormulaEntity>("CalcDetailId", "CalcId");
            OpmetingFormulaDetails = new FakeDbSet<OpmetingFormulaDetailEntity>("CalcDetailId", "CalcId", "Line");
            ParameterBibs = new FakeDbSet<ParameterBibEntity>("BibId");
            ParameterDefinitions = new FakeDbSet<ParameterDefinitionEntity>("ParameterName");
            Projects = new FakeDbSet<ProjectEntity>("ProjectId", "ProjectType");
            ProjectCalculations = new FakeDbSet<ProjectCalculationEntity>("ProjectId", "ProjectType", "CalcId");
            ProjectDocuments = new FakeDbSet<ProjectDocumentEntity>("ProjectId", "ProjectType", "DocumentId");
            ProjectRelations = new FakeDbSet<ProjectRelationEntity>("ProjectId", "ProjectType", "RelationTypeId", "RelationId");
            ProjectRelationContacts = new FakeDbSet<ProjectRelationContactEntity>("ProjectId", "ProjectType", "RelationTypeId", "RelationId", "ContactId");
            ProjectSubProjects = new FakeDbSet<ProjectSubProjectEntity>("MasterProjectId", "MasterProjectType", "SubProjectId", "SubProjectType");
            ProjectUnits = new FakeDbSet<ProjectUnitEntity>("ProjectUnitId");
            ProjectWerfs = new FakeDbSet<ProjectWerfEntity>("ProjectId", "ProjectType", "WerfId");
            Relations = new FakeDbSet<RelationEntity>("RelationId");
            RelationTypes = new FakeDbSet<RelationTypeEntity>("RelationTypeId");
            SbDetails = new FakeDbSet<SbDetailEntity>("DetailId");
            SupplierPrijsAntwoords = new FakeDbSet<SupplierPrijsAntwoordEntity>("PrijsVraagId", "SupplierId", "RelationTypeId", "AntwoordId");
            SysCalculationParas = new FakeDbSet<SysCalculationParaEntity>("Id");
            SysProjectSettings = new FakeDbSet<SysProjectSettingEntity>("Id");
            SysWerfParas = new FakeDbSet<SysWerfParaEntity>("Id1");
            TodoItems = new FakeDbSet<TodoItemEntity>("ItemId");
            UsersGroeps = new FakeDbSet<UsersGroepEntity>("UserGroupId");
            UserUserGroups = new FakeDbSet<UserUserGroupEntity>("UserId", "UserGroupId");
            WBestelBonDetailExplorerDxes = new FakeDbSet<WBestelBonDetailExplorerDxEntity>("DetailId", "LineOrder", "LineType", "AddedOnLevering", "Status", "BestelBonType");
            WBestelBonExplorer2 = new FakeDbSet<WBestelBonExplorer2Entity>("Sbid", "Status", "BestelbonType");
            WBestelbonExplorerDxes = new FakeDbSet<WBestelbonExplorerDxEntity>("Sbid", "Status", "BestelBonType", "IsRetour");
            WCalculationExplorer2 = new FakeDbSet<WCalculationExplorer2Entity>("CalcId", "CalcTypeId", "CalcMayorTypeCode", "MarkedForDeletion", "CalcSoort", "Domain", "UiVersion");
            WCalculationExplorerDxes = new FakeDbSet<WCalculationExplorerDxEntity>("CalcId");
            WCalculationInkoopCats = new FakeDbSet<WCalculationInkoopCatEntity>("CalcId");
            WContractExplorers = new FakeDbSet<WContractExplorerEntity>("ContractId", "ContractTypeId", "Contractjaar", "Contractnummer", "ContractStatus", "ContractNaam", "Domain");
            WContractOaExplorerDxes = new FakeDbSet<WContractOaExplorerDxEntity>("ContractId", "ContractState", "ContractName", "ContractTypeId", "ContractYear", "ContractNumber", "Domain", "WerfId", "WerfState", "WerfName");
            WCostExplorerDxes = new FakeDbSet<WCostExplorerDxEntity>("DetailId", "CostHeaderId", "CostHeaderType", "MasterType", "Aantal", "Ekp", "Kp", "Evp", "Vp", "Status");
            Werfs = new FakeDbSet<WerfEntity>("WerfId");
            WerfActiviteitenLinkDatas = new FakeDbSet<WerfActiviteitenLinkDataEntity>("Source", "WerfId", "ActiviteitId");
            WerfInvoiceAdresses = new FakeDbSet<WerfInvoiceAdressEntity>("InvoiceAdressId");
            WerfLijsts = new FakeDbSet<WerfLijstEntity>("WerfLijstId");
            WerfMultiAnaCodes = new FakeDbSet<WerfMultiAnaCodeEntity>("MultiId");
            WerfRelations = new FakeDbSet<WerfRelationEntity>("WerfId", "RelationId", "RelationTypeId");
            WerfVoorraads = new FakeDbSet<WerfVoorraadEntity>("DetailId");
            WerfVorderingInvoices = new FakeDbSet<WerfVorderingInvoiceEntity>("WerfId", "VorderingNr", "InvoiceId");
            WKostens = new FakeDbSet<WKostenEntity>("DetailId", "CostHeaderId", "CostHeaderType", "MasterType", "Aantal", "Ekp", "Kp", "Evp", "Vp", "Status", "Goedgekeurd", "Domain");
            WMasterProjectExplorerDxes = new FakeDbSet<WMasterProjectExplorerDxEntity>("ProjectId", "ProjectType");
            WPrijsAntwoordExplorerDxes = new FakeDbSet<WPrijsAntwoordExplorerDxEntity>("AntwoordId", "AntwoordType", "HasPrijsVraag", "CalcTypeId", "MarkedForDeletion", "CalcSoort", "UiVersion");
            WPrijsVraagExplorerDxes = new FakeDbSet<WPrijsVraagExplorerDxEntity>("PrijsAanvraagId", "CalcTypeId", "MarkedForDeletion", "CalcSoort", "Domain", "UiVersion", "CalcId");
            WProjectExplorers = new FakeDbSet<WProjectExplorerEntity>("ProjectId", "ProjectType", "ProjectYear", "ProjectNumber", "ProjectNrText", "ProjectName", "ProjectDate", "CreateDate", "UpdateDate", "CreatedBy", "UpdatedBy", "OwnerId", "ProjectResult", "ProjectResultText", "HasExtendedSecurity", "ProjectDone", "ProjectDoneText", "CountOfExtInvoiceTodo");
            WProjectExplorerDxes = new FakeDbSet<WProjectExplorerDxEntity>("ProjectId", "ProjectType");
            WProjectPrijslijstExpolorers = new FakeDbSet<WProjectPrijslijstExpolorerEntity>("ProjectUnitId", "ProjectMasterType", "ProjectId", "ProjectType", "ProjectNrText", "ProjectName", "UnitState", "UnittypeId", "VolgNummer", "CreateDate", "ChangedDate", "CreatedById", "ChangedById", "IntegrationYn", "ProjectYear", "ProjectNumber", "VerdeelMode", "VolgNrYearText");
            WProjectRelationsDxes = new FakeDbSet<WProjectRelationsDxEntity>("ProjectId", "ProjectType", "RelationId");
            WProjectUnitExplorerDxes = new FakeDbSet<WProjectUnitExplorerDxEntity>("ProjectUnitId", "UnitState", "VolgNummer", "CreateDate", "ChangedDate", "IntegrationYn", "VerdeelMode", "VolgNrYearText", "Year", "VolgNrYear");
            WSearchBestelBonDetails = new FakeDbSet<WSearchBestelBonDetailEntity>("Sbid", "Status", "DetailId", "LineOrder", "LineType", "GeleverdAantal", "GeleverdBedrag", "GeleverdAantalInOntwerp", "GeleverdBedragInOntwerp", "DefaultAddTypeText", "DefaultAddType", "AddedOnLevering");
            WShareAtWorkWerfInfoes = new FakeDbSet<WShareAtWorkWerfInfoEntity>("WerfId", "WerfState", "WerfName");
            WTodoExplorers = new FakeDbSet<WTodoExplorerEntity>("ItemId", "ToDoMasterType", "DisplayIcon", "IsDone", "IsDeleted", "DisplayNumber", "DisplayText", "Owner", "IsActive", "HasReminder", "Prioriteit");
            WUsers = new FakeDbSet<WUserEntity>("UserId", "UserSname", "Disabled");
            WWerfExplorers = new FakeDbSet<WWerfExplorerEntity>("WerfId", "WerfTypeId", "WerfMayorTypeCode", "WerfYear", "WerfNumber", "WerfState", "WerfName", "CountOfExtInvoiceTodo", "Domain");
            WWerfExplorerDxes = new FakeDbSet<WWerfExplorerDxEntity>("WerfId");

            InitializePartial();
        }

        public int SaveChangesCount { get; private set; }
        public int SaveChanges()
        {
            ++SaveChangesCount;
            return 1;
        }

        public System.Threading.Tasks.Task<int> SaveChangesAsync()
        {
            ++SaveChangesCount;
            return System.Threading.Tasks.Task<int>.Factory.StartNew(() => 1);
        }

        public System.Threading.Tasks.Task<int> SaveChangesAsync(System.Threading.CancellationToken cancellationToken)
        {
            ++SaveChangesCount;
            return System.Threading.Tasks.Task<int>.Factory.StartNew(() => 1, cancellationToken);
        }

        partial void InitializePartial();

        protected virtual void Dispose(bool disposing)
        {
        }

        public void Dispose()
        {
            Dispose(true);
        }

        private System.Data.Entity.Infrastructure.DbChangeTracker _changeTracker;
        public System.Data.Entity.Infrastructure.DbChangeTracker ChangeTracker { get { return _changeTracker; } }
        private System.Data.Entity.Infrastructure.DbContextConfiguration _configuration;
        public System.Data.Entity.Infrastructure.DbContextConfiguration Configuration { get { return _configuration; } }
        private System.Data.Entity.Database _database;
        public System.Data.Entity.Database Database { get { return _database; } }
        public System.Data.Entity.Infrastructure.DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class
        {
            throw new System.NotImplementedException();
        }
        public System.Data.Entity.Infrastructure.DbEntityEntry Entry(object entity)
        {
            throw new System.NotImplementedException();
        }
        public System.Collections.Generic.IEnumerable<System.Data.Entity.Validation.DbEntityValidationResult> GetValidationErrors()
        {
            throw new System.NotImplementedException();
        }
        public System.Data.Entity.DbSet Set(System.Type entityType)
        {
            throw new System.NotImplementedException();
        }
        public System.Data.Entity.DbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            throw new System.NotImplementedException();
        }
        public override string ToString()
        {
            throw new System.NotImplementedException();
        }


        // Stored Procedures
        public System.Collections.Generic.List<SpMaakWerfReturnModel> SpMaakWerf(long? calcId, int? currentState, int? werfYear, string newWerfTypeId)
        {
            int procResult;
            return SpMaakWerf(calcId, currentState, werfYear, newWerfTypeId, out procResult);
        }

        public System.Collections.Generic.List<SpMaakWerfReturnModel> SpMaakWerf(long? calcId, int? currentState, int? werfYear, string newWerfTypeId, out int procResult)
        {

            procResult = 0;
            return new System.Collections.Generic.List<SpMaakWerfReturnModel>();
        }

        public System.Threading.Tasks.Task<System.Collections.Generic.List<SpMaakWerfReturnModel>> SpMaakWerfAsync(long? calcId, int? currentState, int? werfYear, string newWerfTypeId)
        {
            int procResult;
            return System.Threading.Tasks.Task.FromResult(SpMaakWerf(calcId, currentState, werfYear, newWerfTypeId, out procResult));
        }

        public System.Collections.Generic.List<SpWerfVoorraadReturnModel> SpWerfVoorraad(long? werfId, System.DateTime? voorraadDatum)
        {
            int procResult;
            return SpWerfVoorraad(werfId, voorraadDatum, out procResult);
        }

        public System.Collections.Generic.List<SpWerfVoorraadReturnModel> SpWerfVoorraad(long? werfId, System.DateTime? voorraadDatum, out int procResult)
        {

            procResult = 0;
            return new System.Collections.Generic.List<SpWerfVoorraadReturnModel>();
        }

        public System.Threading.Tasks.Task<System.Collections.Generic.List<SpWerfVoorraadReturnModel>> SpWerfVoorraadAsync(long? werfId, System.DateTime? voorraadDatum)
        {
            int procResult;
            return System.Threading.Tasks.Task.FromResult(SpWerfVoorraad(werfId, voorraadDatum, out procResult));
        }

        // Table Valued Functions
        [System.Data.Entity.DbFunction("ProjectContext", "fnMaakWerfChecks")]
        public IQueryable<FnMaakWerfChecksReturnModel> FnMaakWerfChecks(int? currentState, long? calcId)
        {
            return new System.Collections.Generic.List<FnMaakWerfChecksReturnModel>().AsQueryable();
        }

    }
}
