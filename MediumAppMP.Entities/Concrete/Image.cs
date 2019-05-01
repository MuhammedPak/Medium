using System;
using System.Collections.Generic;
using System.Text;

namespace MediumAppMP.Entities.Concrete
{
    public class Image:BaseEntity<int>
    {        
        public string Url { get; set; }
        public string Path { get; set; }        
    }
}
