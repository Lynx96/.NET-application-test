using Microsoft.EntityFrameworkCore;
using ProductApi.models;



namespace ProductApi.Data;

    public class AppDbContext : DbContext {

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public AppDbContext(){
        
    }

    public DbSet<Client> Clients {get; set;}
    public DbSet<ProductItem> Products {get; set;}
    public DbSet<Order> Orders {get; set;}
    public DbSet<OrderItem> OrderItems {get; set;}
   

    protected override void OnModelCreating(ModelBuilder modelBuilder){
        base.OnModelCreating(modelBuilder);

        // Order - Client relationship
        modelBuilder.Entity<Order>().ToTable("Pedido")
            .HasOne(o => o.Client)
            .WithMany()
            .HasForeignKey(o => o.ClientId);

        modelBuilder.Entity<OrderItem>().ToTable("Item_Pedido")
            .HasOne(oi => oi.Order)
            .WithMany(o => o.OrderItems)
            .HasForeignKey(oi => oi.OrderId);

        modelBuilder.Entity<Client>().ToTable("Cliente");
        modelBuilder.Entity<ProductItem>().ToTable("Item_Produto");
        modelBuilder.Entity<Manufacturer>().ToTable("Fabricante");
        modelBuilder.Entity<Manufacturer>().ToTable("Fabricante");
    
    }

  
}
