using MappingSPO.Project.DL.Entities;

namespace MappingSPO.Project.DL.Configurations
{
    public class WerfEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<WerfEntity>
    {
        public WerfEntityConfiguration()
            : this("Project")
        {
        }

        public WerfEntityConfiguration(string schema)
        {
            ToTable("tWerf", schema);
            HasKey(x => x.WerfId);

            Property(x => x.WerfId).HasColumnName(@"WerfID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.WerfState).HasColumnName(@"WerfState").HasColumnType("int").IsRequired();
            Property(x => x.WerfTypeId).HasColumnName(@"WerfTypeID").HasColumnType("nchar").IsRequired().IsFixedLength().HasMaxLength(2);
            Property(x => x.WerfYear).HasColumnName(@"WerfYear").HasColumnType("int").IsRequired();
            Property(x => x.WerfNumber).HasColumnName(@"WerfNumber").HasColumnType("int").IsRequired();
            Property(x => x.WerfName).HasColumnName(@"WerfName").HasColumnType("nvarchar").IsRequired().HasMaxLength(200);
            Property(x => x.NotesInternal).HasColumnName(@"NotesInternal").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.NotesExternal).HasColumnName(@"NotesExternal").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.Code1).HasColumnName(@"Code1").HasColumnType("int").IsOptional();
            Property(x => x.Code2).HasColumnName(@"Code2").HasColumnType("int").IsOptional();
            Property(x => x.Code3).HasColumnName(@"Code3").HasColumnType("int").IsOptional();
            Property(x => x.Code4).HasColumnName(@"Code4").HasColumnType("int").IsOptional();
            Property(x => x.Code5).HasColumnName(@"Code5").HasColumnType("int").IsOptional();
            Property(x => x.Code6).HasColumnName(@"Code6").HasColumnType("int").IsOptional();
            Property(x => x.Code7).HasColumnName(@"Code7").HasColumnType("int").IsOptional();
            Property(x => x.Code8).HasColumnName(@"Code8").HasColumnType("int").IsOptional();
            Property(x => x.CreatedDate).HasColumnName(@"CreatedDate").HasColumnType("datetime").IsOptional();
            Property(x => x.StartDate).HasColumnName(@"StartDate").HasColumnType("datetime").IsOptional();
            Property(x => x.EndDate).HasColumnName(@"EndDate").HasColumnType("datetime").IsOptional();
            Property(x => x.ExtentionShowOverOnPart).HasColumnName(@"ExtentionShowOverOnPart").HasColumnType("int").IsRequired();
            Property(x => x.OfferShowOnPart).HasColumnName(@"OfferShowOnPart").HasColumnType("int").IsRequired();
            Property(x => x.OfferShowOverOnPart).HasColumnName(@"OfferShowOverOnPart").HasColumnType("int").IsRequired();
            Property(x => x.ExtentionShowOnPart).HasColumnName(@"ExtentionShowOnPart").HasColumnType("int").IsRequired();
            Property(x => x.DefaultInvoiceAdressId).HasColumnName(@"DefaultInvoiceAdressID").HasColumnType("bigint").IsOptional();
            Property(x => x.WerfCategory).HasColumnName(@"WerfCategory").HasColumnType("int").IsRequired();
            Property(x => x.Creator).HasColumnName(@"Creator").HasColumnType("int").IsOptional();
            Property(x => x.CompanyId).HasColumnName(@"CompanyID").HasColumnType("int").IsOptional();
            Property(x => x.FacturationMode).HasColumnName(@"FacturationMode").HasColumnType("int").IsRequired();
            Property(x => x.WithPrijsHerziening).HasColumnName(@"WithPrijsHerziening").HasColumnType("int").IsRequired();
            Property(x => x.VordStructModeStaat1).HasColumnName(@"VordStructModeStaat1").HasColumnType("int").IsRequired();
            Property(x => x.VordStructModeStaat2).HasColumnName(@"VordStructModeStaat2").HasColumnType("int").IsRequired();
            Property(x => x.VordStructModeStaat3).HasColumnName(@"VordStructModeStaat3").HasColumnType("int").IsRequired();
            Property(x => x.VordPostMode1).HasColumnName(@"VordPostMode1").HasColumnType("int").IsRequired();
            Property(x => x.VordDetailMode).HasColumnName(@"VordDetailMode").HasColumnType("int").IsRequired();
            Property(x => x.VordHerzieningMode).HasColumnName(@"VordHerzieningMode").HasColumnType("int").IsRequired();
            Property(x => x.VordSamenvattingMode).HasColumnName(@"VordSamenvattingMode").HasColumnType("int").IsRequired();
            Property(x => x.VordSchuldVorderingMode).HasColumnName(@"VordSchuldVorderingMode").HasColumnType("int").IsRequired();
            Property(x => x.VordPostMode2).HasColumnName(@"VordPostMode2").HasColumnType("int").IsRequired();
            Property(x => x.VordPostMode3).HasColumnName(@"VordPostMode3").HasColumnType("int").IsRequired();
            Property(x => x.WerfAdresContactId).HasColumnName(@"WerfAdresContactID").HasColumnType("int").IsOptional();
            Property(x => x.WerfAdresRelationId).HasColumnName(@"WerfAdresRelationID").HasColumnType("bigint").IsOptional();
            Property(x => x.WerfAdresRelationTypeId).HasColumnName(@"WerfAdresRelationTypeID").HasColumnType("int").IsOptional();
            Property(x => x.WerfAdresWerfId).HasColumnName(@"WerfAdresWerfID").HasColumnType("bigint").IsOptional();
            Property(x => x.PathDocsFileSystem).HasColumnName(@"PathDocsFileSystem").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.DefaultRegieYn).HasColumnName(@"DefaultRegieYn").HasColumnType("bit").IsOptional();
            Property(x => x.Werfleider).HasColumnName(@"Werfleider").HasColumnType("int").IsOptional();
            Property(x => x.ProjectLeider).HasColumnName(@"ProjectLeider").HasColumnType("int").IsOptional();
            Property(x => x.BegrotingPct).HasColumnName(@"BegrotingPct").HasColumnType("float").IsOptional();
            Property(x => x.UriWebSystem).HasColumnName(@"URIWebSystem").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.Ref1).HasColumnName(@"Ref1").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.Ref2).HasColumnName(@"Ref2").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.Ref3).HasColumnName(@"Ref3").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.Ref4).HasColumnName(@"Ref4").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.DefaultMagazijnId).HasColumnName(@"DefaultMagazijnID").HasColumnType("bigint").IsOptional();
            Property(x => x.DefaultLeveradresId).HasColumnName(@"DefaultLeveradresID").HasColumnType("bigint").IsOptional();
            Property(x => x.AddPostenToVordMode).HasColumnName(@"AddPostenToVordMode").HasColumnType("int").IsOptional();
            Property(x => x.WerfadresId).HasColumnName(@"WerfadresID").HasColumnType("bigint").IsOptional();
            Property(x => x.DefaultBtwRegime).HasColumnName(@"DefaultBTWRegime").HasColumnType("int").IsOptional();
            Property(x => x.DefaultVatCode).HasColumnName(@"DefaultVATCode").HasColumnType("int").IsOptional();
            Property(x => x.AfstandWerfInKm).HasColumnName(@"AfstandWerfInKm").HasColumnType("float").IsOptional();
            Property(x => x.TotVergoedingPassagier).HasColumnName(@"TotVergoedingPassagier").HasColumnType("float").IsOptional();
            Property(x => x.TotVergoedingBestuurder).HasColumnName(@"TotVergoedingBestuurder").HasColumnType("float").IsOptional();
            Property(x => x.DuurVerificatieTermijn).HasColumnName(@"DuurVerificatieTermijn").HasColumnType("int").IsOptional();
            Property(x => x.VerwijlIntrestRentevoet).HasColumnName(@"VerwijlIntrestRentevoet").HasColumnType("decimal").IsOptional().HasPrecision(18,6);
            Property(x => x.ExtNumber).HasColumnName(@"ExtNumber").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.CheckInAtWorkYn).HasColumnName(@"CheckInAtWorkYn").HasColumnType("bit").IsOptional();
            Property(x => x.CExtNumber).HasColumnName(@"cExtNumber").HasColumnType("nvarchar").IsOptional().HasMaxLength(4000).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.VordShowSubTotalsOnHfst).HasColumnName(@"VordShowSubTotalsOnHfst").HasColumnType("bit").IsOptional();
            Property(x => x.ExtraNum1).HasColumnName(@"ExtraNum1").HasColumnType("float").IsOptional();
            Property(x => x.ExtraNum2).HasColumnName(@"ExtraNum2").HasColumnType("float").IsOptional();
            Property(x => x.ExtraNum3).HasColumnName(@"ExtraNum3").HasColumnType("float").IsOptional();
            Property(x => x.ExtraNum4).HasColumnName(@"ExtraNum4").HasColumnType("float").IsOptional();
            Property(x => x.ExtraNum5).HasColumnName(@"ExtraNum5").HasColumnType("float").IsOptional();
            Property(x => x.ExtraNum6).HasColumnName(@"ExtraNum6").HasColumnType("float").IsOptional();
            Property(x => x.ExtraNum7).HasColumnName(@"ExtraNum7").HasColumnType("float").IsOptional();
            Property(x => x.ExtraNum8).HasColumnName(@"ExtraNum8").HasColumnType("float").IsOptional();
            Property(x => x.VordShowCncMode).HasColumnName(@"VordShowCNCMode").HasColumnType("int").IsOptional();
            Property(x => x.VordShowDigitsUnits).HasColumnName(@"VordShowDigitsUnits").HasColumnType("int").IsOptional();
            Property(x => x.VordShowDigitsEprijs).HasColumnName(@"VordShowDigitsEprijs").HasColumnType("int").IsOptional();
            Property(x => x.VordShowDigitsPrijs).HasColumnName(@"VordShowDigitsPrijs").HasColumnType("int").IsOptional();
            Property(x => x.VoorlopigeOpleveringsdatum).HasColumnName(@"VoorlopigeOpleveringsdatum").HasColumnType("date").IsOptional();
            Property(x => x.DefinitieveOpleveringsdatum).HasColumnName(@"DefinitieveOpleveringsdatum").HasColumnType("date").IsOptional();
            Property(x => x.Domain).HasColumnName(@"Domain").HasColumnType("nchar").IsRequired().IsFixedLength().HasMaxLength(1);
            Property(x => x.ExtraDate1).HasColumnName(@"ExtraDate1").HasColumnType("date").IsOptional();
            Property(x => x.ExtraDate2).HasColumnName(@"ExtraDate2").HasColumnType("date").IsOptional();
            Property(x => x.ExtraDate3).HasColumnName(@"ExtraDate3").HasColumnType("date").IsOptional();
            Property(x => x.ExtraDate4).HasColumnName(@"ExtraDate4").HasColumnType("date").IsOptional();
            Property(x => x.ExtraDate5).HasColumnName(@"ExtraDate5").HasColumnType("date").IsOptional();
            Property(x => x.ExtraDate6).HasColumnName(@"ExtraDate6").HasColumnType("date").IsOptional();
            Property(x => x.ExtraDate7).HasColumnName(@"ExtraDate7").HasColumnType("date").IsOptional();
            Property(x => x.ExtraDate8).HasColumnName(@"ExtraDate8").HasColumnType("date").IsOptional();
            Property(x => x.DefaultVerkoopCat).HasColumnName(@"DefaultVerkoopCat").HasColumnType("bigint").IsOptional();
            Property(x => x.PlanningsMode).HasColumnName(@"PlanningsMode").HasColumnType("int").IsOptional();
            Property(x => x.BsMagazijnId).HasColumnName(@"BSMagazijnID").HasColumnType("bigint").IsOptional();
            Property(x => x.BsToonzaalId).HasColumnName(@"BSToonzaalID").HasColumnType("bigint").IsOptional();

            HasOptional(a => a.WerfInvoiceAdress).WithMany(b => b.Werfs).HasForeignKey(c => c.DefaultInvoiceAdressId).WillCascadeOnDelete(false);
            HasOptional(a => a.WerfRelation).WithMany(b => b.Werfs).HasForeignKey(c => new { c.WerfAdresWerfId, c.WerfAdresRelationId, c.WerfAdresRelationTypeId }).WillCascadeOnDelete(false);
            HasMany(t => t.Werfs_WerfId).WithMany(t => t.Werfs_ContractWerfId).Map(m =>
            {
                m.ToTable("tWerfContract", "Project");
                m.MapLeftKey("ContractWerfID");
                m.MapRightKey("WerfID");
            });
        }
    }
}
