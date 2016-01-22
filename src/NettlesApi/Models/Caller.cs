namespace NettlesApi.Models
{
    public class Caller
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string CallerUrl { get; set; }

        public Show Show { get; set; }
    }
}
