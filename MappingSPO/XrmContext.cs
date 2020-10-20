using MappingSPO.Configurations;
using MappingSPO.Entities;

namespace MappingSPO
{
    using System.Linq;

    public partial class XrmContext : System.Data.Entity.DbContext, IXrmContext
    {
        public System.Data.Entity.DbSet<ActiviteitenEntity> Activiteitens { get; set; }
        public System.Data.Entity.DbSet<ActiviteitGpsLinkDataEntity> ActiviteitGpsLinkDatas { get; set; }
        public System.Data.Entity.DbSet<ActiviteitGroupEntity> ActiviteitGroups { get; set; }
        public System.Data.Entity.DbSet<AddinEntity> Addins { get; set; }
        public System.Data.Entity.DbSet<AddinContractEntity> AddinContracts { get; set; }
        public System.Data.Entity.DbSet<AddinContractsSecurityEntity> AddinContractsSecurities { get; set; }
        public System.Data.Entity.DbSet<AfdelingEntity> Afdelings { get; set; }
        public System.Data.Entity.DbSet<AfmeldingPuntTypeEntity> AfmeldingPuntTypes { get; set; }
        public System.Data.Entity.DbSet<AfmeldingsPuntenEntity> AfmeldingsPuntens { get; set; }
        public System.Data.Entity.DbSet<AfmeldingspuntenGpsLinkDataEntity> AfmeldingspuntenGpsLinkDatas { get; set; }
        public System.Data.Entity.DbSet<ArticleDefaultEntity> ArticleDefaults { get; set; }
        public System.Data.Entity.DbSet<AutomaticCalcLibraryEntity> AutomaticCalcLibraries { get; set; }
        public System.Data.Entity.DbSet<AutomaticCalcSettingEntity> AutomaticCalcSettings { get; set; }
        public System.Data.Entity.DbSet<BAnaCodeEntity> BAnaCodes { get; set; }
        public System.Data.Entity.DbSet<BAnaGroup1Entity> BAnaGroup1 { get; set; }
        public System.Data.Entity.DbSet<BAnaSubGroupEntity> BAnaSubGroups { get; set; }
        public System.Data.Entity.DbSet<BatchJobEntity> BatchJobs { get; set; }
        public System.Data.Entity.DbSet<BatchJobParameterEntity> BatchJobParameters { get; set; }
        public System.Data.Entity.DbSet<BatchServiceSettingEntity> BatchServiceSettings { get; set; }
        public System.Data.Entity.DbSet<BetaalWijzeEntity> BetaalWijzes { get; set; }
        public System.Data.Entity.DbSet<BoekPeriodeEntity> BoekPeriodes { get; set; }
        public System.Data.Entity.DbSet<BtwBoekingsgroepEntity> BtwBoekingsgroeps { get; set; }
        public System.Data.Entity.DbSet<CalcCode1Entity> CalcCode1 { get; set; }
        public System.Data.Entity.DbSet<CalcCode2Entity> CalcCode2 { get; set; }
        public System.Data.Entity.DbSet<CalcCode3Entity> CalcCode3 { get; set; }
        public System.Data.Entity.DbSet<CalcCode4Entity> CalcCode4 { get; set; }
        public System.Data.Entity.DbSet<CalcCode5Entity> CalcCode5 { get; set; }
        public System.Data.Entity.DbSet<CalcCode6Entity> CalcCode6 { get; set; }
        public System.Data.Entity.DbSet<CalcCode7Entity> CalcCode7 { get; set; }
        public System.Data.Entity.DbSet<CalcCode8Entity> CalcCode8 { get; set; }
        public System.Data.Entity.DbSet<CalcErrorEntity> CalcErrors { get; set; }
        public System.Data.Entity.DbSet<CalcFilterEntity> CalcFilters { get; set; }
        public System.Data.Entity.DbSet<CalcLineTypeEntity> CalcLineTypes { get; set; }
        public System.Data.Entity.DbSet<CalcTypeEntity> CalcTypes { get; set; }
        public System.Data.Entity.DbSet<CashDiscountEntity> CashDiscounts { get; set; }
        public System.Data.Entity.DbSet<CategoryEntity> Categories { get; set; }
        public System.Data.Entity.DbSet<CityEntity> Cities { get; set; }
        public System.Data.Entity.DbSet<ClientDiscountEntity> ClientDiscounts { get; set; }
        public System.Data.Entity.DbSet<CodaBoxSettingEntity> CodaBoxSettings { get; set; }
        public System.Data.Entity.DbSet<CodeEntity> Codes { get; set; }
        public System.Data.Entity.DbSet<CodeCaptionTranslationEntity> CodeCaptionTranslations { get; set; }
        public System.Data.Entity.DbSet<CodeTranslationEntity> CodeTranslations { get; set; }
        public System.Data.Entity.DbSet<CompanyEntity> Companies { get; set; }
        public System.Data.Entity.DbSet<CompanyRekeningenEntity> CompanyRekeningens { get; set; }
        public System.Data.Entity.DbSet<CompanyUserGroepRightEntity> CompanyUserGroepRights { get; set; }
        public System.Data.Entity.DbSet<CompanyUserRightEntity> CompanyUserRights { get; set; }
        public System.Data.Entity.DbSet<ContactEntity> Contacts { get; set; }
        public System.Data.Entity.DbSet<ContactCodeEntity> ContactCodes { get; set; }
        public System.Data.Entity.DbSet<ContactsMultiAnaCodeEntity> ContactsMultiAnaCodes { get; set; }
        public System.Data.Entity.DbSet<ContactTypeEntity> ContactTypes { get; set; }
        public System.Data.Entity.DbSet<CostHeaderTypeEntity> CostHeaderTypes { get; set; }
        public System.Data.Entity.DbSet<CounterDefinitionEntity> CounterDefinitions { get; set; }
        public System.Data.Entity.DbSet<CounterWerkCodeEntity> CounterWerkCodes { get; set; }
        public System.Data.Entity.DbSet<CountriesLinkDataEntity> CountriesLinkDatas { get; set; }
        public System.Data.Entity.DbSet<CountryEntity> Countries { get; set; }
        public System.Data.Entity.DbSet<CountryLanguageEntity> CountryLanguages { get; set; }
        public System.Data.Entity.DbSet<CurrencyEntity> Currencies { get; set; }
        public System.Data.Entity.DbSet<DagZoneEntity> DagZones { get; set; }
        public System.Data.Entity.DbSet<DocCode1Entity> DocCode1 { get; set; }
        public System.Data.Entity.DbSet<DocCode2Entity> DocCode2 { get; set; }
        public System.Data.Entity.DbSet<DocCode3Entity> DocCode3 { get; set; }
        public System.Data.Entity.DbSet<DocCode4Entity> DocCode4 { get; set; }
        public System.Data.Entity.DbSet<DocumentEntity> Documents { get; set; }
        public System.Data.Entity.DbSet<DocumentTypeEntity> DocumentTypes { get; set; }
        public System.Data.Entity.DbSet<DynAx2012CustSettingsEntity> DynAx2012CustSettings { get; set; }
        public System.Data.Entity.DbSet<EmailTypeEntity> EmailTypes { get; set; }
        public System.Data.Entity.DbSet<EmailTypeTextEntity> EmailTypeTexts { get; set; }
        public System.Data.Entity.DbSet<EmmaAddinEntity> EmmaAddins { get; set; }
        public System.Data.Entity.DbSet<EmmaAddinContractEntity> EmmaAddinContracts { get; set; }
        public System.Data.Entity.DbSet<EmmaAddinContractsSecurityEntity> EmmaAddinContractsSecurities { get; set; }
        public System.Data.Entity.DbSet<EmmaAnaCode1Entity> EmmaAnaCode1 { get; set; }
        public System.Data.Entity.DbSet<EmmaAnaCode2Entity> EmmaAnaCode2 { get; set; }
        public System.Data.Entity.DbSet<EmmaAnaCode3Entity> EmmaAnaCode3 { get; set; }
        public System.Data.Entity.DbSet<EmmaAnaCode4Entity> EmmaAnaCode4 { get; set; }
        public System.Data.Entity.DbSet<EmmaAnaCode5Entity> EmmaAnaCode5 { get; set; }
        public System.Data.Entity.DbSet<EmmaAnaCode6Entity> EmmaAnaCode6 { get; set; }
        public System.Data.Entity.DbSet<EmmaAnaCode7Entity> EmmaAnaCode7 { get; set; }
        public System.Data.Entity.DbSet<EmmaAnaCode8Entity> EmmaAnaCode8 { get; set; }
        public System.Data.Entity.DbSet<EmmaAnaCode9Entity> EmmaAnaCode9 { get; set; }
        public System.Data.Entity.DbSet<EmmaMagazijnEntity> EmmaMagazijns { get; set; }
        public System.Data.Entity.DbSet<EmmaOfferLabelValueEntity> EmmaOfferLabelValues { get; set; }
        public System.Data.Entity.DbSet<EmmaOfferTypeEntity> EmmaOfferTypes { get; set; }
        public System.Data.Entity.DbSet<EmmaTextenEntity> EmmaTextens { get; set; }
        public System.Data.Entity.DbSet<EmmaTextGroupEntity> EmmaTextGroups { get; set; }
        public System.Data.Entity.DbSet<EmmaUserSettingEntity> EmmaUserSettings { get; set; }
        public System.Data.Entity.DbSet<EmmaVerzendwijzeEntity> EmmaVerzendwijzes { get; set; }
        public System.Data.Entity.DbSet<EmmaVkoTypeEntity> EmmaVkoTypes { get; set; }
        public System.Data.Entity.DbSet<EmployeeEntity> Employees { get; set; }
        public System.Data.Entity.DbSet<ExactOnlineSettingEntity> ExactOnlineSettings { get; set; }
        public System.Data.Entity.DbSet<ExportVatSettingEntity> ExportVatSettings { get; set; }
        public System.Data.Entity.DbSet<ExternalApiSettingEntity> ExternalApiSettings { get; set; }
        public System.Data.Entity.DbSet<ExternalDatabaseEntity> ExternalDatabases { get; set; }
        public System.Data.Entity.DbSet<ExternalInvoiceBuildSettingEntity> ExternalInvoiceBuildSettings { get; set; }
        public System.Data.Entity.DbSet<ExternalInvoiceUserSettingEntity> ExternalInvoiceUserSettings { get; set; }
        public System.Data.Entity.DbSet<HcEntity> Hcs { get; set; }
        public System.Data.Entity.DbSet<HerzieningIndexEntity> HerzieningIndexes { get; set; }
        public System.Data.Entity.DbSet<HerzieningTemplateEntity> HerzieningTemplates { get; set; }
        public System.Data.Entity.DbSet<HerzieningTemplateTermEntity> HerzieningTemplateTerms { get; set; }
        public System.Data.Entity.DbSet<IncomingInvoiceSettingEntity> IncomingInvoiceSettings { get; set; }
        public System.Data.Entity.DbSet<InvoiceEntity> Invoices { get; set; }
        public System.Data.Entity.DbSet<InvoiceExportEntity> InvoiceExports { get; set; }
        public System.Data.Entity.DbSet<InvoiceExportGeneralEntity> InvoiceExportGenerals { get; set; }
        public System.Data.Entity.DbSet<InvoicePlanDefaultEntity> InvoicePlanDefaults { get; set; }
        public System.Data.Entity.DbSet<InvoicePlanDefaultsSchijvenEntity> InvoicePlanDefaultsSchijvens { get; set; }
        public System.Data.Entity.DbSet<KsEntity> Ks { get; set; }
        public System.Data.Entity.DbSet<LanguageEntity> Languages { get; set; }
        public System.Data.Entity.DbSet<MaatTypeEntity> MaatTypes { get; set; }
        public System.Data.Entity.DbSet<MagazijnEntity> Magazijns { get; set; }
        public System.Data.Entity.DbSet<MobiliteitsCodeEntity> MobiliteitsCodes { get; set; }
        public System.Data.Entity.DbSet<MobiliteitsCodeTarievenEntity> MobiliteitsCodeTarievens { get; set; }
        public System.Data.Entity.DbSet<MobiliteitTariefDetailEntity> MobiliteitTariefDetails { get; set; }
        public System.Data.Entity.DbSet<OpmetingDefinitionEntity> OpmetingDefinitions { get; set; }
        public System.Data.Entity.DbSet<ParitairComiteEntity> ParitairComites { get; set; }
        public System.Data.Entity.DbSet<ParitairComiteCounterEntity> ParitairComiteCounters { get; set; }
        public System.Data.Entity.DbSet<PayConditionEntity> PayConditions { get; set; }
        public System.Data.Entity.DbSet<PlanningResourceEntity> PlanningResources { get; set; }
        public System.Data.Entity.DbSet<PrijsAntwoordSoortEntity> PrijsAntwoordSoorts { get; set; }
        public System.Data.Entity.DbSet<ProjectCode1Entity> ProjectCode1 { get; set; }
        public System.Data.Entity.DbSet<ProjectCode2Entity> ProjectCode2 { get; set; }
        public System.Data.Entity.DbSet<ProjectCode3Entity> ProjectCode3 { get; set; }
        public System.Data.Entity.DbSet<ProjectCode4Entity> ProjectCode4 { get; set; }
        public System.Data.Entity.DbSet<ProjectCode5Entity> ProjectCode5 { get; set; }
        public System.Data.Entity.DbSet<ProjectCode6Entity> ProjectCode6 { get; set; }
        public System.Data.Entity.DbSet<ProjectCode7Entity> ProjectCode7 { get; set; }
        public System.Data.Entity.DbSet<ProjectCode8Entity> ProjectCode8 { get; set; }
        public System.Data.Entity.DbSet<ProjectExplorerSpecialQueryEntity> ProjectExplorerSpecialQueries { get; set; }
        public System.Data.Entity.DbSet<ProjectResultReasonEntity> ProjectResultReasons { get; set; }
        public System.Data.Entity.DbSet<ProjectTypeEntity> ProjectTypes { get; set; }
        public System.Data.Entity.DbSet<ProjectTypeUserEntity> ProjectTypeUsers { get; set; }
        public System.Data.Entity.DbSet<ProjectTypeUserGroupEntity> ProjectTypeUserGroups { get; set; }
        public System.Data.Entity.DbSet<ProjectTypeWorkFlowEntity> ProjectTypeWorkFlows { get; set; }
        public System.Data.Entity.DbSet<ProjectUnitCodeEntity> ProjectUnitCodes { get; set; }
        public System.Data.Entity.DbSet<ProjectUnitMultiAnaCodeEntity> ProjectUnitMultiAnaCodes { get; set; }
        public System.Data.Entity.DbSet<ProjectUnitsSearchMapUserSettingEntity> ProjectUnitsSearchMapUserSettings { get; set; }
        public System.Data.Entity.DbSet<QueriesDxEntity> QueriesDxes { get; set; }
        public System.Data.Entity.DbSet<QueryEntity> Queries { get; set; }
        public System.Data.Entity.DbSet<RegionEntity> Regions { get; set; }
        public System.Data.Entity.DbSet<RekeningNrEntity> RekeningNrs { get; set; }
        public System.Data.Entity.DbSet<RelActiviteitEntity> RelActiviteits { get; set; }
        public System.Data.Entity.DbSet<RelActiviteitGroupEntity> RelActiviteitGroups { get; set; }
        public System.Data.Entity.DbSet<RelationEntity> Relations { get; set; }
        public System.Data.Entity.DbSet<RelationCode1Entity> RelationCode1 { get; set; }
        public System.Data.Entity.DbSet<RelationCode2Entity> RelationCode2 { get; set; }
        public System.Data.Entity.DbSet<RelationCode3Entity> RelationCode3 { get; set; }
        public System.Data.Entity.DbSet<RelationCode4Entity> RelationCode4 { get; set; }
        public System.Data.Entity.DbSet<RelationCode5Entity> RelationCode5 { get; set; }
        public System.Data.Entity.DbSet<RelationCode6Entity> RelationCode6 { get; set; }
        public System.Data.Entity.DbSet<RelationCode7Entity> RelationCode7 { get; set; }
        public System.Data.Entity.DbSet<RelationCode8Entity> RelationCode8 { get; set; }
        public System.Data.Entity.DbSet<RelationsContactEntity> RelationsContacts { get; set; }
        public System.Data.Entity.DbSet<RelationTypeEntity> RelationTypes { get; set; }
        public System.Data.Entity.DbSet<RelOpportunityEntity> RelOpportunities { get; set; }
        public System.Data.Entity.DbSet<RelOpportunityGroupEntity> RelOpportunityGroups { get; set; }
        public System.Data.Entity.DbSet<ReportEntity> Reports { get; set; }
        public System.Data.Entity.DbSet<ReportLayoutsDxEntity> ReportLayoutsDxes { get; set; }
        public System.Data.Entity.DbSet<ReportsDxEntity> ReportsDxes { get; set; }
        public System.Data.Entity.DbSet<ReportsDxFormLinkEntity> ReportsDxFormLinks { get; set; }
        public System.Data.Entity.DbSet<SageBobCompanySettingEntity> SageBobCompanySettings { get; set; }
        public System.Data.Entity.DbSet<SalesDefaultEntity> SalesDefaults { get; set; }
        public System.Data.Entity.DbSet<SecurityRuleEntity> SecurityRules { get; set; }
        public System.Data.Entity.DbSet<SettingEntity> Settings { get; set; }
        public System.Data.Entity.DbSet<SubCategoryEntity> SubCategories { get; set; }
        public System.Data.Entity.DbSet<SysCalculationParaEntity> SysCalculationParas { get; set; }
        public System.Data.Entity.DbSet<SysMasterProjectSettingEntity> SysMasterProjectSettings { get; set; }
        public System.Data.Entity.DbSet<SysMpSettingsCijferEntity> SysMpSettingsCijfers { get; set; }
        public System.Data.Entity.DbSet<SysMpSettingsCijfersLabelEntity> SysMpSettingsCijfersLabels { get; set; }
        public System.Data.Entity.DbSet<SysProjectSettingEntity> SysProjectSettings { get; set; }
        public System.Data.Entity.DbSet<SysProjectUserSettingEntity> SysProjectUserSettings { get; set; }
        public System.Data.Entity.DbSet<SysRelationsParaEntity> SysRelationsParas { get; set; }
        public System.Data.Entity.DbSet<SysSalesInvoiceParaEntity> SysSalesInvoiceParas { get; set; }
        public System.Data.Entity.DbSet<SysUserFilterEntity> SysUserFilters { get; set; }
        public System.Data.Entity.DbSet<SysUserSettingObjectEntity> SysUserSettingObjects { get; set; }
        public System.Data.Entity.DbSet<SysUserSettingUserObjectEntity> SysUserSettingUserObjects { get; set; }
        public System.Data.Entity.DbSet<SysUserViewEntity> SysUserViews { get; set; }
        public System.Data.Entity.DbSet<SysWerfParaEntity> SysWerfParas { get; set; }
        public System.Data.Entity.DbSet<TeamsIntegrationEntity> TeamsIntegrations { get; set; }
        public System.Data.Entity.DbSet<ToDoItemStateEntity> ToDoItemStates { get; set; }
        public System.Data.Entity.DbSet<TodoTypeEntity> TodoTypes { get; set; }
        public System.Data.Entity.DbSet<TodoTypeItemStateEntity> TodoTypeItemStates { get; set; }
        public System.Data.Entity.DbSet<TofSettingEntity> TofSettings { get; set; }
        public System.Data.Entity.DbSet<TransportMiddelEntity> TransportMiddels { get; set; }
        public System.Data.Entity.DbSet<UcEntity> Ucs { get; set; }
        public System.Data.Entity.DbSet<UcUcEntity> UcUcs { get; set; }
        public System.Data.Entity.DbSet<UnitTypeEntity> UnitTypes { get; set; }
        public System.Data.Entity.DbSet<UserEntity> Users { get; set; }
        public System.Data.Entity.DbSet<UsersGroepEntity> UsersGroeps { get; set; }
        public System.Data.Entity.DbSet<VatEntity> Vats { get; set; }
        public System.Data.Entity.DbSet<VatRegimeEntity> VatRegimes { get; set; }
        public System.Data.Entity.DbSet<VatRegimeNoteEntity> VatRegimeNotes { get; set; }
        public System.Data.Entity.DbSet<VeniceSettingEntity> VeniceSettings { get; set; }
        public System.Data.Entity.DbSet<WerfCode1Entity> WerfCode1 { get; set; }
        public System.Data.Entity.DbSet<WerfCode2Entity> WerfCode2 { get; set; }
        public System.Data.Entity.DbSet<WerfCode3Entity> WerfCode3 { get; set; }
        public System.Data.Entity.DbSet<WerfCode4Entity> WerfCode4 { get; set; }
        public System.Data.Entity.DbSet<WerfCode5Entity> WerfCode5 { get; set; }
        public System.Data.Entity.DbSet<WerfCode6Entity> WerfCode6 { get; set; }
        public System.Data.Entity.DbSet<WerfCode7Entity> WerfCode7 { get; set; }
        public System.Data.Entity.DbSet<WerfCode8Entity> WerfCode8 { get; set; }
        public System.Data.Entity.DbSet<WerfDocSearchMapUserSettingEntity> WerfDocSearchMapUserSettings { get; set; }
        public System.Data.Entity.DbSet<WerfMultiAnaCodeEntity> WerfMultiAnaCodes { get; set; }
        public System.Data.Entity.DbSet<WerfPropertiesItemEntity> WerfPropertiesItems { get; set; }
        public System.Data.Entity.DbSet<WerfTypeEntity> WerfTypes { get; set; }
        public System.Data.Entity.DbSet<WerkCodeEntity> WerkCodes { get; set; }
        public System.Data.Entity.DbSet<WholesalerEntity> Wholesalers { get; set; }
        public System.Data.Entity.DbSet<WholesalerUnitcodeEntity> WholesalerUnitcodes { get; set; }
        public System.Data.Entity.DbSet<WholesalerUserEntity> WholesalerUsers { get; set; }
        public System.Data.Entity.DbSet<WinbookEntity> Winbooks { get; set; }
        public System.Data.Entity.DbSet<WinbooksBoekYearPeriodToBoekingDatumEntity> WinbooksBoekYearPeriodToBoekingDatums { get; set; }
        public System.Data.Entity.DbSet<WinbooksCompanyEntity> WinbooksCompanies { get; set; }
        public System.Data.Entity.DbSet<WinbooksCompanyTableEntity> WinbooksCompanyTables { get; set; }
        public System.Data.Entity.DbSet<WinbooksSettingEntity> WinbooksSettings { get; set; }
        public System.Data.Entity.DbSet<WingsSettingEntity> WingsSettings { get; set; }
        public System.Data.Entity.DbSet<WorkerContractTypeEntity> WorkerContractTypes { get; set; }
        public System.Data.Entity.DbSet<WorkFlowEntity> WorkFlows { get; set; }
        public System.Data.Entity.DbSet<WorkOrderTimeItemsCounterEntity> WorkOrderTimeItemsCounters { get; set; }
        public System.Data.Entity.DbSet<WorkOrderTypeEntity> WorkOrderTypes { get; set; }
        public System.Data.Entity.DbSet<WorkOrderTypeAfdelingEntity> WorkOrderTypeAfdelings { get; set; }

