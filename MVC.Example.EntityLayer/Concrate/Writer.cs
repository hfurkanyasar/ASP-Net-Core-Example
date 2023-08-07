using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.Example.EntityLayer.Concrate
{
    public class Writer
    {
        [Key]
        public int WriterID { get; set; }
        public string About { get; set; }
        public string WriterName { get; set; }

        public string Image { get; set; }
        public bool Status { get; set; }

        public string Mail { get; set; }
        public string Password { get; set; }
    }
}
