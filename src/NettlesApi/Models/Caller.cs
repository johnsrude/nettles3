using System.ComponentModel.DataAnnotations;

namespace NettlesApi.Models
{
    public class Caller
    {
        public int Id { get; set; }

        [Required]
        public string FullName { get; set; }
        public string Url { get; set; }
    }
}
