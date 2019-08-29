
using System;
using Newtonsoft.Json;
using System.IO;
//namespace MyTranslate
//{
	public  class JsonFile
	{
		public JsonFile()
		{
			MyMusic myCollection = new MyMusic();
            myCollection.Tracks = new Track[3];
 
            myCollection.Tracks[0] = new Track()
            {
                Artist="Artist1",
                Album="Album1",
                Title="Title1",
                Year="2015"
            };
            myCollection.Tracks[1] = new Track()
            {
                Artist = "Artist2",
                Album = "Album2",
                Title = "Title2",
                Year = "2015"
            };
            myCollection.Tracks[2] = new Track()
            {
                Artist = "Artist3",
                Album = "Album3",
                Title = "Title3",
                Year = "2015"
            };
            
            
            

				string serialized = JsonConvert.SerializeObject(myCollection);
				File.WriteAllText(@"C:\Users\User\AppData\Local\Temp\DataBase.txt", serialized);
		}
	}

		class MyMusic
        {
            public Track[] Tracks { get; set; }
        }
 
       		 class Track
        {
            public string Artist { get; set; }
            public string Album { get; set; }
            public string Title { get; set; }
            public string Year { get; set; }
 
 //       }
       		 }