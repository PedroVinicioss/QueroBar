using Microsoft.EntityFrameworkCore;
using QueroBar.Models.Entities;
using System.Numerics;
using System;

namespace QueroBar.Models.Data

{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
            this.Database.EnsureCreated();
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartProduct> CartProducts { get; set; }
        public DbSet<Events> Events { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Pictures> Pictures { get; set; }
        public DbSet<Pub> Pubs { get; set; }
        public DbSet<PurchaseFinalize> PurchaseFinalizes { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Memberships> Memberships { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}
