using static System.Collections.Specialized.BitVector32;

namespace Webservices.Models
{
    public class Class
    {
        public int ClassID { get; set; }
        public string ClassName { get; set; }
        public ICollection<Section> Sections { get; set; } = new List<Section>();
        public int StreamID { get; set; }
        public Stream Stream { get; set; }
    }
}
