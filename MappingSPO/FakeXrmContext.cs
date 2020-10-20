using MappingSPO.Configurations;
using MappingSPO.Entities;

namespace MappingSPO
{
    using System.Linq;

    public partial class FakeXrmContext : IXrmContext
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

        public FakeXrmContext()
        {
            _changeTracker = null;
            _configuration = null;
            _database = null;

            Activiteitens = new FakeDbSet<ActiviteitenEntity>("ActiviteitId");
            ActiviteitGpsLinkDatas = new FakeDbSet<ActiviteitGpsLinkDataEntity>("ActiviteitId");
            ActiviteitGroups = new FakeDbSet<ActiviteitGroupEntity>("ActGroupId");
            Addins = new FakeDbSet<AddinEntity>("AddinId");
            AddinContracts = new FakeDbSet<AddinContractEntity>("ContractId", "Number");
            AddinContractsSecurities = new FakeDbSet<AddinContractsSecurityEntity>("ContractId", "Number", "UserGroupId");
            Afdelings = new FakeDbSet<AfdelingEntity>("AfdelingId");
            AfmeldingPuntTypes = new FakeDbSet<AfmeldingPuntTypeEntity>("AfmpuntType");
            AfmeldingsPuntens = new FakeDbSet<AfmeldingsPuntenEntity>("AfmpuntId");
            AfmeldingspuntenGpsLinkDatas = new FakeDbSet<AfmeldingspuntenGpsLinkDataEntity>("AfmpuntId");
            ArticleDefaults = new FakeDbSet<ArticleDefaultEntity>("Id");
            AutomaticCalcLibraries = new FakeDbSet<AutomaticCalcLibraryEntity>("Id", "CalcId");
            AutomaticCalcSettings = new FakeDbSet<AutomaticCalcSettingEntity>("Id");
            BAnaCodes = new FakeDbSet<BAnaCodeEntity>("AnaCodeId");
            BAnaGroup1 = new FakeDbSet<BAnaGroup1Entity>("GroupId");
            BAnaSubGroups = new FakeDbSet<BAnaSubGroupEntity>("SubGroupId");
            BatchJobs = new FakeDbSet<BatchJobEntity>("BatchJobId");
            BatchJobParameters = new FakeDbSet<BatchJobParameterEntity>("Id");
            BatchServiceSettings = new FakeDbSet<BatchServiceSettingEntity>("Id");
            BetaalWijzes = new FakeDbSet<BetaalWijzeEntity>("BetaalwijzeId");
            BoekPeriodes = new FakeDbSet<BoekPeriodeEntity>("CompanyId", "BoekPeriode_");
            BtwBoekingsgroeps = new FakeDbSet<BtwBoekingsgroepEntity>("BtwBoekingsgroepId");
            CalcCode1 = new FakeDbSet<CalcCode1Entity>("CalcCodeId");
            CalcCode2 = new FakeDbSet<CalcCode2Entity>("CalcCodeId");
            CalcCode3 = new FakeDbSet<CalcCode3Entity>("CalcCodeId");
            CalcCode4 = new FakeDbSet<CalcCode4Entity>("CalcCodeId");
            CalcCode5 = new FakeDbSet<CalcCode5Entity>("CalcCodeId");
            CalcCode6 = new FakeDbSet<CalcCode6Entity>("CalcCodeId");
            CalcCode7 = new FakeDbSet<CalcCode7Entity>("CalcCodeId");
            CalcCode8 = new FakeDbSet<CalcCode8Entity>("CalcCodeId");
            CalcErrors = new FakeDbSet<CalcErrorEntity>("Id");
            CalcFilters = new FakeDbSet<CalcFilterEntity>("CalcFilterId");
            CalcLineTypes = new FakeDbSet<CalcLineTypeEntity>("CalcLineTypeCode");
            CalcTypes = new FakeDbSet<CalcTypeEntity>("CalcTypeId");
            CashDiscounts = new FakeDbSet<CashDiscountEntity>("CashDiscountId");
            Categories = new FakeDbSet<CategoryEntity>("CategoryId");
            Cities = new FakeDbSet<CityEntity>("Id");
            ClientDiscounts = new FakeDbSet<ClientDiscountEntity>("ClientDiscountId");
            CodaBoxSettings = new FakeDbSet<CodaBoxSettingEntity>("SettingName");
            Codes = new FakeDbSet<CodeEntity>("Id");
            CodeCaptionTranslations = new FakeDbSet<CodeCaptionTranslationEntity>("Id");
            CodeTranslations = new FakeDbSet<CodeTranslationEntity>("Id");
            Companies = new FakeDbSet<CompanyEntity>("CompanyId");
            CompanyRekeningens = new FakeDbSet<CompanyRekeningenEntity>("CompanyId", "RekeningId");
            CompanyUserGroepRights = new FakeDbSet<CompanyUserGroepRightEntity>("CompanyId", "UserGroupId");
            CompanyUserRights = new FakeDbSet<CompanyUserRightEntity>("CompanyId", "UserId");
            Contacts = new FakeDbSet<ContactEntity>("ContactId");
            ContactCodes = new FakeDbSet<ContactCodeEntity>("CodeId");
            ContactsMultiAnaCodes = new FakeDbSet<ContactsMultiAnaCodeEntity>("MultiId");
            ContactTypes = new FakeDbSet<ContactTypeEntity>("ContactTypeId");
            CostHeaderTypes = new FakeDbSet<CostHeaderTypeEntity>("CostHeaderType_");
            CounterDefinitions = new FakeDbSet<CounterDefinitionEntity>("CounterId");
            CounterWerkCodes = new FakeDbSet<CounterWerkCodeEntity>("CounterId", "WerkCode");
            CountriesLinkDatas = new FakeDbSet<CountriesLinkDataEntity>("Source", "CountryCode");
            Countries = new FakeDbSet<CountryEntity>("CountryCode");
            CountryLanguages = new FakeDbSet<CountryLanguageEntity>("CountryCode", "Code");
            Currencies = new FakeDbSet<CurrencyEntity>("CurrencyCode");
            DagZones = new FakeDbSet<DagZoneEntity>("DagZone_");
            DocCode1 = new FakeDbSet<DocCode1Entity>("CodeId");
            DocCode2 = new FakeDbSet<DocCode2Entity>("CodeId");
            DocCode3 = new FakeDbSet<DocCode3Entity>("CodeId");
            DocCode4 = new FakeDbSet<DocCode4Entity>("CodeId");
            Documents = new FakeDbSet<DocumentEntity>("DocumentId");
            DocumentTypes = new FakeDbSet<DocumentTypeEntity>("DocTypeId");
            DynAx2012CustSettings = new FakeDbSet<DynAx2012CustSettingsEntity>("Id");
            EmailTypes = new FakeDbSet<EmailTypeEntity>("EmailTypeId");
            EmailTypeTexts = new FakeDbSet<EmailTypeTextEntity>("EmailTypeTextId");
            EmmaAddins = new FakeDbSet<EmmaAddinEntity>("AddinId");
            EmmaAddinContracts = new FakeDbSet<EmmaAddinContractEntity>("ContractId", "Number");
            EmmaAddinContractsSecurities = new FakeDbSet<EmmaAddinContractsSecurityEntity>("ContractId", "Number", "UserGroupId");
            EmmaAnaCode1 = new FakeDbSet<EmmaAnaCode1Entity>("CodeId");
            EmmaAnaCode2 = new FakeDbSet<EmmaAnaCode2Entity>("CodeId");
            EmmaAnaCode3 = new FakeDbSet<EmmaAnaCode3Entity>("CodeId");
            EmmaAnaCode4 = new FakeDbSet<EmmaAnaCode4Entity>("CodeId");
            EmmaAnaCode5 = new FakeDbSet<EmmaAnaCode5Entity>("CodeId");
            EmmaAnaCode6 = new FakeDbSet<EmmaAnaCode6Entity>("CodeId");
            EmmaAnaCode7 = new FakeDbSet<EmmaAnaCode7Entity>("CodeId");
            EmmaAnaCode8 = new FakeDbSet<EmmaAnaCode8Entity>("CodeId");
            EmmaAnaCode9 = new FakeDbSet<EmmaAnaCode9Entity>("CodeId");
            EmmaMagazijns = new FakeDbSet<EmmaMagazijnEntity>("MagazijnId");
            EmmaOfferLabelValues = new FakeDbSet<EmmaOfferLabelValueEntity>("LabelId", "OfferType");
            EmmaOfferTypes = new FakeDbSet<EmmaOfferTypeEntity>("OfferType");
            EmmaTextens = new FakeDbSet<EmmaTextenEntity>("TextId");
            EmmaTextGroups = new FakeDbSet<EmmaTextGroupEntity>("GroupId");
            EmmaUserSettings = new FakeDbSet<EmmaUserSettingEntity>("UserId");
            EmmaVerzendwijzes = new FakeDbSet<EmmaVerzendwijzeEntity>("VerzendWijzeId");
            EmmaVkoTypes = new FakeDbSet<EmmaVkoTypeEntity>("VkoType");
            Employees = new FakeDbSet<EmployeeEntity>("EmployeeId");
            ExactOnlineSettings = new FakeDbSet<ExactOnlineSettingEntity>("Id");
            ExportVatSettings = new FakeDbSet<ExportVatSettingEntity>("Id");
            ExternalApiSettings = new FakeDbSet<ExternalApiSettingEntity>("Id");
            ExternalDatabases = new FakeDbSet<ExternalDatabaseEntity>("ExternalDbid");
            ExternalInvoiceBuildSettings = new FakeDbSet<ExternalInvoiceBuildSettingEntity>("Id");
            ExternalInvoiceUserSettings = new FakeDbSet<ExternalInvoiceUserSettingEntity>("UserId");
            Hcs = new FakeDbSet<HcEntity>("CalcHc");
            HerzieningIndexes = new FakeDbSet<HerzieningIndexEntity>("IndexCode");
            HerzieningTemplates = new FakeDbSet<HerzieningTemplateEntity>("HerzieningTemplateId");
            HerzieningTemplateTerms = new FakeDbSet<HerzieningTemplateTermEntity>("HerzieningTemplateId", "TermId");
            IncomingInvoiceSettings = new FakeDbSet<IncomingInvoiceSettingEntity>("Id");
            Invoices = new FakeDbSet<InvoiceEntity>("InvoiceId");
            InvoiceExports = new FakeDbSet<InvoiceExportEntity>("CountryCode", "VatCode", "BtwRegime");
            InvoiceExportGenerals = new FakeDbSet<InvoiceExportGeneralEntity>("Id");
            InvoicePlanDefaults = new FakeDbSet<InvoicePlanDefaultEntity>("InvPlanId");
            InvoicePlanDefaultsSchijvens = new FakeDbSet<InvoicePlanDefaultsSchijvenEntity>("InvPlanId", "SchijfNr");
            Ks = new FakeDbSet<KsEntity>("Ks_");
            Languages = new FakeDbSet<LanguageEntity>("Code");
            MaatTypes = new FakeDbSet<MaatTypeEntity>("Id");
            Magazijns = new FakeDbSet<MagazijnEntity>("MagazijnId");
            MobiliteitsCodes = new FakeDbSet<MobiliteitsCodeEntity>("Code");
            MobiliteitsCodeTarievens = new FakeDbSet<MobiliteitsCodeTarievenEntity>("Code", "StartDate");
            MobiliteitTariefDetails = new FakeDbSet<MobiliteitTariefDetailEntity>("MobCode", "KmFrom");
            OpmetingDefinitions = new FakeDbSet<OpmetingDefinitionEntity>("OpmetingDefinitionId");
            ParitairComites = new FakeDbSet<ParitairComiteEntity>("ParitairComiteId");
            ParitairComiteCounters = new FakeDbSet<ParitairComiteCounterEntity>("PcCounterId");
            PayConditions = new FakeDbSet<PayConditionEntity>("PayConditionId");
            PlanningResources = new FakeDbSet<PlanningResourceEntity>("ResourceId");
            PrijsAntwoordSoorts = new FakeDbSet<PrijsAntwoordSoortEntity>("AntwoordSoortId");
            ProjectCode1 = new FakeDbSet<ProjectCode1Entity>("CodeId");
            ProjectCode2 = new FakeDbSet<ProjectCode2Entity>("CodeId");
            ProjectCode3 = new FakeDbSet<ProjectCode3Entity>("CodeId");
            ProjectCode4 = new FakeDbSet<ProjectCode4Entity>("CodeId");
            ProjectCode5 = new FakeDbSet<ProjectCode5Entity>("CodeId");
            ProjectCode6 = new FakeDbSet<ProjectCode6Entity>("CodeId");
            ProjectCode7 = new FakeDbSet<ProjectCode7Entity>("CodeId");
            ProjectCode8 = new FakeDbSet<ProjectCode8Entity>("CodeId");
            ProjectExplorerSpecialQueries = new FakeDbSet<ProjectExplorerSpecialQueryEntity>("Code");
            ProjectResultReasons = new FakeDbSet<ProjectResultReasonEntity>("ProjectResultReasonId");
            ProjectTypes = new FakeDbSet<ProjectTypeEntity>("ProjectType_");
            ProjectTypeUsers = new FakeDbSet<ProjectTypeUserEntity>("ProjectType", "UserId");
            ProjectTypeUserGroups = new FakeDbSet<ProjectTypeUserGroupEntity>("ProjectType", "UserGroupId");
            ProjectTypeWorkFlows = new FakeDbSet<ProjectTypeWorkFlowEntity>("ProjectType", "WorkflowId");
            ProjectUnitCodes = new FakeDbSet<ProjectUnitCodeEntity>("CodeId");
            ProjectUnitMultiAnaCodes = new FakeDbSet<ProjectUnitMultiAnaCodeEntity>("MultiId");
            ProjectUnitsSearchMapUserSettings = new FakeDbSet<ProjectUnitsSearchMapUserSettingEntity>("UserId", "MapNr");
            QueriesDxes = new FakeDbSet<QueriesDxEntity>("QueryId");
            Queries = new FakeDbSet<QueryEntity>("Number");
            Regions = new FakeDbSet<RegionEntity>("RegioId");
            RekeningNrs = new FakeDbSet<RekeningNrEntity>("RekeningId");
            RelActiviteits = new FakeDbSet<RelActiviteitEntity>("ActiviteitId");
            RelActiviteitGroups = new FakeDbSet<RelActiviteitGroupEntity>("ActGroupId");
            Relations = new FakeDbSet<RelationEntity>("RelationId");
            RelationCode1 = new FakeDbSet<RelationCode1Entity>("RelationCodeId");
            RelationCode2 = new FakeDbSet<RelationCode2Entity>("RelationCodeId");
            RelationCode3 = new FakeDbSet<RelationCode3Entity>("RelationCodeId");
            RelationCode4 = new FakeDbSet<RelationCode4Entity>("RelationCodeId");
            RelationCode5 = new FakeDbSet<RelationCode5Entity>("RelationCodeId");
            RelationCode6 = new FakeDbSet<RelationCode6Entity>("RelationCodeId");
            RelationCode7 = new FakeDbSet<RelationCode7Entity>("RelationCodeId");
            RelationCode8 = new FakeDbSet<RelationCode8Entity>("RelationCodeId");
            RelationsContacts = new FakeDbSet<RelationsContactEntity>("RelationId", "ContactId");
            RelationTypes = new FakeDbSet<RelationTypeEntity>("RelationTypeId");
            RelOpportunities = new FakeDbSet<RelOpportunityEntity>("OpportunityId");
            RelOpportunityGroups = new FakeDbSet<RelOpportunityGroupEntity>("OppGroupId");
            Reports = new FakeDbSet<ReportEntity>("ReportId");
            ReportLayoutsDxes = new FakeDbSet<ReportLayoutsDxEntity>("ReportId", "LangCode");
            ReportsDxes = new FakeDbSet<ReportsDxEntity>("ReportId");
            ReportsDxFormLinks = new FakeDbSet<ReportsDxFormLinkEntity>("Id");
            SageBobCompanySettings = new FakeDbSet<SageBobCompanySettingEntity>("Id");
            SalesDefaults = new FakeDbSet<SalesDefaultEntity>("Id");
            SecurityRules = new FakeDbSet<SecurityRuleEntity>("RuleId");
            Settings = new FakeDbSet<SettingEntity>("Id");
            SubCategories = new FakeDbSet<SubCategoryEntity>("SubCategoryId");
            SysCalculationParas = new FakeDbSet<SysCalculationParaEntity>("Id");
            SysMasterProjectSettings = new FakeDbSet<SysMasterProjectSettingEntity>("MpId");
            SysMpSettingsCijfers = new FakeDbSet<SysMpSettingsCijferEntity>("KolomId");
            SysMpSettingsCijfersLabels = new FakeDbSet<SysMpSettingsCijfersLabelEntity>("KolomId", "UiLanguageCode");
            SysProjectSettings = new FakeDbSet<SysProjectSettingEntity>("Id");
            SysProjectUserSettings = new FakeDbSet<SysProjectUserSettingEntity>("Id", "UserId");
            SysRelationsParas = new FakeDbSet<SysRelationsParaEntity>("Id");
            SysSalesInvoiceParas = new FakeDbSet<SysSalesInvoiceParaEntity>("Id");
            SysUserFilters = new FakeDbSet<SysUserFilterEntity>("Id");
            SysUserSettingObjects = new FakeDbSet<SysUserSettingObjectEntity>("ObjectId");
            SysUserSettingUserObjects = new FakeDbSet<SysUserSettingUserObjectEntity>("ObjectId", "UserId");
            SysUserViews = new FakeDbSet<SysUserViewEntity>("Id");
            SysWerfParas = new FakeDbSet<SysWerfParaEntity>("Id1");
            TeamsIntegrations = new FakeDbSet<TeamsIntegrationEntity>("TeamIntegrateId");
            ToDoItemStates = new FakeDbSet<ToDoItemStateEntity>("ItemStateId");
            TodoTypes = new FakeDbSet<TodoTypeEntity>("TodoTypeId");
            TodoTypeItemStates = new FakeDbSet<TodoTypeItemStateEntity>("TodoTypeItemStateId");
            TofSettings = new FakeDbSet<TofSettingEntity>("Id");
            TransportMiddels = new FakeDbSet<TransportMiddelEntity>("TransportMiddelId");
            Ucs = new FakeDbSet<UcEntity>("Uc_");
            UcUcs = new FakeDbSet<UcUcEntity>("UcParent", "Uc");
            UnitTypes = new FakeDbSet<UnitTypeEntity>("UnittypeId");
            Users = new FakeDbSet<UserEntity>("UserId");
            UsersGroeps = new FakeDbSet<UsersGroepEntity>("UserGroupId");
            Vats = new FakeDbSet<VatEntity>("VatCode");
            VatRegimes = new FakeDbSet<VatRegimeEntity>("BtwRegime");
            VatRegimeNotes = new FakeDbSet<VatRegimeNoteEntity>("BtwRegime", "LanguageCode");
            VeniceSettings = new FakeDbSet<VeniceSettingEntity>("Id");
            WerfCode1 = new FakeDbSet<WerfCode1Entity>("CodeId");
            WerfCode2 = new FakeDbSet<WerfCode2Entity>("CodeId");
            WerfCode3 = new FakeDbSet<WerfCode3Entity>("CodeId");
            WerfCode4 = new FakeDbSet<WerfCode4Entity>("CodeId");
            WerfCode5 = new FakeDbSet<WerfCode5Entity>("CodeId");
            WerfCode6 = new FakeDbSet<WerfCode6Entity>("CodeId");
            WerfCode7 = new FakeDbSet<WerfCode7Entity>("CodeId");
            WerfCode8 = new FakeDbSet<WerfCode8Entity>("CodeId");
            WerfDocSearchMapUserSettings = new FakeDbSet<WerfDocSearchMapUserSettingEntity>("UserId", "MapNr", "DocMayorType");
            WerfMultiAnaCodes = new FakeDbSet<WerfMultiAnaCodeEntity>("MultiId");
            WerfPropertiesItems = new FakeDbSet<WerfPropertiesItemEntity>("Name");
            WerfTypes = new FakeDbSet<WerfTypeEntity>("WerfTypeId");
            WerkCodes = new FakeDbSet<WerkCodeEntity>("WerkCode_");
            Wholesalers = new FakeDbSet<WholesalerEntity>("Wholesalerkey", "Environment");
            WholesalerUnitcodes = new FakeDbSet<WholesalerUnitcodeEntity>("Wholesalerkey", "Environment", "UcWholesaler");
            WholesalerUsers = new FakeDbSet<WholesalerUserEntity>("Wholesalerkey", "Environment", "UserId");
            Winbooks = new FakeDbSet<WinbookEntity>("Wbid");
            WinbooksBoekYearPeriodToBoekingDatums = new FakeDbSet<WinbooksBoekYearPeriodToBoekingDatumEntity>("CompanyId", "Bookyear", "Period");
            WinbooksCompanies = new FakeDbSet<WinbooksCompanyEntity>("Wbid", "CompanyId");
            WinbooksCompanyTables = new FakeDbSet<WinbooksCompanyTableEntity>("Wbid", "CompanyId", "TableId");
            WinbooksSettings = new FakeDbSet<WinbooksSettingEntity>("Id");
            WingsSettings = new FakeDbSet<WingsSettingEntity>("Id");
            WorkerContractTypes = new FakeDbSet<WorkerContractTypeEntity>("ContractTypeId");
            WorkFlows = new FakeDbSet<WorkFlowEntity>("WorkflowId");
            WorkOrderTimeItemsCounters = new FakeDbSet<WorkOrderTimeItemsCounterEntity>("Id");
            WorkOrderTypes = new FakeDbSet<WorkOrderTypeEntity>("WorkOrderTypeId");
            WorkOrderTypeAfdelings = new FakeDbSet<WorkOrderTypeAfdelingEntity>("WorkOrderTypeId", "AfdelingId");

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

    }
}
