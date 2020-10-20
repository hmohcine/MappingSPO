using MappingSPO.Project.DL.Entities;

namespace MappingSPO.Project.DL.Configurations
{
    public class ParameterDefinitionEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<ParameterDefinitionEntity>
    {
        public ParameterDefinitionEntityConfiguration()
            : this("library")
        {
        }

        public ParameterDefinitionEntityConfiguration(string schema)
        {
            ToTable("tParameterDefinition", schema);
            HasKey(x => x.ParameterName);

            Property(x => x.ParameterName).HasColumnName(@"ParameterName").HasColumnType("nvarchar").IsRequired().HasMaxLength(100).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Uc).HasColumnName(@"UC").HasColumnType("nvarchar").IsRequired().HasMaxLength(10);
            Property(x => x.Description).HasColumnName(@"Description").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.BibId).HasColumnName(@"BibID").HasColumnType("bigint").IsOptional();

            HasOptional(a => a.ParameterBib).WithMany(b => b.ParameterDefinitions).HasForeignKey(c => c.BibId).WillCascadeOnDelete(false);
        }
    }
}
