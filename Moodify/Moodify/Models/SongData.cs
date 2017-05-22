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
							SongName="Shake it off",
                            Emotion=Emotion.Sad,
							NumberOfTimesPlayed=1,
                            Genre=Genre.HipHop,
						},
						new Song {
							SongName="Shake it off 2",
                            Emotion=Emotion.Happy,
							NumberOfTimesPlayed=1,
                            Genre=Genre.Pop,
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
