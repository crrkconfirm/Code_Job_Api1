using Code_Job_Api1.Models;

namespace Code_Job_Api1.Repository
{
    public interface IStudentRepository
    {
        IEnumerable<Student> GetAll();
    }
}
