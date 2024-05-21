using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogForest.Entitylayer.Concrete
{
    public class Comment
    {
        public int CommentId { get; set; }
        public string CommentText { get; set; }
        public DateTime CommentDate { get; set; }
        public bool Status { get; set; }

        public int BlogId { get; set; }
        public Blog Blog { get; set; }

        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }

    }
}
