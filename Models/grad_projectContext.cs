using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Grad_Project.Models
{
    public partial class grad_projectContext : DbContext
    {
        public grad_projectContext()
        {
        }

        public grad_projectContext(DbContextOptions<grad_projectContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cart> Carts { get; set; } = null!;
        public virtual DbSet<Customer> Customers { get; set; } = null!;
        public virtual DbSet<Customercredential> Customercredentials { get; set; } = null!;
        public virtual DbSet<Order> Orders { get; set; } = null!;
        public virtual DbSet<Orderstatus> Orderstatuses { get; set; } = null!;
        public virtual DbSet<Partner> Partners { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<Rating> Ratings { get; set; } = null!;
        public virtual DbSet<Restocking> Restockings { get; set; } = null!;
        public virtual DbSet<Restockingstatus> Restockingstatuses { get; set; } = null!;
        public virtual DbSet<Supplier> Suppliers { get; set; } = null!;
        public virtual DbSet<Wishlist> Wishlists { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySQL("Server=localhost;Port=3306;Database=grad_project;User=root;Password=MysqlKranthi;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cart>(entity =>
            {
                entity.ToTable("cart");

                entity.HasIndex(e => e.CustomerId, "customer_id");

                entity.Property(e => e.CartId).HasColumnName("cart_id");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.ProductName)
                    .HasMaxLength(300)
                    .HasColumnName("product_name");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Carts)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("cart_ibfk_1");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("customers");

                entity.HasIndex(e => e.Email, "idx_customers_email");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.Address).HasColumnName("address");

                entity.Property(e => e.Attachments).HasColumnName("attachments");

                entity.Property(e => e.BusinessPhone)
                    .HasMaxLength(25)
                    .HasColumnName("business_phone");

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .HasColumnName("city");

                entity.Property(e => e.CountryRegion)
                    .HasMaxLength(50)
                    .HasColumnName("country_region");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasColumnName("email");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .HasColumnName("first_name");

                entity.Property(e => e.HomePhone)
                    .HasMaxLength(25)
                    .HasColumnName("home_phone");

                entity.Property(e => e.JobTitle)
                    .HasMaxLength(50)
                    .HasColumnName("job_title");

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .HasColumnName("last_name");

                entity.Property(e => e.MobilePhone)
                    .HasMaxLength(25)
                    .HasColumnName("mobile_phone");

                entity.Property(e => e.Notes).HasColumnName("notes");

                entity.Property(e => e.StateProvince)
                    .HasMaxLength(50)
                    .HasColumnName("state_province");

                entity.Property(e => e.WebPage).HasColumnName("web_page");

                entity.Property(e => e.ZipPostalCode)
                    .HasMaxLength(15)
                    .HasColumnName("zip_postal_code");
            });

            modelBuilder.Entity<Customercredential>(entity =>
            {
                entity.HasKey(e => e.CustomerId)
                    .HasName("PRIMARY");

                entity.ToTable("customercredentials");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(50)
                    .HasColumnName("customer_name");

                entity.Property(e => e.PasswordHash)
                    .HasMaxLength(255)
                    .HasColumnName("password_hash");

                entity.HasOne(d => d.Customer)
                    .WithOne(p => p.Customercredential)
                    .HasForeignKey<Customercredential>(d => d.CustomerId)
                    .HasConstraintName("fk_customer_credentials");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.ToTable("orders");

                entity.HasIndex(e => e.CustomerId, "idx_orders_customer_id");

                entity.HasIndex(e => e.StatusId, "status_id");

                entity.Property(e => e.OrderId).HasColumnName("order_id");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.OrderDate)
                    .HasColumnType("date")
                    .HasColumnName("order_date");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.Property(e => e.TotalPrice)
                    .HasPrecision(19, 4)
                    .HasColumnName("total_price");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("orders_ibfk_1");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("orders_ibfk_2");
            });

            modelBuilder.Entity<Orderstatus>(entity =>
            {
                entity.HasKey(e => e.StatusId)
                    .HasName("PRIMARY");

                entity.ToTable("orderstatus");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.Property(e => e.StatusName)
                    .HasMaxLength(20)
                    .HasColumnName("status_name");
            });

            modelBuilder.Entity<Partner>(entity =>
            {
                entity.ToTable("partners");

                entity.Property(e => e.PartnerId).HasColumnName("partner_id");

                entity.Property(e => e.Description)
                    .HasMaxLength(300)
                    .HasColumnName("description");

                entity.Property(e => e.PartnerName)
                    .HasMaxLength(50)
                    .HasColumnName("partner_name");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("products");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.Attachments).HasColumnName("attachments");

                entity.Property(e => e.Category)
                    .HasMaxLength(50)
                    .HasColumnName("category");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Discontinued).HasColumnName("discontinued");

                entity.Property(e => e.InStock).HasColumnName("in_stock");

                entity.Property(e => e.ListPrice)
                    .HasPrecision(19, 4)
                    .HasColumnName("list_price");

                entity.Property(e => e.MinimumInstockQuantity).HasColumnName("minimum_instock_quantity");

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(25)
                    .HasColumnName("product_code");

                entity.Property(e => e.ProductName)
                    .HasMaxLength(50)
                    .HasColumnName("product_name");

                entity.Property(e => e.QuantityPerUnit)
                    .HasMaxLength(50)
                    .HasColumnName("quantity_per_unit");

                entity.Property(e => e.StandardCost)
                    .HasPrecision(19, 4)
                    .HasColumnName("standard_cost");

                entity.Property(e => e.TargetLevel).HasColumnName("target_level");
            });

            modelBuilder.Entity<Rating>(entity =>
            {
                entity.ToTable("ratings");

                entity.HasIndex(e => e.ProductId, "FK_ProductRating");

                entity.Property(e => e.RatingId).HasColumnName("rating_id");

                entity.Property(e => e.Comment)
                    .HasColumnType("text")
                    .HasColumnName("comment");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.RatingDate)
                    .HasColumnType("date")
                    .HasColumnName("rating_date");

                entity.Property(e => e.RatingValue)
                    .HasPrecision(3)
                    .HasColumnName("rating_value");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Ratings)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_ProductRating");
            });

            modelBuilder.Entity<Restocking>(entity =>
            {
                entity.ToTable("restocking");

                entity.HasIndex(e => e.ProductId, "idx_restocking_product_id");

                entity.HasIndex(e => e.StatusId, "status_id");

                entity.Property(e => e.RestockingId).HasColumnName("restocking_id");

                entity.Property(e => e.OrderDate)
                    .HasColumnType("date")
                    .HasColumnName("order_date");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Restockings)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("restocking_ibfk_1");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Restockings)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("restocking_ibfk_2");
            });

            modelBuilder.Entity<Restockingstatus>(entity =>
            {
                entity.HasKey(e => e.StatusId)
                    .HasName("PRIMARY");

                entity.ToTable("restockingstatus");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.Property(e => e.StatusName)
                    .HasMaxLength(20)
                    .HasColumnName("status_name");
            });

            modelBuilder.Entity<Supplier>(entity =>
            {
                entity.ToTable("suppliers");

                entity.Property(e => e.SupplierId).HasColumnName("supplier_id");

                entity.Property(e => e.ContactEmail)
                    .HasMaxLength(50)
                    .HasColumnName("contact_email");

                entity.Property(e => e.ContactPerson)
                    .HasMaxLength(50)
                    .HasColumnName("contact_person");

                entity.Property(e => e.ContactPhone)
                    .HasMaxLength(25)
                    .HasColumnName("contact_phone");

                entity.Property(e => e.SupplierName)
                    .HasMaxLength(100)
                    .HasColumnName("supplier_name");
            });

            modelBuilder.Entity<Wishlist>(entity =>
            {
                entity.ToTable("wishlist");

                entity.HasIndex(e => e.CustomerId, "customer_id");

                entity.Property(e => e.WishlistId).HasColumnName("wishlist_id");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.DateAdded)
                    .HasColumnType("date")
                    .HasColumnName("date_added");

                entity.Property(e => e.ProductName)
                    .HasMaxLength(250)
                    .HasColumnName("product_name");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Wishlists)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("wishlist_ibfk_1");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
