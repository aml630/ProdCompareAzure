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
    [Table("Categories")]

    public class CategoryModel
    {
      
            [Key]
            public int CategoryId { get; set; }
            public string CategoryName { get; set; }
            public string CategorySlug { get; set; }
            public string CategoryPic { get; set; }
            public bool CategoryArticle { get; set; }
            public string Intro { get; set; }
            public int FbShares { get; set; }
            public int TwitShares { get; set; }
            


        public virtual ICollection<SegmentModel> Segments { get; set; }

        public virtual ICollection<ProductModel> Products { get; set; }

    }

}
    
