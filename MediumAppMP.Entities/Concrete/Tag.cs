using System;
using System.Collections.Generic;
using System.Text;

namespace MediumAppMP.Entities.Concrete
{
    public class Tag : BaseEntity
    {
        public int ArticleId { get; set; }
        public string Name { get; set; }
    }
}
