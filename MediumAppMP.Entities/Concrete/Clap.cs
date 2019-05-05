using System;
using System.Collections.Generic;
using System.Text;

namespace MediumAppMP.Entities.Concrete
{
    public class Clap:BaseEntity
    {
        public virtual List<User> User{ get; set; }
        public int UserId { get; set; }
        public virtual Article Article { get; set; }
        public int ArticleId { get; set; }
    }
}
