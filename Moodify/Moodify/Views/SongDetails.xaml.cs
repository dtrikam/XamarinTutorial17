using System;
using System.Collections.Generic;
using Moodify.Models;
using Xamarin.Forms;

namespace Moodify.Views
{
    public partial class SongDetails : ContentPage
    {
        public SongDetails(Song song)
        {
            InitializeComponent();
            BindingContext = song;
        }
    }
}
