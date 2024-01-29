using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
   public class Post
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }

        public virtual User user { get; set; }
    }
}
