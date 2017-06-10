using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoSharingCepedi.Models
{
    public class Photo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public byte[] File { get; set; }
        public string MimeType { get; set; }

        public DateTime CreateAt { get; set; }
        public DateTime ModifiedAt { get; set; }

        public string User { get; set; }

        public virtual ICollection<Comment> Comment { get; set; }
    }
}
