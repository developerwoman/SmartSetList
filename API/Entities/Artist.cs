using System.ComponentModel.DataAnnotations;

namespace API.Entities
{
    public class Artist
    {
        [Required]
        public ExternalURL External_Urls { get; set; }

        [Required]
        public string Href { get; set; }

        [Required]
        public string Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Type { get; set; }

        [Required]
        public string URI { get; set; }
    }
}
