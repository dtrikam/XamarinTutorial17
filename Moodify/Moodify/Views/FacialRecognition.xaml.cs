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
		EmotionServiceClient emotionClient;

		public FacialRecognition()
		{
			InitializeComponent();
			Title = "Facial Recognition";
			Icon = "Songs.png";
			emotionClient = new EmotionServiceClient(Constants.EmotionApiKey);
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

			// Recognize emotion
			try
			{

				var emotionResults = await emotionClient.RecognizeAsync(file.GetStream());

				var temp = emotionResults[0].Scores;

				emotionResultLabel.Text = emotionResults.FirstOrDefault().Scores.ToRankedList().FirstOrDefault().Key;

				image.Source = ImageSource.FromStream(() =>
				{
					var stream = file.GetStream();
					file.Dispose();
					return stream;
				});
			}
			catch (Exception ex)
			{
				emotionResultLabel.Text = ex.Message;
			}

        }




    }
}
