using MappingSPO.Project.DL.Entities;

namespace MappingSPO.Project.DL.Configurations
{
    public class ProjectEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<ProjectEntity>
    {
        public ProjectEntityConfiguration()
            : this("Project")
        {
        }

        public ProjectEntityConfiguration(string schema)
        {
            ToTable("tProject", schema);
            HasKey(x => new { x.ProjectId, x.ProjectType });

            Property(x => x.ProjectId).HasColumnName(@"ProjectID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ProjectType).HasColumnName(@"ProjectType").HasColumnType("nvarchar").IsRequired().HasMaxLength(2).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ProjectYear).HasColumnName(@"ProjectYear").HasColumnType("int").IsRequired();
            Property(x => x.ProjectNumber).HasColumnName(@"ProjectNumber").HasColumnType("int").IsRequired();
            Property(x => x.ProjectNrText).HasColumnName(@"ProjectNrText").HasColumnType("nvarchar").IsRequired().HasMaxLength(50);
            Property(x => x.ProjectName).HasColumnName(@"ProjectName").HasColumnType("nvarchar").IsRequired().HasMaxLength(250);
            Property(x => x.ProjectDate).HasColumnName(@"ProjectDate").HasColumnType("datetime").IsRequired();
            Property(x => x.StartDate).HasColumnName(@"StartDate").HasColumnType("datetime").IsOptional();
            Property(x => x.DueDate).HasColumnName(@"DueDate").HasColumnType("datetime").IsOptional();
            Property(x => x.DoneDate).HasColumnName(@"DoneDate").HasColumnType("datetime").IsOptional();
            Property(x => x.CreateDate).HasColumnName(@"CreateDate").HasColumnType("datetime").IsRequired();
            Property(x => x.UpdateDate).HasColumnName(@"UpdateDate").HasColumnType("datetime").IsRequired();
            Property(x => x.CreatedBy).HasColumnName(@"CreatedBy").HasColumnType("int").IsRequired();
            Property(x => x.UpdatedBy).HasColumnName(@"UpdatedBy").HasColumnType("int").IsRequired();
            Property(x => x.NotesIntern).HasColumnName(@"NotesIntern").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.NotesExtern).HasColumnName(@"NotesExtern").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.DefaultCompanyId).HasColumnName(@"DefaultCompanyID").HasColumnType("int").IsOptional();
            Property(x => x.OfferCode1).HasColumnName(@"OfferCode1").HasColumnType("int").IsOptional();
            Property(x => x.OfferCode2).HasColumnName(@"OfferCode2").HasColumnType("int").IsOptional();
            Property(x => x.OfferCode3).HasColumnName(@"OfferCode3").HasColumnType("int").IsOptional();
            Property(x => x.OfferCode4).HasColumnName(@"OfferCode4").HasColumnType("int").IsOptional();
            Property(x => x.OfferCode5).HasColumnName(@"OfferCode5").HasColumnType("int").IsOptional();
            Property(x => x.OfferCode6).HasColumnName(@"OfferCode6").HasColumnType("int").IsOptional();
            Property(x => x.OfferCode7).HasColumnName(@"OfferCode7").HasColumnType("int").IsOptional();
            Property(x => x.OfferCode8).HasColumnName(@"OfferCode8").HasColumnType("int").IsOptional();
            Property(x => x.Ref1).HasColumnName(@"Ref1").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.Ref2).HasColumnName(@"Ref2").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.Ref3).HasColumnName(@"Ref3").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.Ref4).HasColumnName(@"Ref4").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.WerfCode1).HasColumnName(@"WerfCode1").HasColumnType("int").IsOptional();
            Property(x => x.WerfCode2).HasColumnName(@"WerfCode2").HasColumnType("int").IsOptional();
            Property(x => x.WerfCode3).HasColumnName(@"WerfCode3").HasColumnType("int").IsOptional();
            Property(x => x.WerfCode4).HasColumnName(@"WerfCode4").HasColumnType("int").IsOptional();
            Property(x => x.WerfCode5).HasColumnName(@"WerfCode5").HasColumnType("int").IsOptional();
            Property(x => x.WerfCode6).HasColumnName(@"WerfCode6").HasColumnType("int").IsOptional();
            Property(x => x.WerfCode7).HasColumnName(@"WerfCode7").HasColumnType("int").IsOptional();
            Property(x => x.WerfCode8).HasColumnName(@"WerfCode8").HasColumnType("int").IsOptional();
            Property(x => x.DefaultCodeRange).HasColumnName(@"DefaultCodeRange").HasColumnType("int").IsOptional();
            Property(x => x.ProjectVerantWoordelijke1).HasColumnName(@"ProjectVerantWoordelijke1").HasColumnType("int").IsOptional();
            Property(x => x.ProjectVerantWoordelijke2).HasColumnName(@"ProjectVerantWoordelijke2").HasColumnType("int").IsOptional();
            Property(x => x.ProjectVerantWoordelijke3).HasColumnName(@"ProjectVerantWoordelijke3").HasColumnType("int").IsOptional();
            Property(x => x.ProjectState).HasColumnName(@"ProjectState").HasColumnType("int").IsRequired();
            Property(x => x.ProjectResult).HasColumnName(@"ProjectResult").HasColumnType("int").IsRequired();
            Property(x => x.Owner).HasColumnName(@"Owner").HasColumnType("int").IsRequired();
            Property(x => x.HasExtendedSecurity).HasColumnName(@"HasExtendedSecurity").HasColumnType("bit").IsRequired();
            Property(x => x.Code1).HasColumnName(@"Code1").HasColumnType("int").IsOptional();
            Property(x => x.Code2).HasColumnName(@"Code2").HasColumnType("int").IsOptional();
            Property(x => x.Code3).HasColumnName(@"Code3").HasColumnType("int").IsOptional();
            Property(x => x.Code4).HasColumnName(@"Code4").HasColumnType("int").IsOptional();
            Property(x => x.Code5).HasColumnName(@"Code5").HasColumnType("int").IsOptional();
            Property(x => x.Code6).HasColumnName(@"Code6").HasColumnType("int").IsOptional();
            Property(x => x.Code7).HasColumnName(@"Code7").HasColumnType("int").IsOptional();
            Property(x => x.Code8).HasColumnName(@"Code8").HasColumnType("int").IsOptional();
            Property(x => x.RelationTypeId).HasColumnName(@"RelationTypeID").HasColumnType("int").IsOptional();
            Property(x => x.RelationId).HasColumnName(@"RelationID").HasColumnType("bigint").IsOptional();
            Property(x => x.ProjectResultReason).HasColumnName(@"ProjectResultReason").HasColumnType("int").IsOptional();
            Property(x => x.TotalsColumn).HasColumnName(@"TotalsColumn").HasColumnType("int").IsRequired();
            Property(x => x.ContactId).HasColumnName(@"ContactID").HasColumnType("int").IsOptional();
            Property(x => x.ProjectDone).HasColumnName(@"ProjectDone").HasColumnType("bit").IsRequired();
            Property(x => x.ExtraDate1).HasColumnName(@"ExtraDate1").HasColumnType("datetime").IsOptional();
            Property(x => x.ExtraDate2).HasColumnName(@"ExtraDate2").HasColumnType("datetime").IsOptional();
            Property(x => x.ExtraDate3).HasColumnName(@"ExtraDate3").HasColumnType("datetime").IsOptional();
            Property(x => x.ExtraDate4).HasColumnName(@"ExtraDate4").HasColumnType("datetime").IsOptional();
            Property(x => x.ExtraDate5).HasColumnName(@"ExtraDate5").HasColumnType("datetime").IsOptional();
            Property(x => x.ExtraDate6).HasColumnName(@"ExtraDate6").HasColumnType("datetime").IsOptional();
            Property(x => x.ExtraDate7).HasColumnName(@"ExtraDate7").HasColumnType("datetime").IsOptional();
            Property(x => x.ExtraNum1).HasColumnName(@"ExtraNum1").HasColumnType("decimal").IsOptional().HasPrecision(18,4);
            Property(x => x.ExtraNum2).HasColumnName(@"ExtraNum2").HasColumnType("decimal").IsOptional().HasPrecision(18,4);
            Property(x => x.ExtraNum3).HasColumnName(@"ExtraNum3").HasColumnType("decimal").IsOptional().HasPrecision(18,4);
            Property(x => x.ExtraNum4).HasColumnName(@"ExtraNum4").HasColumnType("decimal").IsOptional().HasPrecision(18,4);
            Property(x => x.ExtraNum5).HasColumnName(@"ExtraNum5").HasColumnType("decimal").IsOptional().HasPrecision(18,4);
            Property(x => x.ExtraNum6).HasColumnName(@"ExtraNum6").HasColumnType("decimal").IsOptional().HasPrecision(18,4);
            Property(x => x.ExtraNum7).HasColumnName(@"ExtraNum7").HasColumnType("decimal").IsOptional().HasPrecision(18,4);
            Property(x => x.ExtraNum8).HasColumnName(@"ExtraNum8").HasColumnType("decimal").IsOptional().HasPrecision(18,4);
            Property(x => x.GlobalId).HasColumnName(@"GlobalID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.ExtNumber).HasColumnName(@"ExtNumber").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.CheckInAtWorkYn).HasColumnName(@"CheckInAtWorkYn").HasColumnType("bit").IsOptional();
            Property(x => x.CExtNumber).HasColumnName(@"cExtNumber").HasColumnType("nvarchar").IsOptional().HasMaxLength(4000).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.IntegrationYn).HasColumnName(@"IntegrationYn").HasColumnType("bit").IsRequired();
            Property(x => x.SubCategoryId).HasColumnName(@"SubCategoryId").HasColumnType("int").IsOptional();

            HasOptional(a => a.CalcCode1).WithMany(b => b.Projects).HasForeignKey(c => c.OfferCode1).WillCascadeOnDelete(false);
            HasOptional(a => a.CalcCode2).WithMany(b => b.Projects).HasForeignKey(c => c.OfferCode2).WillCascadeOnDelete(false);
            HasOptional(a => a.CalcCode3).WithMany(b => b.Projects).HasForeignKey(c => c.OfferCode3).WillCascadeOnDelete(false);
            HasOptional(a => a.CalcCode4).WithMany(b => b.Projects).HasForeignKey(c => c.OfferCode4).WillCascadeOnDelete(false);
            HasOptional(a => a.CalcCode5).WithMany(b => b.Projects).HasForeignKey(c => c.OfferCode5).WillCascadeOnDelete(false);
            HasOptional(a => a.CalcCode6).WithMany(b => b.Projects).HasForeignKey(c => c.OfferCode6).WillCascadeOnDelete(false);
            HasOptional(a => a.CalcCode7).WithMany(b => b.Projects).HasForeignKey(c => c.OfferCode7).WillCascadeOnDelete(false);
            HasOptional(a => a.CalcCode8).WithMany(b => b.Projects).HasForeignKey(c => c.OfferCode8).WillCascadeOnDelete(false);
            HasOptional(a => a.Relation).WithMany(b => b.Projects).HasForeignKey(c => c.RelationId).WillCascadeOnDelete(false);
            HasOptional(a => a.RelationType).WithMany(b => b.Projects).HasForeignKey(c => c.RelationTypeId).WillCascadeOnDelete(false);
        }
    }
}
