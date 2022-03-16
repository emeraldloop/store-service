using store_service.Models;
using Microsoft.EntityFrameworkCore;

namespace store_service;

public class StoreServiceContext:DbContext
{
    public virtual DbSet<Category> Category { get; set; } = null!;
    public virtual DbSet<Person> Person { get; set; } = null!;
    public virtual DbSet<PersonOrder> Person_Order { get; set; } = null!;
    public virtual DbSet<Producer> Producer { get; set; } = null!;
    public virtual DbSet<Product> Product { get; set; } = null!;
    public virtual DbSet<Shop> Shop { get; set; } = null!;
    public virtual DbSet<Storage> Storage { get; set; } = null!;
    public virtual DbSet<Role> Role { get; set; } = null!;

    public StoreServiceContext(DbContextOptions<StoreServiceContext> options)
        : base(options)
    {
       // Database.EnsureCreated();   // создаем базу данных при первом обращении
    }
    
    
    
    
    /*
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            string connection = Configuration.GetConnectionString("DefaultConnection");
            optionsBuilder.UseSqlServer("Server=LAPTOP-HSG27GVC;database=clothes_store;Trusted_Connection=True;");
        }
    }
    //jdbc:sqlserver://127.0.0.1\MSSQLSERVER:1433;instance=MSSQLSERVER;database=clothes_store
    */

    
    
}