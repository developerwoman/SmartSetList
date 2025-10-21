using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace API.Entities
{
    public class Album
    {
        [Required]
        public string AlbumType { get; set; }

        [Required]
        public int TotalTracks { get; set; }

        [Required]
        public List<string> Available_Markets { get; set; }

        [Required]
        public ExternalURL External_Urls { get; set; }

        [Required]
        public string Href { get; set; }

        [Required]
        public string Id { get; set; }

        [Required]
        public List<Image> Images { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Release_Date { get; set; }

        [Required]
        public string Release_Date_Precision { get; set; }

        [Required]
        public Restrictions Restrictions { get; set; }

        [Required]
        public string Type { get; set; }

        [Required]
        public string URI { get; set; }

        [Required]
        public List<Artist> Artists { get; set; }


    }
}
