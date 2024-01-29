using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
   public class UserDal : IUserDal
    {
       private  Database db;
        public UserDal(Database _db)
        {
            this.db = _db;
        }
        public void AddUser(User u)
        {
            this.db.Users.Add(u);
            this.db.SaveChanges();
        }

        public List<User> GetAllUser()
        {
            return this.db.Users.ToList();
        }

        public User GetUserById(int id)
        {
            return this.db.Users.FirstOrDefault(x => x.Id == id);
        }

        public void RemoveUser(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateUser(int id, User u)
        {
            throw new NotImplementedException();
        }
    }
}
