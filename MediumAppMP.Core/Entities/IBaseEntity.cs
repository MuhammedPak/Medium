using System;
using System.Collections.Generic;
using System.Text;

namespace MediumAppMP.Core.Entities
{
    public interface IBaseEntity<TKey>
    {
        TKey Id { get; set; }
        DateTime CreateTime { get; set; }
        bool IsDeleted { get; set; }        
    }
}
