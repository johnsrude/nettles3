namespace NettlesApi.Models
{
    public class Caller
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Url { get; set; }

        public Show Show { get; set; }
    }
}
