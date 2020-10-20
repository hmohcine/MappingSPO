using MappingSPO.Project.DL.Entities;

namespace MappingSPO.Project.DL.Configurations
{
    public class LinkedTeamProjectEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<LinkedTeamProjectEntity>
    {
        public LinkedTeamProjectEntityConfiguration()
            : this("Project")
        {
        }

        public LinkedTeamProjectEntityConfiguration(string schema)
        {
            ToTable("tLinkedTeamProject", schema);
            HasKey(x => new { x.ProjectId, x.ProjectType });

            Property(x => x.LinkedTeamProjectId).HasColumnName(@"LinkedTeamProjectId").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.ProjectId).HasColumnName(@"ProjectID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ProjectType).HasColumnName(@"ProjectType").HasColumnType("nvarchar").IsRequired().HasMaxLength(2).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ProjectNumberText).HasColumnName(@"ProjectNumberText").HasColumnType("nvarchar").IsOptional().HasMaxLength(1000);
            Property(x => x.SharePointUrl).HasColumnName(@"SharePointUrl").HasColumnType("nvarchar").IsOptional().HasMaxLength(1000);
            Property(x => x.TeamsUrl).HasColumnName(@"TeamsUrl").HasColumnType("nvarchar").IsOptional().HasMaxLength(1000);
            Property(x => x.TeamsStatus).HasColumnName(@"TeamsStatus").HasColumnType("nvarchar").IsOptional().HasMaxLength(1000);
            Property(x => x.LookupId).HasColumnName(@"LookupId").HasColumnType("bigint").IsRequired();
            Property(x => x.SyncDate).HasColumnName(@"SyncDate").HasColumnType("datetime").IsOptional();
            Property(x => x.CreationDate).HasColumnName(@"CreationDate").HasColumnType("datetime").IsOptional();
            Property(x => x.ModificationDate).HasColumnName(@"ModificationDate").HasColumnType("datetime").IsOptional();
            Property(x => x.CreatedBy).HasColumnName(@"CreatedBy").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(255);
            Property(x => x.ModifiedBy).HasColumnName(@"ModifiedBy").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(255);
            Property(x => x.ProjectTitle).HasColumnName(@"ProjectTitle").HasColumnType("nvarchar").IsOptional().HasMaxLength(1000);

            HasRequired(a => a.Project).WithOptional(b => b.LinkedTeamProject).WillCascadeOnDelete(false);
        }
    }
}
