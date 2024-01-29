using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bll;
using Dto;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserBll userBll;
        public UserController(IUserBll userBll)
        {
            this.userBll = userBll;
        }
        // GET: api/<UserController>
        [HttpGet]
        public List<UserDto> Get()
        {
            return this.userBll.getAllUsers();
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public UserDto Get(int id)
        {
            return this.userBll.GetUserById(id);
        }

        // POST api/<UserController>
        [HttpPost]
        public void Post([FromBody]UserDto user)
        {
            this.userBll.AddUser(user);
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
