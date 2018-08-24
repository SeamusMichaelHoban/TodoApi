using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TodoApi.Models;

namespace TodoApi.Controllers
{
    public class TodoController : ApiController
    {
        private static List<Todo> todos = new List<Todo>()
            {
                new Todo() { Id = 1, Name = "Feed cat", Priority = 1}
            };
        public List<Todo> GetAll()
        {
            return todos;
        }

        public void Post(Todo todo)
        {
            todos.Add(todo);
        }
    }
}
