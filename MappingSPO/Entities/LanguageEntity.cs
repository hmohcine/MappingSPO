
namespace MappingSPO.Entities
{
    public partial class LanguageEntity
    {
		public LanguageEntity()
        {
            ArticleDefaults_ArtLanguage1 = new System.Collections.Generic.List<ArticleDefaultEntity>();
            ArticleDefaults_ArtLanguage2 = new System.Collections.Generic.List<ArticleDefaultEntity>();
            ArticleDefaults_ArtLanguage3 = new System.Collections.Generic.List<ArticleDefaultEntity>();
            ArticleDefaults_ArtLanguage4 = new System.Collections.Generic.List<ArticleDefaultEntity>();
            ArticleDefaults_DefaultArtLanguage = new System.Collections.Generic.List<ArticleDefaultEntity>();
            CodeCaptionTranslations = new System.Collections.Generic.List<CodeCaptionTranslationEntity>();
            CodeTranslations = new System.Collections.Generic.List<CodeTranslationEntity>();
            Companies = new System.Collections.Generic.List<CompanyEntity>();
            Contacts = new System.Collections.Generic.List<ContactEntity>();
            CountryLanguages = new System.Collections.Generic.List<CountryLanguageEntity>();
            EmailTypeTexts = new System.Collections.Generic.List<EmailTypeTextEntity>();
            EmmaOfferLabelValues = new System.Collections.Generic.List<EmmaOfferLabelValueEntity>();
            EmmaTextens = new System.Collections.Generic.List<EmmaTextenEntity>();
            Employees = new System.Collections.Generic.List<EmployeeEntity>();
            Invoices = new System.Collections.Generic.List<InvoiceEntity>();
            Relations = new System.Collections.Generic.List<RelationEntity>();
            ReportLayoutsDxes = new System.Collections.Generic.List<ReportLayoutsDxEntity>();
            Reports = new System.Collections.Generic.List<ReportEntity>();
            SysCalculationParas = new System.Collections.Generic.List<SysCalculationParaEntity>();
            Users = new System.Collections.Generic.List<UserEntity>();
            VatRegimeNotes = new System.Collections.Generic.List<VatRegimeNoteEntity>();
            InitializePartial();
		}

        public string Code { get; set; }
        public string Language_ { get; set; }
        public string ExterneCode { get; set; }
        public System.Collections.Generic.ICollection<ArticleDefaultEntity> ArticleDefaults_ArtLanguage1 { get; set; }
        public System.Collections.Generic.ICollection<ArticleDefaultEntity> ArticleDefaults_ArtLanguage2 { get; set; }
        public System.Collections.Generic.ICollection<ArticleDefaultEntity> ArticleDefaults_ArtLanguage3 { get; set; }
        public System.Collections.Generic.ICollection<ArticleDefaultEntity> ArticleDefaults_ArtLanguage4 { get; set; }
        public System.Collections.Generic.ICollection<ArticleDefaultEntity> ArticleDefaults_DefaultArtLanguage { get; set; }
        public System.Collections.Generic.ICollection<CodeCaptionTranslationEntity> CodeCaptionTranslations { get; set; }
        public System.Collections.Generic.ICollection<CodeTranslationEntity> CodeTranslations { get; set; }
        public System.Collections.Generic.ICollection<CompanyEntity> Companies { get; set; }
        public System.Collections.Generic.ICollection<ContactEntity> Contacts { get; set; }
        public System.Collections.Generic.ICollection<CountryLanguageEntity> CountryLanguages { get; set; }
        public System.Collections.Generic.ICollection<EmailTypeTextEntity> EmailTypeTexts { get; set; }
        public System.Collections.Generic.ICollection<EmmaOfferLabelValueEntity> EmmaOfferLabelValues { get; set; }
        public System.Collections.Generic.ICollection<EmmaTextenEntity> EmmaTextens { get; set; }
        public System.Collections.Generic.ICollection<EmployeeEntity> Employees { get; set; }
        public System.Collections.Generic.ICollection<InvoiceEntity> Invoices { get; set; }
        public System.Collections.Generic.ICollection<RelationEntity> Relations { get; set; }
        public System.Collections.Generic.ICollection<ReportEntity> Reports { get; set; }
        public System.Collections.Generic.ICollection<ReportLayoutsDxEntity> ReportLayoutsDxes { get; set; }
        public System.Collections.Generic.ICollection<SysCalculationParaEntity> SysCalculationParas { get; set; }
        public System.Collections.Generic.ICollection<UserEntity> Users { get; set; }
        public System.Collections.Generic.ICollection<VatRegimeNoteEntity> VatRegimeNotes { get; set; }
             
        partial void InitializePartial();
    }
}
