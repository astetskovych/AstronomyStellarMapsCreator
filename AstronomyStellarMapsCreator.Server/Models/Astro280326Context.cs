using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AstronomyStellarMapsCreator.Server.Models;

public partial class Astro280326Context : DbContext
{
    public Astro280326Context()
    {
    }

    public Astro280326Context(DbContextOptions<Astro280326Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Acknowledgement> Acknowledgements { get; set; }

    public virtual DbSet<Acronym> Acronyms { get; set; }

    public virtual DbSet<AdcKeyword> AdcKeywords { get; set; }

    public virtual DbSet<AditionalFile> AditionalFiles { get; set; }

    public virtual DbSet<Adsid> Adsids { get; set; }

    public virtual DbSet<Author> Authors { get; set; }

    public virtual DbSet<BibCode> BibCodes { get; set; }

    public virtual DbSet<CServer> CServers { get; set; }

    public virtual DbSet<Cat> Cats { get; set; }

    public virtual DbSet<CatCategory> CatCategories { get; set; }

    public virtual DbSet<CatFile> CatFiles { get; set; }

    public virtual DbSet<Catalogue> Catalogues { get; set; }

    public virtual DbSet<CatalogueField> CatalogueFields { get; set; }

    public virtual DbSet<CatalogueInsertionLog> CatalogueInsertionLogs { get; set; }

    public virtual DbSet<CatalogueReference> CatalogueReferences { get; set; }

    public virtual DbSet<CataloguesFile> CataloguesFiles { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<CatsAcronym> CatsAcronyms { get; set; }

    public virtual DbSet<CatsAllVersion> CatsAllVersions { get; set; }

    public virtual DbSet<CatsAuthor> CatsAuthors { get; set; }

    public virtual DbSet<CatsKeyword> CatsKeywords { get; set; }

    public virtual DbSet<CatsMedia> CatsMedias { get; set; }

    public virtual DbSet<CatsStatus> CatsStatuses { get; set; }

    public virtual DbSet<CatscServer> CatscServers { get; set; }

    public virtual DbSet<Content> Contents { get; set; }

    public virtual DbSet<Extention> Extentions { get; set; }

    public virtual DbSet<Footge> Footges { get; set; }

    public virtual DbSet<Format> Formats { get; set; }

    public virtual DbSet<History> Histories { get; set; }

    public virtual DbSet<I40CatalogDat> I40CatalogDats { get; set; }

    public virtual DbSet<I42CatalogDat> I42CatalogDats { get; set; }

    public virtual DbSet<Ii20aDataDat> Ii20aDataDats { get; set; }

    public virtual DbSet<Ii20aNotesDat> Ii20aNotesDats { get; set; }

    public virtual DbSet<Ii20aPositionDat> Ii20aPositionDats { get; set; }

    public virtual DbSet<Ii20aRemarksDat> Ii20aRemarksDats { get; set; }

    public virtual DbSet<Iii14NotesDat> Iii14NotesDats { get; set; }

    public virtual DbSet<Iii14Table1Dat> Iii14Table1Dats { get; set; }

    public virtual DbSet<Iii14Table2Dat> Iii14Table2Dats { get; set; }

    public virtual DbSet<Iv26CatalogDat> Iv26CatalogDats { get; set; }

    public virtual DbSet<Iv26Notes2Dat> Iv26Notes2Dats { get; set; }

    public virtual DbSet<Iv26NotesDat> Iv26NotesDats { get; set; }

    public virtual DbSet<Journal> Journals { get; set; }

    public virtual DbSet<JournalsAbbreviation> JournalsAbbreviations { get; set; }

    public virtual DbSet<Keyword> Keywords { get; set; }

    public virtual DbSet<Media> Medias { get; set; }

    public virtual DbSet<ObsoleteCatalogue> ObsoleteCatalogues { get; set; }

    public virtual DbSet<Orcid> Orcids { get; set; }

    public virtual DbSet<Prov> Provs { get; set; }

    public virtual DbSet<QProgram> QPrograms { get; set; }

    public virtual DbSet<ReadMe> ReadMes { get; set; }

    public virtual DbSet<Ref> Refs { get; set; }

    public virtual DbSet<Reference> References { get; set; }

    public virtual DbSet<Remark> Remarks { get; set; }

    public virtual DbSet<Source> Sources { get; set; }

    public virtual DbSet<Status> Statuses { get; set; }

    public virtual DbSet<UniqueIdetifier> UniqueIdetifiers { get; set; }

    public virtual DbSet<Unit> Units { get; set; }

    public virtual DbSet<V50Catalog> V50Catalogs { get; set; }

    public virtual DbSet<V50Note> V50Notes { get; set; }

    public virtual DbSet<Vii11DataDat> Vii11DataDats { get; set; }

    public virtual DbSet<Vii6DataDat> Vii6DataDats { get; set; }

    public virtual DbSet<Vii6DatazcorDat> Vii6DatazcorDats { get; set; }

    public virtual DbSet<Vii6DrivquanDat> Vii6DrivquanDats { get; set; }

    public virtual DbSet<Vii6DrivzcorDat> Vii6DrivzcorDats { get; set; }

    public virtual DbSet<Vii7aLdn> Vii7aLdns { get; set; }

    public virtual DbSet<Vii9CatalogDat> Vii9CatalogDats { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.;Database=Astro28_03_26;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Latin1_General_CS_AS");

        modelBuilder.Entity<Acknowledgement>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Acknowle__3214EC27C362D766");

            entity.ToTable("Acknowledgements", "Misc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Acknowledgements).IsUnicode(false);
            entity.Property(e => e.CatalogueId).HasColumnName("CatalogueID");

            entity.HasOne(d => d.Catalogue).WithMany(p => p.Acknowledgements)
                .HasForeignKey(d => d.CatalogueId)
                .HasConstraintName("FK_Acknowledgements_Catalogues");
        });

        modelBuilder.Entity<Acronym>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Acronyms__3214EC271435CC3C");

            entity.ToTable("Acronyms", "Misc");

            entity.HasIndex(e => e.Name, "UQ__Acronyms__737584F6E335A3F6").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<AdcKeyword>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ADC_Keyw__3214EC271A879AF7");

            entity.ToTable("ADC_Keywords", "Misc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CatalogueId).HasColumnName("CatalogueID");
            entity.Property(e => e.KeywordId).HasColumnName("KeywordID");

            entity.HasOne(d => d.Catalogue).WithMany(p => p.AdcKeywords)
                .HasForeignKey(d => d.CatalogueId)
                .HasConstraintName("FK_Catalogues_ADC_Keywords");

            entity.HasOne(d => d.Keyword).WithMany(p => p.AdcKeywords)
                .HasForeignKey(d => d.KeywordId)
                .HasConstraintName("FK_Keywords_ADC_Keywords");
        });

        modelBuilder.Entity<AditionalFile>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Aditiona__3214EC278A449DB1");

            entity.ToTable("AditionalFiles", "Misc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CatalogueId).HasColumnName("CatalogueID");
            entity.Property(e => e.ExtentionId).HasColumnName("ExtentionID");
            entity.Property(e => e.Name).HasMaxLength(100);

            entity.HasOne(d => d.Catalogue).WithMany(p => p.AditionalFiles)
                .HasForeignKey(d => d.CatalogueId)
                .HasConstraintName("FK_AditionalFiles_Catalogues");

            entity.HasOne(d => d.Extention).WithMany(p => p.AditionalFiles)
                .HasForeignKey(d => d.ExtentionId)
                .HasConstraintName("FK_AditionalFiles_Extentions");
        });

