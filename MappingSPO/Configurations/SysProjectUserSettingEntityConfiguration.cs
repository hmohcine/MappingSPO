using MappingSPO.Entities;

namespace MappingSPO
{
    public class SysProjectUserSettingEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SysProjectUserSettingEntity>
    {
        public SysProjectUserSettingEntityConfiguration()
            : this("Settings")
        {
        }

        public SysProjectUserSettingEntityConfiguration(string schema)
        {
            ToTable("tsysProjectUserSettings", schema);
            HasKey(x => new { x.Id, x.UserId });

            Property(x => x.Id).HasColumnName(@"ID").HasColumnType("nchar").IsRequired().IsFixedLength().HasMaxLength(10).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.UserId).HasColumnName(@"UserID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.DefaultProjectType).HasColumnName(@"DefaultProjectType").HasColumnType("nvarchar").IsOptional().HasMaxLength(2);
            Property(x => x.CenterAutoOpenOnStart).HasColumnName(@"CenterAutoOpenOnStart").HasColumnType("bit").IsRequired();
            Property(x => x.CenterOnNewScreen).HasColumnName(@"CenterOnNewScreen").HasColumnType("bit").IsRequired();
            Property(x => x.CenterSplitterPct).HasColumnName(@"CenterSplitterPct").HasColumnType("int").IsRequired();
            Property(x => x.CenterMaxActive).HasColumnName(@"CenterMaxActive").HasColumnType("int").IsRequired();
            Property(x => x.CenterProjectTabIndex).HasColumnName(@"CenterProjectTabIndex").HasColumnType("int").IsOptional();
            Property(x => x.TodoPlusDays).HasColumnName(@"TodoPlusDays").HasColumnType("int").IsRequired();
            Property(x => x.DefaultTodoTypeId).HasColumnName(@"DefaultTodoTypeID").HasColumnType("bigint").IsOptional();
            Property(x => x.ProjectSplitterpct).HasColumnName(@"ProjectSplitterpct").HasColumnType("int").IsRequired();
            Property(x => x.ProjectXrmSplitter).HasColumnName(@"ProjectXRMSplitter").HasColumnType("int").IsRequired();
            Property(x => x.ProjectTabIndex).HasColumnName(@"ProjectTabIndex").HasColumnType("int").IsRequired();
            Property(x => x.DefaultProjectResult).HasColumnName(@"DefaultProjectResult").HasColumnType("int").IsOptional();
            Property(x => x.ProjectSearchDaysPast).HasColumnName(@"ProjectSearchDaysPast").HasColumnType("int").IsOptional();
            Property(x => x.ShowAProjAlgemeen).HasColumnName(@"ShowA_ProjAlgemeen").HasColumnType("bit").IsRequired();
            Property(x => x.ShowAProjTexten).HasColumnName(@"ShowA_ProjTexten").HasColumnType("bit").IsRequired();
            Property(x => x.ShowBWfHistoriek).HasColumnName(@"ShowB_WFHistoriek").HasColumnType("bit").IsRequired();
            Property(x => x.ShowBWfStateTask).HasColumnName(@"ShowB_WFStateTask").HasColumnType("bit").IsRequired();
            Property(x => x.ShowBWfTask).HasColumnName(@"ShowB_WFTask").HasColumnType("bit").IsRequired();
            Property(x => x.ShowCXrmRelations).HasColumnName(@"ShowC_XRMRelations").HasColumnType("bit").IsRequired();
            Property(x => x.ShowCXrmContacts).HasColumnName(@"ShowC_XRMContacts").HasColumnType("bit").IsRequired();
            Property(x => x.ShowCXrmRelationsVia).HasColumnName(@"ShowC_XRMRelationsVia").HasColumnType("bit").IsRequired();
            Property(x => x.ShowCXrmContactsVia).HasColumnName(@"ShowC_XRMContactsVia").HasColumnType("bit").IsRequired();
            Property(x => x.ShowDCalcAlgemeen).HasColumnName(@"ShowD_CalcAlgemeen").HasColumnType("bit").IsRequired();
            Property(x => x.ShowDCalcTotalKs).HasColumnName(@"ShowD_CalcTotalKS").HasColumnType("bit").IsRequired();
            Property(x => x.ShowDProjTotalKs).HasColumnName(@"ShowD_ProjTotalKS").HasColumnType("bit").IsRequired();
            Property(x => x.ShowEWerfAlgemeen).HasColumnName(@"ShowE_WerfAlgemeen").HasColumnType("bit").IsRequired();
            Property(x => x.ShowEWerfVordering).HasColumnName(@"ShowE_WerfVordering").HasColumnType("bit").IsRequired();
            Property(x => x.ShowEWerfInvoice).HasColumnName(@"ShowE_WerfInvoice").HasColumnType("bit").IsRequired();
            Property(x => x.ShowFForeCastCurrent).HasColumnName(@"ShowF_ForeCastCurrent").HasColumnType("bit").IsRequired();
            Property(x => x.ShowFForeCastHistoriek).HasColumnName(@"ShowF_ForeCastHistoriek").HasColumnType("bit").IsRequired();
            Property(x => x.ShowGAnaAlgemeen).HasColumnName(@"ShowG_AnaAlgemeen").HasColumnType("bit").IsRequired();
            Property(x => x.ShowGAnaDetailKs).HasColumnName(@"ShowG_AnaDetailKS").HasColumnType("bit").IsRequired();
            Property(x => x.ShowGAnaTime).HasColumnName(@"ShowG_AnaTime").HasColumnType("bit").IsRequired();
            Property(x => x.DefaultReminderMinutes).HasColumnName(@"DefaultReminderMinutes").HasColumnType("int").IsRequired();
            Property(x => x.DefaultReminderMode).HasColumnName(@"DefaultReminderMode").HasColumnType("int").IsRequired();
            Property(x => x.EnableReminderService).HasColumnName(@"EnableReminderService").HasColumnType("bit").IsRequired();
            Property(x => x.CenterTodoTaskSplitterpct).HasColumnName(@"CenterTodoTaskSplitterpct").HasColumnType("int").IsRequired();
            Property(x => x.DefaultPathExportXml).HasColumnName(@"DefaultPathExportXML").HasColumnType("nvarchar").IsOptional().HasMaxLength(4000);
            Property(x => x.DefaultReminderTimeSchedule).HasColumnName(@"DefaultReminderTimeSchedule").HasColumnType("int").IsRequired();

            HasOptional(a => a.ProjectType).WithMany(b => b.SysProjectUserSettings).HasForeignKey(c => c.DefaultProjectType).WillCascadeOnDelete(false);
            HasOptional(a => a.TodoType).WithMany(b => b.SysProjectUserSettings).HasForeignKey(c => c.DefaultTodoTypeId).WillCascadeOnDelete(false);
            HasRequired(a => a.User).WithMany(b => b.SysProjectUserSettings).HasForeignKey(c => c.UserId).WillCascadeOnDelete(false);
        }
    }
}
