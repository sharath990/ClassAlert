namespace Webservices.Models
{
    public class Section
    {

        public int SectionID { get; set; }
        public string SectionName { get; set; } = default!;
        public int ClassID { get; set; }
        public Class Class { get; set; } = default!;
        public ICollection<Student> Students { get; set; } = new List<Student>();
    }
}
