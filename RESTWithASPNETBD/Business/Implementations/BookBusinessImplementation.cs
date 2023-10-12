using RESTWithASPNETBD.Data.Converter.Implementations;
using RESTWithASPNETBD.Data.VO;
using RESTWithASPNETBD.Models;
using RESTWithASPNETBD.Repository;
using RESTWithASPNETBD.Repository.Generic;

namespace RESTWithASPNETBD.Business.Implementations
{
    public class BookBusinessImplementation : IBookBusiness
    {
        private readonly IRepository<Book> _repository;

        private readonly BookConverter _converter;

        public BookBusinessImplementation(IRepository<Book> repository)
        {
            _repository = repository;
            _converter = new BookConverter();
        }

        public BookVO FindById(long id)
        {
            return _converter.Parse(_repository.FindById(id));
        }

        public List<BookVO> FindAll()
        {
            return _converter.Parse(_repository.FindAll());
        }

        public BookVO Create(BookVO bookVO)
        {
            var book = _converter.Parse(bookVO);
            book = _repository.Create(book);

            return _converter.Parse(book);

        }

        public BookVO Update(BookVO bookVO)
        {
            var book = _converter.Parse(bookVO);
            book = _repository.Update(book);

            return _converter.Parse(book);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }
    }
}
