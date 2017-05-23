﻿using System;
using System.Collections.Generic;
using Moodify.Models;
using Moodify.Views;
using Xamarin.Forms;

namespace Moodify
{
    public partial class MoodifyPage : ContentPage
    {
        public MoodifyPage()
        {
            InitializeComponent();

;        }

		async void Handle_ItemSelectedAsync(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
		{
			var song = e.SelectedItem as Song;

			//await DisplayAlert("Name of song", song.SongName.ToString(), "OK", "Cancel");

			((ListView)sender).SelectedItem = null;

			var detailPage = new SongDetails(song);

			await Navigation.PushAsync(detailPage);

		}
    }
}
