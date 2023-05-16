using Code_Job_Api1.Models;
using Code_Job_Api1.Repository.GenericRepository;

namespace Code_Job_Api1.Repository;
public class StudentRepository : GenericRepository<Student>, IStudentRepository, IDisposable
{
    public IEnumerable<Student> GetAll()
    {
        List<Student> students = new List<Student>();
        students.Add(new Student() { Age = 20, Name = "Alice", Hobbies = new List<string>() { "reading", "swimming", "coding" } });
        students.Add(new Student() { Age = 22, Name = "Bob", Hobbies = new List<string>() { "painting", "dancing", "singing" } });
        return students;
    }

    private bool disposed = false;
    protected override void Dispose(bool disposing)
    {
        if (!this.disposed)
        {
            if (disposing)
            {
                // write necessary code , ex: context.Dispose()
            }
        }
        this.disposed = true;
    }
}
