using MappingSPO.Entities;

namespace MappingSPO
{
    public class ExternalInvoiceBuildSettingEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<ExternalInvoiceBuildSettingEntity>
    {
        public ExternalInvoiceBuildSettingEntityConfiguration()
            : this("Settings")
        {
        }

        public ExternalInvoiceBuildSettingEntityConfiguration(string schema)
        {
            ToTable("tExternalInvoiceBuildSettings", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.KoppelcentrumMasterSwitch).HasColumnName(@"KoppelcentrumMasterSwitch").HasColumnType("bit").IsOptional();
            Property(x => x.KoppelCenterRoleGroup).HasColumnName(@"KoppelCenterRoleGroup").HasColumnType("int").IsOptional();
            Property(x => x.WerfExtInvViewerMasterSwitch).HasColumnName(@"WerfExtInvViewerMasterSwitch").HasColumnType("bit").IsOptional();
            Property(x => x.WerfExtInvViewerReadRoleGroup).HasColumnName(@"WerfExtInvViewerReadRoleGroup").HasColumnType("int").IsOptional();
            Property(x => x.WerfExtInvViewerApproveRoleGroup).HasColumnName(@"WerfExtInvViewerApproveRoleGroup").HasColumnType("int").IsOptional();
        }
    }
}
