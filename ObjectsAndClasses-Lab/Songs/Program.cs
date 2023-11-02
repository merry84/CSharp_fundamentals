using Microsoft.VisualBasic;
using static System.Net.Mime.MediaTypeNames;
using System.Collections.Generic;

namespace Songs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Define a class called Song that will hold the following information about some songs:
            //•	Type List
            //•	Name
            //•	Time
            //Input / Constraints
            //•	On the first line, you will receive the number of songs - N.
            //•	On the next N lines, you will be receiving data in the following format:
            //"{typeList}_{name}_{time}".
            //•	On the last line, you will receive Type List or "all".
            //Output
            //If you receive Type List as an input on the last line, print out only the names of the songs,
            //which are from that Type List.
            //If you receive the "all" command, print out the names of all the songs.

            int numberSong = int.Parse(Console.ReadLine()); 

            List<Song> list = new List<Song>();

            for (int i = 0; i < numberSong; i++) 
            {
                string[] data = Console.ReadLine().Split("_");
                string type = data[0];
                string name = data[1];
                string time = data[2];

                Song song = new Song();

                song.TypeList = type;
                song.Name = name;
                song.Time = time;
                list.Add(song);
            }
            string filter = Console.ReadLine();
            if(filter != "all")
            {
                foreach (Song song in list)
                {
                    if(song.TypeList== filter)
                    {
                        Console.WriteLine(song.Name);
                    }
                    
                }
                return;
            }
            foreach (Song song in list) //If you receive the "all" command, print out the names of all the songs.
            {
                Console.WriteLine(song.Name);
            }

        }
    }
    class Song
    {
        public string TypeList { get; set; }

        public string Name { get; set; }

        public string Time { get; set; }
    }
}