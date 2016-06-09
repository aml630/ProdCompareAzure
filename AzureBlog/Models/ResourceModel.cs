using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace AzureBlog.Models
{
    [Table("Resources")]

    public class ResourceModel
    {


        [Key]
        public int ResourceId { get; set; }
        public string ResourceTitle { get; set; }
        public string ResourceLink { get; set; }

        public int SegmentId { get; set; }

        public virtual SegmentModel Segment { get; set; }
    }
}