using System;
using Passfalfger.Core.Domain;
using Passfalfger.Core.Repositories;
using Passfalfger.Infrastructure.DTO;

namespace Passfalfger.Infrastructure.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRespository)
        {
            _userRepository = userRespository;
        }

        public UserDTO Get(string email)
        {
            var user = _userRepository.Get(email);
            return new UserDTO
            {
                Id = user.Id,
                UserName = user.UserName,
                Email = user.Email,
                FullName = user.FullName
            };
        }

        public void Register(string email, string username, string password)
        {
            var user = _userRepository.Get(email);
            if(user != null)
            {
                throw new Exception($"User with email: '{email}' already exists.");
            }
            
            var salt = Guid.NewGuid().ToString("N");
            _userRepository.Add(new User(email, username, password, salt));
        }
    }
}