using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DowntimeAlert.Data.Models
{
    public partial class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public virtual DbSet<EmailValid> EmailValid { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<TargetApps> TargetApps { get; set; }
        public virtual DbSet<AppResponseInfos> ResponseInfos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmailValid>(entity =>
            {
                entity.Property(e => e.ActivationKey)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Time).HasColumnType("datetime");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(124);

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TargetApps>(entity =>
            {
                entity.Property(e => e.UserId)
                    .IsRequired();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.MonitoringInterval)
                    .IsRequired();

                entity.Property(e => e.IsActive)
                    .HasDefaultValue(true);

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<AppResponseInfos>(entity =>
            {
                entity.Property(e => e.TargetAppId)
                    .IsRequired();

                entity.Property(e => e.ResponseStatusCode)
                    .IsRequired();

                entity.Property(e => e.ResponseTime)
                    .IsRequired();

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");
            });
        }
    }
}
