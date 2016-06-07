using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace AzureBlog.Models
{
    [Table("Segments")]

    public class SegmentModel
    {


        [Key]
        public int SegmentId { get; set; }
        public string SegmentTitle { get; set; }
        public string SegmentBody { get; set; }
        public string SegmentPar2 { get; set; }
        public string SegmentPar3 { get; set; }
        public string SegmentImage { get; set; }
        public string SegmentVideo { get; set; }

        public int CategoryId { get; set; }
        public virtual CategoryModel Category { get; set; }
    }
}