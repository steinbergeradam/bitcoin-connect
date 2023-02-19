using BitcoinConnect.Models;
using Microsoft.EntityFrameworkCore;

namespace BitcoinConnect.Contexts;

public partial class BitcoinConnectContext : DbContext
{
    public BitcoinConnectContext()
    {
    }

    public BitcoinConnectContext(DbContextOptions<BitcoinConnectContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Comment> Comments { get; set; }

    public virtual DbSet<Post> Posts { get; set; }
    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("/* DB CONNECTION STRING GOES HERE */");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Comment>(entity =>
        {
            entity.ToTable("Comment");

            entity.Property(e => e.CommentId).ValueGeneratedNever();
            entity.Property(e => e.Body).HasColumnType("text");
        });

        modelBuilder.Entity<Post>(entity =>
        {
            entity.ToTable("Post");

            entity.Property(e => e.PostId).ValueGeneratedNever();
            entity.Property(e => e.Body).HasColumnType("text");
            entity.Property(e => e.Title).HasMaxLength(100);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.ToTable("User");

            entity.Property(e => e.UserId).ValueGeneratedNever();
            entity.Property(e => e.EmailAddress)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PasswordHash)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PasswordSalt)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
