using System;
using System.Collections.Generic;
using System.Text;

namespace MediumAppMP.Entities.Concrete
{
    public class Friendship : BaseEntity
    {       
        public int UserId { get; set; }  
        public int FollowerId { get; set; }
    }
}
