﻿using System.ComponentModel.DataAnnotations;

namespace Reddit.Models
{
    public class Community
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Post> Posts { get; set; } = new List<Post>();
        public virtual IList<User> Users { get; set; }
    }
}