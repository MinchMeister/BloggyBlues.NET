using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;


namespace BloggyBlues.Models
{
    public class Post
    {

        public int ID { get; set; }


        [StringLength(60, MinimumLength = 1)]
        public string Title { get; set; }


        public string Author { get; set; }
        

        public string Content { get; set; }


        public DateTime PublishedDate { get; set; }
    }

    public class PostDBContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }
    }
}