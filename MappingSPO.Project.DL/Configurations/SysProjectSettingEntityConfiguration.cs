using MappingSPO.Project.DL.Entities;

namespace MappingSPO.Project.DL.Configurations
{
    public class SysProjectSettingEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SysProjectSettingEntity>
    {
        public SysProjectSettingEntityConfiguration()
            : this("Settings")
        {
        }

        public SysProjectSettingEntityConfiguration(string schema)
        {
            ToTable("tsysProjectSettings", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").HasColumnType("nchar").IsRequired().IsFixedLength().HasMaxLength(10).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.LabelProjectVerantWoordelijke1).HasColumnName(@"LabelProjectVerantWoordelijke1").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.LabelProjectVerantWoordelijke2).HasColumnName(@"LabelProjectVerantWoordelijke2").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.LabelProjectVerantWoordelijke3).HasColumnName(@"LabelProjectVerantWoordelijke3").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.ProjectMode).HasColumnName(@"ProjectMode").HasColumnType("bigint").IsOptional();
            Property(x => x.Code1Caption).HasColumnName(@"Code1Caption").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.Code2Caption).HasColumnName(@"Code2Caption").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.Code3Caption).HasColumnName(@"Code3Caption").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.Code4Caption).HasColumnName(@"Code4Caption").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.Code5Caption).HasColumnName(@"Code5Caption").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.Code6Caption).HasColumnName(@"Code6Caption").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.Code7Caption).HasColumnName(@"Code7Caption").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.Code8Caption).HasColumnName(@"Code8Caption").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.Ref1Label).HasColumnName(@"Ref1Label").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.Ref2Label).HasColumnName(@"Ref2Label").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.Ref3Label).HasColumnName(@"Ref3Label").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.Ref4Label).HasColumnName(@"Ref4Label").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.SmtpServer).HasColumnName(@"SMTPServer").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.ReplayAdress).HasColumnName(@"ReplayAdress").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.ExtraTextOnBody).HasColumnName(@"ExtraTextOnBody").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.ExtraDate1Caption).HasColumnName(@"ExtraDate1Caption").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.ExtraDate2Caption).HasColumnName(@"ExtraDate2Caption").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.ExtraDate3Caption).HasColumnName(@"ExtraDate3Caption").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.ExtraDate4Caption).HasColumnName(@"ExtraDate4Caption").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.ExtraDate5Caption).HasColumnName(@"ExtraDate5Caption").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.ExtraDate6Caption).HasColumnName(@"ExtraDate6Caption").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.ExtraDate7Caption).HasColumnName(@"ExtraDate7Caption").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.ExtaNumLabel1).HasColumnName(@"ExtaNumLabel1").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.ExtaNumLabel2).HasColumnName(@"ExtaNumLabel2").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.ExtaNumLabel3).HasColumnName(@"ExtaNumLabel3").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.ExtaNumLabel4).HasColumnName(@"ExtaNumLabel4").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.ExtaNumLabel5).HasColumnName(@"ExtaNumLabel5").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.ExtaNumLabel6).HasColumnName(@"ExtaNumLabel6").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.ExtaNumLabel7).HasColumnName(@"ExtaNumLabel7").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.ExtaNumLabel8).HasColumnName(@"ExtaNumLabel8").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.ExtaNumShortLabel1).HasColumnName(@"ExtaNumShortLabel1").HasColumnType("nvarchar").IsOptional().HasMaxLength(8);
            Property(x => x.ExtaNumShortLabel2).HasColumnName(@"ExtaNumShortLabel2").HasColumnType("nvarchar").IsOptional().HasMaxLength(8);
            Property(x => x.ExtaNumShortLabel3).HasColumnName(@"ExtaNumShortLabel3").HasColumnType("nvarchar").IsOptional().HasMaxLength(8);
            Property(x => x.ExtaNumShortLabel4).HasColumnName(@"ExtaNumShortLabel4").HasColumnType("nvarchar").IsOptional().HasMaxLength(8);
            Property(x => x.ExtaNumShortLabel5).HasColumnName(@"ExtaNumShortLabel5").HasColumnType("nvarchar").IsOptional().HasMaxLength(8);
            Property(x => x.ExtaNumShortLabel6).HasColumnName(@"ExtaNumShortLabel6").HasColumnType("nvarchar").IsOptional().HasMaxLength(8);
            Property(x => x.ExtaNumShortLabel7).HasColumnName(@"ExtaNumShortLabel7").HasColumnType("nvarchar").IsOptional().HasMaxLength(8);
            Property(x => x.ExtaNumShortLabel8).HasColumnName(@"ExtaNumShortLabel8").HasColumnType("nvarchar").IsOptional().HasMaxLength(8);
            Property(x => x.SumExtraNum1).HasColumnName(@"SumExtraNum1").HasColumnType("bit").IsOptional();
            Property(x => x.SumExtraNum2).HasColumnName(@"SumExtraNum2").HasColumnType("bit").IsOptional();
            Property(x => x.SumExtraNum3).HasColumnName(@"SumExtraNum3").HasColumnType("bit").IsOptional();
            Property(x => x.SumExtraNum4).HasColumnName(@"SumExtraNum4").HasColumnType("bit").IsOptional();
            Property(x => x.SumExtraNum5).HasColumnName(@"SumExtraNum5").HasColumnType("bit").IsOptional();
            Property(x => x.SumExtraNum6).HasColumnName(@"SumExtraNum6").HasColumnType("bit").IsOptional();
            Property(x => x.SumExtraNum7).HasColumnName(@"SumExtraNum7").HasColumnType("bit").IsOptional();
            Property(x => x.SumExtraNum8).HasColumnName(@"SumExtraNum8").HasColumnType("bit").IsOptional();
        }
    }
}
