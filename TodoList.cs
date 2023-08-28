using System;
using System.Collections.Generic;

namespace TodoApp
{
    public class TodoList
    {
        private List<Todo> todos;
        private int currentID;

        public TodoList()
        {
            todos = new List<Todo>();
            currentID = 1;
        }

        public void Add(string title)
        {
            todos.Add(new Todo { ID = currentID, Title = title });
            currentID++;
        }

        public void Remove(int id)
        {
            todos.RemoveAll(todo => todo.ID == id);
        }

        public Todo GetByID(int id)
        {
            return todos.Find(todo => todo.ID == id);
        }

        public List<Todo> GetAll()
        {
            return todos;
        }
    }
}
