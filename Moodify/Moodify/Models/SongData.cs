﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Moodify
{
    public static class SongData
    {
		static List<Song> _allSongs;
		public static List<Song> AllSongs
		{
			get
			{
				if (_allSongs == null)
				{
					_allSongs = new List<Song>
					{
						new Song {
							SongName="Let Her Go",
                            Artist = "Passenger",
                            Album = "All the Little Lights",
                            Emotion = Emotion.Sadness,
                            Genre = Genre.NeoFolk,
                            Artwork = "LetHerGo.png"
						},
						new Song {
							SongName="Baby",
                            Artist="Justin Bieber ft. Ludacris",
                            Album="My World 2.0",
                            Emotion=Emotion.Anger,
                            Genre=Genre.Pop,
                            Artwork ="Baby.jpg"
						},

						new Song {
							SongName="Happy",
							Artist = "Pharrel Williams",
                            Album = "G I R L",
                            Emotion = Emotion.Happiness,
                            Genre = Genre.Pop,
                            Artwork = "Happy.jpg"
						}
					};
				}
				return _allSongs;
			}
		}


		static List<SongGrouping> _allSongsGrouped;
		public static List<SongGrouping> AllSongsGrouped
		{
			get
			{
				if (_allSongsGrouped == null)
				{
					var sadGrouping = new SongGrouping("Sadness", "S");
                    sadGrouping.AddRange(SongData.AllSongs.Where(r => r.Emotion == Emotion.Sadness));

					var happyGrouping = new SongGrouping("Happiness", "H");
                    happyGrouping.AddRange(SongData.AllSongs.Where(r => r.Emotion == Emotion.Happiness));

					var angryGrouping = new SongGrouping("Anger", "A");
                    angryGrouping.AddRange(SongData.AllSongs.Where(r => r.Emotion == Emotion.Anger));

					_allSongsGrouped = new List<SongGrouping> {
						sadGrouping,
						happyGrouping,
						angryGrouping
					};
				}

				return _allSongsGrouped;
			}
		}
           
    }
}
