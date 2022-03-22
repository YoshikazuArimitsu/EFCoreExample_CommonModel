using System;
using System.Collections.Generic;
using System.Text;

namespace CommonModelLib.Models
{
    public class Post : BaseModel
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
    }
}
