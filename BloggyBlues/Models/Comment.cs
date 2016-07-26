using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace BloggyBlues.Models
{
    public class Comment
    {
        public int ID { get; set; }


        [StringLength(60, MinimumLength = 1)]
        public string Title { get; set; }


        public string Author { get; set; }


        public string Content { get; set; }


        public DateTime PublishedDate { get; set; }
    }

    public class CommentDBContext : DbContext
    {
        public DbSet<Comment> Commments { get; set; }
    }
}