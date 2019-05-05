using System;
using System.Collections.Generic;
using System.Text;

namespace MediumAppMP.Entities.Abstract
{
    public interface IBaseEntity
    {
        int Id { get; set; }
        DateTime CreateTime { get; set; }
        bool IsDeleted { get; set; }
    }
}