        modelBuilder.Entity<Adsid>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ADSids__3214EC2788CA5D08");

            entity.ToTable("ADSids", "Misc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Adsid1)
                .HasMaxLength(250)
                .HasColumnName("%ADSid");
            entity.Property(e => e.CatId).HasColumnName("CatID");

            entity.HasOne(d => d.Cat).WithMany(p => p.Adsids)
                .HasForeignKey(d => d.CatId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ADSids_Cats");
        });

        modelBuilder.Entity<Author>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Authors__3214EC27D093B1A1");

            entity.ToTable("Authors", "Misc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Name).HasMaxLength(250);
        });

        modelBuilder.Entity<BibCode>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BibCodes__3214EC27DECF62D6");

            entity.ToTable("BibCodes", "Misc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CatId).HasColumnName("CatID");
            entity.Property(e => e.Name).HasMaxLength(250);

            entity.HasOne(d => d.Cat).WithMany(p => p.BibCodes)
                .HasForeignKey(d => d.CatId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BibCodes_Cats");
        });

        modelBuilder.Entity<CServer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__cServers__3214EC27FB20B2ED");

            entity.ToTable("cServers", "Gen");

            entity.HasIndex(e => e.Name, "UQ__cServers__737584F6EBFEFFC2").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Name).HasMaxLength(10);
        });

        modelBuilder.Entity<Cat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Cats__3214EC27A7820A4E");

            entity.ToTable("Cats", "Misc");

            entity.HasIndex(e => e.UniqueIdetifierId, "IX_Cats_UniqueIdetifierID").IsUnique();

            entity.HasIndex(e => e.Name, "UQ__Cats__737584F6AF503FC7").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CatCategoryId).HasColumnName("CatCategoryID");
            entity.Property(e => e.Cite).HasMaxLength(250);
            entity.Property(e => e.Ignored)
                .HasMaxLength(100)
                .HasColumnName("ignored");
            entity.Property(e => e.Name).HasMaxLength(500);
            entity.Property(e => e.SizeKb).HasColumnName("Size(Kb)");
            entity.Property(e => e.UniqueIdetifierId).HasColumnName("UniqueIdetifierID");
            entity.Property(e => e.YCat).HasColumnName("yCat");

            entity.HasOne(d => d.CatCategory).WithMany(p => p.Cats)
                .HasForeignKey(d => d.CatCategoryId)
                .HasConstraintName("FK_Cats_CatsCategories");

            entity.HasOne(d => d.UniqueIdetifier).WithOne(p => p.Cat)
                .HasForeignKey<Cat>(d => d.UniqueIdetifierId)
                .HasConstraintName("FK_Cats_UniqueIdetifiers");
        });

        modelBuilder.Entity<CatCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CatCateg__3214EC27F0883897");

            entity.ToTable("CatCategories", "Gen");

            entity.HasIndex(e => e.Name, "UQ__CatCateg__737584F64A3585BA").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Description).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(3);
        });

        modelBuilder.Entity<CatFile>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CatFiles__3214EC2732E4787F");

            entity.ToTable("CatFiles", "Misc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CatId).HasColumnName("CatID");
            entity.Property(e => e.ExtentionId).HasColumnName("ExtentionID");
            entity.Property(e => e.Name).HasMaxLength(100);

            entity.HasOne(d => d.Cat).WithMany(p => p.CatFiles)
                .HasForeignKey(d => d.CatId)
                .HasConstraintName("FK_CatFiles_Cats");

            entity.HasOne(d => d.Extention).WithMany(p => p.CatFiles)
                .HasForeignKey(d => d.ExtentionId)
                .HasConstraintName("FK_CatFiles_Extentions");
        });

        modelBuilder.Entity<Catalogue>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Catalogu__3214EC2777DB27F1");

            entity.ToTable("Catalogues", "Misc");

            entity.HasIndex(e => e.Name, "UQ__Catalogu__737584F6EE028614").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Author).HasMaxLength(100);
            entity.Property(e => e.Name).HasMaxLength(500);
            entity.Property(e => e.UniqueIdetifierId).HasColumnName("UniqueIdetifierID");

            entity.HasOne(d => d.UniqueIdetifier).WithMany(p => p.Catalogues)
                .HasForeignKey(d => d.UniqueIdetifierId)
                .HasConstraintName("FK_Catalogues_UniqueIdetifiers");
        });

        modelBuilder.Entity<CatalogueField>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Catalogu__3214EC2726BC6FB8");

            entity.ToTable("CatalogueFields", "Misc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CatalogueFileId).HasColumnName("CatalogueFileID");
            entity.Property(e => e.CatalogueId).HasColumnName("CatalogueID");
            entity.Property(e => e.FormatId).HasColumnName("FormatID");
            entity.Property(e => e.Label).HasMaxLength(100);
            entity.Property(e => e.UnitId).HasColumnName("UnitID");

            entity.HasOne(d => d.CatalogueFile).WithMany(p => p.CatalogueFields)
                .HasForeignKey(d => d.CatalogueFileId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CatalogueFields_CataloguesFiles");

            entity.HasOne(d => d.Catalogue).WithMany(p => p.CatalogueFields)
                .HasForeignKey(d => d.CatalogueId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CatalogueFields_Catalogues");

            entity.HasOne(d => d.Format).WithMany(p => p.CatalogueFields)
                .HasForeignKey(d => d.FormatId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CatalogueFields_Formats");

            entity.HasOne(d => d.Unit).WithMany(p => p.CatalogueFields)
                .HasForeignKey(d => d.UnitId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CatalogueFields_Units");
        });

        modelBuilder.Entity<CatalogueInsertionLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Catalogu__3214EC271B00CED5");

            entity.ToTable("CatalogueInsertionLog", "Misc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CatalogueId).HasColumnName("CatalogueID");
            entity.Property(e => e.Date)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ProccessingTimeS).HasColumnName("ProccessingTime(s)");
            entity.Property(e => e.ResultOfInsertion).HasDefaultValue(false);

            entity.HasOne(d => d.Catalogue).WithMany(p => p.CatalogueInsertionLogs)
                .HasForeignKey(d => d.CatalogueId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CatalogueInsertionLog_Catalogues_CatID");
        });

        modelBuilder.Entity<CatalogueReference>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Catalogu__3214EC27ADB76DAC");

            entity.ToTable("CatalogueReferences", "Misc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.UniqueIdetifierMainId).HasColumnName("UniqueIdetifierMainID");
            entity.Property(e => e.UniqueIdetifierRefId).HasColumnName("UniqueIdetifierRefID");

            entity.HasOne(d => d.UniqueIdetifierMain).WithMany(p => p.CatalogueReferenceUniqueIdetifierMains)
                .HasForeignKey(d => d.UniqueIdetifierMainId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.UniqueIdetifierRef).WithMany(p => p.CatalogueReferenceUniqueIdetifierRefs).HasForeignKey(d => d.UniqueIdetifierRefId);
        });

        modelBuilder.Entity<CataloguesFile>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Catalogu__3214EC2725BC7C26");

            entity.ToTable("CataloguesFiles", "Misc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CatalogueId).HasColumnName("CatalogueID");
            entity.Property(e => e.ExtentionId).HasColumnName("ExtentionID");
            entity.Property(e => e.Name).HasMaxLength(100);

            entity.HasOne(d => d.Catalogue).WithMany(p => p.CataloguesFiles)
                .HasForeignKey(d => d.CatalogueId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CataloguesFiles_Catalogues");

            entity.HasOne(d => d.Extention).WithMany(p => p.CataloguesFiles)
                .HasForeignKey(d => d.ExtentionId)
                .HasConstraintName("FK_CataloguesFiles_Extentions");
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Categori__3214EC278451C5C9");

            entity.ToTable("Categories", "Gen");

            entity.HasIndex(e => e.Name, "UQ__Categori__737584F6E72357A9").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Description).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(4);
        });

        modelBuilder.Entity<CatsAcronym>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CatsAcro__3214EC2736B21AC6");

            entity.ToTable("CatsAcronyms", "Misc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AcronymId).HasColumnName("AcronymID");
            entity.Property(e => e.CatId).HasColumnName("CatID");

            entity.HasOne(d => d.Acronym).WithMany(p => p.CatsAcronyms)
                .HasForeignKey(d => d.AcronymId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CatsAcronyms_Acronyms");

            entity.HasOne(d => d.Cat).WithMany(p => p.CatsAcronyms)
                .HasForeignKey(d => d.CatId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CatsAcronyms_Cats");
        });

        modelBuilder.Entity<CatsAllVersion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CatsAllV__3214EC272F98730B");

            entity.ToTable("CatsAllVersions", "Misc");

            entity.Property(e => e.Id).HasColumnName("ID");
        });

        modelBuilder.Entity<CatsAuthor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CatsAuth__3214EC2719F0CF04");

            entity.ToTable("CatsAuthors", "Misc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AuthorId).HasColumnName("AuthorID");
            entity.Property(e => e.CatId).HasColumnName("CatID");

            entity.HasOne(d => d.Author).WithMany(p => p.CatsAuthors)
                .HasForeignKey(d => d.AuthorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CatsAuthors_Authors");

            entity.HasOne(d => d.Cat).WithMany(p => p.CatsAuthors)
                .HasForeignKey(d => d.CatId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CatsAuthors_Cats");
        });

        modelBuilder.Entity<CatsKeyword>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CatsKeyw__3214EC2759E12DB3");

            entity.ToTable("CatsKeywords", "Misc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CatId).HasColumnName("CatID");
            entity.Property(e => e.KeywordId).HasColumnName("KeywordID");

            entity.HasOne(d => d.Cat).WithMany(p => p.CatsKeywords)
                .HasForeignKey(d => d.CatId)
                .HasConstraintName("FK_CatsKeywords_Cats");

            entity.HasOne(d => d.Keyword).WithMany(p => p.CatsKeywords)
                .HasForeignKey(d => d.KeywordId)
                .HasConstraintName("FK_CatsKeywords_Keywords");
        });

        modelBuilder.Entity<CatsMedia>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CatsMedi__3214EC27B497367B");

            entity.ToTable("CatsMedias", "Misc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CatId).HasColumnName("CatID");
            entity.Property(e => e.MediaId).HasColumnName("MediaID");

            entity.HasOne(d => d.Cat).WithMany(p => p.CatsMedia)
                .HasForeignKey(d => d.CatId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CatsMedias_Cats");

            entity.HasOne(d => d.Media).WithMany(p => p.CatsMedia)
                .HasForeignKey(d => d.MediaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CatsMedias_Medias");
        });

        modelBuilder.Entity<CatsStatus>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CatsStat__3214EC27B6D68EE4");

            entity.ToTable("CatsStatuses", "Misc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CatId).HasColumnName("CatID");
            entity.Property(e => e.StatusId).HasColumnName("StatusID");

            entity.HasOne(d => d.Cat).WithMany(p => p.CatsStatuses)
                .HasForeignKey(d => d.CatId)
                .HasConstraintName("FK_CatsStatuses_Cats");

            entity.HasOne(d => d.Status).WithMany(p => p.CatsStatuses)
                .HasForeignKey(d => d.StatusId)
                .HasConstraintName("FK_CatsStatuses_Statuses");
        });

        modelBuilder.Entity<CatscServer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CatscSer__3214EC273E4C2726");

            entity.ToTable("CatscServers", "Misc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CServerId).HasColumnName("cServerID");
            entity.Property(e => e.CatId).HasColumnName("CatID");

            entity.HasOne(d => d.CServer).WithMany(p => p.CatscServers)
                .HasForeignKey(d => d.CServerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cServersCats_cServers");

            entity.HasOne(d => d.Cat).WithMany(p => p.CatscServers)
                .HasForeignKey(d => d.CatId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cServersCats_Cats");
        });

        modelBuilder.Entity<Content>(entity =>
        {
            entity.HasKey(e => e.ContentId).HasName("PK__Contents__2907A87E49E1833A");

            entity.ToTable("Contents", "Misc");

            entity.Property(e => e.ContentId).HasColumnName("ContentID");
            entity.Property(e => e.CatId).HasColumnName("CatID");
            entity.Property(e => e.Name).HasMaxLength(250);

            entity.HasOne(d => d.Cat).WithMany(p => p.Contents)
                .HasForeignKey(d => d.CatId)
                .HasConstraintName("FK_Contents_Cats");
        });

        modelBuilder.Entity<Extention>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Extentio__3214EC27BBB22748");

            entity.ToTable("Extentions", "Gen");

            entity.HasIndex(e => e.Name, "UQ__Extentio__737584F6DBDCA1A0").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Name).HasMaxLength(10);
        });

        modelBuilder.Entity<Footge>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Footges__3214EC27ECE31CE1");

            entity.ToTable("Footges", "Misc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CatalogueId).HasColumnName("CatalogueID");
            entity.Property(e => e.Footg5).HasColumnType("image");
            entity.Property(e => e.Footg8).HasColumnType("image");

            entity.HasOne(d => d.Catalogue).WithMany(p => p.Footges)
                .HasForeignKey(d => d.CatalogueId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Footges_Catalogues");
        });

        modelBuilder.Entity<Format>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Formats__3214EC279CC88A6E");

            entity.ToTable("Formats", "Gen");

            entity.HasIndex(e => e.Name, "UQ__Formats__737584F63FC69DB8").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Description).HasMaxLength(100);
            entity.Property(e => e.Name)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.SqlType)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<History>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__History__3214EC27F9F62AA9");

            entity.ToTable("History", "Misc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CatalogueId).HasColumnName("CatalogueID");
            entity.Property(e => e.HistoryRecord).IsUnicode(false);

            entity.HasOne(d => d.Catalogue).WithMany(p => p.Histories)
                .HasForeignKey(d => d.CatalogueId)
                .HasConstraintName("FK_History_Catalogues");
        });

        modelBuilder.Entity<I40CatalogDat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__I/40(cat__E7FC93549D1F19FD");

            entity.ToTable("I/40(catalog.dat)", "Cats");

            entity.Property(e => e.Id).HasColumnName("<ID>");
            entity.Property(e => e.De)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("DE-");
            entity.Property(e => e.DedDeg).HasColumnName("DEd(deg)");
            entity.Property(e => e.DemArcmin).HasColumnName("DEm(arcmin)");
            entity.Property(e => e.DesArcsec).HasColumnName("DEs(arcsec)");
            entity.Property(e => e.Dm)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("DM");
            entity.Property(e => e.EpDe1900001a).HasColumnName("EpDE-1900(0.01a)");
            entity.Property(e => e.EpRa1900001a).HasColumnName("EpRA-1900(0.01a)");
            entity.Property(e => e.NVmag)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("n_Vmag");
            entity.Property(e => e.Note)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.NumSp)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.ODes).HasColumnName("o_DEs");
            entity.Property(e => e.ORas).HasColumnName("o_RAs");
            entity.Property(e => e.ObsMagMag).HasColumnName("ObsMag(mag)");
            entity.Property(e => e.PmDeArcsecA).HasColumnName("pmDE(arcsec/a)");
            entity.Property(e => e.PmRaSA).HasColumnName("pmRA(s/a)");
            entity.Property(e => e.RahH).HasColumnName("RAh(h)");
            entity.Property(e => e.RamMin).HasColumnName("RAm(min)");
            entity.Property(e => e.RasS).HasColumnName("RAs(s)");
            entity.Property(e => e.Sp)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.VmagMag).HasColumnName("Vmag(mag)");
        });

        modelBuilder.Entity<I42CatalogDat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__I/42(cat__E7FC9354CFC724AE");

            entity.ToTable("I/42(catalog.dat)", "Cats");

            entity.Property(e => e.Id).HasColumnName("<ID>");
            entity.Property(e => e.Bd)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("BD");
            entity.Property(e => e.De)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("DE-");
            entity.Property(e => e.Decs10mas).HasColumnName("DEcs(10mas)");
            entity.Property(e => e.DedDeg).HasColumnName("DEd(deg)");
            entity.Property(e => e.DemArcmin).HasColumnName("DEm(arcmin)");
            entity.Property(e => e.EDecs10mas).HasColumnName("e_DEcs(10mas)");
            entity.Property(e => e.ERamsMs).HasColumnName("e_RAms(ms)");
            entity.Property(e => e.EpDe001yr).HasColumnName("EpDE(0.01yr)");
            entity.Property(e => e.EpRa001yr).HasColumnName("EpRA(0.01yr)");
            entity.Property(e => e.Fksz).HasColumnName("FKSZ");
            entity.Property(e => e.Gc).HasColumnName("GC");
            entity.Property(e => e.Note)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.Pfksz).HasColumnName("PFKSZ");
            entity.Property(e => e.PmDeMasYr).HasColumnName("pmDE(mas/yr)");
            entity.Property(e => e.PmRa01msYr).HasColumnName("pmRA(0.1ms/yr)");
            entity.Property(e => e.RahH).HasColumnName("RAh(h)");
            entity.Property(e => e.RamMin).HasColumnName("RAm(min)");
            entity.Property(e => e.RamsMs).HasColumnName("RAms(ms)");
            entity.Property(e => e.SpType)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Vmag01mag).HasColumnName("Vmag(0.1mag)");
        });

        modelBuilder.Entity<Ii20aDataDat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__II/20A(d__E7FC9354B6F85D16");

            entity.ToTable("II/20A(data.dat)", "Cats");

            entity.Property(e => e.Id).HasColumnName("<ID>");
            entity.Property(e => e.AVMag).HasColumnName("A(V)(mag)");
            entity.Property(e => e.BVMag).HasColumnName("B-V(mag)");
            entity.Property(e => e.Cpd)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("CPD");
            entity.Property(e => e.De)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("DE-");
            entity.Property(e => e.DedDeg).HasColumnName("DEd(deg)");
            entity.Property(e => e.DemArcmin).HasColumnName("DEm(arcmin)");
            entity.Property(e => e.EBVMag).HasColumnName("E(B-V)(mag)");
            entity.Property(e => e.Em)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("em");
            entity.Property(e => e.GlatDeg).HasColumnName("GLAT(deg)");
            entity.Property(e => e.GlonDeg).HasColumnName("GLON(deg)");
            entity.Property(e => e.Hd).HasColumnName("HD");
            entity.Property(e => e.MMMag).HasColumnName("m-M(mag)");
            entity.Property(e => e.MSeq).HasColumnName("m_Seq");
            entity.Property(e => e.NCpd)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("n_CPD");
            entity.Property(e => e.QMag).HasColumnName("Q(mag)");
            entity.Property(e => e.RPc).HasColumnName("R(pc)");
            entity.Property(e => e.RSp).HasColumnName("r_Sp");
            entity.Property(e => e.RahH).HasColumnName("RAh(h)");
            entity.Property(e => e.RamMin).HasColumnName("RAm(min)");
            entity.Property(e => e.Rem)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("rem");
            entity.Property(e => e.Sp)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Sp2)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.UBMag).HasColumnName("U-B(mag)");
            entity.Property(e => e.UBV)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("u_B-V");
            entity.Property(e => e.UUB)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("u_U-B");
            entity.Property(e => e.UVmag)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("u_Vmag");
            entity.Property(e => e.VmagMag).HasColumnName("Vmag(mag)");
            entity.Property(e => e.ZPc).HasColumnName("Z(pc)");
        });

        modelBuilder.Entity<Ii20aNotesDat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__II/20A(n__E7FC935477B31298");

            entity.ToTable("II/20A(notes.dat)", "Cats");

            entity.Property(e => e.Id).HasColumnName("<ID>");
            entity.Property(e => e.MSeq).HasColumnName("m_Seq");
            entity.Property(e => e.Text)
                .HasMaxLength(418)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Ii20aPositionDat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__II/20A(p__E7FC935492CFDE27");

            entity.ToTable("II/20A(position.dat)", "Cats");

            entity.Property(e => e.Id).HasColumnName("<ID>");
            entity.Property(e => e.De)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("DE-");
            entity.Property(e => e.DedDeg).HasColumnName("DEd(deg)");
            entity.Property(e => e.DemArcmin).HasColumnName("DEm(arcmin)");
            entity.Property(e => e.DesArcsec).HasColumnName("DEs(arcsec)");
            entity.Property(e => e.FSname)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("f_Sname");
            entity.Property(e => e.MSeq).HasColumnName("m_Seq");
            entity.Property(e => e.NA1)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("N/A1");
            entity.Property(e => e.Name2)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.RahH).HasColumnName("RAh(h)");
            entity.Property(e => e.RamMin).HasColumnName("RAm(min)");
            entity.Property(e => e.RasS).HasColumnName("RAs(s)");
            entity.Property(e => e.Sname)
                .HasMaxLength(34)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Ii20aRemarksDat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__II/20A(r__E7FC9354B0DA83F6");

            entity.ToTable("II/20A(remarks.dat)", "Cats");

            entity.Property(e => e.Id).HasColumnName("<ID>");
            entity.Property(e => e.MSeq).HasColumnName("m_Seq");
            entity.Property(e => e.Text)
                .HasMaxLength(418)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Iii14NotesDat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__III/14(n__E7FC93547D809D09");

            entity.ToTable("III/14(notes.dat)", "Cats");

            entity.Property(e => e.Id).HasColumnName("<ID>");
            entity.Property(e => e.Tbl)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Text)
                .HasMaxLength(508)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Iii14Table1Dat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__III/14(t__E7FC9354EAD3DF6C");

            entity.ToTable("III/14(table1.dat)", "Cats");

            entity.Property(e => e.Id).HasColumnName("<ID>");
            entity.Property(e => e.De)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("DE-");
            entity.Property(e => e.De50)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("DE50-");
            entity.Property(e => e.De50dDeg).HasColumnName("DE50d(deg)");
            entity.Property(e => e.De50mArcmin).HasColumnName("DE50m(arcmin)");
            entity.Property(e => e.DedDeg).HasColumnName("DEd(deg)");
            entity.Property(e => e.DemArcmin).HasColumnName("DEm(arcmin)");
            entity.Property(e => e.DesArcsec).HasColumnName("DEs(arcsec)");
            entity.Property(e => e.MSeq)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("m_Seq");
            entity.Property(e => e.NA1)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("N/A1");
            entity.Property(e => e.Note)
                .HasMaxLength(78)
                .IsUnicode(false);
            entity.Property(e => e.Oname)
                .HasMaxLength(22)
                .IsUnicode(false)
                .HasColumnName("OName");
            entity.Property(e => e.PmagMag).HasColumnName("Pmag(mag)");
            entity.Property(e => e.Ra50hH).HasColumnName("RA50h(h)");
            entity.Property(e => e.Ra50mMin).HasColumnName("RA50m(min)");
            entity.Property(e => e.RahH).HasColumnName("RAh(h)");
            entity.Property(e => e.RamMin).HasColumnName("RAm(min)");
            entity.Property(e => e.RasS).HasColumnName("RAs(s)");
            entity.Property(e => e.S)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("s");
            entity.Property(e => e.SpT)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Tbl)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.VmagMag).HasColumnName("Vmag(mag)");
        });

        modelBuilder.Entity<Iii14Table2Dat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__III/14(t__E7FC9354D3DA7C7B");

            entity.ToTable("III/14(table2.dat)", "Cats");

            entity.Property(e => e.Id).HasColumnName("<ID>");
            entity.Property(e => e.De)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("DE-");
            entity.Property(e => e.De50)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("DE50-");
            entity.Property(e => e.De50dDeg).HasColumnName("DE50d(deg)");
            entity.Property(e => e.De50mArcmin).HasColumnName("DE50m(arcmin)");
            entity.Property(e => e.DedDeg).HasColumnName("DEd(deg)");
            entity.Property(e => e.DemArcmin).HasColumnName("DEm(arcmin)");
            entity.Property(e => e.DesArcsec).HasColumnName("DEs(arcsec)");
            entity.Property(e => e.MSeq)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("m_Seq");
            entity.Property(e => e.NA1)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("N/A1");
            entity.Property(e => e.Note)
                .HasMaxLength(78)
                .IsUnicode(false);
            entity.Property(e => e.Oname)
                .HasMaxLength(22)
                .IsUnicode(false)
                .HasColumnName("OName");
            entity.Property(e => e.PmagMag).HasColumnName("Pmag(mag)");
            entity.Property(e => e.Ra50hH).HasColumnName("RA50h(h)");
            entity.Property(e => e.Ra50mMin).HasColumnName("RA50m(min)");
            entity.Property(e => e.RahH).HasColumnName("RAh(h)");
            entity.Property(e => e.RamMin).HasColumnName("RAm(min)");
            entity.Property(e => e.RasS).HasColumnName("RAs(s)");
            entity.Property(e => e.S)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("s");
            entity.Property(e => e.SpT)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Tbl)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.VmagMag).HasColumnName("Vmag(mag)");
        });

        modelBuilder.Entity<Iv26CatalogDat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__IV/26(ca__E7FC93543A133A05");

            entity.ToTable("IV/26(catalog.dat)", "Cats");

            entity.Property(e => e.Id).HasColumnName("<ID>");
            entity.Property(e => e.DDeArcsec).HasColumnName("dDE(arcsec)");
            entity.Property(e => e.DRaArcsec).HasColumnName("dRA(arcsec)");
            entity.Property(e => e.DXpos30mas).HasColumnName("dXpos(30mas)");
            entity.Property(e => e.DYpos30mas).HasColumnName("dYpos(30mas)");
            entity.Property(e => e.Dm).HasColumnName("dm");
            entity.Property(e => e.GrMag).HasColumnName("Gr(mag)");
            entity.Property(e => e.Ma).HasColumnName("ma");
            entity.Property(e => e.NA1)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("N/A1");
            entity.Property(e => e.NMa)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("n_ma");
            entity.Property(e => e.NS)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("n_S");
            entity.Property(e => e.NSeq)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("n_Seq");
            entity.Property(e => e.ODe)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("oDE-");
            entity.Property(e => e.ODemArcmin).HasColumnName("oDEm(arcmin)");
            entity.Property(e => e.ODesArcsec).HasColumnName("oDEs(arcsec)");
            entity.Property(e => e.ORa)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("oRA-");
            entity.Property(e => e.ORamArcmin).HasColumnName("oRAm(arcmin)");
            entity.Property(e => e.ORasArcsec).HasColumnName("oRAs(arcsec)");
            entity.Property(e => e.UDDe)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("u_dDE");
            entity.Property(e => e.UDRa)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("u_dRA");
            entity.Property(e => e.UDXpos)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("u_dXpos");
            entity.Property(e => e.UDYpos)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("u_dYpos");
            entity.Property(e => e.US)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("u_S");
        });

        modelBuilder.Entity<Iv26Notes2Dat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__IV/26(no__E7FC93541A04EC19");

            entity.ToTable("IV/26(notes2.dat)", "Cats");

            entity.Property(e => e.Id).HasColumnName("<ID>");
            entity.Property(e => e.Note)
                .HasMaxLength(132)
                .IsUnicode(false);
            entity.Property(e => e.US)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("u_S");
        });

        modelBuilder.Entity<Iv26NotesDat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__IV/26(no__E7FC93549D1EFEAC");

            entity.ToTable("IV/26(notes.dat)", "Cats");

            entity.Property(e => e.Id).HasColumnName("<ID>");
            entity.Property(e => e.Note)
                .HasMaxLength(150)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Journal>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Journals__3214EC27A9E9073B");

            entity.ToTable("Journals", "Misc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.FirstPagePrefix).HasMaxLength(1);
            entity.Property(e => e.JournalAbbrId).HasColumnName("JournalAbbrID");
            entity.Property(e => e.SpecialVolume).HasMaxLength(25);
            entity.Property(e => e.VolumeSuffix).HasMaxLength(1);

            entity.HasOne(d => d.JournalAbbr).WithMany(p => p.Journals)
                .HasForeignKey(d => d.JournalAbbrId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Journals_JournalsAbbreviations");
        });

        modelBuilder.Entity<JournalsAbbreviation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Journals__3214EC27E453779D");

            entity.ToTable("JournalsAbbreviations", "Gen");

            entity.HasIndex(e => e.Name, "UQ__Journals__737584F6E2DC8DDD").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Title).HasMaxLength(500);
        });

        modelBuilder.Entity<Keyword>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Keywords__3214EC27B50D88F3");

            entity.ToTable("Keywords", "Misc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Name).HasMaxLength(250);
        });

        modelBuilder.Entity<Media>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Medias__3214EC278874F1E2");

            entity.ToTable("Medias", "Misc");

            entity.HasIndex(e => e.Name, "UQ__Medias__737584F669FC221C").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<ObsoleteCatalogue>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Obsolete__3214EC27DF32366D");

            entity.ToTable("ObsoleteCatalogues", "Misc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.NewUniqueIdetifierId).HasColumnName("NewUniqueIdetifierID");
            entity.Property(e => e.UniqueIdetifierId).HasColumnName("UniqueIdetifierID");

            entity.HasOne(d => d.UniqueIdetifier).WithMany(p => p.ObsoleteCatalogues)
                .HasForeignKey(d => d.UniqueIdetifierId)
                .HasConstraintName("FK_ObsoleteCatalogues_UniqueIdetifiers_NewUniqueIdetifierID");
        });

        modelBuilder.Entity<Orcid>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ORCIDs__3214EC27C8F446B1");

            entity.ToTable("ORCIDs", "Misc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CatId).HasColumnName("CatID");
            entity.Property(e => e.Orcid1)
                .HasMaxLength(250)
                .HasColumnName("%ORCID");

            entity.HasOne(d => d.Cat).WithMany(p => p.Orcids)
                .HasForeignKey(d => d.CatId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ORCIDs_Cats");
        });

        modelBuilder.Entity<Prov>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Provs__3214EC27A22C9D31");

            entity.ToTable("Provs", "Misc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CatalogueId).HasColumnName("CatalogueID");
            entity.Property(e => e.ProvenanceJson).HasColumnName("ProvenanceJSON");
            entity.Property(e => e.ProvenancePng)
                .HasColumnType("image")
                .HasColumnName("provenancePNG");
            entity.Property(e => e.ProvenanceRdf).HasColumnName("provenanceRDF");
            entity.Property(e => e.ProvenanceTxt).HasColumnName("provenanceTXT");

            entity.HasOne(d => d.Catalogue).WithMany(p => p.Provs)
                .HasForeignKey(d => d.CatalogueId)
                .HasConstraintName("FK_Provs_CataloguesProvs");
        });

        modelBuilder.Entity<QProgram>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__qProgram__3214EC27FFA193C7");

            entity.ToTable("qPrograms", "Misc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CatId).HasColumnName("CatID");
            entity.Property(e => e.Name).HasMaxLength(250);

            entity.HasOne(d => d.Cat).WithMany(p => p.QPrograms)
                .HasForeignKey(d => d.CatId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_qProgram_Cats");
        });

        modelBuilder.Entity<ReadMe>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ReadMes__3214EC27494D1E0D");

            entity.ToTable("ReadMes", "Misc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CatalogueId).HasColumnName("CatalogueID");
            entity.Property(e => e.ReadMeFile).HasColumnType("text");

            entity.HasOne(d => d.Catalogue).WithMany(p => p.ReadMes)
                .HasForeignKey(d => d.CatalogueId)
                .HasConstraintName("FK_ReadMes_Catalogues");
        });

        modelBuilder.Entity<Ref>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Refs__3214EC2709B70D45");

            entity.ToTable("Refs", "Misc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CatId).HasColumnName("CatID");

            entity.HasOne(d => d.Cat).WithMany(p => p.Refs)
                .HasForeignKey(d => d.CatId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Refs_Cats");
        });

        modelBuilder.Entity<Reference>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Referenc__3214EC27BBF2A358");

            entity.ToTable("References", "Misc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CatalogueId).HasColumnName("CatalogueID");
            entity.Property(e => e.Reference1)
                .IsUnicode(false)
                .HasColumnName("Reference");

            entity.HasOne(d => d.Catalogue).WithMany(p => p.References)
                .HasForeignKey(d => d.CatalogueId)
                .HasConstraintName("FK_References_Catalogues");
        });

        modelBuilder.Entity<Remark>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Remarks__3214EC272BDC4C0C");

            entity.ToTable("Remarks", "Misc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CatId).HasColumnName("CatID");

            entity.HasOne(d => d.Cat).WithMany(p => p.Remarks)
                .HasForeignKey(d => d.CatId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Remark_Cats");
        });

        modelBuilder.Entity<Source>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Sources__3214EC2735040856");

            entity.ToTable("Sources", "Misc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CatId).HasColumnName("CatID");
            entity.Property(e => e.Name).HasMaxLength(250);

            entity.HasOne(d => d.Cat).WithMany(p => p.Sources)
                .HasForeignKey(d => d.CatId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Sources_Cats");
        });

        modelBuilder.Entity<Status>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Statuses__3214EC275987250C");

            entity.ToTable("Statuses", "Gen");

            entity.HasIndex(e => e.Name, "UQ__Statuses__737584F639914DB4").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.Name)
                .HasMaxLength(1)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UniqueIdetifier>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__UniqueId__3214EC270B1939CC");

            entity.ToTable("UniqueIdetifiers", "Misc");

            entity.HasIndex(e => e.CategoryId, "IX_UniqueIdetifiers_CategoryID");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Abbreviation).HasMaxLength(50);
            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.JournalId).HasColumnName("JournalID");
            entity.Property(e => e.SubNo).HasMaxLength(2);

            entity.HasOne(d => d.Category).WithMany(p => p.UniqueIdetifiers)
                .HasForeignKey(d => d.CategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UniqueIdetifiers_Categories");

            entity.HasOne(d => d.Journal).WithMany(p => p.UniqueIdetifiers)
                .HasForeignKey(d => d.JournalId)
                .HasConstraintName("FK_UniqueIdetifiers_Journals");
        });

        modelBuilder.Entity<Unit>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Units__3214EC2713D39737");

            entity.ToTable("Units", "Gen");

            entity.HasIndex(e => e.Name, "UQ__Units__737584F65C44BAEC").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CiUnit)
                .HasMaxLength(100)
                .HasColumnName("CI_Unit");
            entity.Property(e => e.Description).HasMaxLength(100);
            entity.Property(e => e.Dim).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<V50Catalog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__V/50(cat__E7FC93549CC913E6");

            entity.ToTable("V/50(catalog)", "Cats");

            entity.Property(e => e.Id).HasColumnName("<ID>");
            entity.Property(e => e.Ads)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("ADS");
            entity.Property(e => e.Adscomp)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("ADScomp");
            entity.Property(e => e.BVMag).HasColumnName("B-V(mag)");
            entity.Property(e => e.De)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("DE-");
            entity.Property(e => e.De1900)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("DE-1900");
            entity.Property(e => e.Ded1900Deg).HasColumnName("DEd1900(deg)");
            entity.Property(e => e.DedDeg).HasColumnName("DEd(deg)");
            entity.Property(e => e.Dem1900Arcmin).HasColumnName("DEm1900(arcmin)");
            entity.Property(e => e.DemArcmin).HasColumnName("DEm(arcmin)");
            entity.Property(e => e.Des1900Arcsec).HasColumnName("DEs1900(arcsec)");
            entity.Property(e => e.DesArcsec).HasColumnName("DEs(arcsec)");
            entity.Property(e => e.Dm)
                .HasMaxLength(22)
                .IsUnicode(false)
                .HasColumnName("DM");
            entity.Property(e => e.DmagMag).HasColumnName("Dmag(mag)");
            entity.Property(e => e.Fk5).HasColumnName("FK5");
            entity.Property(e => e.GlatDeg).HasColumnName("GLAT(deg)");
            entity.Property(e => e.GlonDeg).HasColumnName("GLON(deg)");
            entity.Property(e => e.Hd).HasColumnName("HD");
            entity.Property(e => e.Hr).HasColumnName("HR");
            entity.Property(e => e.Irflag)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("IRflag");
            entity.Property(e => e.LRotVel)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("l_RotVel");
            entity.Property(e => e.MultId)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("MultID");
            entity.Property(e => e.Multiple)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.NParallax)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("n_Parallax");
            entity.Property(e => e.NRI)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("n_R-I");
            entity.Property(e => e.NRadVel)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("n_RadVel");
            entity.Property(e => e.NSpType)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("n_SpType");
            entity.Property(e => e.NVmag)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("n_Vmag");
            entity.Property(e => e.Name)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.NoteFlag)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.ParallaxArcsec).HasColumnName("Parallax(arcsec)");
            entity.Property(e => e.PmDeArcsecYr).HasColumnName("pmDE(arcsec/yr)");
            entity.Property(e => e.PmRaArcsecYr).HasColumnName("pmRA(arcsec/yr)");
            entity.Property(e => e.RIMag).HasColumnName("R-I(mag)");
            entity.Property(e => e.RIrflag)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("r_IRflag");
            entity.Property(e => e.RadVelKmS).HasColumnName("RadVel(km/s)");
            entity.Property(e => e.Rah1900H).HasColumnName("RAh1900(h)");
            entity.Property(e => e.RahH).HasColumnName("RAh(h)");
            entity.Property(e => e.Ram1900Min).HasColumnName("RAm1900(min)");
            entity.Property(e => e.RamMin).HasColumnName("RAm(min)");
            entity.Property(e => e.Ras1900S).HasColumnName("RAs1900(s)");
            entity.Property(e => e.RasS).HasColumnName("RAs(s)");
            entity.Property(e => e.RotVelKmS).HasColumnName("RotVel(km/s)");
            entity.Property(e => e.Sao).HasColumnName("SAO");
            entity.Property(e => e.SepArcsec).HasColumnName("Sep(arcsec)");
            entity.Property(e => e.SpType)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.UBMag).HasColumnName("U-B(mag)");
            entity.Property(e => e.UBV)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("u_B-V");
            entity.Property(e => e.URotVel)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("u_RotVel");
            entity.Property(e => e.UUB)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("u_U-B");
            entity.Property(e => e.UVmag)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("u_Vmag");
            entity.Property(e => e.VarId)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("VarID");
            entity.Property(e => e.VmagMag).HasColumnName("Vmag(mag)");
        });

        modelBuilder.Entity<V50Note>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__V/50(not__E7FC9354874AC599");

            entity.ToTable("V/50(notes)", "Cats");

            entity.Property(e => e.Id).HasColumnName("<ID>");
            entity.Property(e => e.Category)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Hr).HasColumnName("HR");
            entity.Property(e => e.Remark)
                .HasMaxLength(240)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Vii11DataDat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__VII/11(d__E7FC9354DC5FB7A3");

            entity.ToTable("VII/11(data.dat)", "Cats");

            entity.Property(e => e.Id).HasColumnName("<ID>");
            entity.Property(e => e.DedegDeg).HasColumnName("DEdeg(deg)");
            entity.Property(e => e.Name)
                .HasMaxLength(24)
                .IsUnicode(false);
            entity.Property(e => e.RadegDeg).HasColumnName("RAdeg(deg)");
        });

        modelBuilder.Entity<Vii6DataDat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__VII/6(da__E7FC9354FEC1E2B6");

            entity.ToTable("VII/6(data.dat)", "Cats");

            entity.Property(e => e.Id).HasColumnName("<ID>");
            entity.Property(e => e.AngDiamArcsec).HasColumnName("AngDiam(arcsec)");
            entity.Property(e => e.Class)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.De)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("DE-");
            entity.Property(e => e.DedDeg).HasColumnName("DEd(deg)");
            entity.Property(e => e.Lp11cm).HasColumnName("LP(11cm)(%)");
            entity.Property(e => e.Lp18cm).HasColumnName("LP(18cm)(%)");
            entity.Property(e => e.Lp21cm).HasColumnName("LP(21cm)(%)");
            entity.Property(e => e.Lp2cm).HasColumnName("LP(2cm)(%)");
            entity.Property(e => e.Lp31cm).HasColumnName("LP(31cm)(%)");
            entity.Property(e => e.Lp37cm).HasColumnName("LP(3.7cm)(%)");
            entity.Property(e => e.Lp49cm).HasColumnName("LP(49cm)(%)");
            entity.Property(e => e.Lp6cm).HasColumnName("LP(6cm)(%)");
            entity.Property(e => e.Lp73cm).HasColumnName("LP(73cm)(%)");
            entity.Property(e => e.PaDeg).HasColumnName("PA(deg)");
            entity.Property(e => e.PolA11cmDeg).HasColumnName("PolA(11cm)(deg)");
            entity.Property(e => e.PolA18cmDeg).HasColumnName("PolA(18cm)(deg)");
            entity.Property(e => e.PolA21cmDeg).HasColumnName("PolA(21cm)(deg)");
            entity.Property(e => e.PolA2cmDeg).HasColumnName("PolA(2cm)(deg)");
            entity.Property(e => e.PolA31cmDeg).HasColumnName("PolA(31cm)(deg)");
            entity.Property(e => e.PolA37cmDeg).HasColumnName("PolA(3.7cm)(deg)");
            entity.Property(e => e.PolA49cmDeg).HasColumnName("PolA(49cm)(deg)");
            entity.Property(e => e.PolA6cmDeg).HasColumnName("PolA(6cm)(deg)");
            entity.Property(e => e.PolA73cmDeg).HasColumnName("PolA(73cm)(deg)");
            entity.Property(e => e.RahH).HasColumnName("RAh(h)");
            entity.Property(e => e.RamMin).HasColumnName("RAm(min)");
            entity.Property(e => e.S11cmJy).HasColumnName("S(11cm)(Jy)");
            entity.Property(e => e.S18cmJy).HasColumnName("S(18cm)(Jy)");
            entity.Property(e => e.S21cmJy).HasColumnName("S(21cm)(Jy)");
            entity.Property(e => e.S2cmJy).HasColumnName("S(2cm)(Jy)");
            entity.Property(e => e.S31cmJy).HasColumnName("S(31cm)(Jy)");
            entity.Property(e => e.S37cmJy).HasColumnName("S(3.7cm)(Jy)");
            entity.Property(e => e.S49cmJy).HasColumnName("S(49cm)(Jy)");
            entity.Property(e => e.S6cmJy).HasColumnName("S(6cm)(Jy)");
            entity.Property(e => e.S73cmJy).HasColumnName("S(73cm)(Jy)");
            entity.Property(e => e.Z).HasColumnName("z");
            entity.Property(e => e._3cr).HasColumnName("3CR");
        });

        modelBuilder.Entity<Vii6DatazcorDat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__VII/6(da__E7FC9354BA9648F8");

            entity.ToTable("VII/6(datazcor.dat)", "Cats");

            entity.Property(e => e.Id).HasColumnName("<ID>");
            entity.Property(e => e.Class)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.De)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("DE-");
            entity.Property(e => e.DedDeg).HasColumnName("DEd(deg)");
            entity.Property(e => e.Lp11cm).HasColumnName("LP(11cm)(%)");
            entity.Property(e => e.Lp18cm).HasColumnName("LP(18cm)(%)");
            entity.Property(e => e.Lp21cm).HasColumnName("LP(21cm)(%)");
            entity.Property(e => e.Lp2cm).HasColumnName("LP(2cm)(%)");
            entity.Property(e => e.Lp31cm).HasColumnName("LP(31cm)(%)");
            entity.Property(e => e.Lp37cm).HasColumnName("LP(3.7cm)(%)");
            entity.Property(e => e.Lp49cm).HasColumnName("LP(49cm)(%)");
            entity.Property(e => e.Lp6cm).HasColumnName("LP(6cm)(%)");
            entity.Property(e => e.Lp73cm).HasColumnName("LP(73cm)(%)");
            entity.Property(e => e.PolA11cmDeg).HasColumnName("PolA(11cm)(deg)");
            entity.Property(e => e.PolA18cmDeg).HasColumnName("PolA(18cm)(deg)");
            entity.Property(e => e.PolA21cmDeg).HasColumnName("PolA(21cm)(deg)");
            entity.Property(e => e.PolA2cmDeg).HasColumnName("PolA(2cm)(deg)");
            entity.Property(e => e.PolA31cmDeg).HasColumnName("PolA(31cm)(deg)");
            entity.Property(e => e.PolA37cmDeg).HasColumnName("PolA(3.7cm)(deg)");
            entity.Property(e => e.PolA49cmDeg).HasColumnName("PolA(49cm)(deg)");
            entity.Property(e => e.PolA6cmDeg).HasColumnName("PolA(6cm)(deg)");
            entity.Property(e => e.PolA73cmDeg).HasColumnName("PolA(73cm)(deg)");
            entity.Property(e => e.RahH).HasColumnName("RAh(h)");
            entity.Property(e => e.RamMin).HasColumnName("RAm(min)");
            entity.Property(e => e.S11cmJy).HasColumnName("S(11cm)(Jy)");
            entity.Property(e => e.S18cmJy).HasColumnName("S(18cm)(Jy)");
            entity.Property(e => e.S21cmJy).HasColumnName("S(21cm)(Jy)");
            entity.Property(e => e.S2cmJy).HasColumnName("S(2cm)(Jy)");
            entity.Property(e => e.S31cmJy).HasColumnName("S(31cm)(Jy)");
            entity.Property(e => e.S37cmJy).HasColumnName("S(3.7cm)(Jy)");
            entity.Property(e => e.S49cmJy).HasColumnName("S(49cm)(Jy)");
            entity.Property(e => e.S6cmJy).HasColumnName("S(6cm)(Jy)");
            entity.Property(e => e.S73cmJy).HasColumnName("S(73cm)(Jy)");
            entity.Property(e => e._3cr).HasColumnName("3CR");
        });

        modelBuilder.Entity<Vii6DrivquanDat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__VII/6(dr__E7FC93542E8C1DF4");

            entity.ToTable("VII/6(drivquan.dat)", "Cats");

            entity.Property(e => e.Id).HasColumnName("<ID>");
            entity.Property(e => e.Class)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.De)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("DE-");
            entity.Property(e => e.DedDeg).HasColumnName("DEd(deg)");
            entity.Property(e => e.PaPolADeg).HasColumnName("PA-PolA(deg)");
            entity.Property(e => e.Pi).HasColumnName("PI");
            entity.Property(e => e.Pi11).HasColumnName("PI(11)");
            entity.Property(e => e.Pi18).HasColumnName("PI(18)");
            entity.Property(e => e.Pi2).HasColumnName("PI(2)");
            entity.Property(e => e.Pi21).HasColumnName("PI(21)");
            entity.Property(e => e.Pi31).HasColumnName("PI(31)");
            entity.Property(e => e.Pi37).HasColumnName("PI(3.7)");
            entity.Property(e => e.Pi49).HasColumnName("PI(49)");
            entity.Property(e => e.Pi6).HasColumnName("PI(6)");
            entity.Property(e => e.PolADeg).HasColumnName("PolA(deg)");
            entity.Property(e => e.RahH).HasColumnName("RAh(h)");
            entity.Property(e => e.RamMin).HasColumnName("RAm(min)");
            entity.Property(e => e.RmRadM2).HasColumnName("RM(rad/m2)");
            entity.Property(e => e.Si).HasColumnName("SI");
            entity.Property(e => e.Si11).HasColumnName("SI(11)");
            entity.Property(e => e.Si18).HasColumnName("SI(18)");
            entity.Property(e => e.Si2).HasColumnName("SI(2)");
            entity.Property(e => e.Si21).HasColumnName("SI(21)");
            entity.Property(e => e.Si31).HasColumnName("SI(31)");
            entity.Property(e => e.Si37).HasColumnName("SI(3.7)");
            entity.Property(e => e.Si49).HasColumnName("SI(49)");
            entity.Property(e => e.Si6).HasColumnName("SI(6)");
            entity.Property(e => e._3cr).HasColumnName("3CR");
        });

        modelBuilder.Entity<Vii6DrivzcorDat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__VII/6(dr__E7FC93540549348F");

            entity.ToTable("VII/6(drivzcor.dat)", "Cats");

            entity.Property(e => e.Id).HasColumnName("<ID>");
            entity.Property(e => e.Class)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.De)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("DE-");
            entity.Property(e => e.DedDeg).HasColumnName("DEd(deg)");
            entity.Property(e => e.DiamMpc).HasColumnName("Diam(Mpc)");
            entity.Property(e => e.PaPolADeg).HasColumnName("PA-PolA(deg)");
            entity.Property(e => e.Pi).HasColumnName("PI");
            entity.Property(e => e.Pi11).HasColumnName("PI(11)");
            entity.Property(e => e.Pi18).HasColumnName("PI(18)");
            entity.Property(e => e.Pi2).HasColumnName("PI(2)");
            entity.Property(e => e.Pi21).HasColumnName("PI(21)");
            entity.Property(e => e.Pi31).HasColumnName("PI(31)");
            entity.Property(e => e.Pi37).HasColumnName("PI(3.7)");
            entity.Property(e => e.Pi49).HasColumnName("PI(49)");
            entity.Property(e => e.Pi6).HasColumnName("PI(6)");
            entity.Property(e => e.PolADeg).HasColumnName("PolA(deg)");
            entity.Property(e => e.RahH).HasColumnName("RAh(h)");
            entity.Property(e => e.RamMin).HasColumnName("RAm(min)");
            entity.Property(e => e.RmRadM2).HasColumnName("RM(rad/m2)");
            entity.Property(e => e.Si).HasColumnName("SI");
            entity.Property(e => e.Si11).HasColumnName("SI(11)");
            entity.Property(e => e.Si18).HasColumnName("SI(18)");
            entity.Property(e => e.Si2).HasColumnName("SI(2)");
            entity.Property(e => e.Si21).HasColumnName("SI(21)");
            entity.Property(e => e.Si31).HasColumnName("SI(31)");
            entity.Property(e => e.Si37).HasColumnName("SI(3.7)");
            entity.Property(e => e.Si49).HasColumnName("SI(49)");
            entity.Property(e => e.Si6).HasColumnName("SI(6)");
            entity.Property(e => e._3cr).HasColumnName("3CR");
        });

        modelBuilder.Entity<Vii7aLdn>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__VII/7A(l__E7FC9354CE6A1CE5");

            entity.ToTable("VII/7A(ldn)", "Cats");

            entity.Property(e => e.Id).HasColumnName("<ID>");
            entity.Property(e => e.AreaDeg2).HasColumnName("Area(deg2)");
            entity.Property(e => e.Barn)
                .HasMaxLength(64)
                .IsUnicode(false);
            entity.Property(e => e.De)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("DE-");
            entity.Property(e => e.DedDeg).HasColumnName("DEd(deg)");
            entity.Property(e => e.DemArcmin).HasColumnName("DEm(arcmin)");
            entity.Property(e => e.GlatDeg).HasColumnName("GLAT(deg)");
            entity.Property(e => e.GlonDeg).HasColumnName("GLON(deg)");
            entity.Property(e => e.Id1).HasColumnName("ID");
            entity.Property(e => e.Ldn).HasColumnName("LDN");
            entity.Property(e => e.RahH).HasColumnName("RAh(h)");
            entity.Property(e => e.RamMin).HasColumnName("RAm(min)");
        });

        modelBuilder.Entity<Vii9CatalogDat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__VII/9(ca__E7FC93546A639C7B");

            entity.ToTable("VII/9(catalog.dat)", "Cats");

            entity.Property(e => e.Id).HasColumnName("<ID>");
            entity.Property(e => e.AreaDeg2).HasColumnName("Area(deg2)");
            entity.Property(e => e.De)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("DE-");
            entity.Property(e => e.DedDeg).HasColumnName("DEd(deg)");
            entity.Property(e => e.DemArcmin).HasColumnName("DEm(arcmin)");
            entity.Property(e => e.Diam1Arcmin).HasColumnName("Diam1(arcmin)");
            entity.Property(e => e.Diam2Arcmin).HasColumnName("Diam2(arcmin)");
            entity.Property(e => e.GlatDeg).HasColumnName("GLAT(deg)");
            entity.Property(e => e.GlonDeg).HasColumnName("GLON(deg)");
            entity.Property(e => e.Id1).HasColumnName("ID");
            entity.Property(e => e.Name)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.RahH).HasColumnName("RAh(h)");
            entity.Property(e => e.RamMin).HasColumnName("RAm(min)");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
