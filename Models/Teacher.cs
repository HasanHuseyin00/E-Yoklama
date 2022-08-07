namespace E_Yoklama.Models
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        public string TeacherName { get; set; }
        public string TeacherSurName { get; set; }
        public string StudentDepartment { get; set; }

        public List<Lesson> Lessons { get; set; }

    }
}
