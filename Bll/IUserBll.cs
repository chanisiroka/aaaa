using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dto;
namespace Bll
{
   public  interface IUserBll
    {
        List<UserDto> getAllUsers();
        UserDto GetUserById(int id);

        void AddUser(UserDto u);
        void RemoveUser(int id);
        void UpdateUser(int id,UserDto u);
    }
}
