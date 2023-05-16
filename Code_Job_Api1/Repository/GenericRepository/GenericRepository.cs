using Code_Job_Api1.Models;

namespace Code_Job_Api1.Repository.GenericRepository
{
    public class GenericRepository<T> :  IGenericRepository<T>, IDisposable where T : class
    {
        public virtual T Find(int Id)
        {
            throw new NotImplementedException();
        }

        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
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
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
