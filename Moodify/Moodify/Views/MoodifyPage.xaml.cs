﻿﻿using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Moodify
{
    public partial class MoodifyPage : ContentPage
    {
        void Handle_ItemTapped(object sender, Xamarin.Forms.ItemTappedEventArgs e)
        {
			if (((ListView)sender).SelectedItem == null)
				return;
			//Do stuff here with the SelectedItem ...
			((ListView)sender).SelectedItem = null;
		}

        async void Handle_ItemSelectedAsync(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
          
			var song = ((ListView)sender).SelectedItem as Song;
			if (song != null)
			{
				var detailPage = new SongDetails(song);
				detailPage.BindingContext = song;
				await Navigation.PushAsync(detailPage);
			}
        }


        public MoodifyPage()
        {
            InitializeComponent();

;        }

    }
}
