using MappingSPO.Project.DL.Entities;

namespace MappingSPO.Project.DL.Configurations
{
    public class CalcLibraryEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CalcLibraryEntity>
    {
        public CalcLibraryEntityConfiguration()
            : this("Project")
        {
        }

        public CalcLibraryEntityConfiguration(string schema)
        {
            ToTable("tCalcLibrary", schema);
            HasKey(x => new { x.CalcId, x.ItemId });

            Property(x => x.CalcId).HasColumnName(@"CalcID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ItemId).HasColumnName(@"ItemID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.LibraryId).HasColumnName(@"LibraryID").HasColumnType("bigint").IsOptional();
            Property(x => x.ArticleId).HasColumnName(@"ArticleID").HasColumnType("bigint").IsOptional();
            Property(x => x.Code1).HasColumnName(@"Code1").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Code2).HasColumnName(@"Code2").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Code3).HasColumnName(@"Code3").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Code4).HasColumnName(@"Code4").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Code5).HasColumnName(@"Code5").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Code6).HasColumnName(@"Code6").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Code7).HasColumnName(@"Code7").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Code8).HasColumnName(@"Code8").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Description).HasColumnName(@"Description").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Uc).HasColumnName(@"UC").HasColumnType("nvarchar").IsOptional().HasMaxLength(10);
            Property(x => x.Ekp).HasColumnName(@"EKP").HasColumnType("float").IsOptional();
            Property(x => x.DateUpdatedEkp).HasColumnName(@"DateUpdatedEKP").HasColumnType("datetime").IsOptional();
            Property(x => x.Ks).HasColumnName(@"KS").HasColumnType("nvarchar").IsOptional().HasMaxLength(10);
            Property(x => x.ExtraNum1).HasColumnName(@"ExtraNum1").HasColumnType("float").IsOptional();
            Property(x => x.ExtraNum2).HasColumnName(@"ExtraNum2").HasColumnType("float").IsOptional();
            Property(x => x.ExtraNum3).HasColumnName(@"ExtraNum3").HasColumnType("float").IsOptional();
            Property(x => x.ExtraNum4).HasColumnName(@"ExtraNum4").HasColumnType("float").IsOptional();
            Property(x => x.ExtraNum5).HasColumnName(@"ExtraNum5").HasColumnType("float").IsOptional();
            Property(x => x.ExtraNum6).HasColumnName(@"ExtraNum6").HasColumnType("float").IsOptional();
            Property(x => x.ExtraNum7).HasColumnName(@"ExtraNum7").HasColumnType("float").IsOptional();
            Property(x => x.ExtraNum8).HasColumnName(@"ExtraNum8").HasColumnType("float").IsOptional();
            Property(x => x.InkoopCatId).HasColumnName(@"InkoopCatID").HasColumnType("bigint").IsOptional();

            HasRequired(a => a.Calculation).WithMany(b => b.CalcLibraries).HasForeignKey(c => c.CalcId);
        }
    }
}
