using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AP3_MEDIA.Entities;

public partial class MediatoutContext : DbContext
{
    public MediatoutContext()
    {
    }

    public MediatoutContext(DbContextOptions<MediatoutContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Categorie> Categories { get; set; }

    public virtual DbSet<Emprunter> Emprunters { get; set; }

    public virtual DbSet<Emprunteur> Emprunteurs { get; set; }

    public virtual DbSet<Etat> Etats { get; set; }

    public virtual DbSet<Exemplaire> Exemplaires { get; set; }

    public virtual DbSet<Ressource> Ressources { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=192.168.10.15;port=3306;user=mediatout-2;password=8Ny4tskS;database=mediatout", Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.9.8-mariadb"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("latin1_swedish_ci")
            .HasCharSet("latin1");

        modelBuilder.Entity<Categorie>(entity =>
        {
            entity.HasKey(e => e.Idcategorie).HasName("PRIMARY");

            entity.ToTable("categorie");

            entity.Property(e => e.Idcategorie)
                .HasColumnType("int(11)")
                .HasColumnName("idcategorie");
            entity.Property(e => e.Libellecategorie)
                .HasMaxLength(128)
                .HasColumnName("libellecategorie");
        });

        modelBuilder.Entity<Emprunter>(entity =>
        {
            entity.HasKey(e => new { e.Idemprunteur, e.Idressource, e.Idexemplaire, e.Datedebutemprunt })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });

            entity.ToTable("emprunter");

            entity.HasIndex(e => e.Idemprunteur, "i_fk_emprunter_emprunteur1");

            entity.HasIndex(e => new { e.Idressource, e.Idexemplaire }, "i_fk_emprunter_exemplaire1");

            entity.Property(e => e.Idemprunteur)
                .HasColumnType("int(11)")
                .HasColumnName("idemprunteur");
            entity.Property(e => e.Idressource)
                .HasColumnType("int(11)")
                .HasColumnName("idressource");
            entity.Property(e => e.Idexemplaire)
                .HasColumnType("int(11)")
                .HasColumnName("idexemplaire");
            entity.Property(e => e.Datedebutemprunt)
                .HasColumnType("datetime")
                .HasColumnName("datedebutemprunt");
            entity.Property(e => e.Dateretour)
                .HasColumnType("datetime")
                .HasColumnName("dateretour");
            entity.Property(e => e.Dureeemprunt)
                .HasColumnType("int(11)")
                .HasColumnName("dureeemprunt");

            entity.HasOne(d => d.IdemprunteurNavigation).WithMany(p => p.Emprunters)
                .HasForeignKey(d => d.Idemprunteur)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_emprunter_emprunteur");

            entity.HasOne(d => d.Id).WithMany(p => p.Emprunters)
                .HasForeignKey(d => new { d.Idressource, d.Idexemplaire })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_emprunter_exemplaire");
        });

        modelBuilder.Entity<Emprunteur>(entity =>
        {
            entity.HasKey(e => e.Idemprunteur).HasName("PRIMARY");

            entity.ToTable("emprunteur");

            entity.HasIndex(e => e.Emailemprunteur, "emailemprunteur").IsUnique();

            entity.Property(e => e.Idemprunteur)
                .HasColumnType("int(11)")
                .HasColumnName("idemprunteur");
            entity.Property(e => e.Datenaissance).HasColumnName("datenaissance");
            entity.Property(e => e.Emailemprunteur).HasColumnName("emailemprunteur");
            entity.Property(e => e.Motpasseemprunteur)
                .HasMaxLength(128)
                .HasColumnName("motpasseemprunteur");
            entity.Property(e => e.Nomemprunteur)
                .HasMaxLength(128)
                .HasColumnName("nomemprunteur");
            entity.Property(e => e.Prenomemprunteur)
                .HasMaxLength(128)
                .HasColumnName("prenomemprunteur");
            entity.Property(e => e.Telportable)
                .HasMaxLength(128)
                .HasColumnName("telportable");
            entity.Property(e => e.Validationcompte)
                .HasColumnType("int(11)")
                .HasColumnName("validationcompte");
        });

        modelBuilder.Entity<Etat>(entity =>
        {
            entity.HasKey(e => e.Idetat).HasName("PRIMARY");

            entity.ToTable("etat");

            entity.Property(e => e.Idetat)
                .HasColumnType("int(11)")
                .HasColumnName("idetat");
            entity.Property(e => e.Libelleetat)
                .HasMaxLength(128)
                .HasColumnName("libelleetat");
        });

        modelBuilder.Entity<Exemplaire>(entity =>
        {
            entity.HasKey(e => new { e.Idressource, e.Idexemplaire })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("exemplaire");

            entity.HasIndex(e => e.Idetat, "i_fk_exemplaire_etat1");

            entity.HasIndex(e => e.Idressource, "i_fk_exemplaire_ressource1");

            entity.Property(e => e.Idressource)
                .HasColumnType("int(11)")
                .HasColumnName("idressource");
            entity.Property(e => e.Idexemplaire)
                .HasColumnType("int(11)")
                .HasColumnName("idexemplaire");
            entity.Property(e => e.Dateentree).HasColumnName("dateentree");
            entity.Property(e => e.Idetat)
                .HasColumnType("int(11)")
                .HasColumnName("idetat");

            entity.HasOne(d => d.IdetatNavigation).WithMany(p => p.Exemplaires)
                .HasForeignKey(d => d.Idetat)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_exemplaire_etat");

            entity.HasOne(d => d.IdressourceNavigation).WithMany(p => p.Exemplaires)
                .HasForeignKey(d => d.Idressource)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_exemplaire_ressource");
        });

        modelBuilder.Entity<Ressource>(entity =>
        {
            entity.HasKey(e => e.Idressource).HasName("PRIMARY");

            entity.ToTable("ressource");

            entity.HasIndex(e => e.Idcategorie, "i_fk_ressource_categorie1");

            entity.Property(e => e.Idressource)
                .HasColumnType("int(11)")
                .HasColumnName("idressource");
            entity.Property(e => e.Anneesortie)
                .HasColumnType("int(11)")
                .HasColumnName("anneesortie");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasColumnName("description");
            entity.Property(e => e.Idcategorie)
                .HasColumnType("int(11)")
                .HasColumnName("idcategorie");
            entity.Property(e => e.Image)
                .HasMaxLength(255)
                .HasColumnName("image");
            entity.Property(e => e.Isbn)
                .HasMaxLength(128)
                .HasColumnName("isbn");
            entity.Property(e => e.Langue)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("langue");
            entity.Property(e => e.Titre)
                .HasMaxLength(128)
                .HasColumnName("titre");

            entity.HasOne(d => d.IdcategorieNavigation).WithMany(p => p.Ressources)
                .HasForeignKey(d => d.Idcategorie)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ressource_categorie");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
