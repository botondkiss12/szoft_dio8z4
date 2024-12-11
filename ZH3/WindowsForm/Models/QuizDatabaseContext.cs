using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WindowsForm.Models;

public partial class QuizDatabaseContext : DbContext
{
    public QuizDatabaseContext()
    {
    }

    public QuizDatabaseContext(DbContextOptions<QuizDatabaseContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Riddle> Riddles { get; set; }

    public virtual DbSet<Score> Scores { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=kiss.database.windows.net;Initial Catalog=QuizDatabase;User ID=smallbotond;Password=Password123");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.CategoryId).HasName("PK__Categori__19093A2BFAD189EC");

            entity.HasIndex(e => e.CategoryName, "UQ_CategoryName").IsUnique();

            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.CategoryName).HasMaxLength(100);
        });

        modelBuilder.Entity<Riddle>(entity =>
        {
            entity.HasKey(e => e.RiddleId).HasName("PK__Riddles__117D469079A6C116");

            entity.Property(e => e.RiddleId).HasColumnName("RiddleID");
            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.CorrectAnswer).HasMaxLength(250);
            entity.Property(e => e.QuestionText).HasMaxLength(500);
            entity.Property(e => e.WrongAnswer1).HasMaxLength(250);
            entity.Property(e => e.WrongAnswer2).HasMaxLength(250);
            entity.Property(e => e.WrongAnswer3).HasMaxLength(250);

            entity.HasOne(d => d.Category).WithMany(p => p.Riddles)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("FK_Riddles_Categories");
        });

        modelBuilder.Entity<Score>(entity =>
        {
            entity.HasKey(e => e.ScoreId).HasName("PK__Scores__7DD229F137894A73");

            entity.Property(e => e.ScoreId).HasColumnName("ScoreID");
            entity.Property(e => e.PlayedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.UserName).HasMaxLength(100);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
