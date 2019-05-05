using MediumAppMP.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediumAppMP.Entities.Concrete
{
    public class BaseEntity : IBaseEntity
    {
        public int Id { get; set; }
        public DateTime CreateTime { get; set; }
        public bool IsDeleted { get; set; }
    }
}
