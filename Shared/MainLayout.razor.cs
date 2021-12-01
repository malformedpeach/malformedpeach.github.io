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
        private string _currentTheme = "mountain-lake-light";

        private void ToggleTheme()
        {
            if (_currentTheme == "mountain-lake-light") _currentTheme = "mountain-lake-dark";
            else if (_currentTheme == "mountain-lake-dark") _currentTheme = "mountain-lake-light";
            this.StateHasChanged();
        }


        protected override async Task OnInitializedAsync()
        {
            var interopResult = await JS.InvokeAsync<string>("getPreferedTheme");
            _currentTheme = $"mountain-lake-{interopResult}";
        }
    }
}
