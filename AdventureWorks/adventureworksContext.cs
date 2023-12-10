using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Grad_Project.AdventWorksModel
{
    public partial class adventureworksContext : DbContext
    {
        public adventureworksContext()
        {
        }

        public adventureworksContext(DbContextOptions<adventureworksContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Address> Addresses { get; set; } = null!;
        public virtual DbSet<Addresstype> Addresstypes { get; set; } = null!;
        public virtual DbSet<Awbuildversion> Awbuildversions { get; set; } = null!;
        public virtual DbSet<Billofmaterial> Billofmaterials { get; set; } = null!;
        public virtual DbSet<Contact> Contacts { get; set; } = null!;
        public virtual DbSet<Contactcreditcard> Contactcreditcards { get; set; } = null!;
        public virtual DbSet<Contacttype> Contacttypes { get; set; } = null!;
        public virtual DbSet<Countryregion> Countryregions { get; set; } = null!;
        public virtual DbSet<Countryregioncurrency> Countryregioncurrencies { get; set; } = null!;
        public virtual DbSet<Creditcard> Creditcards { get; set; } = null!;
        public virtual DbSet<Culture> Cultures { get; set; } = null!;
        public virtual DbSet<Currency> Currencies { get; set; } = null!;
        public virtual DbSet<Currencyrate> Currencyrates { get; set; } = null!;
        public virtual DbSet<Customer> Customers { get; set; } = null!;
        public virtual DbSet<Customeraddress> Customeraddresses { get; set; } = null!;
        public virtual DbSet<Databaselog> Databaselogs { get; set; } = null!;
        public virtual DbSet<Department> Departments { get; set; } = null!;
        public virtual DbSet<Document> Documents { get; set; } = null!;
        public virtual DbSet<Employee> Employees { get; set; } = null!;
        public virtual DbSet<Employeeaddress> Employeeaddresses { get; set; } = null!;
        public virtual DbSet<Employeedepartmenthistory> Employeedepartmenthistories { get; set; } = null!;
        public virtual DbSet<Employeepayhistory> Employeepayhistories { get; set; } = null!;
        public virtual DbSet<Errorlog> Errorlogs { get; set; } = null!;
        public virtual DbSet<Illustration> Illustrations { get; set; } = null!;
        public virtual DbSet<Individual> Individuals { get; set; } = null!;
        public virtual DbSet<Jobcandidate> Jobcandidates { get; set; } = null!;
        public virtual DbSet<Location> Locations { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<Productcategory> Productcategories { get; set; } = null!;
        public virtual DbSet<Productcosthistory> Productcosthistories { get; set; } = null!;
        public virtual DbSet<Productdescription> Productdescriptions { get; set; } = null!;
        public virtual DbSet<Productdocument> Productdocuments { get; set; } = null!;
        public virtual DbSet<Productinventory> Productinventories { get; set; } = null!;
        public virtual DbSet<Productlistpricehistory> Productlistpricehistories { get; set; } = null!;
        public virtual DbSet<Productmodel> Productmodels { get; set; } = null!;
        public virtual DbSet<Productmodelillustration> Productmodelillustrations { get; set; } = null!;
        public virtual DbSet<Productmodelproductdescriptionculture> Productmodelproductdescriptioncultures { get; set; } = null!;
        public virtual DbSet<Productphoto> Productphotos { get; set; } = null!;
        public virtual DbSet<Productproductphoto> Productproductphotos { get; set; } = null!;
        public virtual DbSet<Productreview> Productreviews { get; set; } = null!;
        public virtual DbSet<Productsubcategory> Productsubcategories { get; set; } = null!;
        public virtual DbSet<Productvendor> Productvendors { get; set; } = null!;
        public virtual DbSet<Purchaseorderdetail> Purchaseorderdetails { get; set; } = null!;
        public virtual DbSet<Purchaseorderheader> Purchaseorderheaders { get; set; } = null!;
        public virtual DbSet<Salesorderdetail> Salesorderdetails { get; set; } = null!;
        public virtual DbSet<Salesorderheader> Salesorderheaders { get; set; } = null!;
        public virtual DbSet<Salesorderheadersalesreason> Salesorderheadersalesreasons { get; set; } = null!;
        public virtual DbSet<Salesperson> Salespeople { get; set; } = null!;
        public virtual DbSet<Salespersonquotahistory> Salespersonquotahistories { get; set; } = null!;
        public virtual DbSet<Salesreason> Salesreasons { get; set; } = null!;
        public virtual DbSet<Salestaxrate> Salestaxrates { get; set; } = null!;
        public virtual DbSet<Salesterritory> Salesterritories { get; set; } = null!;
        public virtual DbSet<Salesterritoryhistory> Salesterritoryhistories { get; set; } = null!;
        public virtual DbSet<Scrapreason> Scrapreasons { get; set; } = null!;
        public virtual DbSet<Shift> Shifts { get; set; } = null!;
        public virtual DbSet<Shipmethod> Shipmethods { get; set; } = null!;
        public virtual DbSet<Shoppingcartitem> Shoppingcartitems { get; set; } = null!;
        public virtual DbSet<Specialoffer> Specialoffers { get; set; } = null!;
        public virtual DbSet<Specialofferproduct> Specialofferproducts { get; set; } = null!;
        public virtual DbSet<Stateprovince> Stateprovinces { get; set; } = null!;
        public virtual DbSet<Store> Stores { get; set; } = null!;
        public virtual DbSet<Storecontact> Storecontacts { get; set; } = null!;
        public virtual DbSet<Transactionhistory> Transactionhistories { get; set; } = null!;
        public virtual DbSet<Transactionhistoryarchive> Transactionhistoryarchives { get; set; } = null!;
        public virtual DbSet<Unitmeasure> Unitmeasures { get; set; } = null!;
        public virtual DbSet<Vendor> Vendors { get; set; } = null!;
        public virtual DbSet<Vendoraddress> Vendoraddresses { get; set; } = null!;
        public virtual DbSet<Vendorcontact> Vendorcontacts { get; set; } = null!;
        public virtual DbSet<Workorder> Workorders { get; set; } = null!;
        public virtual DbSet<Workorderrouting> Workorderroutings { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySQL("Server=localhost;Port=3306;Database=adventureworks;User=root;Password=MysqlKranthi;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>(entity =>
            {
                entity.ToTable("address");

                entity.Property(e => e.AddressId).HasColumnName("AddressID");

                entity.Property(e => e.AddressLine1).HasMaxLength(60);

                entity.Property(e => e.AddressLine2).HasMaxLength(60);

                entity.Property(e => e.City).HasMaxLength(30);

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.PostalCode).HasMaxLength(15);

                entity.Property(e => e.Rowguid)
                    .HasMaxLength(16)
                    .HasColumnName("rowguid");

                entity.Property(e => e.StateProvinceId).HasColumnName("StateProvinceID");
            });

            modelBuilder.Entity<Addresstype>(entity =>
            {
                entity.ToTable("addresstype");

                entity.Property(e => e.AddressTypeId).HasColumnName("AddressTypeID");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Rowguid)
                    .HasMaxLength(16)
                    .HasColumnName("rowguid");
            });

            modelBuilder.Entity<Awbuildversion>(entity =>
            {
                entity.HasKey(e => e.SystemInformationId)
                    .HasName("PRIMARY");

                entity.ToTable("awbuildversion");

                entity.Property(e => e.SystemInformationId).HasColumnName("SystemInformationID");

                entity.Property(e => e.DatabaseVersion)
                    .HasMaxLength(25)
                    .HasColumnName("Database Version");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.VersionDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Billofmaterial>(entity =>
            {
                entity.HasKey(e => e.BillOfMaterialsId)
                    .HasName("PRIMARY");

                entity.ToTable("billofmaterials");

                entity.Property(e => e.BillOfMaterialsId).HasColumnName("BillOfMaterialsID");

                entity.Property(e => e.Bomlevel).HasColumnName("BOMLevel");

                entity.Property(e => e.ComponentId).HasColumnName("ComponentID");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.PerAssemblyQty).HasPrecision(8);

                entity.Property(e => e.ProductAssemblyId).HasColumnName("ProductAssemblyID");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.UnitMeasureCode).HasMaxLength(3);
            });

            modelBuilder.Entity<Contact>(entity =>
            {
                entity.ToTable("contact");

                entity.Property(e => e.ContactId).HasColumnName("ContactID");

                entity.Property(e => e.AdditionalContactInfo).HasColumnType("mediumtext");

                entity.Property(e => e.EmailAddress).HasMaxLength(50);

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.MiddleName).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.NameStyle).HasColumnType("bit(1)");

                entity.Property(e => e.PasswordHash).HasMaxLength(40);

                entity.Property(e => e.PasswordSalt).HasMaxLength(10);

                entity.Property(e => e.Phone).HasMaxLength(25);

                entity.Property(e => e.Rowguid)
                    .HasMaxLength(16)
                    .HasColumnName("rowguid");

                entity.Property(e => e.Suffix).HasMaxLength(10);

                entity.Property(e => e.Title).HasMaxLength(8);
            });

            modelBuilder.Entity<Contactcreditcard>(entity =>
            {
                entity.HasKey(e => new { e.ContactId, e.CreditCardId })
                    .HasName("PRIMARY");

                entity.ToTable("contactcreditcard");

                entity.Property(e => e.ContactId).HasColumnName("ContactID");

                entity.Property(e => e.CreditCardId).HasColumnName("CreditCardID");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<Contacttype>(entity =>
            {
                entity.ToTable("contacttype");

                entity.Property(e => e.ContactTypeId).HasColumnName("ContactTypeID");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Countryregion>(entity =>
            {
                entity.HasKey(e => e.CountryRegionCode)
                    .HasName("PRIMARY");

                entity.ToTable("countryregion");

                entity.Property(e => e.CountryRegionCode).HasMaxLength(3);

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Countryregioncurrency>(entity =>
            {
                entity.HasKey(e => new { e.CountryRegionCode, e.CurrencyCode })
                    .HasName("PRIMARY");

                entity.ToTable("countryregioncurrency");

                entity.Property(e => e.CountryRegionCode).HasMaxLength(3);

                entity.Property(e => e.CurrencyCode).HasMaxLength(3);

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<Creditcard>(entity =>
            {
                entity.ToTable("creditcard");

                entity.Property(e => e.CreditCardId).HasColumnName("CreditCardID");

                entity.Property(e => e.CardNumber).HasMaxLength(25);

                entity.Property(e => e.CardType).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<Culture>(entity =>
            {
                entity.ToTable("culture");

                entity.Property(e => e.CultureId)
                    .HasMaxLength(6)
                    .HasColumnName("CultureID");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Currency>(entity =>
            {
                entity.HasKey(e => e.CurrencyCode)
                    .HasName("PRIMARY");

                entity.ToTable("currency");

                entity.Property(e => e.CurrencyCode).HasMaxLength(3);

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Currencyrate>(entity =>
            {
                entity.ToTable("currencyrate");

                entity.Property(e => e.CurrencyRateId).HasColumnName("CurrencyRateID");

                entity.Property(e => e.CurrencyRateDate).HasColumnType("datetime");

                entity.Property(e => e.FromCurrencyCode).HasMaxLength(3);

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.ToCurrencyCode).HasMaxLength(3);
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("customer");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.AccountNumber).HasMaxLength(10);

                entity.Property(e => e.CustomerType).HasMaxLength(1);

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Rowguid)
                    .HasMaxLength(16)
                    .HasColumnName("rowguid");

                entity.Property(e => e.TerritoryId).HasColumnName("TerritoryID");
            });

            modelBuilder.Entity<Customeraddress>(entity =>
            {
                entity.HasKey(e => new { e.CustomerId, e.AddressId })
                    .HasName("PRIMARY");

                entity.ToTable("customeraddress");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.AddressId).HasColumnName("AddressID");

                entity.Property(e => e.AddressTypeId).HasColumnName("AddressTypeID");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Rowguid)
                    .HasMaxLength(16)
                    .HasColumnName("rowguid");
            });

            modelBuilder.Entity<Databaselog>(entity =>
            {
                entity.ToTable("databaselog");

                entity.Property(e => e.DatabaseLogId).HasColumnName("DatabaseLogID");

                entity.Property(e => e.DatabaseUser).HasMaxLength(128);

                entity.Property(e => e.Event).HasMaxLength(128);

                entity.Property(e => e.Object).HasMaxLength(128);

                entity.Property(e => e.PostTime)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Schema).HasMaxLength(128);

                entity.Property(e => e.Tsql)
                    .HasColumnType("mediumtext")
                    .HasColumnName("TSQL");

                entity.Property(e => e.XmlEvent).HasColumnType("mediumtext");
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.ToTable("department");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.GroupName).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Document>(entity =>
            {
                entity.ToTable("document");

                entity.Property(e => e.DocumentId).HasColumnName("DocumentID");

                entity.Property(e => e.Document1)
                    .HasColumnType("blob")
                    .HasColumnName("Document");

                entity.Property(e => e.DocumentSummary).HasColumnType("mediumtext");

                entity.Property(e => e.FileExtension).HasMaxLength(8);

                entity.Property(e => e.FileName).HasColumnType("mediumtext");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Revision).HasMaxLength(5);

                entity.Property(e => e.Title).HasMaxLength(50);
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("employee");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.BirthDate).HasColumnType("datetime");

                entity.Property(e => e.ContactId).HasColumnName("ContactID");

                entity.Property(e => e.CurrentFlag).HasColumnType("bit(1)");

                entity.Property(e => e.Gender).HasMaxLength(1);

                entity.Property(e => e.HireDate).HasColumnType("datetime");

                entity.Property(e => e.LoginId)
                    .HasMaxLength(256)
                    .HasColumnName("LoginID");

                entity.Property(e => e.ManagerId).HasColumnName("ManagerID");

                entity.Property(e => e.MaritalStatus).HasMaxLength(1);

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.NationalIdnumber)
                    .HasMaxLength(15)
                    .HasColumnName("NationalIDNumber");

                entity.Property(e => e.Rowguid)
                    .HasMaxLength(16)
                    .HasColumnName("rowguid");

                entity.Property(e => e.SalariedFlag).HasColumnType("bit(1)");

                entity.Property(e => e.Title).HasMaxLength(50);
            });

            modelBuilder.Entity<Employeeaddress>(entity =>
            {
                entity.HasKey(e => new { e.EmployeeId, e.AddressId })
                    .HasName("PRIMARY");

                entity.ToTable("employeeaddress");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.AddressId).HasColumnName("AddressID");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Rowguid)
                    .HasMaxLength(16)
                    .HasColumnName("rowguid");
            });

            modelBuilder.Entity<Employeedepartmenthistory>(entity =>
            {
                entity.HasKey(e => new { e.EmployeeId, e.DepartmentId, e.ShiftId, e.StartDate })
                    .HasName("PRIMARY");

                entity.ToTable("employeedepartmenthistory");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.ShiftId).HasColumnName("ShiftID");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<Employeepayhistory>(entity =>
            {
                entity.HasKey(e => new { e.EmployeeId, e.RateChangeDate })
                    .HasName("PRIMARY");

                entity.ToTable("employeepayhistory");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.RateChangeDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<Errorlog>(entity =>
            {
                entity.ToTable("errorlog");

                entity.Property(e => e.ErrorLogId).HasColumnName("ErrorLogID");

                entity.Property(e => e.ErrorMessage).HasColumnType("mediumtext");

                entity.Property(e => e.ErrorProcedure).HasMaxLength(126);

                entity.Property(e => e.ErrorTime)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.UserName).HasMaxLength(128);
            });

            modelBuilder.Entity<Illustration>(entity =>
            {
                entity.ToTable("illustration");

                entity.Property(e => e.IllustrationId).HasColumnName("IllustrationID");

                entity.Property(e => e.Diagram).HasColumnType("text");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<Individual>(entity =>
            {
                entity.HasKey(e => e.CustomerId)
                    .HasName("PRIMARY");

                entity.ToTable("individual");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.ContactId).HasColumnName("ContactID");

                entity.Property(e => e.Demographics).HasColumnType("text");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<Jobcandidate>(entity =>
            {
                entity.ToTable("jobcandidate");

                entity.Property(e => e.JobCandidateId).HasColumnName("JobCandidateID");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Resume).HasColumnType("text");
            });

            modelBuilder.Entity<Location>(entity =>
            {
                entity.ToTable("location");

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.Availability).HasPrecision(8);

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("product");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.Class).HasMaxLength(2);

                entity.Property(e => e.Color).HasMaxLength(15);

                entity.Property(e => e.DiscontinuedDate).HasColumnType("datetime");

                entity.Property(e => e.FinishedGoodsFlag).HasColumnType("bit(1)");

                entity.Property(e => e.MakeFlag).HasColumnType("bit(1)");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.ProductLine).HasMaxLength(2);

                entity.Property(e => e.ProductModelId).HasColumnName("ProductModelID");

                entity.Property(e => e.ProductNumber).HasMaxLength(25);

                entity.Property(e => e.ProductSubcategoryId).HasColumnName("ProductSubcategoryID");

                entity.Property(e => e.Rowguid)
                    .HasMaxLength(16)
                    .HasColumnName("rowguid");

                entity.Property(e => e.SellEndDate).HasColumnType("datetime");

                entity.Property(e => e.SellStartDate).HasColumnType("datetime");

                entity.Property(e => e.Size).HasMaxLength(5);

                entity.Property(e => e.SizeUnitMeasureCode).HasMaxLength(3);

                entity.Property(e => e.Style).HasMaxLength(2);

                entity.Property(e => e.Weight).HasPrecision(8);

                entity.Property(e => e.WeightUnitMeasureCode).HasMaxLength(3);
            });

            modelBuilder.Entity<Productcategory>(entity =>
            {
                entity.ToTable("productcategory");

                entity.Property(e => e.ProductCategoryId).HasColumnName("ProductCategoryID");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Rowguid)
                    .HasMaxLength(16)
                    .HasColumnName("rowguid");
            });

            modelBuilder.Entity<Productcosthistory>(entity =>
            {
                entity.HasKey(e => new { e.ProductId, e.StartDate })
                    .HasName("PRIMARY");

                entity.ToTable("productcosthistory");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<Productdescription>(entity =>
            {
                entity.ToTable("productdescription");

                entity.Property(e => e.ProductDescriptionId).HasColumnName("ProductDescriptionID");

                entity.Property(e => e.Description).HasColumnType("mediumtext");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Rowguid)
                    .HasMaxLength(16)
                    .HasColumnName("rowguid");
            });

            modelBuilder.Entity<Productdocument>(entity =>
            {
                entity.HasKey(e => new { e.ProductId, e.DocumentId })
                    .HasName("PRIMARY");

                entity.ToTable("productdocument");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.DocumentId).HasColumnName("DocumentID");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<Productinventory>(entity =>
            {
                entity.HasKey(e => new { e.ProductId, e.LocationId })
                    .HasName("PRIMARY");

                entity.ToTable("productinventory");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Rowguid)
                    .HasMaxLength(16)
                    .HasColumnName("rowguid");

                entity.Property(e => e.Shelf).HasMaxLength(10);
            });

            modelBuilder.Entity<Productlistpricehistory>(entity =>
            {
                entity.HasKey(e => new { e.ProductId, e.StartDate })
                    .HasName("PRIMARY");

                entity.ToTable("productlistpricehistory");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<Productmodel>(entity =>
            {
                entity.ToTable("productmodel");

                entity.Property(e => e.ProductModelId).HasColumnName("ProductModelID");

                entity.Property(e => e.CatalogDescription).HasColumnType("text");

                entity.Property(e => e.Instructions).HasColumnType("text");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Rowguid)
                    .HasMaxLength(16)
                    .HasColumnName("rowguid");
            });

            modelBuilder.Entity<Productmodelillustration>(entity =>
            {
                entity.HasKey(e => new { e.ProductModelId, e.IllustrationId })
                    .HasName("PRIMARY");

                entity.ToTable("productmodelillustration");

                entity.Property(e => e.ProductModelId).HasColumnName("ProductModelID");

                entity.Property(e => e.IllustrationId).HasColumnName("IllustrationID");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<Productmodelproductdescriptionculture>(entity =>
            {
                entity.HasKey(e => new { e.ProductModelId, e.ProductDescriptionId, e.CultureId })
                    .HasName("PRIMARY");

                entity.ToTable("productmodelproductdescriptionculture");

                entity.Property(e => e.ProductModelId).HasColumnName("ProductModelID");

                entity.Property(e => e.ProductDescriptionId).HasColumnName("ProductDescriptionID");

                entity.Property(e => e.CultureId)
                    .HasMaxLength(6)
                    .HasColumnName("CultureID");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<Productphoto>(entity =>
            {
                entity.ToTable("productphoto");

                entity.Property(e => e.ProductPhotoId).HasColumnName("ProductPhotoID");

                entity.Property(e => e.LargePhoto).HasColumnType("blob");

                entity.Property(e => e.LargePhotoFileName).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.ThumbNailPhoto).HasColumnType("blob");

                entity.Property(e => e.ThumbnailPhotoFileName).HasMaxLength(50);
            });

            modelBuilder.Entity<Productproductphoto>(entity =>
            {
                entity.HasKey(e => new { e.ProductId, e.ProductPhotoId })
                    .HasName("PRIMARY");

                entity.ToTable("productproductphoto");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.ProductPhotoId).HasColumnName("ProductPhotoID");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Primary).HasColumnType("bit(1)");
            });

            modelBuilder.Entity<Productreview>(entity =>
            {
                entity.ToTable("productreview");

                entity.Property(e => e.ProductReviewId).HasColumnName("ProductReviewID");

                entity.Property(e => e.Comments).HasColumnType("mediumtext");

                entity.Property(e => e.EmailAddress).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.ReviewDate)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.ReviewerName).HasMaxLength(50);
            });

            modelBuilder.Entity<Productsubcategory>(entity =>
            {
                entity.ToTable("productsubcategory");

                entity.Property(e => e.ProductSubcategoryId).HasColumnName("ProductSubcategoryID");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.ProductCategoryId).HasColumnName("ProductCategoryID");

                entity.Property(e => e.Rowguid)
                    .HasMaxLength(16)
                    .HasColumnName("rowguid");
            });

            modelBuilder.Entity<Productvendor>(entity =>
            {
                entity.HasKey(e => new { e.ProductId, e.VendorId })
                    .HasName("PRIMARY");

                entity.ToTable("productvendor");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.VendorId).HasColumnName("VendorID");

                entity.Property(e => e.LastReceiptDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.UnitMeasureCode).HasMaxLength(3);
            });

            modelBuilder.Entity<Purchaseorderdetail>(entity =>
            {
                entity.HasKey(e => new { e.PurchaseOrderDetailId, e.PurchaseOrderId })
                    .HasName("PRIMARY");

                entity.ToTable("purchaseorderdetail");

                entity.Property(e => e.PurchaseOrderDetailId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("PurchaseOrderDetailID");

                entity.Property(e => e.PurchaseOrderId).HasColumnName("PurchaseOrderID");

                entity.Property(e => e.DueDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.ReceivedQty).HasPrecision(8);

                entity.Property(e => e.RejectedQty).HasPrecision(8);

                entity.Property(e => e.StockedQty).HasPrecision(9);
            });

            modelBuilder.Entity<Purchaseorderheader>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("purchaseorderheader");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OrderDate).HasColumnType("datetime");

                entity.Property(e => e.PurchaseOrderId).HasColumnName("PurchaseOrderID");

                entity.Property(e => e.ShipDate).HasColumnType("datetime");

                entity.Property(e => e.ShipMethodId).HasColumnName("ShipMethodID");

                entity.Property(e => e.VendorId).HasColumnName("VendorID");
            });

            modelBuilder.Entity<Salesorderdetail>(entity =>
            {
                entity.HasKey(e => new { e.SalesOrderDetailId, e.SalesOrderId })
                    .HasName("PRIMARY");

                entity.ToTable("salesorderdetail");

                entity.Property(e => e.SalesOrderDetailId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("SalesOrderDetailID");

                entity.Property(e => e.SalesOrderId).HasColumnName("SalesOrderID");

                entity.Property(e => e.CarrierTrackingNumber).HasMaxLength(25);

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.Rowguid)
                    .HasMaxLength(16)
                    .HasColumnName("rowguid");

                entity.Property(e => e.SpecialOfferId).HasColumnName("SpecialOfferID");
            });

            modelBuilder.Entity<Salesorderheader>(entity =>
            {
                entity.HasKey(e => e.SalesOrderId)
                    .HasName("PRIMARY");

                entity.ToTable("salesorderheader");

                entity.Property(e => e.SalesOrderId).HasColumnName("SalesOrderID");

                entity.Property(e => e.AccountNumber).HasMaxLength(15);

                entity.Property(e => e.BillToAddressId).HasColumnName("BillToAddressID");

                entity.Property(e => e.Comment).HasMaxLength(128);

                entity.Property(e => e.ContactId).HasColumnName("ContactID");

                entity.Property(e => e.CreditCardApprovalCode).HasMaxLength(15);

                entity.Property(e => e.CreditCardId).HasColumnName("CreditCardID");

                entity.Property(e => e.CurrencyRateId).HasColumnName("CurrencyRateID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.DueDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.OnlineOrderFlag).HasColumnType("bit(1)");

                entity.Property(e => e.OrderDate)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.PurchaseOrderNumber).HasMaxLength(25);

                entity.Property(e => e.Rowguid)
                    .HasMaxLength(16)
                    .HasColumnName("rowguid");

                entity.Property(e => e.SalesOrderNumber).HasMaxLength(25);

                entity.Property(e => e.SalesPersonId).HasColumnName("SalesPersonID");

                entity.Property(e => e.ShipDate).HasColumnType("datetime");

                entity.Property(e => e.ShipMethodId).HasColumnName("ShipMethodID");

                entity.Property(e => e.ShipToAddressId).HasColumnName("ShipToAddressID");

                entity.Property(e => e.TerritoryId).HasColumnName("TerritoryID");
            });

            modelBuilder.Entity<Salesorderheadersalesreason>(entity =>
            {
                entity.HasKey(e => new { e.SalesOrderId, e.SalesReasonId })
                    .HasName("PRIMARY");

                entity.ToTable("salesorderheadersalesreason");

                entity.Property(e => e.SalesOrderId).HasColumnName("SalesOrderID");

                entity.Property(e => e.SalesReasonId).HasColumnName("SalesReasonID");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<Salesperson>(entity =>
            {
                entity.ToTable("salesperson");

                entity.Property(e => e.SalesPersonId).HasColumnName("SalesPersonID");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Rowguid)
                    .HasMaxLength(16)
                    .HasColumnName("rowguid");

                entity.Property(e => e.SalesYtd).HasColumnName("SalesYTD");

                entity.Property(e => e.TerritoryId).HasColumnName("TerritoryID");
            });

            modelBuilder.Entity<Salespersonquotahistory>(entity =>
            {
                entity.HasKey(e => new { e.SalesPersonId, e.QuotaDate })
                    .HasName("PRIMARY");

                entity.ToTable("salespersonquotahistory");

                entity.Property(e => e.SalesPersonId).HasColumnName("SalesPersonID");

                entity.Property(e => e.QuotaDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Rowguid)
                    .HasMaxLength(16)
                    .HasColumnName("rowguid");
            });

            modelBuilder.Entity<Salesreason>(entity =>
            {
                entity.ToTable("salesreason");

                entity.Property(e => e.SalesReasonId).HasColumnName("SalesReasonID");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.ReasonType).HasMaxLength(50);
            });

            modelBuilder.Entity<Salestaxrate>(entity =>
            {
                entity.ToTable("salestaxrate");

                entity.Property(e => e.SalesTaxRateId).HasColumnName("SalesTaxRateID");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Rowguid)
                    .HasMaxLength(16)
                    .HasColumnName("rowguid");

                entity.Property(e => e.StateProvinceId).HasColumnName("StateProvinceID");
            });

            modelBuilder.Entity<Salesterritory>(entity =>
            {
                entity.HasKey(e => e.TerritoryId)
                    .HasName("PRIMARY");

                entity.ToTable("salesterritory");

                entity.Property(e => e.TerritoryId).HasColumnName("TerritoryID");

                entity.Property(e => e.CostYtd).HasColumnName("CostYTD");

                entity.Property(e => e.CountryRegionCode).HasMaxLength(3);

                entity.Property(e => e.Group).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Rowguid)
                    .HasMaxLength(16)
                    .HasColumnName("rowguid");

                entity.Property(e => e.SalesYtd).HasColumnName("SalesYTD");
            });

            modelBuilder.Entity<Salesterritoryhistory>(entity =>
            {
                entity.HasKey(e => new { e.SalesPersonId, e.TerritoryId, e.StartDate })
                    .HasName("PRIMARY");

                entity.ToTable("salesterritoryhistory");

                entity.Property(e => e.SalesPersonId).HasColumnName("SalesPersonID");

                entity.Property(e => e.TerritoryId).HasColumnName("TerritoryID");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Rowguid)
                    .HasMaxLength(16)
                    .HasColumnName("rowguid");
            });

            modelBuilder.Entity<Scrapreason>(entity =>
            {
                entity.ToTable("scrapreason");

                entity.Property(e => e.ScrapReasonId).HasColumnName("ScrapReasonID");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Shift>(entity =>
            {
                entity.ToTable("shift");

                entity.Property(e => e.ShiftId).HasColumnName("ShiftID");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.StartTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Shipmethod>(entity =>
            {
                entity.ToTable("shipmethod");

                entity.Property(e => e.ShipMethodId).HasColumnName("ShipMethodID");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Rowguid)
                    .HasMaxLength(16)
                    .HasColumnName("rowguid");
            });

            modelBuilder.Entity<Shoppingcartitem>(entity =>
            {
                entity.ToTable("shoppingcartitem");

                entity.Property(e => e.ShoppingCartItemId).HasColumnName("ShoppingCartItemID");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.Quantity).HasDefaultValueSql("'1'");

                entity.Property(e => e.ShoppingCartId)
                    .HasMaxLength(50)
                    .HasColumnName("ShoppingCartID");
            });

            modelBuilder.Entity<Specialoffer>(entity =>
            {
                entity.ToTable("specialoffer");

                entity.Property(e => e.SpecialOfferId).HasColumnName("SpecialOfferID");

                entity.Property(e => e.Category).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Rowguid)
                    .HasMaxLength(16)
                    .HasColumnName("rowguid");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.Type).HasMaxLength(50);
            });

            modelBuilder.Entity<Specialofferproduct>(entity =>
            {
                entity.HasKey(e => new { e.SpecialOfferId, e.ProductId })
                    .HasName("PRIMARY");

                entity.ToTable("specialofferproduct");

                entity.Property(e => e.SpecialOfferId).HasColumnName("SpecialOfferID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Rowguid)
                    .HasMaxLength(16)
                    .HasColumnName("rowguid");
            });

            modelBuilder.Entity<Stateprovince>(entity =>
            {
                entity.ToTable("stateprovince");

                entity.Property(e => e.StateProvinceId).HasColumnName("StateProvinceID");

                entity.Property(e => e.CountryRegionCode).HasMaxLength(3);

                entity.Property(e => e.IsOnlyStateProvinceFlag)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'1'");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Rowguid)
                    .HasMaxLength(16)
                    .HasColumnName("rowguid");

                entity.Property(e => e.StateProvinceCode).HasMaxLength(3);

                entity.Property(e => e.TerritoryId).HasColumnName("TerritoryID");
            });

            modelBuilder.Entity<Store>(entity =>
            {
                entity.HasKey(e => e.CustomerId)
                    .HasName("PRIMARY");

                entity.ToTable("store");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.Demographics).HasColumnType("text");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Rowguid)
                    .HasMaxLength(16)
                    .HasColumnName("rowguid");

                entity.Property(e => e.SalesPersonId).HasColumnName("SalesPersonID");
            });

            modelBuilder.Entity<Storecontact>(entity =>
            {
                entity.HasKey(e => new { e.CustomerId, e.ContactId })
                    .HasName("PRIMARY");

                entity.ToTable("storecontact");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.ContactId).HasColumnName("ContactID");

                entity.Property(e => e.ContactTypeId).HasColumnName("ContactTypeID");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Rowguid)
                    .HasMaxLength(16)
                    .HasColumnName("rowguid");
            });

            modelBuilder.Entity<Transactionhistory>(entity =>
            {
                entity.HasKey(e => e.TransactionId)
                    .HasName("PRIMARY");

                entity.ToTable("transactionhistory");

                entity.Property(e => e.TransactionId).HasColumnName("TransactionID");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.ReferenceOrderId).HasColumnName("ReferenceOrderID");

                entity.Property(e => e.ReferenceOrderLineId).HasColumnName("ReferenceOrderLineID");

                entity.Property(e => e.TransactionDate)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.TransactionType).HasMaxLength(1);
            });

            modelBuilder.Entity<Transactionhistoryarchive>(entity =>
            {
                entity.HasKey(e => e.TransactionId)
                    .HasName("PRIMARY");

                entity.ToTable("transactionhistoryarchive");

                entity.Property(e => e.TransactionId).HasColumnName("TransactionID");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.ReferenceOrderId).HasColumnName("ReferenceOrderID");

                entity.Property(e => e.ReferenceOrderLineId).HasColumnName("ReferenceOrderLineID");

                entity.Property(e => e.TransactionDate)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.TransactionType).HasMaxLength(1);
            });

            modelBuilder.Entity<Unitmeasure>(entity =>
            {
                entity.HasKey(e => e.UnitMeasureCode)
                    .HasName("PRIMARY");

                entity.ToTable("unitmeasure");

                entity.Property(e => e.UnitMeasureCode).HasMaxLength(3);

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Vendor>(entity =>
            {
                entity.ToTable("vendor");

                entity.Property(e => e.VendorId).HasColumnName("VendorID");

                entity.Property(e => e.AccountNumber).HasMaxLength(15);

                entity.Property(e => e.ActiveFlag)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'1'");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.PreferredVendorStatus)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'1'");

                entity.Property(e => e.PurchasingWebServiceUrl)
                    .HasColumnType("mediumtext")
                    .HasColumnName("PurchasingWebServiceURL");
            });

            modelBuilder.Entity<Vendoraddress>(entity =>
            {
                entity.HasKey(e => new { e.VendorId, e.AddressId })
                    .HasName("PRIMARY");

                entity.ToTable("vendoraddress");

                entity.Property(e => e.VendorId).HasColumnName("VendorID");

                entity.Property(e => e.AddressId).HasColumnName("AddressID");

                entity.Property(e => e.AddressTypeId).HasColumnName("AddressTypeID");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<Vendorcontact>(entity =>
            {
                entity.HasKey(e => new { e.VendorId, e.ContactId })
                    .HasName("PRIMARY");

                entity.ToTable("vendorcontact");

                entity.Property(e => e.VendorId).HasColumnName("VendorID");

                entity.Property(e => e.ContactId).HasColumnName("ContactID");

                entity.Property(e => e.ContactTypeId).HasColumnName("ContactTypeID");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<Workorder>(entity =>
            {
                entity.ToTable("workorder");

                entity.Property(e => e.WorkOrderId).HasColumnName("WorkOrderID");

                entity.Property(e => e.DueDate).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.ScrapReasonId).HasColumnName("ScrapReasonID");

                entity.Property(e => e.StartDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Workorderrouting>(entity =>
            {
                entity.HasKey(e => new { e.WorkOrderId, e.ProductId, e.OperationSequence })
                    .HasName("PRIMARY");

                entity.ToTable("workorderrouting");

                entity.Property(e => e.WorkOrderId).HasColumnName("WorkOrderID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.ActualEndDate).HasColumnType("datetime");

                entity.Property(e => e.ActualResourceHrs).HasPrecision(9, 4);

                entity.Property(e => e.ActualStartDate).HasColumnType("datetime");

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.ScheduledEndDate).HasColumnType("datetime");

                entity.Property(e => e.ScheduledStartDate).HasColumnType("datetime");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
