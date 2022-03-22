using System;
using System.Collections.Generic;
using System.Text;

namespace CommonModelLib.Models
{
    public class Blog : BaseModel
    {
        public int BlogId { get; set; }
        public string Url { get; set; }

        public IEnumerable<Post> Posts { get; set; }
    }
}
