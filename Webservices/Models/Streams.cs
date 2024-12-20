namespace Webservices.Models
{
    public class Streams
    {
        public int StreamID { get; set; }
        public string StreamName { get; set; } = default!;
        public ICollection<Class> Classes { get; set; } = new List<Class>();
    }
}
