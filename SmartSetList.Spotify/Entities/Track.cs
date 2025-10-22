using System;
using System.Collections.Generic;

namespace SmartSetList.Spotify.Entities
{
    public class Track
    {
        public Album Album { get; set; }

        public List<Artist> Artists { get; set; }
        public List<string> Available_Markets { get; set; }
        public int Disc_Number { get; set; }
        public int Duration_Ms { get; set; }
        public bool Explicity { get; set; }
        public ExternalId External_Ids { get; set; }
        public ExternalURL External_Urls { get; set; }
        public string Href { get; set; }

        public string Id { get; set; }
        public bool Is_Playable { get; set; }
        public LinkedFrom Linked_From { get; set; }
        public Restrictions Restrictions { get; set; }
        public string Name { get; set; }
        public int Popularity { get; set; }
        public string Preview_Url { get; set; }
        public int Track_Number { get; set; }
        public string Type { get; set; }
        public string URI { get; set; }
        public bool IsLocal { get; set; }


    }
}
