using MappingSPO.Entities;

namespace MappingSPO
{
    public class DocumentEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<DocumentEntity>
    {
        public DocumentEntityConfiguration()
            : this("Documents")
        {
        }

        public DocumentEntityConfiguration(string schema)
        {
            ToTable("tDocuments", schema);
            HasKey(x => x.DocumentId);

            Property(x => x.DocumentId).HasColumnName(@"DocumentID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasColumnName(@"Name").HasColumnType("nvarchar").IsRequired().HasMaxLength(255);
            Property(x => x.ExtentionId).HasColumnName(@"ExtentionID").HasColumnType("nvarchar").IsRequired().HasMaxLength(10);
            Property(x => x.Alias).HasColumnName(@"Alias").HasColumnType("nvarchar").IsRequired().HasMaxLength(255);
            Property(x => x.SubPath).HasColumnName(@"SubPath").HasColumnType("nvarchar").IsRequired().HasMaxLength(15);
            Property(x => x.CreateDate).HasColumnName(@"CreateDate").HasColumnType("datetime").IsRequired();
            Property(x => x.CreatedBy).HasColumnName(@"CreatedBy").HasColumnType("int").IsRequired();
            Property(x => x.Notes).HasColumnName(@"Notes").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.Code1).HasColumnName(@"Code1").HasColumnType("bigint").IsOptional();
            Property(x => x.Code2).HasColumnName(@"Code2").HasColumnType("bigint").IsOptional();
            Property(x => x.Code3).HasColumnName(@"Code3").HasColumnType("bigint").IsOptional();
            Property(x => x.Code4).HasColumnName(@"Code4").HasColumnType("bigint").IsOptional();
            Property(x => x.Ref1).HasColumnName(@"Ref1").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.Ref2).HasColumnName(@"Ref2").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.Ref3).HasColumnName(@"Ref3").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.Ref4).HasColumnName(@"Ref4").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.ArchiveId).HasColumnName(@"ArchiveID").HasColumnType("bigint").IsOptional();
            Property(x => x.DocumentMasterType).HasColumnName(@"DocumentMasterType").HasColumnType("int").IsRequired();
            Property(x => x.MasterOwnerUserId).HasColumnName(@"MasterOwnerUserID").HasColumnType("int").IsOptional();
            Property(x => x.Location).HasColumnName(@"Location").HasColumnType("int").IsOptional();
            Property(x => x.Direction).HasColumnName(@"Direction").HasColumnType("int").IsOptional();
            Property(x => x.MailBcc).HasColumnName(@"MailBCC").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.MailCc).HasColumnName(@"MailCC").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.MailTo).HasColumnName(@"MailTo").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.MailImportence).HasColumnName(@"MailImportence").HasColumnType("int").IsOptional();
            Property(x => x.MailSenderName).HasColumnName(@"MailSenderName").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.MailSenderEmail).HasColumnName(@"MailSenderEmail").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.MailType).HasColumnName(@"MailType").HasColumnType("int").IsOptional();
            Property(x => x.DocStateId).HasColumnName(@"DocStateID").HasColumnType("bigint").IsOptional();
            Property(x => x.OldCreatedById).HasColumnName(@"OldCreatedByID").HasColumnType("int").IsOptional();
            Property(x => x.FullAlias).HasColumnName(@"FullAlias").HasColumnType("nvarchar").IsRequired().HasMaxLength(266).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.ActiviteitId).HasColumnName(@"ActiviteitID").HasColumnType("bigint").IsOptional();
            Property(x => x.InkoopCatId).HasColumnName(@"InkoopCatID").HasColumnType("bigint").IsOptional();
            Property(x => x.VerkoopCatId).HasColumnName(@"VerkoopCatID").HasColumnType("bigint").IsOptional();

            HasOptional(a => a.Activiteiten).WithMany(b => b.Documents).HasForeignKey(c => c.ActiviteitId).WillCascadeOnDelete(false);
            HasOptional(a => a.DocCode1).WithMany(b => b.Documents).HasForeignKey(c => c.Code1).WillCascadeOnDelete(false);
            HasOptional(a => a.DocCode2).WithMany(b => b.Documents).HasForeignKey(c => c.Code2).WillCascadeOnDelete(false);
            HasOptional(a => a.DocCode3).WithMany(b => b.Documents).HasForeignKey(c => c.Code3).WillCascadeOnDelete(false);
            HasOptional(a => a.DocCode4).WithMany(b => b.Documents).HasForeignKey(c => c.Code4).WillCascadeOnDelete(false);
            HasOptional(a => a.InkoopCat).WithMany(b => b.Documents_InkoopCatId).HasForeignKey(c => c.InkoopCatId).WillCascadeOnDelete(false);
            HasOptional(a => a.VerkoopCat).WithMany(b => b.Documents_VerkoopCatId).HasForeignKey(c => c.VerkoopCatId).WillCascadeOnDelete(false);
            HasRequired(a => a.User).WithMany(b => b.Documents).HasForeignKey(c => c.CreatedBy).WillCascadeOnDelete(false);
        }
    }
}
