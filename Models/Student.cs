namespace E_Yoklama.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string StudentSurName { get; set; }
        public string StudentDepartment { get; set; }

        public List<Check> Checks { get; set; }
        public List<Lesson> Lessons { get; set; }
        
    }
}
