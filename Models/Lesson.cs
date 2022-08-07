namespace E_Yoklama.Models
{
    public class Lesson
    {
        public int LessonId { get; set; }
        public string LessonName { get; set; }
        public string LessonDescription { get; set; }

        public Teacher Teacher { get; set; }
        public List<Student> Students { get; set; }
    }
}
