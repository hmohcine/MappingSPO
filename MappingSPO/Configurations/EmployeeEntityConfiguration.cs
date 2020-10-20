using MappingSPO.Entities;

namespace MappingSPO
{
    public class EmployeeEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<EmployeeEntity>
    {
        public EmployeeEntityConfiguration()
            : this("HumanResources")
        {
        }

        public EmployeeEntityConfiguration(string schema)
        {
            ToTable("tEmployees", schema);
            HasKey(x => x.EmployeeId);

            Property(x => x.EmployeeId).HasColumnName(@"EmployeeID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.EmployeeNumber).HasColumnName(@"EmployeeNumber").HasColumnType("bigint").IsRequired();
            Property(x => x.Title).HasColumnName(@"Title").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.FirstName).HasColumnName(@"FirstName").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.MiddleName).HasColumnName(@"MiddleName").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.LastName).HasColumnName(@"LastName").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.Initials).HasColumnName(@"Initials").HasColumnType("nvarchar").IsOptional().HasMaxLength(10);
            Property(x => x.AdressLine1).HasColumnName(@"AdressLine1").HasColumnType("nvarchar").IsOptional().HasMaxLength(120);
            Property(x => x.AdressLine2).HasColumnName(@"AdressLine2").HasColumnType("nvarchar").IsOptional().HasMaxLength(120);
            Property(x => x.StreetCode).HasColumnName(@"StreetCode").HasColumnType("nchar").IsOptional().IsFixedLength().HasMaxLength(10);
            Property(x => x.ZipCode).HasColumnName(@"ZipCode").HasColumnType("nvarchar").IsOptional().HasMaxLength(15);
            Property(x => x.City).HasColumnName(@"City").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.CountryCode).HasColumnName(@"CountryCode").HasColumnType("nchar").IsOptional().IsFixedLength().HasMaxLength(4);
            Property(x => x.Phone).HasColumnName(@"Phone").HasColumnType("nvarchar").IsOptional().HasMaxLength(40);
            Property(x => x.Fax).HasColumnName(@"Fax").HasColumnType("nvarchar").IsOptional().HasMaxLength(40);
            Property(x => x.Gsm).HasColumnName(@"GSM").HasColumnType("nvarchar").IsOptional().HasMaxLength(40);
            Property(x => x.Email).HasColumnName(@"Email").HasColumnType("nvarchar").IsOptional().HasMaxLength(250);
            Property(x => x.Birthday).HasColumnName(@"Birthday").HasColumnType("datetime").IsOptional();
            Property(x => x.Language).HasColumnName(@"Language").HasColumnType("nchar").IsOptional().IsFixedLength().HasMaxLength(4);
            Property(x => x.Notes).HasColumnName(@"Notes").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.ParentEmployeeId).HasColumnName(@"ParentEmployeeID").HasColumnType("int").IsOptional();
            Property(x => x.Gender).HasColumnName(@"Gender").HasColumnType("nchar").IsOptional().IsFixedLength().HasMaxLength(1);
            Property(x => x.HireDate).HasColumnName(@"HireDate").HasColumnType("datetime").IsOptional();
            Property(x => x.StartDate).HasColumnName(@"StartDate").HasColumnType("datetime").IsOptional();
            Property(x => x.EndDate).HasColumnName(@"EndDate").HasColumnType("datetime").IsOptional();
            Property(x => x.CompanyId).HasColumnName(@"CompanyID").HasColumnType("int").IsOptional();
            Property(x => x.BasisLoon).HasColumnName(@"BasisLoon").HasColumnType("float").IsOptional();
            Property(x => x.BasisLoonEc).HasColumnName(@"BasisLoonEC").HasColumnType("nvarchar").IsOptional().HasMaxLength(10);
            Property(x => x.LoonCost).HasColumnName(@"LoonCost").HasColumnType("float").IsOptional();
            Property(x => x.LoonCostEc).HasColumnName(@"LoonCostEC").HasColumnType("nvarchar").IsOptional().HasMaxLength(10);
            Property(x => x.LoonCostKs).HasColumnName(@"LoonCostKS").HasColumnType("nvarchar").IsOptional().HasMaxLength(10);
            Property(x => x.NormAantal).HasColumnName(@"NormAantal").HasColumnType("float").IsOptional();
            Property(x => x.OnNumber).HasColumnName(@"ONNumber").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.RijksregNr).HasColumnName(@"RijksregNr").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.IsCalculator).HasColumnName(@"IsCalculator").HasColumnType("bit").IsOptional();
            Property(x => x.IsVeranwoordelijke).HasColumnName(@"IsVeranwoordelijke").HasColumnType("bit").IsOptional();
            Property(x => x.IsArbeider).HasColumnName(@"IsArbeider").HasColumnType("bit").IsOptional();
            Property(x => x.IsBediende).HasColumnName(@"IsBediende").HasColumnType("bit").IsOptional();
            Property(x => x.Foto).HasColumnName(@"Foto").HasColumnType("image").IsOptional().HasMaxLength(2147483647);
            Property(x => x.FullName).HasColumnName(@"FullName").HasColumnType("nvarchar").IsOptional().HasMaxLength(360);
            Property(x => x.Code1).HasColumnName(@"Code1").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Code2).HasColumnName(@"Code2").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Code3).HasColumnName(@"Code3").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Code4).HasColumnName(@"Code4").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Code5).HasColumnName(@"Code5").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Code6).HasColumnName(@"Code6").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Code7).HasColumnName(@"Code7").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Code8).HasColumnName(@"Code8").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Description).HasColumnName(@"Description").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.GeboortePlaats).HasColumnName(@"GeboortePlaats").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.Nationality).HasColumnName(@"Nationality").HasColumnType("nvarchar").IsOptional().HasMaxLength(75);
            Property(x => x.IdentiteitskaartNummer).HasColumnName(@"IdentiteitskaartNummer").HasColumnType("nvarchar").IsOptional().HasMaxLength(75);
            Property(x => x.SisKaartNummer).HasColumnName(@"SISKaartNummer").HasColumnType("nvarchar").IsOptional().HasMaxLength(75);
            Property(x => x.SisVervalDatum).HasColumnName(@"SISVervalDatum").HasColumnType("datetime").IsOptional();
            Property(x => x.PersoneelsNummer).HasColumnName(@"PersoneelsNummer").HasColumnType("nvarchar").IsOptional().HasMaxLength(75);
            Property(x => x.PersoneelsRegisterNummer).HasColumnName(@"PersoneelsRegisterNummer").HasColumnType("nvarchar").IsOptional().HasMaxLength(75);
            Property(x => x.EmailPrive).HasColumnName(@"EmailPrive").HasColumnType("nvarchar").IsOptional().HasMaxLength(250);
            Property(x => x.PhonePrive).HasColumnName(@"PhonePrive").HasColumnType("nvarchar").IsOptional().HasMaxLength(40);
            Property(x => x.GsmPrive).HasColumnName(@"GSMPrive").HasColumnType("nvarchar").IsOptional().HasMaxLength(40);
            Property(x => x.ParitairComiteNummer).HasColumnName(@"ParitairComiteNummer").HasColumnType("nvarchar").IsOptional().HasMaxLength(75);
            Property(x => x.Functie).HasColumnName(@"Functie").HasColumnType("nvarchar").IsOptional().HasMaxLength(75);
            Property(x => x.UurPerWeek).HasColumnName(@"UurPerWeek").HasColumnType("float").IsOptional();
            Property(x => x.DaysPerWeek).HasColumnName(@"DaysPerWeek").HasColumnType("int").IsOptional();
            Property(x => x.KmThuisWerk).HasColumnName(@"KmThuisWerk").HasColumnType("float").IsOptional();
            Property(x => x.Loonstelsel).HasColumnName(@"Loonstelsel").HasColumnType("nvarchar").IsOptional().HasMaxLength(75);
            Property(x => x.BurgelijkeStand).HasColumnName(@"BurgelijkeStand").HasColumnType("nvarchar").IsOptional().HasMaxLength(75);
            Property(x => x.NameSpouse).HasColumnName(@"NameSpouse").HasColumnType("nvarchar").IsOptional().HasMaxLength(150);
            Property(x => x.BirtDaySpouse).HasColumnName(@"BirtDaySpouse").HasColumnType("datetime").IsOptional();
            Property(x => x.EchtgenoteTenLaste).HasColumnName(@"EchtgenoteTenLaste").HasColumnType("bit").IsOptional();
            Property(x => x.KinderenTenLaste).HasColumnName(@"KinderenTenLaste").HasColumnType("int").IsOptional();
            Property(x => x.KinderenTenLasteInvalid).HasColumnName(@"KinderenTenLasteInvalid").HasColumnType("int").IsOptional();
            Property(x => x.AndereTenLaste).HasColumnName(@"AndereTenLaste").HasColumnType("int").IsOptional();
            Property(x => x.AndereTenLasteInvalid).HasColumnName(@"AndereTenLasteInvalid").HasColumnType("int").IsOptional();
            Property(x => x.BetalingsWijze).HasColumnName(@"BetalingsWijze").HasColumnType("nvarchar").IsOptional().HasMaxLength(75);
            Property(x => x.IbanNr).HasColumnName(@"IBANNr").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.BicNr).HasColumnName(@"BICNr").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.RekeningHouder).HasColumnName(@"RekeningHouder").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.RekeningHouderStraat).HasColumnName(@"RekeningHouderStraat").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.RekeningHouderZipCode).HasColumnName(@"RekeningHouderZipCode").HasColumnType("nvarchar").IsOptional().HasMaxLength(15);
            Property(x => x.RekeningHouderCity).HasColumnName(@"RekeningHouderCity").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.DefaultMobiliteitsCode).HasColumnName(@"DefaultMobiliteitsCode").HasColumnType("nvarchar").IsOptional().HasMaxLength(10);
            Property(x => x.OldEmployeeNumber).HasColumnName(@"OldEmployeeNumber").HasColumnType("nvarchar").IsOptional().HasMaxLength(30);
            Property(x => x.LoonCostFromParentYn).HasColumnName(@"LoonCostFromParentYn").HasColumnType("bit").IsRequired();

            HasOptional(a => a.Company).WithMany(b => b.Employees).HasForeignKey(c => c.CompanyId).WillCascadeOnDelete(false);
            HasOptional(a => a.Country).WithMany(b => b.Employees).HasForeignKey(c => c.CountryCode).WillCascadeOnDelete(false);
            HasOptional(a => a.Ks).WithMany(b => b.Employees).HasForeignKey(c => c.LoonCostKs).WillCascadeOnDelete(false);
            HasOptional(a => a.Language_Language).WithMany(b => b.Employees).HasForeignKey(c => c.Language).WillCascadeOnDelete(false);
            HasOptional(a => a.MobiliteitsCode).WithMany(b => b.Employees).HasForeignKey(c => c.DefaultMobiliteitsCode).WillCascadeOnDelete(false);
            HasOptional(a => a.Uc_BasisLoonEc).WithMany(b => b.Employees_BasisLoonEc).HasForeignKey(c => c.BasisLoonEc).WillCascadeOnDelete(false);
            HasOptional(a => a.Uc_LoonCostEc).WithMany(b => b.Employees_LoonCostEc).HasForeignKey(c => c.LoonCostEc).WillCascadeOnDelete(false);
        }
    }
}
