using RESTWithASPNETBD.Data.Converter.Implementations;
using RESTWithASPNETBD.Data.VO;
using RESTWithASPNETBD.Hypermedia.Utils;
using RESTWithASPNETBD.Repository;

namespace RESTWithASPNETBD.Business.Implementations
{
    public class PersonBusinessImplementation : IPersonBusiness
    {

        private readonly IPersonRepository _repository;

        private readonly PersonConverter _converter;

        public PersonBusinessImplementation(IPersonRepository repository)
        {
            _repository = repository;
            _converter = new PersonConverter();
        }

        public List<PersonVO> FindAll()
        {
            return _converter.Parse(_repository.FindAll());
        }


        public PersonVO FindById(long id)
        {
            return _converter.Parse(_repository.FindById(id));
        }

        public List<PersonVO> FindByName(string firstName, string lastName)
        {
            return _converter.Parse(_repository.FindByName(firstName, lastName));
        }

        public PagedSearchVO<PersonVO> FindWithPagedSearch(string name, string sortDirection, int pageSize, int page)
        {   
            var sort = (!string.IsNullOrWhiteSpace(sortDirection) && !sortDirection.Equals("desc")) ? "asc" : "desc";
            var size = (pageSize < 1) ? 10 : pageSize;
            var offset = page > 0 ? (page - 1) * size : 0;

            //where 1=1 is used to avoid que broked query
            string query = @"SELECT * FROM person p WHERE 1 = 1 ";
            if (!string.IsNullOrWhiteSpace(name)) query = query + $" AND p.first_name like '%{name}%' ";
            query += $" ORDER BY p.first_name {sort} LIMIT {size} OFFSET {offset} ";

	        //ORDER BY p.name ASC LIMIT 10 OFFSET 1

            string countQuery = @"SELECT COUNT(*) FROM person p where 1 = 1";
            if (!string.IsNullOrWhiteSpace(name)) countQuery = countQuery + $" AND p.first_name like '%{name}%' ";

            var persons = _repository.FindWithPagedSearch(query);
            int totalResults = _repository.GetCount(countQuery);

            return new PagedSearchVO<PersonVO>
            {
                CurrentPage = page,
                List = _converter.Parse(persons),
                PageSize = size,
                SortDirections = sort,
                TotalResults = totalResults
            };
        }

        public PersonVO Create(PersonVO personVO)
        {
            var person = _converter.Parse(personVO);
            person = _repository.Create(person);

            return _converter.Parse(person);
        }

        public PersonVO Update(PersonVO personVO)
        {
            var person = _converter.Parse(personVO);
            person = _repository.Update(person);

            return _converter.Parse(person);
        }

        public PersonVO Disable(long id)
        {
            var person = _repository.Disable(id);

            return _converter.Parse(person);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }

        
    }
}
