﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.Example.EntityLayer.Concrate
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }

        public string Description { get; set; }

        public bool Status { get; set; }


        public List<Blog> Blogs { get; set; }
    }
}
