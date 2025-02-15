﻿using App.Data.Entities.Base;
using App.Data.Entities.User;

namespace App.Data.Entities.News
{
    public class AppNews : AppEntityBase
    {
        public string Title { get; set; }
        public string Slug { get; set; }
        public string? Summary { get; set; }
        public string? Content { get; set; }
        public long Views { get; set; }
        public float Votes { get; set; }
        public bool Published { get; set; }
        public DateTime? PublishedAt { get; set; }
        public string? CoverImgPath { get; set; }
        public string? CoverImgThumbnailPath { get; set; }
        public string? StampPath { get; set; }
        public int? CategoryId { get; set; }

        public AppUser Users { get; set; }
        public AppNewsCategory NewsCategory { get; set; }
    }
}