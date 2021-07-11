using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace eOrdinacija_API.Database
{
    public partial class eOrdinacijaContext : DbContext
    {
        public eOrdinacijaContext()
        {
        }

        public eOrdinacijaContext(DbContextOptions<eOrdinacijaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Klijent> Klijent { get; set; }
        public virtual DbSet<Lijek> Lijek { get; set; }
        public virtual DbSet<Nabavka> Nabavka { get; set; }
        public virtual DbSet<NabavkaMaterijal> NabavkaMaterijal { get; set; }
        public virtual DbSet<Ocjena> Ocjena { get; set; }
        public virtual DbSet<Pregled> Pregled { get; set; }
        public virtual DbSet<Recept> Recept { get; set; }
        public virtual DbSet<Rezervacija> Rezervacija { get; set; }
        public virtual DbSet<StomatoloskiMaterijal> StomatoloskiMaterijal { get; set; }
        public virtual DbSet<Uloga> Uloga { get; set; }
        public virtual DbSet<Usluga> Usluga { get; set; }
        public virtual DbSet<UslugaMaterijal> UslugaMaterijal { get; set; }
        public virtual DbSet<Zaposlenik> Zaposlenik { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.;Database=eOrdinacija;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Klijent>(entity =>
            {
                entity.Property(e => e.DatumRodjenja).HasColumnType("datetime");

                entity.Property(e => e.Ime).IsRequired();

                entity.Property(e => e.PasswordHash).IsRequired();

                entity.Property(e => e.PasswordSalt).IsRequired();

                entity.Property(e => e.Prezime).IsRequired();

                entity.Property(e => e.Username).IsRequired();
            });

            modelBuilder.Entity<Lijek>(entity =>
            {
                entity.Property(e => e.Naziv).IsRequired();
            });

            modelBuilder.Entity<Nabavka>(entity =>
            {
                entity.Property(e => e.DatumNabavke).HasColumnType("datetime");

                entity.HasOne(d => d.Zaposlenik)
                    .WithMany(p => p.Nabavka)
                    .HasForeignKey(d => d.ZaposlenikId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Nabavka_Zaposlenik");
            });

            modelBuilder.Entity<NabavkaMaterijal>(entity =>
            {
                entity.HasOne(d => d.Materijal)
                    .WithMany(p => p.NabavkaMaterijal)
                    .HasForeignKey(d => d.MaterijalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NabavkaMaterijal_StomatoloskiMaterijal");

                entity.HasOne(d => d.Nabavka)
                    .WithMany(p => p.NabavkaMaterijal)
                    .HasForeignKey(d => d.NabavkaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NabavkaMaterijal_Nabavka");
            });

            modelBuilder.Entity<Ocjena>(entity =>
            {
                entity.Property(e => e.Ocjena1).HasColumnName("Ocjena");

                entity.HasOne(d => d.Klijent)
                    .WithMany(p => p.Ocjena)
                    .HasForeignKey(d => d.KlijentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ocjena_Klijent");

                entity.HasOne(d => d.Usluga)
                    .WithMany(p => p.Ocjena)
                    .HasForeignKey(d => d.UslugaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ocjena_Usluga");
            });

            modelBuilder.Entity<Pregled>(entity =>
            {
                entity.Property(e => e.DatumPregleda).HasColumnType("datetime");

                entity.Property(e => e.VrijemePregleda).IsRequired();

                entity.HasOne(d => d.Klijent)
                    .WithMany(p => p.Pregled)
                    .HasForeignKey(d => d.KlijentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Pregled_Klijent");

                entity.HasOne(d => d.Recept)
                    .WithMany(p => p.Pregled)
                    .HasForeignKey(d => d.ReceptId)
                    .HasConstraintName("FK_Pregled_Recept");

                entity.HasOne(d => d.Usluga)
                    .WithMany(p => p.Pregled)
                    .HasForeignKey(d => d.UslugaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Pregled_Usluga");

                entity.HasOne(d => d.Zaposlenik)
                    .WithMany(p => p.Pregled)
                    .HasForeignKey(d => d.ZaposlenikId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Pregled_Zaposlenik");
            });

            modelBuilder.Entity<Recept>(entity =>
            {
                entity.HasOne(d => d.Klijent)
                    .WithMany(p => p.Recept)
                    .HasForeignKey(d => d.KlijentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Recept_Klijent");

                entity.HasOne(d => d.Lijek)
                    .WithMany(p => p.Recept)
                    .HasForeignKey(d => d.LijekId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Recept_Lijek");

                entity.HasOne(d => d.Zaposlenik)
                    .WithMany(p => p.Recept)
                    .HasForeignKey(d => d.ZaposlenikId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Recept_Zaposlenik");
            });

            modelBuilder.Entity<Rezervacija>(entity =>
            {
                entity.Property(e => e.Datum).HasColumnType("datetime");

                entity.Property(e => e.Vrijeme).IsRequired();

                entity.HasOne(d => d.Klijent)
                    .WithMany(p => p.Rezervacija)
                    .HasForeignKey(d => d.KlijentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Rezervacija_Klijent");

                entity.HasOne(d => d.Usluga)
                    .WithMany(p => p.Rezervacija)
                    .HasForeignKey(d => d.UslugaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Rezervacija_Usluga");
            });

            modelBuilder.Entity<StomatoloskiMaterijal>(entity =>
            {
                entity.Property(e => e.Naziv).IsRequired();

                entity.Property(e => e.StanjeUskladistu).HasColumnName("StanjeUSkladistu");
            });

            modelBuilder.Entity<Uloga>(entity =>
            {
                entity.Property(e => e.Naziv).IsRequired();
            });

            modelBuilder.Entity<Usluga>(entity =>
            {
                entity.Property(e => e.Naziv).IsRequired();
            });

            modelBuilder.Entity<UslugaMaterijal>(entity =>
            {
                entity.HasOne(d => d.Materijal)
                    .WithMany(p => p.UslugaMaterijal)
                    .HasForeignKey(d => d.MaterijalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UslugaMaterijal_StomatoloskiMaterijal");

                entity.HasOne(d => d.Usluga)
                    .WithMany(p => p.UslugaMaterijal)
                    .HasForeignKey(d => d.UslugaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UslugaMaterijal_Usluga");
            });

            modelBuilder.Entity<Zaposlenik>(entity =>
            {
                entity.Property(e => e.DatumRodjenja).HasColumnType("datetime");

                entity.Property(e => e.DatumZaposlenja).HasColumnType("datetime");

                entity.Property(e => e.Ime).IsRequired();

                entity.Property(e => e.IsAdministrator).HasColumnName("isAdministrator");

                entity.Property(e => e.PasswordHash).IsRequired();

                entity.Property(e => e.PasswordSalt).IsRequired();

                entity.Property(e => e.Prezime).IsRequired();

                entity.Property(e => e.Username).IsRequired();

                entity.HasOne(d => d.Uloga)
                    .WithMany(p => p.Zaposlenik)
                    .HasForeignKey(d => d.UlogaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Zaposlenik_Uloga");
            });
        }
    }
}
