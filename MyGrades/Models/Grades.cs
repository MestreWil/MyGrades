namespace MyGrades.Models
{
    public class Grades
    {
        public int Id { get; set; }
        public double Grade { get; set; }
        public DateTime DataTest { get; set; }
        public int StudentId { get; set; }
        public int SubjectId { get; set; }


    }
}
