namespace FosteringAPI.Models
{
    public class Student
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public int Age { get; set; }
        public required string Phone { get; set; }
        public required string Course { get; set; }
        public required string Period { get; set; }  
        public required string Hobby { get; set; }
        public required string Sentence { get; set; }
    }
}
