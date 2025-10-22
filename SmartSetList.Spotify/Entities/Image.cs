using System.ComponentModel.DataAnnotations;

namespace SmartSetList.Spotify.Entities
{
    public class Image
    {
        [Required]
        public string URL { get; set; }

        [Required]
        public int? Height { get; set; }

        [Required]
        public int? Width { get; set; }
    }
}
