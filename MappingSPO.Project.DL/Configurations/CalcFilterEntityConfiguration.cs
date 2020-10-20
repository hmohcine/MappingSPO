using MappingSPO.Project.DL.Entities;

namespace MappingSPO.Project.DL.Configurations
{
    public class CalcFilterEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CalcFilterEntity>
    {
        public CalcFilterEntityConfiguration()
            : this("Settings")
        {
        }

        public CalcFilterEntityConfiguration(string schema)
        {
            ToTable("tCalcFilters", schema);
            HasKey(x => x.CalcFilterId);

            Property(x => x.CalcFilterId).HasColumnName(@"CalcFilterID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Range).HasColumnName(@"Range").HasColumnType("int").IsRequired();
            Property(x => x.FilterName).HasColumnName(@"FilterName").HasColumnType("nvarchar").IsOptional().HasMaxLength(150);
            Property(x => x.FilterNotes).HasColumnName(@"FilterNotes").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.CreateDate).HasColumnName(@"CreateDate").HasColumnType("datetime").IsOptional();
            Property(x => x.UserId).HasColumnName(@"UserID").HasColumnType("int").IsOptional();
            Property(x => x.SearchRecord).HasColumnName(@"SearchRecord").HasColumnType("nvarchar(max)").IsOptional();
        }
    }
}
