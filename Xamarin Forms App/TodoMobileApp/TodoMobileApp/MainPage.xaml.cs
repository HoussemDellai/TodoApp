using System;
using System.Collections.Generic;
using TodoMobileApp.Models;
using Xamarin.Forms;

namespace TodoMobileApp
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

	    protected override void OnAppearing()
	    {
	        base.OnAppearing();

            var todoes = new List<Todo>
            {
                new Todo{ Id = 1, Title = "Create Xamarin App", IsDone = true, UpdatedAt = DateTime.Now },
                new Todo{ Id = 1, Title = "Create ASP.NET Core App", IsDone = false, UpdatedAt = DateTime.Now },
                new Todo{ Id = 1, Title = "Connect to REST API", IsDone = false, UpdatedAt = DateTime.Now }
            };

	        TodoesListView.ItemsSource = todoes;
	    }
	}
}
