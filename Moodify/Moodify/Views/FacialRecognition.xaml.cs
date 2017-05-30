using System;
using System.Diagnostics;
using System.Linq;
using Xamarin.Forms;
using Microsoft.ProjectOxford.Emotion;
using Microsoft.ProjectOxford.Emotion.Contract;
using Plugin.Media;
using Plugin.Media.Abstractions;

namespace Moodify
{
    public partial class FacialRecognition : ContentPage
    {
		//EmotionServiceClient emotionClient;
		//MediaFile photo;

		public FacialRecognition()
		{
			InitializeComponent();
			Title = "Facial Recognition";
			//Icon = "faceRec.png";
			var emotionClient = new EmotionServiceClient(Constants.EmotionApiKey);
		}

        async void Handle_ClickedAsync(object sender, System.EventArgs e)
        {
            if (!CrossMedia.Current.IsPickPhotoSupported)
            {
                await DisplayAlert("No upload", "Picking a photo is not supported.", "OK");
                return;
            }

            var file = await CrossMedia.Current.PickPhotoAsync();
            if (file == null)
                return;

            image.Source = ImageSource.FromStream(() => file.GetStream());

        }


    }
}
