using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestYoubim.Data.Context;
using TestYoubim.Model;

namespace TestYoubim.Data.Repository
{
    public class UserRepository
    {
        private readonly CustomDbContext _userContext;
        public UserRepository(CustomDbContext context)
        {
            _userContext = context;
        }

        public User FindByUsername(string username)
        {
            return _userContext.User.SingleOrDefault(p => p.UserName == username);
        }

        public IEnumerable<User> getAll()
        {
            return _userContext.User;
        }

        public User FindById(Guid id)
        {
            return _userContext.User.Find(id);
        }

        public void AddUser(User user)
        {
            _userContext.User.Add(user);
            _userContext.SaveChanges();
        }

        public void UpdateUser(User user)
        {
            _userContext.User.Update(user);
            _userContext.SaveChanges();
        }

        public void DeleteUser(Guid id)
        {
            var user = this.FindById(id);
            if (user != null)
            {
                _userContext.User.Remove(user);
                _userContext.SaveChanges();
            }
        }
    }
}
