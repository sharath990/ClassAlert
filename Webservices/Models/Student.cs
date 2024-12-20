namespace Webservices.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        public string Name { get; set; } = default!;
        public string RollNumber { get; set; } = default!;
        public string ParentPhone { get; set; } = default!;

        public string BatchID { get; set; } = default!;

        public string BatchName { get; set; }= default!;
        public string ClassID { get; set; } = default!;

        public string StreamID { get; set; } = default!;
        public string SectionID { get; set; } = default!;   


    }

}