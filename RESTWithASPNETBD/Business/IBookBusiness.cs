using RESTWithASPNETBD.Data.VO;
using RESTWithASPNETBD.Models;

namespace RESTWithASPNETBD.Business
{
    public interface IBookBusiness
    {
        BookVO Create(BookVO bookVO);

        BookVO FindById(long id);

        List<BookVO> FindAll();

        BookVO Update(BookVO bookVO);

        void Delete(long id);
    }
}
