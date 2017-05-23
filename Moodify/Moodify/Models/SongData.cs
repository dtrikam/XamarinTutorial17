using System;
using System.Collections.Generic;
using System.Linq;

namespace Moodify.Models
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
                            Emotion = Emotion.Sad,
                            Genre = Genre.NeoFolk,
                            Artwork = "LetHerGo.png"
						},
						new Song {
							SongName="Baby",
                            Artist="Justin Bieber ft. Ludacris",
                            Album="My World 2.0",
                            Emotion=Emotion.Angry,
                            Genre=Genre.Pop,
                            Artwork ="Baby.jpg"
						},

						new Song {
							SongName="Happy",
							Artist = "Pharrel Williams",
                            Album = "G I R L",
                            Emotion = Emotion.Happy,
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
					var sadGrouping = new SongGrouping("Sad", "S");
                    sadGrouping.AddRange(SongData.AllSongs.Where(r => r.Emotion == Emotion.Sad));

					var happyGrouping = new SongGrouping("Happy", "H");
                    happyGrouping.AddRange(SongData.AllSongs.Where(r => r.Emotion == Emotion.Happy));

					var angryGrouping = new SongGrouping("Angry", "A");
					angryGrouping.AddRange(SongData.AllSongs.Where(r => r.Emotion == Emotion.Angry));

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
