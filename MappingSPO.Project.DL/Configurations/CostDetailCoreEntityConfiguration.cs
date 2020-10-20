using MappingSPO.Project.DL.Entities;

namespace MappingSPO.Project.DL.Configurations
{
    public class CostDetailCoreEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CostDetailCoreEntity>
    {
        public CostDetailCoreEntityConfiguration()
            : this("Project")
        {
        }

        public CostDetailCoreEntityConfiguration(string schema)
        {
            ToTable("tCostDetailCore", schema);
            HasKey(x => new { x.DetailId, x.CostHeaderId });

            Property(x => x.DetailId).HasColumnName(@"DetailID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CostHeaderId).HasColumnName(@"CostHeaderID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.WerfId).HasColumnName(@"WerfID").HasColumnType("bigint").IsOptional();
            Property(x => x.Ks).HasColumnName(@"KS").HasColumnType("nvarchar").IsOptional().HasMaxLength(10);
            Property(x => x.ActiviteitId).HasColumnName(@"ActiviteitID").HasColumnType("bigint").IsOptional();
            Property(x => x.Uc).HasColumnName(@"UC").HasColumnType("nvarchar").IsOptional().HasMaxLength(10);
            Property(x => x.Code1).HasColumnName(@"Code1").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Code2).HasColumnName(@"Code2").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Code3).HasColumnName(@"Code3").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Code4).HasColumnName(@"Code4").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Code5).HasColumnName(@"Code5").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Code6).HasColumnName(@"Code6").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Code7).HasColumnName(@"Code7").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Code8).HasColumnName(@"Code8").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Code).HasColumnName(@"Code").HasColumnType("nvarchar").IsOptional().HasMaxLength(2048);
            Property(x => x.Description).HasColumnName(@"Description").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Notes).HasColumnName(@"Notes").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.Aantal).HasColumnName(@"Aantal").HasColumnType("float").IsRequired();
            Property(x => x.Ekp).HasColumnName(@"EKP").HasColumnType("float").IsRequired();
            Property(x => x.Kp).HasColumnName(@"KP").HasColumnType("float").IsRequired();
            Property(x => x.TotWinstpct).HasColumnName(@"TotWinstpct").HasColumnType("float").IsRequired();
            Property(x => x.Ewinst).HasColumnName(@"Ewinst").HasColumnType("float").IsRequired();
            Property(x => x.Evp).HasColumnName(@"EVP").HasColumnType("float").IsRequired();
            Property(x => x.Vp).HasColumnName(@"VP").HasColumnType("float").IsRequired();
            Property(x => x.RegieYn).HasColumnName(@"RegieYn").HasColumnType("bit").IsOptional();
            Property(x => x.Status).HasColumnName(@"Status").HasColumnType("int").IsRequired();
            Property(x => x.DigitsUnit).HasColumnName(@"DigitsUnit").HasColumnType("int").IsOptional();
            Property(x => x.DigitsTotal).HasColumnName(@"DigitsTotal").HasColumnType("int").IsOptional();
            Property(x => x.LineOrder).HasColumnName(@"LineOrder").HasColumnType("int").IsOptional();
            Property(x => x.Documentdatum).HasColumnName(@"Documentdatum").HasColumnType("datetime").IsOptional();
            Property(x => x.Referentie).HasColumnName(@"Referentie").HasColumnType("nvarchar").IsOptional().HasMaxLength(150);
            Property(x => x.ReferentieIntern).HasColumnName(@"ReferentieIntern").HasColumnType("nvarchar").IsOptional().HasMaxLength(150);
            Property(x => x.FactuurNr).HasColumnName(@"FactuurNr").HasColumnType("nvarchar").IsOptional().HasMaxLength(150);
            Property(x => x.FactuurDatum).HasColumnName(@"FactuurDatum").HasColumnType("datetime").IsOptional();
            Property(x => x.Goedgekeurd).HasColumnName(@"Goedgekeurd").HasColumnType("bit").IsOptional();
            Property(x => x.ArtId).HasColumnName(@"ArtID").HasColumnType("bigint").IsOptional();
            Property(x => x.MagazijnId).HasColumnName(@"MagazijnID").HasColumnType("bigint").IsOptional();
            Property(x => x.StockMoveId).HasColumnName(@"StockMoveID").HasColumnType("bigint").IsOptional();
            Property(x => x.TimeStamp).HasColumnName(@"TimeStamp").HasColumnType("timestamp").IsRequired().IsFixedLength().HasMaxLength(8).IsRowVersion();
            Property(x => x.WerfLijstId).HasColumnName(@"WerfLijstID").HasColumnType("bigint").IsOptional();
            Property(x => x.SbLeveringDetailId).HasColumnName(@"SBLeveringDetailID").HasColumnType("bigint").IsOptional();
            Property(x => x.LeveradresId).HasColumnName(@"LeveradresID").HasColumnType("bigint").IsOptional();
            Property(x => x.LineType).HasColumnName(@"LineType").HasColumnType("int").IsRequired();
            Property(x => x.NotesExtern).HasColumnName(@"NotesExtern").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.InkoopCatId).HasColumnName(@"InkoopCatID").HasColumnType("bigint").IsOptional();
            Property(x => x.NotesExternOa).HasColumnName(@"NotesExternOA").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.CompanyId).HasColumnName(@"CompanyID").HasColumnType("int").IsOptional();
            Property(x => x.AfmpuntId).HasColumnName(@"AfmpuntID").HasColumnType("bigint").IsOptional();

            HasOptional(a => a.Werf).WithMany(b => b.CostDetailCores).HasForeignKey(c => c.WerfId).WillCascadeOnDelete(false);
            HasOptional(a => a.WerfLijst).WithMany(b => b.CostDetailCores).HasForeignKey(c => c.WerfLijstId).WillCascadeOnDelete(false);
            HasRequired(a => a.CostHeader).WithMany(b => b.CostDetailCores).HasForeignKey(c => c.CostHeaderId).WillCascadeOnDelete(false);
        }
    }
}
