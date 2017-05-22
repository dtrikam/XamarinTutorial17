﻿using System;
namespace Moodify.Models
{
    public class Song
    {
		public string SongName { get; set; }
		public string Emotion { get; set; }
		public int NumberOfTimesPlayed { get; set; }
        public String Genre { get; set; }
    }

	public static class Emotion
	{
		public static string Sad = "Sad";
		public static string Happy = "Happy";
		public static string Angry = "Angry";
	}

	public static class Genre
	{
        public static string Pop = "Pop";
        public static string HipHop = "Hip Hop";
        public static string RnB = "R&B";

	}
}
