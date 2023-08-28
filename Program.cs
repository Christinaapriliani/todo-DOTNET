using System;

namespace TodoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            TodoList todoList = new TodoList();

            todoList.Add("Buy groceries");
            todoList.Add("Read a book");
            todoList.Add("Go for a run");

            Console.WriteLine("All Todos:");
            foreach (var todo in todoList.GetAll())
            {
                Console.WriteLine($"[{todo.ID}] {todo.Title} - {getStatus(todo.Complete)}");
            }

            int idToRemove = 2;
            todoList.Remove(idToRemove);
            Console.WriteLine("\nUpdated Todo List:");
            foreach (var todo in todoList.GetAll())
            {
                Console.WriteLine($"[{todo.ID}] {todo.Title} - {getStatus(todo.Complete)}");
            }
        }

        static string getStatus(bool complete)
        {
            return complete ? "Completed" : "Incomplete";
        }
    }
}
