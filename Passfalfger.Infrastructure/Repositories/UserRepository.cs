using System;
using System.Linq;
using System.Collections.Generic;
using Passfalfger.Core.Domain;
using Passfalfger.Core.Repositories;

namespace Passfalfger.Infrastructure.Repositories
{
    public class InMemoryUserRepository : IUserRepository
    {
        private static ISet<User> _users = new HashSet<User>()
        {
            new User("user1@email.com", "user1", "secret", "salt"),
            new User("user2@email.com", "user2", "secret", "salt"),
            new User("user3@email.com", "user3", "secret", "salt")
        };

        public void Add(User user)
        {
            _users.Add(user);
        }

        public User Get(Guid id)
        {
            return _users.Single(x => x.Id == id);
        }
          
        public User Get(string email)
        {
            return _users.Single(x => x.Email.ToLowerInvariant() == email.ToLowerInvariant());
        }

        public IEnumerable<User> GetAll()
        {
            return _users;
        }

        public void Remove(Guid id)
        {
            _users.Remove(Get(id));
        }

        public void Update(User user)
        {
            
        }
    }
}