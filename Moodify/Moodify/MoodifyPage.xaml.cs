using System;
using System.Collections.Generic;
using Moodify.Models;
using Xamarin.Forms;

namespace Moodify
{
    public partial class MoodifyPage : ContentPage
    {
        async System.Threading.Tasks.Task Handle_ItemSelectedAsync(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            var song = e.SelectedItem as Song;

            await DisplayAlert("Name of song", song.SongName.ToString(), "OK", "Cancel");

            ((ListView)sender).SelectedItem = null;

        }

        public MoodifyPage()
        {
            InitializeComponent();
        }
    }
}
