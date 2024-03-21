namespace Mission11_CalebHanssen.Models
{
    public interface IBookRepository
    {
        public IQueryable<Book> Books {  get; }
    }
}
