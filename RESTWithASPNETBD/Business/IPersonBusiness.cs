using RESTWithASPNETBD.Data.VO;
using RESTWithASPNETBD.Hypermedia.Utils;

namespace RESTWithASPNETBD.Business
{
    public interface IPersonBusiness
    {
        PersonVO Create(PersonVO personVO);
        PersonVO FindById(long id);
        List<PersonVO> FindAll();
        List<PersonVO> FindByName(string firstName, string lastName);
        PagedSearchVO<PersonVO> FindWithPagedSearch(
                string name,
                string sortDirection,
                int pageSize,
                int page
            );
        PersonVO Update(PersonVO personVO);
        PersonVO Disable(long id);
        void Delete(long id);
    }
}
