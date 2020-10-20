using MappingSPO.Project.DL.Entities;

namespace MappingSPO.Project.DL.Configurations
{
    public class SbDetailEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SbDetailEntity>
    {
        public SbDetailEntityConfiguration()
            : this("Stock")
        {
        }

        public SbDetailEntityConfiguration(string schema)
        {
            ToTable("tSBDetail", schema);
            HasKey(x => x.DetailId);

            Property(x => x.DetailId).HasColumnName(@"DetailID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.LineOrder).HasColumnName(@"LineOrder").HasColumnType("int").IsRequired();
            Property(x => x.LineType).HasColumnName(@"LineType").HasColumnType("int").IsRequired();
            Property(x => x.ArtId).HasColumnName(@"ArtID").HasColumnType("bigint").IsOptional();
            Property(x => x.Sbid).HasColumnName(@"SBID").HasColumnType("bigint").IsOptional();
            Property(x => x.Aantal).HasColumnName(@"Aantal").HasColumnType("float").IsOptional();
            Property(x => x.MagazijnId).HasColumnName(@"MagazijnID").HasColumnType("bigint").IsOptional();
            Property(x => x.TermijnDays).HasColumnName(@"TermijnDays").HasColumnType("bigint").IsOptional();
            Property(x => x.Code).HasColumnName(@"Code").HasColumnType("nvarchar").IsOptional().HasMaxLength(250);
            Property(x => x.Uc).HasColumnName(@"UC").HasColumnType("nvarchar").IsOptional().HasMaxLength(10);
            Property(x => x.Prijs).HasColumnName(@"Prijs").HasColumnType("float").IsOptional();
            Property(x => x.Factor).HasColumnName(@"Factor").HasColumnType("float").IsOptional();
            Property(x => x.Timestamp).HasColumnName(@"timestamp").HasColumnType("timestamp").IsRequired().IsFixedLength().HasMaxLength(8).IsRowVersion();
            Property(x => x.Description).HasColumnName(@"Description").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.NotesExternal).HasColumnName(@"NotesExternal").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.NotesInternal).HasColumnName(@"NotesInternal").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.WerfLijstId).HasColumnName(@"WerfLijstID").HasColumnType("bigint").IsOptional();
            Property(x => x.WerfId).HasColumnName(@"WerfID").HasColumnType("bigint").IsOptional();
            Property(x => x.LeveradresId).HasColumnName(@"LeveradresID").HasColumnType("bigint").IsOptional();
            Property(x => x.Code1).HasColumnName(@"Code1").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Code2).HasColumnName(@"Code2").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Code3).HasColumnName(@"Code3").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Code4).HasColumnName(@"Code4").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Code5).HasColumnName(@"Code5").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Code6).HasColumnName(@"Code6").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Code7).HasColumnName(@"Code7").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Code8).HasColumnName(@"Code8").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Ks).HasColumnName(@"KS").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.FullCode).HasColumnName(@"FullCode").HasColumnType("nvarchar").IsOptional().HasMaxLength(2048);
            Property(x => x.AddCount).HasColumnName(@"AddCount").HasColumnType("int").IsOptional();
            Property(x => x.AddedOnLevering).HasColumnName(@"AddedOnLevering").HasColumnType("bigint").IsRequired();
            Property(x => x.EmmaArticleId).HasColumnName(@"EmmaArticleID").HasColumnType("bigint").IsOptional();
            Property(x => x.InkoopCatId).HasColumnName(@"InkoopCatID").HasColumnType("bigint").IsOptional();
            Property(x => x.BaReplaceWerflijstId).HasColumnName(@"BaReplaceWerflijstID").HasColumnType("bigint").IsOptional();
            Property(x => x.Vko).HasColumnName(@"VKO").HasColumnType("bigint").IsOptional();
            Property(x => x.VkoLine).HasColumnName(@"VKOLine").HasColumnType("bigint").IsOptional();
            Property(x => x.LeverancierRef).HasColumnName(@"LeverancierRef").HasColumnType("nvarchar").IsOptional().HasMaxLength(200);

            HasOptional(a => a.WerfLijst).WithMany(b => b.SbDetails).HasForeignKey(c => c.WerfLijstId).WillCascadeOnDelete(false);
        }
    }
}
