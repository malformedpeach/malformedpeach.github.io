using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace malformedpeach.github.io.Shared
{
    public partial class MainLayout
    {
        private string _currentTheme = "light";

        private void ToggleTheme()
        {
            if (_currentTheme == "light") _currentTheme = "dark";
            else if (_currentTheme == "dark") _currentTheme = "light";
            this.StateHasChanged();
        }


        protected override async Task OnInitializedAsync()
        {
            var interopResult = await JS.InvokeAsync<string>("getPreferedTheme");
            _currentTheme = $"{interopResult}";
        }
    }
}
