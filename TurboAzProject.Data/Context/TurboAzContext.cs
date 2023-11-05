using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using Microsoft.EntityFrameworkCore;
using TurboAzProject.Model.Models;
using Image = TurboAzProject.Model.Models.Image;

namespace TurboAzProject.Data.Context
{
    public partial class TurboAzContext : DbContext
    {
        public TurboAzContext()
        {
        }

        public TurboAzContext(DbContextOptions<TurboAzContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AcceleratingBox> AcceleratingBoxes { get; set; }

        public virtual DbSet<Car> Cars { get; set; }

        public virtual DbSet<City> Cities { get; set; }

        public virtual DbSet<Model.Models.Color> Colors { get; set; }

        public virtual DbSet<Engine> Engines { get; set; }

        public virtual DbSet<FuelType> FuelTypes { get; set; }

        public virtual DbSet<Image> Images { get; set; }

        public virtual DbSet<March> Marches { get; set; }

        public virtual DbSet<Marka> Markas { get; set; }

        public virtual DbSet<TurboAzProject.Model.Models.Model> Models { get; set; }

        public virtual DbSet<Price> Prices { get; set; }

        public virtual DbSet<RegistrationPlate> RegistrationPlates { get; set; }

        public virtual DbSet<Transmitter> Transmitters { get; set; }

        public virtual DbSet<Year> Years { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseLazyLoadingProxies().UseSqlServer("Data Source=STHQ0123-02;Initial Catalog=TurboAz;User ID=admin;Password=admin;Connect Timeout=30;Encrypt=False;");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AcceleratingBox>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK__Accelera__3214EC072486D608");

                entity.ToTable("AcceleratingBox");

                entity.Property(e => e.AcceleratingBox1).HasColumnName("AcceleratingBox");
            });

            modelBuilder.Entity<Car>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK__CAR__3214EC072D68D6B2");

                entity.ToTable("CAR");

                entity.HasOne(d => d.AcceleratingBox).WithMany(p => p.Cars)
                    .HasForeignKey(d => d.AcceleratingBoxId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CAR__Acceleratin__59FA5E80");

                entity.HasOne(d => d.City).WithMany(p => p.Cars)
                    .HasForeignKey(d => d.CityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CAR__CityId__534D60F1");

                entity.HasOne(d => d.Color).WithMany(p => p.Cars)
                    .HasForeignKey(d => d.ColorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CAR__ColorId__5629CD9C");

                entity.HasOne(d => d.Engine).WithMany(p => p.Cars)
                    .HasForeignKey(d => d.EngineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CAR__EngineId__571DF1D5");

                entity.HasOne(d => d.FuelType).WithMany(p => p.Cars)
                    .HasForeignKey(d => d.FuelTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CAR__FuelTypeId__5AEE82B9");

                entity.HasOne(d => d.Image).WithMany(p => p.Cars)
                    .HasForeignKey(d => d.ImageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CAR__ImageId__5BE2A6F2");

                entity.HasOne(d => d.March).WithMany(p => p.Cars)
                    .HasForeignKey(d => d.MarchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CAR__MarchId__5812160E");

                entity.HasOne(d => d.Marka).WithMany(p => p.Cars)
                    .HasForeignKey(d => d.MarkaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CAR__MarkaId__5165187F");

                entity.HasOne(d => d.Model).WithMany(p => p.Cars)
                    .HasForeignKey(d => d.ModelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CAR__ModelId__52593CB8");

                entity.HasOne(d => d.Price).WithMany(p => p.Cars)
                    .HasForeignKey(d => d.PriceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CAR__PriceId__5441852A");

                entity.HasOne(d => d.RegistrationPlate).WithMany(p => p.Cars)
                    .HasForeignKey(d => d.RegistrationPlateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CAR__Registratio__5CD6CB2B");

                entity.HasOne(d => d.Transmitter).WithMany(p => p.Cars)
                    .HasForeignKey(d => d.TransmitterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CAR__Transmitter__59063A47");

                entity.HasOne(d => d.Year).WithMany(p => p.Cars)
                    .HasForeignKey(d => d.YearId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CAR__YearId__5535A963");
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK__City__3214EC0710748F51");

                entity.ToTable("City");
            });

            modelBuilder.Entity<Model.Models.Color>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK__Color__3214EC074EA62513");

                entity.ToTable("Color");

                entity.Property(e => e.Color1).HasColumnName("Color");
            });

            modelBuilder.Entity<Engine>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK__Engine__3214EC0757B37018");

                entity.ToTable("Engine");

                entity.Property(e => e.Engine1).HasColumnName("Engine");
            });

            modelBuilder.Entity<FuelType>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK__FuelType__3214EC07B8895631");

                entity.ToTable("FuelType");

                entity.Property(e => e.FuelType1).HasColumnName("FuelType");
            });

            modelBuilder.Entity<Image>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK__Image__3214EC0774BD4352");

                entity.ToTable("Image");
            });

            modelBuilder.Entity<March>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK__March__3214EC07A3B52621");

                entity.ToTable("March");
            });

            modelBuilder.Entity<Marka>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK__Marka__3214EC07022184FE");

                entity.ToTable("Marka");
            });

            modelBuilder.Entity<TurboAzProject.Model.Models.Model>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK__MODEL__3214EC07680F1C1C");

                entity.ToTable("MODEL");

                entity.HasOne(d => d.Marka).WithMany(p => p.Models)
                    .HasForeignKey(d => d.MarkaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__MODEL__MarkaId__398D8EEE");
            });

            modelBuilder.Entity<Price>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK__Price__3214EC071C0C2538");

                entity.ToTable("Price");
            });

            modelBuilder.Entity<RegistrationPlate>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK__Registra__3214EC07DA155301");

                entity.ToTable("RegistrationPlate");

                entity.Property(e => e.RegistrationPlate1).HasColumnName("RegistrationPlate");
            });

            modelBuilder.Entity<Transmitter>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK__Transmit__3214EC076F426B5F");

                entity.ToTable("Transmitter");
            });

            modelBuilder.Entity<Year>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK__Year__3214EC0726AACB7E");
                entity.ToTable("Year");

                entity.Property(e => e.Year1)
                    .HasColumnType("datetime")
                    .HasColumnName("Year");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
