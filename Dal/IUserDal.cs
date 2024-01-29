using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
namespace Dal
{
  public  interface IUserDal
    {
        List<User> GetAllUser();
        User GetUserById(int id);
        void AddUser(User u);

        void RemoveUser(int id);
        void UpdateUser(int id, User u);
    }
}
