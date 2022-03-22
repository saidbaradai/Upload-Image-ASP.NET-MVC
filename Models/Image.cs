using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Upload_Image_v2.Models
{
    public class Image
    {
        
        public int ImageId { get; set; }

        public string Title { get; set; }

        [DisplayName("Upload file")]
        public string ImagePath { get; set; }

        [NotMapped] //very iportant for enabaling migrations
        public HttpPostedFileBase ImageFile { get; set; }



    }
}