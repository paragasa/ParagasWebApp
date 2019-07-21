using DatingApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options){

        }

        public DbSet<Value> Values {get;set;}
        // public DbSet<User> Users { get; set; }

        // public DbSet<Photo> Photos { get; set; }

        // public DbSet<Like> Likes { get; set; }
        // public DbSet<Message>  Messages { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

           
            //Relationship between Liker and Likee relationship, FK
            // builder.Entity<Like>()
            //     .HasKey(k => new {k.LikerId, k.LikeeId});

            // //1 Likee has many Likers
            // builder.Entity<Like>()
            //     .HasOne(u => u.Likee)
            //     .WithMany(u => u.Likers)
            //     .HasForeignKey(u => u.LikeeId)
            //     .OnDelete(DeleteBehavior.Restrict);

            // //1 Liker can like many likees
            // builder.Entity<Like>()
            //     .HasOne(u => u.Liker)
            //     .WithMany(u => u.Likees)
            //     .HasForeignKey(u => u.LikerId)
            //     .OnDelete(DeleteBehavior.Restrict);

            // builder.Entity<Message>()
            //     .HasOne(u => u.Sender)
            //     .WithMany(m => m.MessagesSent)
            //     .OnDelete(DeleteBehavior.Restrict);

            // builder.Entity<Message>()
            //     .HasOne(u => u.Recipient)
            //     .WithMany(m => m.MessagesReceived)
            //     .OnDelete(DeleteBehavior.Restrict);

            // builder.Entity<Photo>().HasQueryFilter(p => p.IsApproved);
        }

    }

   
}