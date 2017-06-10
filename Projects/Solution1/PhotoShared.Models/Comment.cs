using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoShared.Models
{
    public class Comment
    {
        public int id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }

        public string User { get; set; }

        public DateTime CreateAt { get; set; }

        public int PhotoId { get; set; }
        public Photo Photo { get; set; }
    }
}
