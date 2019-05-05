using System;
using System.Collections.Generic;
using System.Text;

namespace MediumAppMP.Entities.Concrete
{
    public class Article : BaseEntity
    { 
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public virtual ArticleContent Content { get; set; }
        public int ArticleContentId { get; set; }
        public List<Clap> Clap { get; set; }
        public List<Tag> Tag { get; set; }
    }
}
