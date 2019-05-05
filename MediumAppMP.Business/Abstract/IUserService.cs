using MediumAppMP.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediumAppMP.Business.Abstract
{
    public interface IUserService
    {
        List<User> GetAll();
        User GetById(int id);
        void Add(User user);
        void Update(User user);
    }
}
