using System;
using System.Collections.Generic;

namespace Moodify.Models
{
	// This is the "list of lists"
	public class SongGrouping : List<Song>
    {
		public string Title { get; set; }
		public string ShortName { get; set; }

		public SongGrouping(string title, string shortName)
		{
			Title = title;
			ShortName = shortName;
		}
    }
}
