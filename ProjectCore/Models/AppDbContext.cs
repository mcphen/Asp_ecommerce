using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectCore.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Book> Books { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }

        protected override void OnModelCreating(ModelBuilder model)
        {
            base.OnModelCreating(model);
            model.Entity<Category>().HasData(
              new Category { CategoryId = 1, CategoryName = "Big Data", Description = "cours sur le big data" }
                );
            model.Entity<Category>().HasData(
              new Category { CategoryId = 2, CategoryName = "Database", Description = "cours sur les bases de données" }
                );
            model.Entity<Category>().HasData(
              new Category { CategoryId = 3, CategoryName = "Front-End", Description = "cours sur le front-end" }
                );
            model.Entity<Category>().HasData(
              new Category { CategoryId = 4, CategoryName = "Back-End", Description = "cours sur le back-end" }
                );



            model.Entity<Book>().HasData(
              new Book
              {
                  BookId = 1,
                  Name = "Big Data For Dummies",
                  LongDescription = "Big data management is one of the major challenges facing business, industry, and not-for-profit organizations. Data sets such as customer transactions for a mega-retailer, weather patterns monitored by meteorologists, or social network activity can quickly outpace the capacity of traditional data management tools. If you need to develop or manage big data solutions, you’ll appreciate how these four experts define, explain, and guide you through this new and often confusing concept. You’ll learn what it is, why it matters, and how to choose and implement solutions that work.",
                  ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/51p6wBow%2B3L._SX389_BO1,204,203,200_.jpg",
                  InStock = true,
                  ShortDescription = "Big data management is one of the major challenges facing business, industry, and not-for-profit organizations",
                  Price = 98,
                  CategoryId = 1
                  
              }
                );

            model.Entity<Book>().HasData(
             new Book
             {
                 BookId = 2,
                 Name = "Big Data",
                 LongDescription = "Bernard Marr’s Data Strategy is a must-have guide to creating a robust data strategy. Explaining how to identify your strategic data needs, what methods to use to collect the data and, most importantly, how to translate your data into organizational insights for improved business decision-making and performance, this is essential reading for anyone aiming to leverage the value of their business data and gain competitive advantage. Packed with case studies and real-world examples, advice on how to build data competencies in an organization and crucial coverage of how to ensure your data doesn’t become a liability, Data Strategy will equip any organization with the tools and strategies it needs to profit from big data, analytics and the Internet of Things.",
                 ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/41JjodHnKHL._SX331_BO1,204,203,200_.jpg",
                 InStock = true,
                 ShortDescription = "Bernard Marr’s Data Strategy is a must-have guide to creating a robust data strategy",
                 Price = 120.90M,
                 CategoryId = 1,
                 
             
             }
               );

            model.Entity<Book>().HasData(
            new Book
            {
                BookId = 4,
                Name = "Data-Intensive",
                LongDescription = "Data is at the center of many challenges in system design today. Difficult issues need to be figured out, such as scalability, consistency, reliability, efficiency, and maintainability. In addition, we have an overwhelming variety of tools, including relational databases, NoSQL datastores, stream or batch processors, and message brokers. What are the right choices for your application? How do you make sense of all these buzzwords?.",
                ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/51gP9mXEqWL._SX379_BO1,204,203,200_.jpg",
                InStock = true,
                ShortDescription = "The Big Ideas Behind Reliable, Scalable, and Maintainable Systems ",
                Price = 66,
                CategoryId = 2,
                
            }
              );
        }
    }
}
