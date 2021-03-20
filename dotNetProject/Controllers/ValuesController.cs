using dotNetProject.DAL;
using System.Collections.Generic;
using System.Web.Http;
using dotNetProject.Models;
using System.Linq;

namespace dotNetProject.Controllers
{
    public class ValuesController : ApiController
    {
        private DatabaseContext context = new DatabaseContext();
        // GET api/values
        public IEnumerable<User> Get()
        {
            return context.Users.ToList();
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
