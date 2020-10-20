using MappingSPO.Project.DL.Entities;

namespace MappingSPO.Project.DL.Configurations
{
    public class WerfLijstEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<WerfLijstEntity>
    {
        public WerfLijstEntityConfiguration()
            : this("Project")
        {
        }

        public WerfLijstEntityConfiguration(string schema)
        {
            ToTable("tWerfLijst", schema);
            HasKey(x => x.WerfLijstId);

            Property(x => x.WerfLijstId).HasColumnName(@"WerfLijstID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.WerfId).HasColumnName(@"WerfID").HasColumnType("bigint").IsRequired();
            Property(x => x.Code1).HasColumnName(@"Code1").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Code2).HasColumnName(@"Code2").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Code3).HasColumnName(@"Code3").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Code4).HasColumnName(@"Code4").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Code5).HasColumnName(@"Code5").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Code6).HasColumnName(@"Code6").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Code7).HasColumnName(@"Code7").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Code8).HasColumnName(@"Code8").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Code).HasColumnName(@"Code").HasColumnType("nvarchar").IsOptional().HasMaxLength(2048);
            Property(x => x.Ks).HasColumnName(@"KS").HasColumnType("nvarchar").IsOptional().HasMaxLength(10);
            Property(x => x.Uc).HasColumnName(@"UC").HasColumnType("nvarchar").IsOptional().HasMaxLength(10);
            Property(x => x.TotBestelAantal).HasColumnName(@"TotBestelAantal").HasColumnType("float").IsRequired();
            Property(x => x.Enabled).HasColumnName(@"Enabled").HasColumnType("bit").IsRequired();
            Property(x => x.EPrijs).HasColumnName(@"EPrijs").HasColumnType("float").IsRequired();
            Property(x => x.EPrijsFixed).HasColumnName(@"EPrijsFixed").HasColumnType("bit").IsRequired();
            Property(x => x.ArtId).HasColumnName(@"ArtID").HasColumnType("bigint").IsOptional();
            Property(x => x.DefaultLeverancierId).HasColumnName(@"DefaultLeverancierID").HasColumnType("bigint").IsOptional();
            Property(x => x.DefaultMagazijnId).HasColumnName(@"DefaultMagazijnID").HasColumnType("bigint").IsOptional();
            Property(x => x.DefaultLeveradresId).HasColumnName(@"DefaultLeveradresID").HasColumnType("bigint").IsOptional();
            Property(x => x.Description).HasColumnName(@"Description").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.NotesExternal).HasColumnName(@"NotesExternal").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.NotesInternal).HasColumnName(@"NotesInternal").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.Created).HasColumnName(@"Created").HasColumnType("datetime").IsRequired();
            Property(x => x.CreatedBy).HasColumnName(@"CreatedBy").HasColumnType("int").IsRequired();
            Property(x => x.TimeStamp).HasColumnName(@"TimeStamp").HasColumnType("timestamp").IsOptional();
            Property(x => x.LastChanged).HasColumnName(@"LastChanged").HasColumnType("datetime").IsRequired();
            Property(x => x.LastChangedBy).HasColumnName(@"LastChangedBy").HasColumnType("int").IsRequired();
            Property(x => x.BestelCode).HasColumnName(@"BestelCode").HasColumnType("nvarchar").IsOptional().HasMaxLength(250);
            Property(x => x.BestelUc).HasColumnName(@"BestelUC").HasColumnType("nvarchar").IsOptional().HasMaxLength(10);
            Property(x => x.BestelPrijs).HasColumnName(@"BestelPrijs").HasColumnType("float").IsOptional();
            Property(x => x.BestelFactor).HasColumnName(@"BestelFactor").HasColumnType("float").IsOptional();
            Property(x => x.EprijsLibrary).HasColumnName(@"EprijsLibrary").HasColumnType("float").IsOptional();
            Property(x => x.Aantal2).HasColumnName(@"Aantal2").HasColumnType("float").IsOptional();
            Property(x => x.Volgorde).HasColumnName(@"Volgorde").HasColumnType("bigint").IsOptional();
            Property(x => x.AddedByMode).HasColumnName(@"AddedByMode").HasColumnType("int").IsOptional();
            Property(x => x.IsDone).HasColumnName(@"IsDone").HasColumnType("bit").IsOptional();
            Property(x => x.InkoopCatId).HasColumnName(@"InkoopCatID").HasColumnType("bigint").IsOptional();
            Property(x => x.LeverancierRef).HasColumnName(@"LeverancierRef").HasColumnType("nvarchar").IsOptional().HasMaxLength(200);

            HasOptional(a => a.Relation).WithMany(b => b.WerfLijsts).HasForeignKey(c => c.DefaultLeverancierId).WillCascadeOnDelete(false);
        }
    }
}
