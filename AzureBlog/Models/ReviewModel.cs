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
    [Table("Reviews")]

    public class ReviewModel
    {

        [Key]
        public int ReviewId { get; set; }
        public int ProductId { get; set; }
        public int ReviewStars { get; set; }
        public string ReviewText { get; set; }
        public string ReviewAuthor { get; set; }
        public string ReviewIP { get; set; }
        public virtual ProductModel Product { get; set; }


    }
}
