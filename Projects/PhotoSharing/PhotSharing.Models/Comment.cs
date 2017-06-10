﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotSharing.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Body { get; set; }
        public string Title { get; set; }

        public string User { get; set; }

        public DateTime createdAt { get; set; }

        public int PhotoId { get; set; }
        public virtual Photo Photo { get; set; }
    }
}
