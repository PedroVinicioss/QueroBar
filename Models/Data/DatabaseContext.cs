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

        //Inserção de dados no Banco (Icones, Categorias e Gêneros)
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Icon>().HasData(
                new Icon
                {
                    Id = 1,
                    Name = "+18",
                    Image = "images/icones/+18.png"
                }, new Icon
                {
                    Id = 2,
                    Name = "Banheiro",
                    Image = "images/icones/banheiro.png"
                }, new Icon
                {
                    Id = 3,
                    Name = "Comida",
                    Image = "images/icones/comida.png"
                }, new Icon
                {
                    Id = 4,
                    Name = "Data",
                    Image = "images/icones/data.png"
                }, new Icon
                {
                    Id = 5,
                    Name = "Estacionamento",
                    Image = "images/icones/estacionamento.png"
                }, new Icon
                {
                    Id = 6,
                    Name = "Lotação",
                    Image = "images/icones/lotacao.png"
                }, new Icon
                {
                    Id = 7,
                    Name = "Musical",
                    Image = "images/icones/musical.png"
                }, new Icon
                {
                    Id = 8,
                    Name = "Palco",
                    Image = "images/icones/palco.png"
                }, new Icon
                {
                    Id = 9,
                    Name = "Preço",
                    Image = "images/icones/preco.png"
                }, new Icon
                {
                    Id = 10,
                    Name = "Vip",
                    Image = "images/icones/vip.png"
                });

            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Axé",
                    Image = "images/categories/axe.jpg"
                },
                new Category
                {
                    Id = 2,
                    Name = "Eletrônica",
                    Image = "images/categories/eletronica.png"
                },
                new Category
                {
                    Id = 3,
                    Name = "Forró",
                    Image = "images/categories/forro.png"
                },
                new Category
                {
                    Id = 4,
                    Name = "Funk",
                    Image = "images/categories/funk.jpg"
                },
                new Category
                {
                    Id = 5,
                    Name = "MPB",
                    Image = "images/categories/mpb.jpg"
                },
                new Category
                {
                    Id = 6,
                    Name = "Pagode",
                    Image = "images/categories/pagode.jpg"
                },
                new Category
                {
                    Id = 7,
                    Name = "Rap",
                    Image = "images/categories/rap.png"
                },
                new Category
                {
                    Id = 8,
                    Name = "Rock",
                    Image = "images/categories/rock.jpg"
                },
                new Category
                {
                    Id = 9,
                    Name = "Samba",
                    Image = "images/categories/samba.png"
                },
                new Category
                {
                    Id = 10,
                    Name = "Sertanejo",
                    Image = "images/categories/sertanejo.png"
                });

            modelBuilder.Entity<Genre>().HasData(
                new Genre
                {
                    Id = 1,
                    Name = "Musical"
                },
                new Genre
                {
                    Id = 2,
                    Name = "Stand Up"
                },
                new Genre
                {
                    Id = 3,
                    Name = "Diversos"
                });
        }
    }
}
