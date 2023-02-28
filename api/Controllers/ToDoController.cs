using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using api.Models;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoController : ControllerBase
    {
        // GET: api/ToDo
        [HttpGet]
        public List<ToDos> Get(){
        {
                List<ToDos> myToDos = new List<ToDos>();
                ToDos toDo = new ToDos(){ID = 1, ToDo = "complete PA3", Completed = false};
                ToDos toDo2 = new ToDos(){ID = 1, ToDo = "complete PA3", Completed = false};
                ToDos toDo3 = new ToDos(){ID = 1, ToDo = "complete PA3", Completed = false};

                myToDos.Add(toDo);
                myToDos.Add(toDo2);
                myToDos.Add(toDo3);

                return myToDos;
            }
        }

        // GET: api/ToDo/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/ToDo
        [HttpPost]
        public void Post([FromBody] ToDos myToDo)
        {
            System.Console.WriteLine("inside the post");
            System.Console.WriteLine(myToDo.ToDo);
        }

        // PUT: api/ToDo/5
        [HttpPut("{id}")] //UPDATE
        public void Put(int id, [FromBody] ToDos myToDo)
        {
            System.Console.WriteLine("inside the put");
            System.Console.WriteLine(id);
            System.Console.WriteLine(myToDo.ToDo);
        }

        // DELETE: api/ToDo/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            System.Console.WriteLine("inside the delete");
            System.Console.WriteLine(id);
        }
    }
}
