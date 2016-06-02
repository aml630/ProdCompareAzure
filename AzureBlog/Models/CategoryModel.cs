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

            public string Sec1Title { get; set; }
            public string Sec1Body { get; set; }

            public string Sec2Title { get; set; }
            public string Sec2Body { get; set; }

            public string Sec3Title { get; set; }
            public string Sec3Body { get; set; }






        public virtual ICollection<SegmentModel> Segments { get; set; }

        public virtual ICollection<ProductModel> Products { get; set; }

        //public string GenerateSlug()
        //{
        //    string phrase = string.Format(CategoryName);

        //    string str = RemoveAccent(phrase).ToLower();
        //    // invalid chars           
        //    str = Regex.Replace(str, @"[^a-z0-9\s-]", "");
        //    // convert multiple spaces into one space   
        //    str = Regex.Replace(str, @"\s+", " ").Trim();
        //    // cut and trim 
        //    str = str.Substring(0, str.Length <= 45 ? str.Length : 45).Trim();
        //    str = Regex.Replace(str, @"\s", "-"); // hyphens   
        //    return str;
        //}

        //private string RemoveAccent(string text)
        //{
        //    byte[] bytes = System.Text.Encoding.GetEncoding("Cyrillic").GetBytes(text);
        //    return System.Text.Encoding.ASCII.GetString(bytes);
        //}
    }

}
    
