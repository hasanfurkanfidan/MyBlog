﻿using MyBlog.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyBlog.Entities.Concrete
{
   public class Comment:ITable
    {
        public int Id { get; set; }

        public string AuthorEMail { get; set; }
        public string AuthorName { get; set; }
        public string Description { get; set; }

        public DateTime PostedTime { get; set; } = DateTime.Now;


        public int? ParentCommentId { get; set; }
        public Comment ParentComment { get; set; }

        public Blog Blog { get; set; }

        public int BlogId { get; set; }
        public List<Comment> SubComments { get; set; }


    }
}
