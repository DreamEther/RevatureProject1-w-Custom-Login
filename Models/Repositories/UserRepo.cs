using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Repositories
{
    public class UserRepo : IUserRepository
    {
        private MyDbContext _context;

        public UserRepo(MyDbContext ctx)
        {
            _context = ctx;
        }

        public async Task<User> Get(string id)
        {
            var customer = await _context.Users.FirstOrDefaultAsync(m => m.Id == id);
            return customer;
        }

        public async Task<List<User>> Get()
        {
            var customers = await _context.Users.ToListAsync();
            return customers;
        }

        public async Task<bool> Register(User customer)
        {
            _context.Add(customer);
            await _context.SaveChangesAsync();
            return true;
        }

        public bool Login(User customer)
        {
            var user = _context.Users.Single(u => u.Pin == customer.Pin);
            return true;
        }

        public async Task<bool> Edit(string id, User customer)
        {
            _context.Update(customer);
            await _context.SaveChangesAsync();
            return true;
        }
        public async Task<bool> Delete(string id)
        {
            var customer = await this.Get((string)id);
            _context.Users.Remove(customer);
            await _context.SaveChangesAsync();
            return true;
        }
        public bool UserExists(string id)
        {
            return _context.Users.Any(e => e.Id == id);
        }

       
    }
}
