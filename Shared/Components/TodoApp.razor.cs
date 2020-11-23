using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace malformedpeach.github.io.Shared.Components
{
    public partial class TodoApp
    {
        public string InputText { get; set; }
        public List<Todo> TodoItems { get; set; }


        public TodoApp()
        {
            InputText = "";
            TodoItems = new List<Todo>();
        }

        public void AddTodo()
        {
            if(InputText != null && InputText != string.Empty)
            {
                TodoItems.Add(new Todo { Id = Guid.NewGuid(), TodoText = InputText});
                InputText = string.Empty;
            }
        }
    }

    public class Todo
    {
        public Guid Id { get; set; }
        public string TodoText { get; set; }
    }
}
