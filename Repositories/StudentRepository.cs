using ToDoListWithSacffolding.Models;

namespace ToDoListWithSacffolding.Repositories
{
    public class StudentRepository
    {
        private static List<Student> _students = new List<Student>();
        private static int _rollID = 1;

        public static List<Student> GetAll()
        { return _students; }
        public static Student? GetById(int id)
        {
            return _students.FirstOrDefault(x => x.Id == id);
        }

        public static void Add(Student student)
        {
            student.Id = _rollID++;
            _students.Add(student);
        }

        public static void Update(Student student)
        {
            var existing = GetById(student.Id);
            if (existing != null)
            {
                existing.Name = student.Name;
                existing.Age = student.Age;
                existing.DOB = student.DOB;
                existing.Mobile_Number = student.Mobile_Number;
                existing.Address = student.Address;
                existing.Class = student.Class;
                existing.IsFeePaid=student.IsFeePaid;
                existing.Gender = student.Gender;   
                
            }
        }

        public static void Delete(int id)
        {
            var student = GetById(id);
            if (student != null)
            {
                _students.Remove(student);
            }
        }


    }
}
