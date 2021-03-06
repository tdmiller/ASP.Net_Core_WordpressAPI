﻿namespace WordPressAPI.Models
{
    public class PostTag
    {
        public string Name { get; set; }
        public string Slug { get; set; }
        public string Description { get; set; }
        public string[] Types { get; set; }
        public bool Hierarchical { get; set; }
        public string RestBase { get; set; }
        public Links Links { get; set; }
    }
}
