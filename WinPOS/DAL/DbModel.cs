using Microsoft.EntityFrameworkCore;

namespace WinPOS.DAL;

public class DbModel : DbContext
{
    private string userName = "sa";
    private string password = "@dmin123";
    private string serverName = @".\SqlExpress";
    private string databaseName = "Testing";

    // ------- DbSet
    public DbSet<Entity.Customer> Customers { get; set; }

    //-----------
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string conStr= $"Server={serverName};Database={databaseName};User Id={userName}; Password={password};" +
            $" TrustServerCertificate=True";

        optionsBuilder.UseSqlServer(conStr);            
    }

    // ---------
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Table name : Customer
        modelBuilder.Entity<Entity.Customer>(entity =>
        {
            entity.ToTable("Customer")
                    .HasKey(x => x.CustId).HasName("PK_Customer");
            entity.Property(e => e.CustId)
                    .HasColumnType("char(6");
            entity.Property(e => e.CustName)
                    .HasColumnType("nchar(100)");
            entity.Property(e => e.Address)
                    .HasColumnType("nchar(200)");
        });
        // --------

    }
}
