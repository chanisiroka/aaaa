using Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
using Dto;
using AutoMapper;
using Entity;

namespace Bll
{
   public class UserBll : IUserBll
    {
        private IUserDal userDal;
        private IMapper mapper;
        public UserBll(IUserDal userDal,IMapper map)
        {
            this.userDal = userDal;
            this.mapper = map;
        }
        public void AddUser(UserDto u)
        {
            this.userDal.AddUser(mapper.Map<User>(u));
        }

        public List<UserDto> getAllUsers()
        {
            return mapper.Map<List<UserDto>>(userDal.GetAllUser());
        }

        public UserDto GetUserById(int id)
        {
            return mapper.Map<UserDto>(userDal.GetUserById(id));
        }

        public void RemoveUser(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateUser(int id, UserDto u)
        {
            throw new NotImplementedException();
        }
    }
}
