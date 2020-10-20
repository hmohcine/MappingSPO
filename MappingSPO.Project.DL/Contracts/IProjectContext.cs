using MappingSPO.Project.DL.Entities;

namespace MappingSPO.Project.DL.Contracts
{
    public interface IProjectContext : System.IDisposable
    {
        System.Data.Entity.DbSet<BibUserEntity> BibUsers { get; set; }
        System.Data.Entity.DbSet<CalcActiviteitenEntity> CalcActiviteitens { get; set; }
        System.Data.Entity.DbSet<CalcAddTemplateEntity> CalcAddTemplates { get; set; }
        System.Data.Entity.DbSet<CalcCode1Entity> CalcCode1 { get; set; }
        System.Data.Entity.DbSet<CalcCode2Entity> CalcCode2 { get; set; }
        System.Data.Entity.DbSet<CalcCode3Entity> CalcCode3 { get; set; }
        System.Data.Entity.DbSet<CalcCode4Entity> CalcCode4 { get; set; }
        System.Data.Entity.DbSet<CalcCode5Entity> CalcCode5 { get; set; }
        System.Data.Entity.DbSet<CalcCode6Entity> CalcCode6 { get; set; }
        System.Data.Entity.DbSet<CalcCode7Entity> CalcCode7 { get; set; }
        System.Data.Entity.DbSet<CalcCode8Entity> CalcCode8 { get; set; }
        System.Data.Entity.DbSet<CalcDetailEntity> CalcDetails { get; set; }
        System.Data.Entity.DbSet<CalcDetailParameterValueEntity> CalcDetailParameterValues { get; set; }
        System.Data.Entity.DbSet<CalcFilterEntity> CalcFilters { get; set; }
        System.Data.Entity.DbSet<CalcHcEntity> CalcHcs { get; set; }
        System.Data.Entity.DbSet<CalcImportTemplateEntity> CalcImportTemplates { get; set; }
        System.Data.Entity.DbSet<CalcInkoopCategorieEntity> CalcInkoopCategories { get; set; }
        System.Data.Entity.DbSet<CalcKEntity> CalcKs { get; set; }
        System.Data.Entity.DbSet<CalcLibraryEntity> CalcLibraries { get; set; }
        System.Data.Entity.DbSet<CalcLineTypeEntity> CalcLineTypes { get; set; }
        System.Data.Entity.DbSet<CalcLogbookEntity> CalcLogbooks { get; set; }
        System.Data.Entity.DbSet<CalcOfferClientEntity> CalcOfferClients { get; set; }
        System.Data.Entity.DbSet<CalcParameterValueEntity> CalcParameterValues { get; set; }
        System.Data.Entity.DbSet<CalcPropertyEntity> CalcProperties { get; set; }
        System.Data.Entity.DbSet<CalcRelationEntity> CalcRelations { get; set; }
        System.Data.Entity.DbSet<CalcRelationContactEntity> CalcRelationContacts { get; set; }
        System.Data.Entity.DbSet<CalcStatusHistoriekEntity> CalcStatusHistorieks { get; set; }
        System.Data.Entity.DbSet<CalcTextenEntity> CalcTextens { get; set; }
        System.Data.Entity.DbSet<CalcTransactionEntity> CalcTransactions { get; set; }
        System.Data.Entity.DbSet<CalcTransactionPostEntity> CalcTransactionPosts { get; set; }
        System.Data.Entity.DbSet<CalcTransactionPostArticleEntity> CalcTransactionPostArticles { get; set; }
        System.Data.Entity.DbSet<CalcTransIndirectPostEntity> CalcTransIndirectPosts { get; set; }
        System.Data.Entity.DbSet<CalcTypeEntity> CalcTypes { get; set; }
        System.Data.Entity.DbSet<CalculationEntity> Calculations { get; set; }
        System.Data.Entity.DbSet<CalculationLogEntity> CalculationLogs { get; set; }
        System.Data.Entity.DbSet<CalculationVersionEntity> CalculationVersions { get; set; }
        System.Data.Entity.DbSet<ContactEntity> Contacts { get; set; }
        System.Data.Entity.DbSet<CostDetailCoreEntity> CostDetailCores { get; set; }
        System.Data.Entity.DbSet<CostHeaderEntity> CostHeaders { get; set; }
        System.Data.Entity.DbSet<CostHeaderTypeEntity> CostHeaderTypes { get; set; }
        System.Data.Entity.DbSet<LinkedTeamProjectEntity> LinkedTeamProjects { get; set; }
        System.Data.Entity.DbSet<OpmetingFormulaEntity> OpmetingFormulas { get; set; }
        System.Data.Entity.DbSet<OpmetingFormulaDetailEntity> OpmetingFormulaDetails { get; set; }
        System.Data.Entity.DbSet<ParameterBibEntity> ParameterBibs { get; set; }
        System.Data.Entity.DbSet<ParameterDefinitionEntity> ParameterDefinitions { get; set; }
        System.Data.Entity.DbSet<ProjectEntity> Projects { get; set; }
        System.Data.Entity.DbSet<ProjectCalculationEntity> ProjectCalculations { get; set; }
        System.Data.Entity.DbSet<ProjectRelationEntity> ProjectRelations { get; set; }
        System.Data.Entity.DbSet<ProjectRelationContactEntity> ProjectRelationContacts { get; set; }
        System.Data.Entity.DbSet<ProjectSubProjectEntity> ProjectSubProjects { get; set; }
        System.Data.Entity.DbSet<ProjectUnitEntity> ProjectUnits { get; set; }
        System.Data.Entity.DbSet<ProjectWerfEntity> ProjectWerfs { get; set; }
        System.Data.Entity.DbSet<RelationEntity> Relations { get; set; }
        System.Data.Entity.DbSet<RelationTypeEntity> RelationTypes { get; set; }
        System.Data.Entity.DbSet<SbDetailEntity> SbDetails { get; set; }
        System.Data.Entity.DbSet<SupplierPrijsAntwoordEntity> SupplierPrijsAntwoords { get; set; }
        System.Data.Entity.DbSet<SysCalculationParaEntity> SysCalculationParas { get; set; }
        System.Data.Entity.DbSet<SysProjectSettingEntity> SysProjectSettings { get; set; }
        System.Data.Entity.DbSet<SysWerfParaEntity> SysWerfParas { get; set; }
        System.Data.Entity.DbSet<TodoItemEntity> TodoItems { get; set; }
        System.Data.Entity.DbSet<UsersGroepEntity> UsersGroeps { get; set; }
        System.Data.Entity.DbSet<UserUserGroupEntity> UserUserGroups { get; set; }
        System.Data.Entity.DbSet<WBestelBonDetailExplorerDxEntity> WBestelBonDetailExplorerDxes { get; set; }
        System.Data.Entity.DbSet<WBestelBonExplorer2Entity> WBestelBonExplorer2 { get; set; }
        System.Data.Entity.DbSet<WBestelbonExplorerDxEntity> WBestelbonExplorerDxes { get; set; }
        System.Data.Entity.DbSet<WCalculationExplorer2Entity> WCalculationExplorer2 { get; set; }
        System.Data.Entity.DbSet<WCalculationExplorerDxEntity> WCalculationExplorerDxes { get; set; }
        System.Data.Entity.DbSet<WCalculationInkoopCatEntity> WCalculationInkoopCats { get; set; }
        System.Data.Entity.DbSet<WContractExplorerEntity> WContractExplorers { get; set; }
        System.Data.Entity.DbSet<WContractOaExplorerDxEntity> WContractOaExplorerDxes { get; set; }
        System.Data.Entity.DbSet<WCostExplorerDxEntity> WCostExplorerDxes { get; set; }
        System.Data.Entity.DbSet<WerfEntity> Werfs { get; set; }
        System.Data.Entity.DbSet<WerfActiviteitenLinkDataEntity> WerfActiviteitenLinkDatas { get; set; }
        System.Data.Entity.DbSet<WerfInvoiceAdressEntity> WerfInvoiceAdresses { get; set; }
        System.Data.Entity.DbSet<WerfLijstEntity> WerfLijsts { get; set; }
        System.Data.Entity.DbSet<WerfMultiAnaCodeEntity> WerfMultiAnaCodes { get; set; }
        System.Data.Entity.DbSet<WerfRelationEntity> WerfRelations { get; set; }
        System.Data.Entity.DbSet<WerfVoorraadEntity> WerfVoorraads { get; set; }
        System.Data.Entity.DbSet<WerfVorderingInvoiceEntity> WerfVorderingInvoices { get; set; }
        System.Data.Entity.DbSet<WKostenEntity> WKostens { get; set; }
        System.Data.Entity.DbSet<WMasterProjectExplorerDxEntity> WMasterProjectExplorerDxes { get; set; }
        System.Data.Entity.DbSet<WPrijsAntwoordExplorerDxEntity> WPrijsAntwoordExplorerDxes { get; set; }
        System.Data.Entity.DbSet<WPrijsVraagExplorerDxEntity> WPrijsVraagExplorerDxes { get; set; }
        System.Data.Entity.DbSet<WProjectExplorerEntity> WProjectExplorers { get; set; }
        System.Data.Entity.DbSet<WProjectExplorerDxEntity> WProjectExplorerDxes { get; set; }
        System.Data.Entity.DbSet<WProjectPrijslijstExpolorerEntity> WProjectPrijslijstExpolorers { get; set; }
        System.Data.Entity.DbSet<WProjectRelationsDxEntity> WProjectRelationsDxes { get; set; }
        System.Data.Entity.DbSet<WProjectUnitExplorerDxEntity> WProjectUnitExplorerDxes { get; set; }
        System.Data.Entity.DbSet<WSearchBestelBonDetailEntity> WSearchBestelBonDetails { get; set; }
        System.Data.Entity.DbSet<WShareAtWorkWerfInfoEntity> WShareAtWorkWerfInfoes { get; set; }
        System.Data.Entity.DbSet<WTodoExplorerEntity> WTodoExplorers { get; set; }
        System.Data.Entity.DbSet<WUserEntity> WUsers { get; set; }
        System.Data.Entity.DbSet<WWerfExplorerEntity> WWerfExplorers { get; set; }
        System.Data.Entity.DbSet<WWerfExplorerDxEntity> WWerfExplorerDxes { get; set; }
        int SaveChanges();
        System.Threading.Tasks.Task<int> SaveChangesAsync();
        System.Threading.Tasks.Task<int> SaveChangesAsync(System.Threading.CancellationToken cancellationToken);
        System.Data.Entity.Infrastructure.DbChangeTracker ChangeTracker { get; }
        System.Data.Entity.Infrastructure.DbContextConfiguration Configuration { get; }
        System.Data.Entity.Database Database { get; }
        System.Data.Entity.Infrastructure.DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
        System.Data.Entity.Infrastructure.DbEntityEntry Entry(object entity);
        System.Collections.Generic.IEnumerable<System.Data.Entity.Validation.DbEntityValidationResult> GetValidationErrors();
        System.Data.Entity.DbSet Set(System.Type entityType);
        System.Data.Entity.DbSet<TEntity> Set<TEntity>() where TEntity : class;
        string ToString();

