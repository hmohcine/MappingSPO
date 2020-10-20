using MappingSPO.Entities;

namespace MappingSPO
{
    public class ArticleDefaultEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<ArticleDefaultEntity>
    {
        public ArticleDefaultEntityConfiguration()
            : this("Settings")
        {
        }

        public ArticleDefaultEntityConfiguration(string schema)
        {
            ToTable("tArticleDefaults", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.DefaultEc).HasColumnName(@"DefaultEC").HasColumnType("nvarchar").IsOptional().HasMaxLength(10);
            Property(x => x.DefaultKs).HasColumnName(@"DefaultKS").HasColumnType("nvarchar").IsOptional().HasMaxLength(10);
            Property(x => x.DefaultCurrencyCode).HasColumnName(@"DefaultCurrencyCode").HasColumnType("nchar").IsOptional().IsFixedLength().HasMaxLength(4);
            Property(x => x.DefaultVatCode).HasColumnName(@"DefaultVatCode").HasColumnType("int").IsOptional();
            Property(x => x.DefaultRoundPosition).HasColumnName(@"DefaultRoundPosition").HasColumnType("int").IsOptional();
            Property(x => x.ArtLabel0).HasColumnName(@"ArtLabel0").HasColumnType("nvarchar").IsOptional().HasMaxLength(30);
            Property(x => x.ArtLabel1).HasColumnName(@"ArtLabel1").HasColumnType("nvarchar").IsOptional().HasMaxLength(30);
            Property(x => x.ArtLabel2).HasColumnName(@"ArtLabel2").HasColumnType("nvarchar").IsOptional().HasMaxLength(30);
            Property(x => x.ArtLabel3).HasColumnName(@"ArtLabel3").HasColumnType("nvarchar").IsOptional().HasMaxLength(30);
            Property(x => x.ArtLabel4).HasColumnName(@"ArtLabel4").HasColumnType("nvarchar").IsOptional().HasMaxLength(30);
            Property(x => x.ArtLabel5).HasColumnName(@"ArtLabel5").HasColumnType("nvarchar").IsOptional().HasMaxLength(30);
            Property(x => x.ArtLabel6).HasColumnName(@"ArtLabel6").HasColumnType("nvarchar").IsOptional().HasMaxLength(30);
            Property(x => x.ArtLabel7).HasColumnName(@"ArtLabel7").HasColumnType("nvarchar").IsOptional().HasMaxLength(30);
            Property(x => x.ArtLabel8).HasColumnName(@"ArtLabel8").HasColumnType("nvarchar").IsOptional().HasMaxLength(30);
            Property(x => x.DiscountPermitted).HasColumnName(@"DiscountPermitted").HasColumnType("bit").IsOptional();
            Property(x => x.MaxDiscountOnMarge).HasColumnName(@"MaxDiscountOnMarge").HasColumnType("float").IsOptional();
            Property(x => x.ArtLanguage1).HasColumnName(@"ArtLanguage1").HasColumnType("nchar").IsOptional().IsFixedLength().HasMaxLength(4);
            Property(x => x.ArtLanguage2).HasColumnName(@"ArtLanguage2").HasColumnType("nchar").IsOptional().IsFixedLength().HasMaxLength(4);
            Property(x => x.ArtLanguage3).HasColumnName(@"ArtLanguage3").HasColumnType("nchar").IsOptional().IsFixedLength().HasMaxLength(4);
            Property(x => x.ArtLanguage4).HasColumnName(@"ArtLanguage4").HasColumnType("nchar").IsOptional().IsFixedLength().HasMaxLength(4);
            Property(x => x.CalcLogicCode).HasColumnName(@"CalcLogicCode").HasColumnType("int").IsOptional();
            Property(x => x.TargetWinstpct).HasColumnName(@"TargetWinstpct").HasColumnType("float").IsOptional();
            Property(x => x.ShowNotesExternOffer).HasColumnName(@"ShowNotesExternOffer").HasColumnType("bit").IsOptional();
            Property(x => x.ShowNotesExternVko).HasColumnName(@"ShowNotesExternVKO").HasColumnType("bit").IsOptional();
            Property(x => x.ShowNotesExternInvoice).HasColumnName(@"ShowNotesExternInvoice").HasColumnType("bit").IsOptional();
            Property(x => x.ShowNotesExternLeverbon).HasColumnName(@"ShowNotesExternLeverbon").HasColumnType("bit").IsOptional();
            Property(x => x.ShowNotesExternBestelbon).HasColumnName(@"ShowNotesExternBestelbon").HasColumnType("bit").IsOptional();
            Property(x => x.ArtImageImportSize).HasColumnName(@"ArtImageImportSize").HasColumnType("int").IsOptional();
            Property(x => x.DefaultEcGewicht).HasColumnName(@"DefaultECGewicht").HasColumnType("nvarchar").IsOptional().HasMaxLength(10);
            Property(x => x.DefaultEcVolume).HasColumnName(@"DefaultECVolume").HasColumnType("nvarchar").IsOptional().HasMaxLength(10);
            Property(x => x.DefaultArtLanguage).HasColumnName(@"DefaultArtLanguage").HasColumnType("nchar").IsOptional().IsFixedLength().HasMaxLength(4);
            Property(x => x.WPrijsMode).HasColumnName(@"WPrijsMode").HasColumnType("int").IsRequired();
            Property(x => x.WPrijsVerdeelWijze).HasColumnName(@"WPrijsVerdeelWijze").HasColumnType("int").IsRequired();
            Property(x => x.DefaultDimEc).HasColumnName(@"DefaultDimEC").HasColumnType("nvarchar").IsOptional().HasMaxLength(10);
            Property(x => x.BsStockBibMode).HasColumnName(@"BSStockBibMode").HasColumnType("int").IsRequired();
            Property(x => x.BsDefaultLanguage).HasColumnName(@"BSDefaultLanguage").HasColumnType("nchar").IsOptional().IsFixedLength().HasMaxLength(4);
            Property(x => x.InfoLabel01).HasColumnName(@"InfoLabel01").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.InfoLabel02).HasColumnName(@"InfoLabel02").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.InfoLabel03).HasColumnName(@"InfoLabel03").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.InfoLabel04).HasColumnName(@"InfoLabel04").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.SuplArtInfoLabel01).HasColumnName(@"SuplArtInfoLabel01").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.SuplArtInfoLabel02).HasColumnName(@"SuplArtInfoLabel02").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.SuplArtInfoLabel03).HasColumnName(@"SuplArtInfoLabel03").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.SuplArtInfoLabel04).HasColumnName(@"SuplArtInfoLabel04").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.NumLabel01).HasColumnName(@"NumLabel01").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.NumLabel02).HasColumnName(@"NumLabel02").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.NumLabel03).HasColumnName(@"NumLabel03").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.NumLabel04).HasColumnName(@"NumLabel04").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.RefLabel01).HasColumnName(@"RefLabel01").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.RefLabel02).HasColumnName(@"RefLabel02").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.RefLabel03).HasColumnName(@"RefLabel03").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.RefLabel04).HasColumnName(@"RefLabel04").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.SuplArtRefLabel01).HasColumnName(@"SuplArtRefLabel01").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.SuplArtRefLabel02).HasColumnName(@"SuplArtRefLabel02").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.SuplArtRefLabel03).HasColumnName(@"SuplArtRefLabel03").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.SuplArtRefLabel04).HasColumnName(@"SuplArtRefLabel04").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.CalcDetailSettingNum01).HasColumnName(@"CalcDetail_SettingNum01").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.CalcDetailSettingNum02).HasColumnName(@"CalcDetail_SettingNum02").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.CalcDetailSettingNum03).HasColumnName(@"CalcDetail_SettingNum03").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.CalcDetailSettingNum04).HasColumnName(@"CalcDetail_SettingNum04").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.CalcDetailSettingNum05).HasColumnName(@"CalcDetail_SettingNum05").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.CalcDetailSettingNum06).HasColumnName(@"CalcDetail_SettingNum06").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.CalcDetailSettingNum07).HasColumnName(@"CalcDetail_SettingNum07").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.CalcDetailSettingNum08).HasColumnName(@"CalcDetail_SettingNum08").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.IsToeslagActive).HasColumnName(@"IsToeslagActive").HasColumnType("bit").IsOptional();
            Property(x => x.WerflijstToVko).HasColumnName(@"WerflijstToVKO").HasColumnType("bit").IsOptional();
            Property(x => x.DefaultVkoTypeForBssIntegratie).HasColumnName(@"DefaultVKOTypeForBSSIntegratie").HasColumnType("nvarchar").IsOptional().HasMaxLength(2);
            Property(x => x.DefaultVkoCompanyIdForBssIntegratie).HasColumnName(@"DefaultVKOCompanyIDForBSSIntegratie").HasColumnType("int").IsOptional();
            Property(x => x.DefaultVkoCompanyIdStockForBssIntegratie).HasColumnName(@"DefaultVKOCompanyIDStockForBSSIntegratie").HasColumnType("int").IsOptional();
            Property(x => x.CreateSbLeveringOnEmmaLeverBonState).HasColumnName(@"CreateSBLeveringOnEmmaLeverBonState").HasColumnType("int").IsOptional();
            Property(x => x.DefaultVkoLeveradresRelationType).HasColumnName(@"DefaultVKOLeveradresRelationType").HasColumnType("int").IsOptional();
            Property(x => x.DefaultVkoLeveradresMode).HasColumnName(@"DefaultVKOLeveradresMode").HasColumnType("int").IsRequired();
            Property(x => x.DefaultVkoStateForBssIntegratie).HasColumnName(@"DefaultVKOStateForBSSIntegratie").HasColumnType("int").IsRequired();

            HasOptional(a => a.Currency).WithMany(b => b.ArticleDefaults).HasForeignKey(c => c.DefaultCurrencyCode).WillCascadeOnDelete(false);
            HasOptional(a => a.Ks).WithMany(b => b.ArticleDefaults).HasForeignKey(c => c.DefaultKs).WillCascadeOnDelete(false);
            HasOptional(a => a.Language_ArtLanguage1).WithMany(b => b.ArticleDefaults_ArtLanguage1).HasForeignKey(c => c.ArtLanguage1).WillCascadeOnDelete(false);
            HasOptional(a => a.Language_ArtLanguage2).WithMany(b => b.ArticleDefaults_ArtLanguage2).HasForeignKey(c => c.ArtLanguage2).WillCascadeOnDelete(false);
            HasOptional(a => a.Language_ArtLanguage3).WithMany(b => b.ArticleDefaults_ArtLanguage3).HasForeignKey(c => c.ArtLanguage3).WillCascadeOnDelete(false);
            HasOptional(a => a.Language_ArtLanguage4).WithMany(b => b.ArticleDefaults_ArtLanguage4).HasForeignKey(c => c.ArtLanguage4).WillCascadeOnDelete(false);
            HasOptional(a => a.Language_DefaultArtLanguage).WithMany(b => b.ArticleDefaults_DefaultArtLanguage).HasForeignKey(c => c.DefaultArtLanguage).WillCascadeOnDelete(false);
            HasOptional(a => a.RelationType).WithMany(b => b.ArticleDefaults).HasForeignKey(c => c.DefaultVkoLeveradresRelationType).WillCascadeOnDelete(false);
            HasOptional(a => a.Uc_DefaultEc).WithMany(b => b.ArticleDefaults_DefaultEc).HasForeignKey(c => c.DefaultEc).WillCascadeOnDelete(false);
            HasOptional(a => a.Uc_DefaultEcGewicht).WithMany(b => b.ArticleDefaults_DefaultEcGewicht).HasForeignKey(c => c.DefaultEcGewicht).WillCascadeOnDelete(false);
            HasOptional(a => a.Uc_DefaultEcVolume).WithMany(b => b.ArticleDefaults_DefaultEcVolume).HasForeignKey(c => c.DefaultEcVolume).WillCascadeOnDelete(false);
            HasOptional(a => a.Vat).WithMany(b => b.ArticleDefaults).HasForeignKey(c => c.DefaultVatCode).WillCascadeOnDelete(false);
        }
    }
}
