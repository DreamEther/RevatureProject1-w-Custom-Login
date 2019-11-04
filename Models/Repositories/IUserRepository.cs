using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Models.Repositories
{
    public interface IUserRepository
    {
        Task<User> Get(string id);

        Task<List<User>> Get();

        Task<bool> Register(User customer);

        Task<bool> Edit(string id, User customer);

        Task<bool> Delete(string id);

        bool UserExists(string id);
        bool Login(User userAccount);
    }
}
