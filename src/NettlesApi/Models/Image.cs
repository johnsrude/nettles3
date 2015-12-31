using System.ComponentModel.DataAnnotations;

namespace NettlesApi.Models
{
    public class Image
    {
        public int Id { get; set; }

        [Required]
        public byte[] Picture { get; set; }
    }
}
