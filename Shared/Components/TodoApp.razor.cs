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
        public List<string> TodoItems { get; set; }


        public TodoApp()
        {
            InputText = "";
            TodoItems = new List<string>();
        }

        public void AddTodo()
        {
            if(InputText != null && InputText != string.Empty)
            {
                TodoItems.Add(InputText);
            }
        }
    }
}
