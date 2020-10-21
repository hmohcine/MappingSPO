using MappingSPO.Entities;

namespace MappingSPO
{
    public class ContactEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<ContactEntity>
    {
        public ContactEntityConfiguration()
            : this("Relations")
        {
        }

        public ContactEntityConfiguration(string schema)
        {
            ToTable("tContacts", schema);
            HasKey(x => x.ContactId);

            Property(x => x.ContactId).HasColumnName(@"ContactID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Title).HasColumnName(@"Title").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.Name).HasColumnName(@"Name").HasColumnType("nvarchar").IsOptional().HasMaxLength(120);
            Property(x => x.AdressLine1).HasColumnName(@"AdressLine1").HasColumnType("nvarchar").IsOptional().HasMaxLength(120);
            Property(x => x.AdressLine2).HasColumnName(@"AdressLine2").HasColumnType("nvarchar").IsOptional().HasMaxLength(120);
            Property(x => x.ZipCode).HasColumnName(@"ZipCode").HasColumnType("nvarchar").IsOptional().HasMaxLength(15);
            Property(x => x.City).HasColumnName(@"City").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.StreetCode).HasColumnName(@"StreetCode").HasColumnType("nchar").IsOptional().IsFixedLength().HasMaxLength(10);
            Property(x => x.CountryCode).HasColumnName(@"CountryCode").HasColumnType("nchar").IsOptional().IsFixedLength().HasMaxLength(4);
            Property(x => x.Notes).HasColumnName(@"Notes").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.Language).HasColumnName(@"Language").HasColumnType("nchar").IsOptional().IsFixedLength().HasMaxLength(4);
            Property(x => x.Phone).HasColumnName(@"Phone").HasColumnType("nvarchar").IsOptional().HasMaxLength(40);
            Property(x => x.Fax).HasColumnName(@"Fax").HasColumnType("nvarchar").IsOptional().HasMaxLength(40);
            Property(x => x.Email).HasColumnName(@"Email").HasColumnType("nvarchar").IsOptional().HasMaxLength(250);
            Property(x => x.LastUpdated).HasColumnName(@"LastUpdated").HasColumnType("datetime").IsOptional();
            Property(x => x.LastUpdatedBy).HasColumnName(@"LastUpdatedBy").HasColumnType("int").IsOptional();
            Property(x => x.Gsm).HasColumnName(@"GSM").HasColumnType("nvarchar").IsOptional().HasMaxLength(40);
            Property(x => x.ExtId).HasColumnName(@"ExtID").HasColumnType("int").IsOptional();
            Property(x => x.Aanhef).HasColumnName(@"Aanhef").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.Foto).HasColumnName(@"Foto").HasColumnType("image").IsOptional().HasMaxLength(2147483647);
            Property(x => x.SPhone).HasColumnName(@"sPhone").HasColumnType("nvarchar").IsOptional().HasMaxLength(50).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.SFax).HasColumnName(@"sFax").HasColumnType("nvarchar").IsOptional().HasMaxLength(50).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.SGsm).HasColumnName(@"sGSM").HasColumnType("nvarchar").IsOptional().HasMaxLength(50).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.AccId).HasColumnName(@"AccID").HasColumnType("bigint").IsOptional();
            Property(x => x.AccType).HasColumnName(@"AccType").HasColumnType("char").IsOptional().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Code1).HasColumnName(@"Code1").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Code2).HasColumnName(@"Code2").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Code3).HasColumnName(@"Code3").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Code4).HasColumnName(@"Code4").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Code5).HasColumnName(@"Code5").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Code6).HasColumnName(@"Code6").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Code7).HasColumnName(@"Code7").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Code8).HasColumnName(@"Code8").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.DateOfBirth).HasColumnName(@"DateOfBirth").HasColumnType("datetime").IsOptional();
            Property(x => x.PlaceOfBirth).HasColumnName(@"PlaceOfBirth").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.NationalNumber).HasColumnName(@"NationalNumber").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.IdNumber).HasColumnName(@"IDNumber").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.Nationality).HasColumnName(@"Nationality").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.Gender).HasColumnName(@"Gender").HasColumnType("int").IsOptional();
            Property(x => x.MaritalStatus).HasColumnName(@"MaritalStatus").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.ExtraBoolean1).HasColumnName(@"ExtraBoolean1").HasColumnType("bit").IsOptional();
            Property(x => x.ExtraBoolean2).HasColumnName(@"ExtraBoolean2").HasColumnType("bit").IsOptional();
            Property(x => x.ExtraBoolean3).HasColumnName(@"ExtraBoolean3").HasColumnType("bit").IsOptional();
            Property(x => x.ExtraBoolean4).HasColumnName(@"ExtraBoolean4").HasColumnType("bit").IsOptional();
            Property(x => x.ExtraRef1).HasColumnName(@"ExtraRef1").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.ExtraRef2).HasColumnName(@"ExtraRef2").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.ExtraRef3).HasColumnName(@"ExtraRef3").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.ExtraRef4).HasColumnName(@"ExtraRef4").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.ExtraNum1).HasColumnName(@"ExtraNum1").HasColumnType("float").IsOptional();
            Property(x => x.ExtraNum2).HasColumnName(@"ExtraNum2").HasColumnType("float").IsOptional();
            Property(x => x.ExtraNum3).HasColumnName(@"ExtraNum3").HasColumnType("float").IsOptional();
            Property(x => x.ExtraNum4).HasColumnName(@"ExtraNum4").HasColumnType("float").IsOptional();
            Property(x => x.ExtraNum5).HasColumnName(@"ExtraNum5").HasColumnType("float").IsOptional();
            Property(x => x.ExtraNum6).HasColumnName(@"ExtraNum6").HasColumnType("float").IsOptional();
            Property(x => x.ExtraNum7).HasColumnName(@"ExtraNum7").HasColumnType("float").IsOptional();
            Property(x => x.ExtraNum8).HasColumnName(@"ExtraNum8").HasColumnType("float").IsOptional();
            Property(x => x.TranslatableCode1).HasColumnName(@"TranslatableCode1").HasColumnType("bigint").IsOptional();
            Property(x => x.TranslatableCode2).HasColumnName(@"TranslatableCode2").HasColumnType("bigint").IsOptional();
            Property(x => x.TranslatableCode3).HasColumnName(@"TranslatableCode3").HasColumnType("bigint").IsOptional();
            Property(x => x.TranslatableCode4).HasColumnName(@"TranslatableCode4").HasColumnType("bigint").IsOptional();
            Property(x => x.TranslatableCode5).HasColumnName(@"TranslatableCode5").HasColumnType("bigint").IsOptional();
            Property(x => x.TranslatableCode6).HasColumnName(@"TranslatableCode6").HasColumnType("bigint").IsOptional();
            Property(x => x.TranslatableCode7).HasColumnName(@"TranslatableCode7").HasColumnType("bigint").IsOptional();
            Property(x => x.TranslatableCode8).HasColumnName(@"TranslatableCode8").HasColumnType("bigint").IsOptional();

            HasOptional(a => a.Country).WithMany(b => b.Contacts).HasForeignKey(c => c.CountryCode).WillCascadeOnDelete(false);
            HasOptional(a => a.Language_Language).WithMany(b => b.Contacts).HasForeignKey(c => c.Language).WillCascadeOnDelete(false);
            HasOptional(a => a.User).WithMany(b => b.Contacts).HasForeignKey(c => c.LastUpdatedBy).WillCascadeOnDelete(false);
        }
    }
}
