using RESTWithASPNETBD.Models;
using RESTWithASPNETBD.Repository.Generic;

namespace RESTWithASPNETBD.Repository
{
    public interface IPersonRepository : IRepository<Person>
    {
        Person Disable(long id);

        List<Person> FindByName(string firstName, string lastName);
    }
}
