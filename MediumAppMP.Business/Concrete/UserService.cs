using MediumAppMP.Business.Abstract;
using MediumAppMP.Core.DataAccess.EntityFramework;
using MediumAppMP.Entities.Concrete;
using System;
using System.Collections.Generic;

namespace MediumAppMP.Business.Concrete
{
    public class UserService : IUserService
    {
        private readonly IEntityRepository<User> db;

        public UserService(IEntityRepository<User> _entityRepository)
        {
            this.db = _entityRepository;
        }

        public void Add(User user)
        {
            db.Add(user);
        }

        public List<User> GetAll()
        {
            var model = db.GetList();

            return model;
        }

        public User GetById(int id)
        {
            var model = db.Get(x => x.Id == id);

            return model;
        }

        public void Update(User user)
        {
            db.Update(user);
        }
    }
}
