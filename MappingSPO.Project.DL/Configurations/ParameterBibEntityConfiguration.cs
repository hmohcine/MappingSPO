using MappingSPO.Project.DL.Entities;

namespace MappingSPO.Project.DL.Configurations
{
    public class ParameterBibEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<ParameterBibEntity>
    {
        public ParameterBibEntityConfiguration()
            : this("library")
        {
        }

        public ParameterBibEntityConfiguration(string schema)
        {
            ToTable("tParameterBib", schema);
            HasKey(x => x.BibId);

            Property(x => x.BibId).HasColumnName(@"BibID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.ParentId).HasColumnName(@"ParentID").HasColumnType("bigint").IsOptional();
            Property(x => x.Naam).HasColumnName(@"Naam").HasColumnType("nvarchar").IsOptional().HasMaxLength(150);
            Property(x => x.Notes).HasColumnName(@"Notes").HasColumnType("nvarchar(max)").IsOptional();
        }
    }
}
