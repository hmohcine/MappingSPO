using MappingSPO.Entities;

namespace MappingSPO
{
    public class SysMasterProjectSettingEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SysMasterProjectSettingEntity>
    {
        public SysMasterProjectSettingEntityConfiguration()
            : this("Settings")
        {
        }

        public SysMasterProjectSettingEntityConfiguration(string schema)
        {
            ToTable("tsysMasterProjectSettings", schema);
            HasKey(x => x.MpId);

            Property(x => x.MpId).HasColumnName(@"MpID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.MasterProjectOn).HasColumnName(@"MasterProjectOn").HasColumnType("bit").IsRequired();
            Property(x => x.CountOfCijfers).HasColumnName(@"CountOfCijfers").HasColumnType("int").IsRequired();
            Property(x => x.MpNrLabelPart1).HasColumnName(@"MpNrLabelPart1").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.MpNrLabelPart2).HasColumnName(@"MpNrLabelPart2").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.MpNrLabelPart3).HasColumnName(@"MpNrLabelPart3").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.MpCodeLabel1).HasColumnName(@"MpCodeLabel1").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.MpCodeLabel2).HasColumnName(@"MpCodeLabel2").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.MpCodeLabel3).HasColumnName(@"MpCodeLabel3").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.MpCodeLabel4).HasColumnName(@"MpCodeLabel4").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.MpCodeLabel5).HasColumnName(@"MpCodeLabel5").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.MpCodeLabel6).HasColumnName(@"MpCodeLabel6").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.MpCodeLabel7).HasColumnName(@"MpCodeLabel7").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.MpCodeLabel8).HasColumnName(@"MpCodeLabel8").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.MpDateLabel1).HasColumnName(@"MpDateLabel1").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.MpDateLabel2).HasColumnName(@"MpDateLabel2").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.MpDateLabel3).HasColumnName(@"MpDateLabel3").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.MpDateLabel4).HasColumnName(@"MpDateLabel4").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.MpDateLabel5).HasColumnName(@"MpDateLabel5").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.MpDateLabel6).HasColumnName(@"MpDateLabel6").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.MpDateLabel7).HasColumnName(@"MpDateLabel7").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.MpDateLabel8).HasColumnName(@"MpDateLabel8").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.MpDefaultVerValTermijnOptieDays).HasColumnName(@"MpDefaultVerValTermijnOptieDays").HasColumnType("int").IsOptional();
            Property(x => x.MpRefLabel1).HasColumnName(@"MpRefLabel1").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.MpRefLabel2).HasColumnName(@"MpRefLabel2").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.MpRefLabel3).HasColumnName(@"MpRefLabel3").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.MpRefLabel4).HasColumnName(@"MpRefLabel4").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.MpExtraBooleanLabel1).HasColumnName(@"MpExtraBooleanLabel1").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.MpExtraBooleanLabel2).HasColumnName(@"MpExtraBooleanLabel2").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.MpExtraBooleanLabel3).HasColumnName(@"MpExtraBooleanLabel3").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.MpExtraBooleanLabel4).HasColumnName(@"MpExtraBooleanLabel4").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.MpExtraNumLabel1).HasColumnName(@"MpExtraNumLabel1").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.MpExtraNumLabel2).HasColumnName(@"MpExtraNumLabel2").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.MpExtraNumLabel3).HasColumnName(@"MpExtraNumLabel3").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.MpExtraNumLabel4).HasColumnName(@"MpExtraNumLabel4").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.MpExtraNumLabel5).HasColumnName(@"MpExtraNumLabel5").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.MpExtraNumLabel6).HasColumnName(@"MpExtraNumLabel6").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.MpExtraNumLabel7).HasColumnName(@"MpExtraNumLabel7").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.MpExtraNumLabel8).HasColumnName(@"MpExtraNumLabel8").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.MpMultiCodeLabel1).HasColumnName(@"MpMultiCodeLabel1").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.MpMultiCodeLabel2).HasColumnName(@"MpMultiCodeLabel2").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.MpMultiCodeLabel3).HasColumnName(@"MpMultiCodeLabel3").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.MpMultiCodeLabel4).HasColumnName(@"MpMultiCodeLabel4").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.MpMultiCodeLabel5).HasColumnName(@"MpMultiCodeLabel5").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.MpMultiCodeLabel6).HasColumnName(@"MpMultiCodeLabel6").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.MpMultiCodeLabel7).HasColumnName(@"MpMultiCodeLabel7").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.MpMultiCodeLabel8).HasColumnName(@"MpMultiCodeLabel8").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
        }
    }
}
