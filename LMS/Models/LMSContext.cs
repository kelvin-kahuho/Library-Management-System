using Microsoft.EntityFrameworkCore;
using LMS.Models;

namespace LMS.Models{
    public class LMSContext:DbContext
    {
        public LMSContext(DbContextOptions<LMSContext> options):base(options){

        }

        public DbSet<Users> Users{ get; set;}
        public DbSet<Books> Books{get; set;}
        public DbSet<Transactions> Transactions{get;set;}
        public DbSet<UserBookHistory> UserBookHistory{get;set;}
        public DbSet<Payments> Payments{get;set;}
        public DbSet<RatingReview> RatingReview{get;set;}

    }
}