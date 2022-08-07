namespace E_Yoklama.Models
{
    public class Check
    {
        public int CheckId { get; set; }
        public int CheckNumber { get; set; }
        public bool CheckIsChecked { get; set; }

        public Lesson Lesson { get; set; }
        public List<Student> Students { get; set; }
    }
}
