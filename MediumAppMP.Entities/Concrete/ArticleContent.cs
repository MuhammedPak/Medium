using System;
using System.Collections.Generic;
using System.Text;

namespace MediumAppMP.Entities.Concrete
{
    public class ArticleContent:BaseEntity<int>
    {
        public int ArticleId { get; set; }
        public string Content { get; set; }
        public List<Image> Image{ get; set; }
    }
}
