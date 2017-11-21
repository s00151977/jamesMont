﻿using jamesMont.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace jamesMont.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ChangeBooking : ContentPage
	{
        string name;
        public ChangeBooking ()
		{
			InitializeComponent ();
            foreach (var x in MainPage.UserName)
            {
                name = x;
            }
		}
        AzureService2 azureService;
        async private void deleteBooking(object sender, EventArgs e)
        {
            azureService = new AzureService2();
            await azureService.DeleteBooking();

            await DisplayAlert("Alert", "Booking Deleted", "Ok");
            await Navigation.PushAsync(new MenuPage(name));
        }
    }
}