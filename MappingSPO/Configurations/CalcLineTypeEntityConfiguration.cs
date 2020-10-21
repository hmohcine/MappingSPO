using MappingSPO.Entities;

namespace MappingSPO
{
    public class CalcLineTypeEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CalcLineTypeEntity>
    {
        public CalcLineTypeEntityConfiguration()
            : this("Settings")
        {
        }

        public CalcLineTypeEntityConfiguration(string schema)
        {
            ToTable("tCalcLineType", schema);
            HasKey(x => x.CalcLineTypeCode);

            Property(x => x.CalcLineTypeCode).HasColumnName(@"CalcLineTypeCode").HasColumnType("nchar").IsRequired().IsFixedLength().HasMaxLength(2).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CalcLineMayorTypeCode).HasColumnName(@"CalcLineMayorTypeCode").HasColumnType("nchar").IsRequired().IsFixedLength().HasMaxLength(1);
            Property(x => x.CalcLineTypeDescription).HasColumnName(@"CalcLineTypeDescription").HasColumnType("nvarchar").IsOptional().HasMaxLength(250);
            Property(x => x.CalcTypeType).HasColumnName(@"CalcTypeType").HasColumnType("nvarchar").IsOptional().HasMaxLength(1);
            Property(x => x.BColor).HasColumnName(@"bColor").HasColumnType("int").IsOptional();
            Property(x => x.BBold).HasColumnName(@"bBold").HasColumnType("bit").IsOptional();
            Property(x => x.BItalic).HasColumnName(@"bItalic").HasColumnType("bit").IsOptional();
            Property(x => x.BBackColor).HasColumnName(@"bBackColor").HasColumnType("int").IsOptional();
            Property(x => x.AlternateColor).HasColumnName(@"AlternateColor").HasColumnType("bit").IsRequired();
            Property(x => x.AltForeColor).HasColumnName(@"AltForeColor").HasColumnType("int").IsOptional();
            Property(x => x.AltBold).HasColumnName(@"AltBold").HasColumnType("bit").IsOptional();
            Property(x => x.AltItalic).HasColumnName(@"AltItalic").HasColumnType("bit").IsOptional();
            Property(x => x.AltBackColor).HasColumnName(@"AltBackColor").HasColumnType("int").IsOptional();
            Property(x => x.FullLineMode).HasColumnName(@"FullLineMode").HasColumnType("bit").IsRequired();
            Property(x => x.IsDefaultForType).HasColumnName(@"IsDefaultForType").HasColumnType("bit").IsRequired();
            Property(x => x.Code1Required).HasColumnName(@"Code1Required").HasColumnType("bit").IsRequired();
            Property(x => x.Code2Required).HasColumnName(@"Code2Required").HasColumnType("bit").IsRequired();
            Property(x => x.Code3Required).HasColumnName(@"Code3Required").HasColumnType("bit").IsRequired();
            Property(x => x.Code4Required).HasColumnName(@"Code4Required").HasColumnType("bit").IsRequired();
            Property(x => x.Code5Required).HasColumnName(@"Code5Required").HasColumnType("bit").IsRequired();
            Property(x => x.Code6Required).HasColumnName(@"Code6Required").HasColumnType("bit").IsRequired();
            Property(x => x.Code7Required).HasColumnName(@"Code7Required").HasColumnType("bit").IsRequired();
            Property(x => x.Code8Required).HasColumnName(@"Code8Required").HasColumnType("bit").IsRequired();
            Property(x => x.ShouldHaveChildern).HasColumnName(@"ShouldHaveChildern").HasColumnType("bit").IsRequired();
            Property(x => x.ToTypeIfSamengesteld).HasColumnName(@"ToTypeIfSamengesteld").HasColumnType("nchar").IsOptional().IsFixedLength().HasMaxLength(2);

            HasOptional(a => a.CalcLineType_ToTypeIfSamengesteld).WithMany(b => b.CalcLineTypes).HasForeignKey(c => c.ToTypeIfSamengesteld).WillCascadeOnDelete(false);
        }
    }
}
