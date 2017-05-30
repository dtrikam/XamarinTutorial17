﻿using System;
namespace Moodify
{
    public class Song
    {
		public string SongName { get; set; }
        public string Artist { get; set; }
        public string Album { get; set; }
		public string Emotion { get; set; }
        public String Genre { get; set; }
        public String Artwork { get; set; }
    }

	public static class Emotion
	{
		public static string Sadness = "Sadness";
		public static string Happiness = "Happiness";
		public static string Anger = "Angry";
        public static string Contempt = "Contempt";
        public static string Disgust = "Disgust";
        public static string Fear = "Fear";
        public static string Neutral = "Neutral";
        public static string Surprise = "Surprise";
	}

	public static class Genre
	{
        public static string Pop = "Pop";
        public static string HipHop = "Hip Hop";
        public static string RnB = "R&B";
        public static string NeoFolk = "Neo-folk";
	}
}
