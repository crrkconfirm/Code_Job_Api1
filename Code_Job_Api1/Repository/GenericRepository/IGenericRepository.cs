namespace Code_Job_Api1.Repository.GenericRepository
{
    public interface IGenericRepository<T> where T : class
    {
        T Find(int Id);
    }
}
