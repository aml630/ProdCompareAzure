using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace AzureBlog.Models
{
    [Table("Products")]

    public class ProductModel
    {

      
            [Key]
            public int ProductId { get; set; }

            public string ProductName { get; set; }
            public string ProductImg { get; set; }
            public string ProductLink { get; set; }
            public int ProductPrice { get; set; }
            public string ProductDescription { get; set; }
            public bool ProductArticle { get; set; }
            public int CategoryId { get; set; }
            public virtual CategoryModel Category { get; set; }

        public string GenerateSlug()
        {
            string phrase = string.Format(ProductName);

            string str = RemoveAccent(phrase).ToLower();
            // invalid chars           
            str = Regex.Replace(str, @"[^a-z0-9\s-]", "");
            // convert multiple spaces into one space   
            str = Regex.Replace(str, @"\s+", " ").Trim();
            // cut and trim 
            str = str.Substring(0, str.Length <= 45 ? str.Length : 45).Trim();
            str = Regex.Replace(str, @"\s", "-"); // hyphens   
            return str;
        }

        private string RemoveAccent(string text)
        {
            byte[] bytes = System.Text.Encoding.GetEncoding("Cyrillic").GetBytes(text);
            return System.Text.Encoding.ASCII.GetString(bytes);
        }

    }
}