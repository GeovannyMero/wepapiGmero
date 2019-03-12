using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using apiGmero.Models;

namespace apiGmero.Controllers
{
    public class UserController : ApiController
    {

        private Users[] users = new Users[]
        {
            new Users
            {
                Id = 1,
                Identificacion = "0931254569",
                Nombre = "Geovanny",
                Apellidos = "Mero Baque",
                FechaNacimiento = Convert.ToDateTime("10/11/1993")
            }
        };
        // GET api/user
        public IEnumerable<Users> Get()
        {
            return users;
        }

        // GET api/user/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/user
        public void Post([FromBody]string value)
        {
        }

        // PUT api/user/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/user/5
        public void Delete(int id)
        {
        }
    }
}