        static XrmContext()
        {
            System.Data.Entity.Database.SetInitializer<XrmContext>(null);
        }

        public XrmContext()
            : base("Name=DevConnection")
        {
            InitializePartial();
        }

        public XrmContext(string connectionString)
            : base(connectionString)
        {
            InitializePartial();
        }

        public XrmContext(string connectionString, System.Data.Entity.Infrastructure.DbCompiledModel model)
            : base(connectionString, model)
        {
            InitializePartial();
        }

        public XrmContext(System.Data.Common.DbConnection existingConnection, bool contextOwnsConnection)
            : base(existingConnection, contextOwnsConnection)
        {
            InitializePartial();
        }

        public XrmContext(System.Data.Common.DbConnection existingConnection, System.Data.Entity.Infrastructure.DbCompiledModel model, bool contextOwnsConnection)
            : base(existingConnection, model, contextOwnsConnection)
        {
            InitializePartial();
        }

        public XrmContext(System.Data.Entity.Core.Objects.ObjectContext objectContext, bool dbContextOwnsObjectContext)
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

            modelBuilder.Configurations.Add(new ActiviteitenEntityConfiguration());
            modelBuilder.Configurations.Add(new ActiviteitGpsLinkDataEntityConfiguration());
            modelBuilder.Configurations.Add(new ActiviteitGroupEntityConfiguration());
            modelBuilder.Configurations.Add(new AddinEntityConfiguration());
            modelBuilder.Configurations.Add(new AddinContractEntityConfiguration());
            modelBuilder.Configurations.Add(new AddinContractsSecurityEntityConfiguration());
            modelBuilder.Configurations.Add(new AfdelingEntityConfiguration());
            modelBuilder.Configurations.Add(new AfmeldingPuntTypeEntityConfiguration());
            modelBuilder.Configurations.Add(new AfmeldingsPuntenEntityConfiguration());
            modelBuilder.Configurations.Add(new AfmeldingspuntenGpsLinkDataEntityConfiguration());
            modelBuilder.Configurations.Add(new ArticleDefaultEntityConfiguration());
            modelBuilder.Configurations.Add(new AutomaticCalcLibraryEntityConfiguration());
            modelBuilder.Configurations.Add(new AutomaticCalcSettingEntityConfiguration());
            modelBuilder.Configurations.Add(new BAnaCodeEntityConfiguration());
            modelBuilder.Configurations.Add(new BAnaGroup1EntityConfiguration());
            modelBuilder.Configurations.Add(new BAnaSubGroupEntityConfiguration());
            modelBuilder.Configurations.Add(new BatchJobEntityConfiguration());
            modelBuilder.Configurations.Add(new BatchJobParameterEntityConfiguration());
            modelBuilder.Configurations.Add(new BatchServiceSettingEntityConfiguration());
            modelBuilder.Configurations.Add(new BetaalWijzeEntityConfiguration());
            modelBuilder.Configurations.Add(new BoekPeriodeEntityConfiguration());
            modelBuilder.Configurations.Add(new BtwBoekingsgroepEntityConfiguration());
            modelBuilder.Configurations.Add(new CalcCode1EntityConfiguration());
            modelBuilder.Configurations.Add(new CalcCode2EntityConfiguration());
            modelBuilder.Configurations.Add(new CalcCode3EntityConfiguration());
            modelBuilder.Configurations.Add(new CalcCode4EntityConfiguration());
            modelBuilder.Configurations.Add(new CalcCode5EntityConfiguration());
            modelBuilder.Configurations.Add(new CalcCode6EntityConfiguration());
            modelBuilder.Configurations.Add(new CalcCode7EntityConfiguration());
            modelBuilder.Configurations.Add(new CalcCode8EntityConfiguration());
            modelBuilder.Configurations.Add(new CalcErrorEntityConfiguration());
            modelBuilder.Configurations.Add(new CalcFilterEntityConfiguration());
            modelBuilder.Configurations.Add(new CalcLineTypeEntityConfiguration());
            modelBuilder.Configurations.Add(new CalcTypeEntityConfiguration());
            modelBuilder.Configurations.Add(new CashDiscountEntityConfiguration());
            modelBuilder.Configurations.Add(new CategoryEntityConfiguration());
            modelBuilder.Configurations.Add(new CityEntityConfiguration());
            modelBuilder.Configurations.Add(new ClientDiscountEntityConfiguration());
            modelBuilder.Configurations.Add(new CodaBoxSettingEntityConfiguration());
            modelBuilder.Configurations.Add(new CodeEntityConfiguration());
            modelBuilder.Configurations.Add(new CodeCaptionTranslationEntityConfiguration());
            modelBuilder.Configurations.Add(new CodeTranslationEntityConfiguration());
            modelBuilder.Configurations.Add(new CompanyEntityConfiguration());
            modelBuilder.Configurations.Add(new CompanyRekeningenEntityConfiguration());
            modelBuilder.Configurations.Add(new CompanyUserGroepRightEntityConfiguration());
            modelBuilder.Configurations.Add(new CompanyUserRightEntityConfiguration());
            modelBuilder.Configurations.Add(new ContactEntityConfiguration());
            modelBuilder.Configurations.Add(new ContactCodeEntityConfiguration());
            modelBuilder.Configurations.Add(new ContactsMultiAnaCodeEntityConfiguration());
            modelBuilder.Configurations.Add(new ContactTypeEntityConfiguration());
            modelBuilder.Configurations.Add(new CostHeaderTypeEntityConfiguration());
            modelBuilder.Configurations.Add(new CounterDefinitionEntityConfiguration());
            modelBuilder.Configurations.Add(new CounterWerkCodeEntityConfiguration());
            modelBuilder.Configurations.Add(new CountriesLinkDataEntityConfiguration());
            modelBuilder.Configurations.Add(new CountryEntityConfiguration());
            modelBuilder.Configurations.Add(new CountryLanguageEntityConfiguration());
            modelBuilder.Configurations.Add(new CurrencyEntityConfiguration());
            modelBuilder.Configurations.Add(new DagZoneEntityConfiguration());
            modelBuilder.Configurations.Add(new DocCode1EntityConfiguration());
            modelBuilder.Configurations.Add(new DocCode2EntityConfiguration());
            modelBuilder.Configurations.Add(new DocCode3EntityConfiguration());
            modelBuilder.Configurations.Add(new DocCode4EntityConfiguration());
            modelBuilder.Configurations.Add(new DocumentEntityConfiguration());
            modelBuilder.Configurations.Add(new DocumentTypeEntityConfiguration());
            modelBuilder.Configurations.Add(new DynAx2012CustSettingsEntityConfiguration());
            modelBuilder.Configurations.Add(new EmailTypeEntityConfiguration());
            modelBuilder.Configurations.Add(new EmailTypeTextEntityConfiguration());
            modelBuilder.Configurations.Add(new EmmaAddinEntityConfiguration());
            modelBuilder.Configurations.Add(new EmmaAddinContractEntityConfiguration());
            modelBuilder.Configurations.Add(new EmmaAddinContractsSecurityEntityConfiguration());
            modelBuilder.Configurations.Add(new EmmaAnaCode1EntityConfiguration());
            modelBuilder.Configurations.Add(new EmmaAnaCode2EntityConfiguration());
            modelBuilder.Configurations.Add(new EmmaAnaCode3EntityConfiguration());
            modelBuilder.Configurations.Add(new EmmaAnaCode4EntityConfiguration());
            modelBuilder.Configurations.Add(new EmmaAnaCode5EntityConfiguration());
            modelBuilder.Configurations.Add(new EmmaAnaCode6EntityConfiguration());
            modelBuilder.Configurations.Add(new EmmaAnaCode7EntityConfiguration());
            modelBuilder.Configurations.Add(new EmmaAnaCode8EntityConfiguration());
            modelBuilder.Configurations.Add(new EmmaAnaCode9EntityConfiguration());
            modelBuilder.Configurations.Add(new EmmaMagazijnEntityConfiguration());
            modelBuilder.Configurations.Add(new EmmaOfferLabelValueEntityConfiguration());
            modelBuilder.Configurations.Add(new EmmaOfferTypeEntityConfiguration());
            modelBuilder.Configurations.Add(new EmmaTextenEntityConfiguration());
            modelBuilder.Configurations.Add(new EmmaTextGroupEntityConfiguration());
            modelBuilder.Configurations.Add(new EmmaUserSettingEntityConfiguration());
            modelBuilder.Configurations.Add(new EmmaVerzendwijzeEntityConfiguration());
            modelBuilder.Configurations.Add(new EmmaVkoTypeEntityConfiguration());
            modelBuilder.Configurations.Add(new EmployeeEntityConfiguration());
            modelBuilder.Configurations.Add(new ExactOnlineSettingEntityConfiguration());
            modelBuilder.Configurations.Add(new ExportVatSettingEntityConfiguration());
            modelBuilder.Configurations.Add(new ExternalApiSettingEntityConfiguration());
            modelBuilder.Configurations.Add(new ExternalDatabaseEntityConfiguration());
            modelBuilder.Configurations.Add(new ExternalInvoiceBuildSettingEntityConfiguration());
            modelBuilder.Configurations.Add(new ExternalInvoiceUserSettingEntityConfiguration());
            modelBuilder.Configurations.Add(new HcEntityConfiguration());
            modelBuilder.Configurations.Add(new HerzieningIndexEntityConfiguration());
            modelBuilder.Configurations.Add(new HerzieningTemplateEntityConfiguration());
            modelBuilder.Configurations.Add(new HerzieningTemplateTermEntityConfiguration());
            modelBuilder.Configurations.Add(new IncomingInvoiceSettingEntityConfiguration());
            modelBuilder.Configurations.Add(new InvoiceEntityConfiguration());
            modelBuilder.Configurations.Add(new InvoiceExportEntityConfiguration());
            modelBuilder.Configurations.Add(new InvoiceExportGeneralEntityConfiguration());
            modelBuilder.Configurations.Add(new InvoicePlanDefaultEntityConfiguration());
            modelBuilder.Configurations.Add(new InvoicePlanDefaultsSchijvenEntityConfiguration());
            modelBuilder.Configurations.Add(new KsEntityConfiguration());
            modelBuilder.Configurations.Add(new LanguageEntityConfiguration());
            modelBuilder.Configurations.Add(new MaatTypeEntityConfiguration());
            modelBuilder.Configurations.Add(new MagazijnEntityConfiguration());
            modelBuilder.Configurations.Add(new MobiliteitsCodeEntityConfiguration());
            modelBuilder.Configurations.Add(new MobiliteitsCodeTarievenEntityConfiguration());
            modelBuilder.Configurations.Add(new MobiliteitTariefDetailEntityConfiguration());
            modelBuilder.Configurations.Add(new OpmetingDefinitionEntityConfiguration());
            modelBuilder.Configurations.Add(new ParitairComiteEntityConfiguration());
            modelBuilder.Configurations.Add(new ParitairComiteCounterEntityConfiguration());
            modelBuilder.Configurations.Add(new PayConditionEntityConfiguration());
            modelBuilder.Configurations.Add(new PlanningResourceEntityConfiguration());
            modelBuilder.Configurations.Add(new PrijsAntwoordSoortEntityConfiguration());
            modelBuilder.Configurations.Add(new ProjectCode1EntityConfiguration());
            modelBuilder.Configurations.Add(new ProjectCode2EntityConfiguration());
            modelBuilder.Configurations.Add(new ProjectCode3EntityConfiguration());
            modelBuilder.Configurations.Add(new ProjectCode4EntityConfiguration());
            modelBuilder.Configurations.Add(new ProjectCode5EntityConfiguration());
            modelBuilder.Configurations.Add(new ProjectCode6EntityConfiguration());
            modelBuilder.Configurations.Add(new ProjectCode7EntityConfiguration());
            modelBuilder.Configurations.Add(new ProjectCode8EntityConfiguration());
            modelBuilder.Configurations.Add(new ProjectExplorerSpecialQueryEntityConfiguration());
            modelBuilder.Configurations.Add(new ProjectResultReasonEntityConfiguration());
            modelBuilder.Configurations.Add(new ProjectTypeEntityConfiguration());
            modelBuilder.Configurations.Add(new ProjectTypeUserEntityConfiguration());
            modelBuilder.Configurations.Add(new ProjectTypeUserGroupEntityConfiguration());
            modelBuilder.Configurations.Add(new ProjectTypeWorkFlowEntityConfiguration());
            modelBuilder.Configurations.Add(new ProjectUnitCodeEntityConfiguration());
            modelBuilder.Configurations.Add(new ProjectUnitMultiAnaCodeEntityConfiguration());
            modelBuilder.Configurations.Add(new ProjectUnitsSearchMapUserSettingEntityConfiguration());
            modelBuilder.Configurations.Add(new QueriesDxEntityConfiguration());
            modelBuilder.Configurations.Add(new QueryEntityConfiguration());
            modelBuilder.Configurations.Add(new RegionEntityConfiguration());
            modelBuilder.Configurations.Add(new RekeningNrEntityConfiguration());
            modelBuilder.Configurations.Add(new RelActiviteitEntityConfiguration());
            modelBuilder.Configurations.Add(new RelActiviteitGroupEntityConfiguration());
            modelBuilder.Configurations.Add(new RelationEntityConfiguration());
            modelBuilder.Configurations.Add(new RelationCode1EntityConfiguration());
            modelBuilder.Configurations.Add(new RelationCode2EntityConfiguration());
            modelBuilder.Configurations.Add(new RelationCode3EntityConfiguration());
            modelBuilder.Configurations.Add(new RelationCode4EntityConfiguration());
            modelBuilder.Configurations.Add(new RelationCode5EntityConfiguration());
            modelBuilder.Configurations.Add(new RelationCode6EntityConfiguration());
            modelBuilder.Configurations.Add(new RelationCode7EntityConfiguration());
            modelBuilder.Configurations.Add(new RelationCode8EntityConfiguration());
            modelBuilder.Configurations.Add(new RelationsContactEntityConfiguration());
            modelBuilder.Configurations.Add(new RelationTypeEntityConfiguration());
            modelBuilder.Configurations.Add(new RelOpportunityEntityConfiguration());
            modelBuilder.Configurations.Add(new RelOpportunityGroupEntityConfiguration());
            modelBuilder.Configurations.Add(new ReportEntityConfiguration());
            modelBuilder.Configurations.Add(new ReportLayoutsDxEntityConfiguration());
            modelBuilder.Configurations.Add(new ReportsDxEntityConfiguration());
            modelBuilder.Configurations.Add(new ReportsDxFormLinkEntityConfiguration());
            modelBuilder.Configurations.Add(new SageBobCompanySettingEntityConfiguration());
            modelBuilder.Configurations.Add(new SalesDefaultEntityConfiguration());
            modelBuilder.Configurations.Add(new SecurityRuleEntityConfiguration());
            modelBuilder.Configurations.Add(new SettingEntityConfiguration());
            modelBuilder.Configurations.Add(new SubCategoryEntityConfiguration());
            modelBuilder.Configurations.Add(new SysCalculationParaEntityConfiguration());
            modelBuilder.Configurations.Add(new SysMasterProjectSettingEntityConfiguration());
            modelBuilder.Configurations.Add(new SysMpSettingsCijferEntityConfiguration());
            modelBuilder.Configurations.Add(new SysMpSettingsCijfersLabelEntityConfiguration());
            modelBuilder.Configurations.Add(new SysProjectSettingEntityConfiguration());
            modelBuilder.Configurations.Add(new SysProjectUserSettingEntityConfiguration());
            modelBuilder.Configurations.Add(new SysRelationsParaEntityConfiguration());
            modelBuilder.Configurations.Add(new SysSalesInvoiceParaEntityConfiguration());
            modelBuilder.Configurations.Add(new SysUserFilterEntityConfiguration());
            modelBuilder.Configurations.Add(new SysUserSettingObjectEntityConfiguration());
            modelBuilder.Configurations.Add(new SysUserSettingUserObjectEntityConfiguration());
            modelBuilder.Configurations.Add(new SysUserViewEntityConfiguration());
            modelBuilder.Configurations.Add(new SysWerfParaEntityConfiguration());
            modelBuilder.Configurations.Add(new TeamsIntegrationEntityConfiguration());
            modelBuilder.Configurations.Add(new ToDoItemStateEntityConfiguration());
            modelBuilder.Configurations.Add(new TodoTypeEntityConfiguration());
            modelBuilder.Configurations.Add(new TodoTypeItemStateEntityConfiguration());
            modelBuilder.Configurations.Add(new TofSettingEntityConfiguration());
            modelBuilder.Configurations.Add(new TransportMiddelEntityConfiguration());
            modelBuilder.Configurations.Add(new UcEntityConfiguration());
            modelBuilder.Configurations.Add(new UcUcEntityConfiguration());
            modelBuilder.Configurations.Add(new UnitTypeEntityConfiguration());
            modelBuilder.Configurations.Add(new UserEntityConfiguration());
            modelBuilder.Configurations.Add(new UsersGroepEntityConfiguration());
            modelBuilder.Configurations.Add(new VatEntityConfiguration());
            modelBuilder.Configurations.Add(new VatRegimeEntityConfiguration());
            modelBuilder.Configurations.Add(new VatRegimeNoteEntityConfiguration());
            modelBuilder.Configurations.Add(new VeniceSettingEntityConfiguration());
            modelBuilder.Configurations.Add(new WerfCode1EntityConfiguration());
            modelBuilder.Configurations.Add(new WerfCode2EntityConfiguration());
            modelBuilder.Configurations.Add(new WerfCode3EntityConfiguration());
            modelBuilder.Configurations.Add(new WerfCode4EntityConfiguration());
            modelBuilder.Configurations.Add(new WerfCode5EntityConfiguration());
            modelBuilder.Configurations.Add(new WerfCode6EntityConfiguration());
            modelBuilder.Configurations.Add(new WerfCode7EntityConfiguration());
            modelBuilder.Configurations.Add(new WerfCode8EntityConfiguration());
            modelBuilder.Configurations.Add(new WerfDocSearchMapUserSettingEntityConfiguration());
            modelBuilder.Configurations.Add(new WerfMultiAnaCodeEntityConfiguration());
            modelBuilder.Configurations.Add(new WerfPropertiesItemEntityConfiguration());
            modelBuilder.Configurations.Add(new WerfTypeEntityConfiguration());
            modelBuilder.Configurations.Add(new WerkCodeEntityConfiguration());
            modelBuilder.Configurations.Add(new WholesalerEntityConfiguration());
            modelBuilder.Configurations.Add(new WholesalerUnitcodeEntityConfiguration());
            modelBuilder.Configurations.Add(new WholesalerUserEntityConfiguration());
            modelBuilder.Configurations.Add(new WinbookEntityConfiguration());
            modelBuilder.Configurations.Add(new WinbooksBoekYearPeriodToBoekingDatumEntityConfiguration());
            modelBuilder.Configurations.Add(new WinbooksCompanyEntityConfiguration());
            modelBuilder.Configurations.Add(new WinbooksCompanyTableEntityConfiguration());
            modelBuilder.Configurations.Add(new WinbooksSettingEntityConfiguration());
            modelBuilder.Configurations.Add(new WingsSettingEntityConfiguration());
            modelBuilder.Configurations.Add(new WorkerContractTypeEntityConfiguration());
            modelBuilder.Configurations.Add(new WorkFlowEntityConfiguration());
            modelBuilder.Configurations.Add(new WorkOrderTimeItemsCounterEntityConfiguration());
            modelBuilder.Configurations.Add(new WorkOrderTypeEntityConfiguration());
            modelBuilder.Configurations.Add(new WorkOrderTypeAfdelingEntityConfiguration());

