using System;
using System.Collections.Generic;
using Moodify.Models;
using Xamarin.Forms;

namespace Moodify
{
    public partial class MoodifyPage : ContentPage
    {
        void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            var song = e.SelectedItem as Song;
            DisplayAlert("Name of song?", song.SongName.ToString(), "OK");

			

        }


        public MoodifyPage()
        {
            InitializeComponent();
        }
    }
}
