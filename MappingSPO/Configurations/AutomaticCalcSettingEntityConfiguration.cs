using MappingSPO.Entities;

namespace MappingSPO
{
    public class AutomaticCalcSettingEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<AutomaticCalcSettingEntity>
    {
        public AutomaticCalcSettingEntityConfiguration()
            : this("Settings")
        {
        }

        public AutomaticCalcSettingEntityConfiguration(string schema)
        {
            ToTable("tAutomaticCalcSettings", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasColumnName(@"Name").HasColumnType("nvarchar").IsRequired().HasMaxLength(255);
            Property(x => x.IsTempSet).HasColumnName(@"IsTempSet").HasColumnType("bit").IsRequired();
            Property(x => x.Owner).HasColumnName(@"Owner").HasColumnType("int").IsRequired();
            Property(x => x.CreateDate).HasColumnName(@"CreateDate").HasColumnType("datetime").IsRequired();
            Property(x => x.OnlyForUser).HasColumnName(@"OnlyForUser").HasColumnType("int").IsOptional();
            Property(x => x.Mode).HasColumnName(@"Mode").HasColumnType("int").IsRequired();
            Property(x => x.SourceCodes).HasColumnName(@"SourceCodes").HasColumnType("nvarchar").IsOptional().HasMaxLength(16);
            Property(x => x.SourceSkipChars).HasColumnName(@"SourceSkipChars").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.SourceSkipBlancs).HasColumnName(@"SourceSkipBlancs").HasColumnType("bit").IsOptional();
            Property(x => x.TargetCodes).HasColumnName(@"TargetCodes").HasColumnType("nvarchar").IsOptional().HasMaxLength(16);
            Property(x => x.TargetSkipChars).HasColumnName(@"TargetSkipChars").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.TargetSkipBlancs).HasColumnName(@"TargetSkipBlancs").HasColumnType("bit").IsOptional();
            Property(x => x.CompareCode).HasColumnName(@"CompareCode").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.ReplaceEmptyKsWith).HasColumnName(@"ReplaceEmptyKSWith").HasColumnType("nvarchar").IsOptional().HasMaxLength(10);
            Property(x => x.SelectMostRecentPrice).HasColumnName(@"SelectMostRecentPrice").HasColumnType("bit").IsOptional();
            Property(x => x.OverwriteExistingValues).HasColumnName(@"OverwriteExistingValues").HasColumnType("bit").IsOptional();

            HasOptional(a => a.Ks).WithMany(b => b.AutomaticCalcSettings).HasForeignKey(c => c.ReplaceEmptyKsWith).WillCascadeOnDelete(false);
            HasOptional(a => a.User_OnlyForUser).WithMany(b => b.AutomaticCalcSettings_OnlyForUser).HasForeignKey(c => c.OnlyForUser).WillCascadeOnDelete(false);
            HasRequired(a => a.User_Owner).WithMany(b => b.AutomaticCalcSettings_Owner).HasForeignKey(c => c.Owner).WillCascadeOnDelete(false);
        }
    }
}
