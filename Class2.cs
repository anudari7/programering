using System;

namespace Projekt
{

    public class Music
    {
        internal string Genre { get; set; }
    }

    public class PerformType : Music
    {
        internal bool performtype { get; set; }
        //true= artist, false= något annat, ksk band etc//

    }

    public class Artist : PerformType
    {
        internal string artist_name { get; set; }
        internal int age { get; set; }

        internal bool gender { get; set; }
        //false = female; true = male//

        internal bool relationship_status { get; set; }
        //false = single; true = in relationship//
    }
    public class Song : Artist
    {
        internal string name { get; set; }
        internal string release_date { get; set; }
        internal string listeners { get; set; }

        internal string lyrics { get; set; }

        public void info()
        {
            Console.WriteLine(Genre);
            Console.WriteLine(artist_name);
            Console.WriteLine(release_date);
            Console.WriteLine(listeners);

        }
    }

}
    
