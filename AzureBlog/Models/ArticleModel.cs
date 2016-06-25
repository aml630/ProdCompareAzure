using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Text.RegularExpressions;

namespace AzureBlog.Models
{
    [Table("Articles")]

    public class ArticleModel
    {

        [Key]
        public int ArticleId { get; set; }
        public string ArticleName { get; set; }
        public string ArticleSlug { get; set; }
        public string ArticlePic { get; set; }
        public bool ArticlePublished { get; set; }
        public string Intro { get; set; }
        public int FbShares { get; set; }
        public int TwitShares { get; set; }

        public virtual ICollection<ArticleSegmentModel> ArticleSegments { get; set; }


    }

}

