using UserStory_Men_Cher.Models;

namespace Logic
{
    public class Logic
    {
        private List<Student> students = new List<Student>();
        public List<Student> GetStudents()
        {
            return students;
        }
        public Student Add(Student student)
        {
            students.Add(student);
            return student;
        }
        public void Change(Student oldstd, Student newstd)
        {
            students[students.IndexOf(oldstd)] = newstd;
        }
        public void Remove(Student student)
        {
            students.Remove(student);
        }
    }
}