        // Stored Procedures
        System.Collections.Generic.List<SpMaakWerfReturnModel> SpMaakWerf(long? calcId, int? currentState, int? werfYear, string newWerfTypeId);
        System.Collections.Generic.List<SpMaakWerfReturnModel> SpMaakWerf(long? calcId, int? currentState, int? werfYear, string newWerfTypeId, out int procResult);
        System.Threading.Tasks.Task<System.Collections.Generic.List<SpMaakWerfReturnModel>> SpMaakWerfAsync(long? calcId, int? currentState, int? werfYear, string newWerfTypeId);
        System.Collections.Generic.List<SpWerfVoorraadReturnModel> SpWerfVoorraad(long? werfId, System.DateTime? voorraadDatum);
        System.Collections.Generic.List<SpWerfVoorraadReturnModel> SpWerfVoorraad(long? werfId, System.DateTime? voorraadDatum, out int procResult);
        System.Threading.Tasks.Task<System.Collections.Generic.List<SpWerfVoorraadReturnModel>> SpWerfVoorraadAsync(long? werfId, System.DateTime? voorraadDatum);
        // Table Valued Functions
        [System.Data.Entity.DbFunction("ProjectContext", "fnMaakWerfChecks")]
        [CodeFirstStoreFunctions.DbFunctionDetails(DatabaseSchema = "dbo")]
        System.Linq.IQueryable<FnMaakWerfChecksReturnModel> FnMaakWerfChecks(int? currentState, long? calcId);
    }
}
