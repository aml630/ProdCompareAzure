using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Data.Entity;



namespace AzureBlog.Models
{
    [Table("Categories")]

    public class CategoryModel
    {
      
            [Key]
            public int CategoryId { get; set; }
            public string CategoryName { get; set; }
            public string CategoryPic { get; set; }

            public virtual ICollection<ProductModel> Products { get; set; }


        }
    }