            OnModelCreatingPartial(modelBuilder);
        }

        public static System.Data.Entity.DbModelBuilder CreateModel(System.Data.Entity.DbModelBuilder modelBuilder, string schema)
        {
            modelBuilder.Configurations.Add(new ActiviteitenEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new ActiviteitGpsLinkDataEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new ActiviteitGroupEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new AddinEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new AddinContractEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new AddinContractsSecurityEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new AfdelingEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new AfmeldingPuntTypeEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new AfmeldingsPuntenEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new AfmeldingspuntenGpsLinkDataEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new ArticleDefaultEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new AutomaticCalcLibraryEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new AutomaticCalcSettingEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new BAnaCodeEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new BAnaGroup1EntityConfiguration(schema));
            modelBuilder.Configurations.Add(new BAnaSubGroupEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new BatchJobEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new BatchJobParameterEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new BatchServiceSettingEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new BetaalWijzeEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new BoekPeriodeEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new BtwBoekingsgroepEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new CalcCode1EntityConfiguration(schema));
            modelBuilder.Configurations.Add(new CalcCode2EntityConfiguration(schema));
            modelBuilder.Configurations.Add(new CalcCode3EntityConfiguration(schema));
            modelBuilder.Configurations.Add(new CalcCode4EntityConfiguration(schema));
            modelBuilder.Configurations.Add(new CalcCode5EntityConfiguration(schema));
            modelBuilder.Configurations.Add(new CalcCode6EntityConfiguration(schema));
            modelBuilder.Configurations.Add(new CalcCode7EntityConfiguration(schema));
            modelBuilder.Configurations.Add(new CalcCode8EntityConfiguration(schema));
            modelBuilder.Configurations.Add(new CalcErrorEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new CalcFilterEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new CalcLineTypeEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new CalcTypeEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new CashDiscountEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new CategoryEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new CityEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new ClientDiscountEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new CodaBoxSettingEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new CodeEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new CodeCaptionTranslationEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new CodeTranslationEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new CompanyEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new CompanyRekeningenEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new CompanyUserGroepRightEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new CompanyUserRightEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new ContactEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new ContactCodeEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new ContactsMultiAnaCodeEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new ContactTypeEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new CostHeaderTypeEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new CounterDefinitionEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new CounterWerkCodeEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new CountriesLinkDataEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new CountryEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new CountryLanguageEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new CurrencyEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new DagZoneEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new DocCode1EntityConfiguration(schema));
            modelBuilder.Configurations.Add(new DocCode2EntityConfiguration(schema));
            modelBuilder.Configurations.Add(new DocCode3EntityConfiguration(schema));
            modelBuilder.Configurations.Add(new DocCode4EntityConfiguration(schema));
            modelBuilder.Configurations.Add(new DocumentEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new DocumentTypeEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new DynAx2012CustSettingsEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new EmailTypeEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new EmailTypeTextEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new EmmaAddinEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new EmmaAddinContractEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new EmmaAddinContractsSecurityEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new EmmaAnaCode1EntityConfiguration(schema));
            modelBuilder.Configurations.Add(new EmmaAnaCode2EntityConfiguration(schema));
            modelBuilder.Configurations.Add(new EmmaAnaCode3EntityConfiguration(schema));
            modelBuilder.Configurations.Add(new EmmaAnaCode4EntityConfiguration(schema));
            modelBuilder.Configurations.Add(new EmmaAnaCode5EntityConfiguration(schema));
            modelBuilder.Configurations.Add(new EmmaAnaCode6EntityConfiguration(schema));
            modelBuilder.Configurations.Add(new EmmaAnaCode7EntityConfiguration(schema));
            modelBuilder.Configurations.Add(new EmmaAnaCode8EntityConfiguration(schema));
            modelBuilder.Configurations.Add(new EmmaAnaCode9EntityConfiguration(schema));
            modelBuilder.Configurations.Add(new EmmaMagazijnEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new EmmaOfferLabelValueEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new EmmaOfferTypeEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new EmmaTextenEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new EmmaTextGroupEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new EmmaUserSettingEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new EmmaVerzendwijzeEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new EmmaVkoTypeEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new EmployeeEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new ExactOnlineSettingEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new ExportVatSettingEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new ExternalApiSettingEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new ExternalDatabaseEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new ExternalInvoiceBuildSettingEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new ExternalInvoiceUserSettingEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new HcEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new HerzieningIndexEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new HerzieningTemplateEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new HerzieningTemplateTermEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new IncomingInvoiceSettingEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new InvoiceEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new InvoiceExportEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new InvoiceExportGeneralEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new InvoicePlanDefaultEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new InvoicePlanDefaultsSchijvenEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new KsEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new LanguageEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new MaatTypeEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new MagazijnEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new MobiliteitsCodeEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new MobiliteitsCodeTarievenEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new MobiliteitTariefDetailEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new OpmetingDefinitionEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new ParitairComiteEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new ParitairComiteCounterEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new PayConditionEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new PlanningResourceEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new PrijsAntwoordSoortEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new ProjectCode1EntityConfiguration(schema));
            modelBuilder.Configurations.Add(new ProjectCode2EntityConfiguration(schema));
            modelBuilder.Configurations.Add(new ProjectCode3EntityConfiguration(schema));
            modelBuilder.Configurations.Add(new ProjectCode4EntityConfiguration(schema));
            modelBuilder.Configurations.Add(new ProjectCode5EntityConfiguration(schema));
            modelBuilder.Configurations.Add(new ProjectCode6EntityConfiguration(schema));
            modelBuilder.Configurations.Add(new ProjectCode7EntityConfiguration(schema));
            modelBuilder.Configurations.Add(new ProjectCode8EntityConfiguration(schema));
            modelBuilder.Configurations.Add(new ProjectExplorerSpecialQueryEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new ProjectResultReasonEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new ProjectTypeEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new ProjectTypeUserEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new ProjectTypeUserGroupEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new ProjectTypeWorkFlowEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new ProjectUnitCodeEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new ProjectUnitMultiAnaCodeEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new ProjectUnitsSearchMapUserSettingEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new QueriesDxEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new QueryEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new RegionEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new RekeningNrEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new RelActiviteitEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new RelActiviteitGroupEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new RelationEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new RelationCode1EntityConfiguration(schema));
            modelBuilder.Configurations.Add(new RelationCode2EntityConfiguration(schema));
            modelBuilder.Configurations.Add(new RelationCode3EntityConfiguration(schema));
            modelBuilder.Configurations.Add(new RelationCode4EntityConfiguration(schema));
            modelBuilder.Configurations.Add(new RelationCode5EntityConfiguration(schema));
            modelBuilder.Configurations.Add(new RelationCode6EntityConfiguration(schema));
            modelBuilder.Configurations.Add(new RelationCode7EntityConfiguration(schema));
            modelBuilder.Configurations.Add(new RelationCode8EntityConfiguration(schema));
            modelBuilder.Configurations.Add(new RelationsContactEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new RelationTypeEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new RelOpportunityEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new RelOpportunityGroupEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new ReportEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new ReportLayoutsDxEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new ReportsDxEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new ReportsDxFormLinkEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new SageBobCompanySettingEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new SalesDefaultEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new SecurityRuleEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new SettingEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new SubCategoryEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new SysCalculationParaEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new SysMasterProjectSettingEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new SysMpSettingsCijferEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new SysMpSettingsCijfersLabelEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new SysProjectSettingEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new SysProjectUserSettingEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new SysRelationsParaEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new SysSalesInvoiceParaEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new SysUserFilterEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new SysUserSettingObjectEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new SysUserSettingUserObjectEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new SysUserViewEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new SysWerfParaEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new TeamsIntegrationEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new ToDoItemStateEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new TodoTypeEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new TodoTypeItemStateEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new TofSettingEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new TransportMiddelEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new UcEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new UcUcEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new UnitTypeEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new UserEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new UsersGroepEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new VatEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new VatRegimeEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new VatRegimeNoteEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new VeniceSettingEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new WerfCode1EntityConfiguration(schema));
            modelBuilder.Configurations.Add(new WerfCode2EntityConfiguration(schema));
            modelBuilder.Configurations.Add(new WerfCode3EntityConfiguration(schema));
            modelBuilder.Configurations.Add(new WerfCode4EntityConfiguration(schema));
            modelBuilder.Configurations.Add(new WerfCode5EntityConfiguration(schema));
            modelBuilder.Configurations.Add(new WerfCode6EntityConfiguration(schema));
            modelBuilder.Configurations.Add(new WerfCode7EntityConfiguration(schema));
            modelBuilder.Configurations.Add(new WerfCode8EntityConfiguration(schema));
            modelBuilder.Configurations.Add(new WerfDocSearchMapUserSettingEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new WerfMultiAnaCodeEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new WerfPropertiesItemEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new WerfTypeEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new WerkCodeEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new WholesalerEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new WholesalerUnitcodeEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new WholesalerUserEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new WinbookEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new WinbooksBoekYearPeriodToBoekingDatumEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new WinbooksCompanyEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new WinbooksCompanyTableEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new WinbooksSettingEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new WingsSettingEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new WorkerContractTypeEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new WorkFlowEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new WorkOrderTimeItemsCounterEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new WorkOrderTypeEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new WorkOrderTypeAfdelingEntityConfiguration(schema));
            OnCreateModelPartial(modelBuilder, schema);
            return modelBuilder;
        }

        partial void InitializePartial();
        partial void DisposePartial(bool disposing);
        partial void OnModelCreatingPartial(System.Data.Entity.DbModelBuilder modelBuilder);
		static partial void OnCreateModelPartial(System.Data.Entity.DbModelBuilder modelBuilder, string schema);        
    }
}
