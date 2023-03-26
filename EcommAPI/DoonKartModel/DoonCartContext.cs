using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EcommAPI.DoonKartModel
{
    public partial class DoonCartContext : DbContext
    {
        public DoonCartContext()
        {
        }
        public DoonCartContext(DbContextOptions<DoonCartContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblBeforeFooter> TblBeforeFooters { get; set; } = null!;
        public virtual DbSet<TblCategory> TblCategories { get; set; } = null!;
        public virtual DbSet<TblError> TblErrors { get; set; } = null!;
        public virtual DbSet<TblFooter> TblFooters { get; set; } = null!;
        public virtual DbSet<TblFooterHeading> TblFooterHeadings { get; set; } = null!;
        public virtual DbSet<TblHeader> TblHeaders { get; set; } = null!;
        public virtual DbSet<TblOrder> TblOrders { get; set; } = null!;
        public virtual DbSet<TblOrderItem> TblOrderItems { get; set; } = null!;
        public virtual DbSet<TblPrice> TblPrices { get; set; } = null!;
        public virtual DbSet<TblProduct> TblProducts { get; set; } = null!;
        public virtual DbSet<TblSlider> TblSliders { get; set; } = null!;
        public virtual DbSet<TblSubCategory> TblSubCategories { get; set; } = null!;
        public virtual DbSet<TblUser> TblUsers { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-46NSJF0;Database=db_doon_cart;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblBeforeFooter>(entity =>
            {
                entity.HasKey(e => e.BeforeFooterId)
                    .HasName("PK__tbl_befo__34A8EDEB3D8B0C6B");

                entity.ToTable("tbl_before_footer");

                entity.Property(e => e.BeforeFooterName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CrtdOn).HasColumnType("datetime");

                entity.Property(e => e.Image).IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.UpdtOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblCategory>(entity =>
            {
                entity.HasKey(e => e.CategoryId)
                    .HasName("PK__tbl_cate__19093A0B3461C4E0");

                entity.ToTable("tbl_category");

                entity.Property(e => e.CategoryName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CrtdOn).HasColumnType("datetime");

                entity.Property(e => e.ImageUrl)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.UpdtOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblError>(entity =>
            {
                entity.HasKey(e => e.ErrorId)
                    .HasName("PK__tbl_erro__35856A2AF08A2981");

                entity.ToTable("tbl_error");

                entity.Property(e => e.CrtdOn).HasColumnType("datetime");

                entity.Property(e => e.ErrorLine).HasColumnName("ERROR_LINE");

                entity.Property(e => e.ErrorMessage)
                    .IsUnicode(false)
                    .HasColumnName("ERROR_MESSAGE");

                entity.Property(e => e.ErrorNumber).HasColumnName("ERROR_NUMBER");

                entity.Property(e => e.ErrorProcedure)
                    .IsUnicode(false)
                    .HasColumnName("ERROR_PROCEDURE");

                entity.Property(e => e.ErrorSeverity).HasColumnName("ERROR_SEVERITY");

                entity.Property(e => e.ErrorState).HasColumnName("ERROR_STATE");
            });

            modelBuilder.Entity<TblFooter>(entity =>
            {
                entity.HasKey(e => e.FooterId)
                    .HasName("PK__tbl_foot__83834798BD787EA8");

                entity.ToTable("tbl_footer");

                entity.Property(e => e.CrtdOn).HasColumnType("datetime");

                entity.Property(e => e.FooterName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.UpdtOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblFooterHeading>(entity =>
            {
                entity.HasKey(e => e.FooterHeadingId)
                    .HasName("PK__tbl_foot__4F1743B6F172BF26");

                entity.ToTable("tbl_footer_heading");

                entity.Property(e => e.CrtdOn).HasColumnType("datetime");

                entity.Property(e => e.FooterHeadingName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.UpdtOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblHeader>(entity =>
            {
                entity.HasKey(e => e.HeaderId)
                    .HasName("PK__tbl_head__DC3E692321011CF1");

                entity.ToTable("tbl_header");

                entity.Property(e => e.CrtdOn).HasColumnType("datetime");

                entity.Property(e => e.HeaderName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ImageUrl).HasColumnType("datetime");

                entity.Property(e => e.Logo)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("logo");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.UpdtOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblOrder>(entity =>
            {
                entity.HasKey(e => e.OrderId)
                    .HasName("PK__tbl_orde__C3905BCF422EFF37");

                entity.ToTable("tbl_orders");

                entity.Property(e => e.CrtdOn).HasColumnType("datetime");

                entity.Property(e => e.OrderNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OrderStatus)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OrderTotal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.UpdtOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblOrderItem>(entity =>
            {
                entity.HasKey(e => e.OrderItemId)
                    .HasName("PK__tbl_orde__57ED0681310F3164");

                entity.ToTable("tbl_order_item");

                entity.Property(e => e.CrtdOn).HasColumnType("datetime");

                entity.Property(e => e.Discunt).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TotalPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UpdtOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblPrice>(entity =>
            {
                entity.HasKey(e => e.PriceId)
                    .HasName("PK__tbl_pric__49575BAF8776E42B");

                entity.ToTable("tbl_price");

                entity.Property(e => e.CrtdOn).HasColumnType("datetime");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PriceDesc)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.UpdtOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblProduct>(entity =>
            {
                entity.HasKey(e => e.ProductId)
                    .HasName("PK__tbl_prod__B40CC6CDFF2DA49A");

                entity.ToTable("tbl_product");

                entity.Property(e => e.CrtdOn).HasColumnType("datetime");

                entity.Property(e => e.ImageUrl)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProductName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.UpdtOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblSlider>(entity =>
            {
                entity.HasKey(e => e.SliderId)
                    .HasName("PK__tbl_slid__24BC96F0D9D09530");

                entity.ToTable("tbl_slider");

                entity.Property(e => e.CrtdOn).HasColumnType("datetime");

                entity.Property(e => e.ImageUrl)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SliderDesc)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SliderName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.UpdtOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblSubCategory>(entity =>
            {
                entity.HasKey(e => e.SubCategoryId)
                    .HasName("PK__tbl_sub___26BE5B19544405A4");

                entity.ToTable("tbl_sub_category");

                entity.Property(e => e.CrtdOn).HasColumnType("datetime");

                entity.Property(e => e.ImageUrl)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SubCategoryName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdtOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblUser>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__tbl_user__1788CC4CB04136B0");

                entity.ToTable("tbl_users");

                entity.HasIndex(e => e.LastName, "UQ__tbl_user__7449F39903EFA308")
                    .IsUnique();

                entity.HasIndex(e => e.Email, "UQ__tbl_user__A9D1053479D47F74")
                    .IsUnique();

                entity.Property(e => e.CrtdOn).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Password).IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.UpdtOn).HasColumnType("datetime");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
