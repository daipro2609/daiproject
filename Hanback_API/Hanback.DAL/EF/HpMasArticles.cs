using System;
using System.Collections.Generic;

namespace Hanback.DAL.EF
{
    public partial class HpMasArticles
    {
        public int ArticleId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Contents { get; set; }
        public DateTime PublishDate { get; set; }
        public bool UseYn { get; set; }
        public string Images { get; set; }
        public string MetaKeywords { get; set; }
        public string MetaDescription { get; set; }
        public string Tags { get; set; }
        public int? CommentCount { get; set; }
        public int? LikeCount { get; set; }
        public double? Rating { get; set; }
        public string Remarks { get; set; }
        public string Creator { get; set; }
        public DateTime? CreateTime { get; set; }
        public string Changer { get; set; }
        public DateTime? ChangeTime { get; set; }
    }
}
